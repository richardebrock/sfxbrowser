
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using WMPLib;

namespace sfxBrowser
{
    public partial class Form1 : Form
    {
        private string currentAudioFilePath = "";
        private string currentAudioFileExt = "";
        private WMPLib.WindowsMediaPlayer wplayer;
        private bool loadingSettings = false;
        private ListItem rootItem = null;
        private string lastUsedFilePath = "";
        private string lastSearchString = "";
        public Form1()
        {
            InitializeComponent();
            speed.Value = 100;
            wplayer = new WMPLib.WindowsMediaPlayer();            
            fileTree.ImageList = imageList1;
            rootItem = new ListItem();
            LoadSettings();
            txtFileNameFilter.Text = lastSearchString;
            if (txtPath.Text!="")
            {                
                bool bAutoPlay = btnAutoPlay.Checked;
                btnAutoPlay.Checked = false;
                UpdateFileList();
                btnAutoPlay.Checked = bAutoPlay;
                fileTree.Focus();
            }
            UpdateControlStates();
            timer1.Start();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateFileList();
        }
        private int GetDirectories(string directoryName, ListItem itemToAddTo)
        {
            ListItem item = new ListItem();
            itemToAddTo.children.Add(item);
            item.FilePath = directoryName;
            item.ImageIndex = 0;
            int matchingFileCount = 0;
            DirectoryInfo sub = new DirectoryInfo(directoryName);            
            DirectoryInfo[] subDirs = sub.GetDirectories();
            if (subDirs!=null)
            {
                foreach (DirectoryInfo subDir in subDirs)
                {
                    GetDirectories(subDir.FullName, item);
                }
            }
            FileInfo[] files = sub.GetFiles();
            foreach (FileInfo file in files)
            {
                string strFilePath = file.DirectoryName;
                if (strFilePath.Substring(strFilePath.Length - 1) != "\\") strFilePath += "\\";
                strFilePath += file.Name;
                string strExt = Path.GetExtension(strFilePath).ToLower();
                if (strExt == ".mp3" || strExt == ".wav" || strExt == ".ogg")
                {
                    ListItem childItem = new ListItem();
                    childItem.FilePath = strFilePath;
                    childItem.ImageIndex = 1;
                    item.children.Add(childItem);                    
                    matchingFileCount++;
                }
            }
            return matchingFileCount;
        }
        void UpdateFileList()
        {
            rootItem.children.Clear();
            if (txtPath.Text.Length > 0)
            {
                DirectoryInfo info = new DirectoryInfo(txtPath.Text);
                if (info.Exists)
                {
                    rootItem.FilePath = txtPath.Text;
                    rootItem.ImageIndex = 0;
                    GetDirectories(info.FullName, rootItem);
                }
            }
            RebuildTree();
            if (fileTree.SelectedNode != null)
            {
                fileTree.SelectedNode.EnsureVisible();                
            }
        }
        void AddNodeToTree(ListItem item, TreeNode parentNode)
        {
            if(item.ImageIndex==1)
            {
                if (item.FileExtension == ".mp3" && btnMP3.Checked == false) return;
                if (item.FileExtension == ".wav" && btnWAV.Checked == false) return;
                if (item.FileExtension == ".ogg" && btnOGG.Checked == false) return;
                if (txtFileNameFilter.Text.Length>0)
                {
                    string filename = item.FileName.ToLower();
                    string contains = txtFileNameFilter.Text.ToLower();
                    if(false==filename.Contains(contains))
                    {
                        return;
                    }
                }
            }
            else
            {
                if (item.MatchingChildCount(txtFileNameFilter.Text, btnWAV.Checked, btnMP3.Checked, btnOGG.Checked) == 0)
                {
                    return;
                }
            }
            TreeNode aNode;
            aNode = new TreeNode(Path.GetFileName(item.FileName), 0, 0);
            aNode.Tag = item.FilePath;
            aNode.ImageIndex = item.ImageIndex;
            aNode.SelectedImageIndex = item.ImageIndex;
            if (parentNode != null)
            {
                parentNode.Nodes.Add(aNode);
            }
            else
            {
                aNode.Text = item.FileName;
                fileTree.Nodes.Add(aNode);
            }
            if(item.children.Count>0)
            {
                for(int c=0;c<item.children.Count;c++)
                {                    
                    AddNodeToTree(item.children[c], aNode);
                }
                aNode.Expand();
            }
            if (aNode.Tag.Equals(lastUsedFilePath))
            {
                fileTree.SelectedNode = aNode;
            }
        }
        void RebuildTree()
        {
            fileTree.Nodes.Clear();
            if (rootItem.MatchingChildCount(txtFileNameFilter.Text,btnWAV.Checked,btnMP3.Checked,btnOGG.Checked) > 0)
            {
                AddNodeToTree(rootItem, null);
            }
        }
        void StoreSettings()
        {
            if (loadingSettings) return;
            Settings1.Default.auto = btnAutoPlay.Checked;
            Settings1.Default.loop = btnLoop.Checked;
            Settings1.Default.mp3 = btnMP3.Checked;
            Settings1.Default.wav = btnWAV.Checked;
            Settings1.Default.ogg = btnOGG.Checked;
            Settings1.Default.path = txtPath.Text;
            Settings1.Default.volume = volume.Value;
            Settings1.Default.lastfile = lastUsedFilePath;
            Settings1.Default.lastsearch = lastSearchString;
            Settings1.Default.Save();
        }
        void LoadSettings()
        {
            loadingSettings = true;
            volume.Value = Settings1.Default.volume;
            btnAutoPlay.Checked = Settings1.Default.auto;
            btnLoop.Checked = Settings1.Default.loop;
            btnMP3.Checked = Settings1.Default.mp3;
            btnWAV.Checked = Settings1.Default.wav;
            btnOGG.Checked = Settings1.Default.ogg;
            txtPath.Text = Settings1.Default.path;
            lastUsedFilePath = Settings1.Default.lastfile;
            lastSearchString = Settings1.Default.lastsearch;
            loadingSettings = false;
        }
        void UpdateControlStates()
        {
            btnCopyTo.Enabled = currentAudioFilePath.Length > 0;
            btnOpenLocation.Enabled = currentAudioFilePath.Length > 0;
            btnPlay.Enabled = currentAudioFilePath.Length > 0;
            btnRefresh.Enabled = txtPath.Text.Length > 0;
        }
        private void btnMP3_CheckedChanged(object sender, EventArgs e)
        {
            StoreSettings();
            RebuildTree();
        }
        private void btnWAV_CheckedChanged(object sender, EventArgs e)
        {
            StoreSettings();
            RebuildTree();
        }        
        private void btnOGG_CheckedChanged(object sender, EventArgs e)
        {
            StoreSettings();
            RebuildTree();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;                
                StoreSettings();
                UpdateFileList();
                UpdateControlStates();
            }
        }
        private void volume_ValueChanged(object sender, EventArgs e)
        {
            if (wplayer != null)
            {
                wplayer.settings.volume = volume.Value;
                StoreSettings();
            }
        }
        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            currentAudioFilePath = e.Node.Tag.ToString();
            currentAudioFileExt = Path.GetExtension(currentAudioFilePath).ToLower();
            if (currentAudioFileExt == ".mp3" || currentAudioFileExt == ".wav" || currentAudioFileExt == ".ogg")
            {                
                wplayer.URL = currentAudioFilePath;
                lastUsedFilePath = currentAudioFilePath;
                StoreSettings();
                if (btnAutoPlay.Checked == true)
                {
                    PlaySelectedSound();
                }
                else
                {
                    wplayer.controls.stop();
                }
            }
            UpdateControlStates();
        }
        private void fileTree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==32)
            {
                PlaySelectedSound();
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMPLib.WMPPlayState ps = wplayer.playState;
            if (ps == WMPLib.WMPPlayState.wmppsPlaying)
            {                
                wplayer.controls.stop();
                btnPlay.Text = "Play";
            }
            else
            {
                PlaySelectedSound();
            }
        }
        void PlaySelectedSound()
        {
            btnPlay.Text = "Stop";
            if (btnLoop.Checked) wplayer.settings.playCount = 1000;
            else wplayer.settings.playCount = 1;
            wplayer.settings.volume = volume.Value;
            wplayer.settings.rate = (speed.Value/100.0f);
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            wplayer.controls.play();            
        }
        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                playerTrack.Maximum = (int)wplayer.currentMedia.duration;
                txtDuration.Text = wplayer.currentMedia.durationString;                
            }
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                playerTrack.Value = (int)wplayer.controls.currentPosition;
                btnPlay.Text = "Play";
            }
        }
        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (currentAudioFileExt == ".mp3") saveFileDialog1.Filter = "MP3 file|*.mp3";
            if (currentAudioFileExt == ".wav") saveFileDialog1.Filter = "WAV file|*.wav";
            if (currentAudioFileExt == ".ogg") saveFileDialog1.Filter = "OGG file|*.ogg";
            saveFileDialog1.Title = "Copy audio file to";
            saveFileDialog1.FileName = Path.GetFileName(currentAudioFilePath);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    File.Copy(currentAudioFilePath, saveFileDialog1.FileName,true);
                    MessageBox.Show("File copied to " + saveFileDialog1.FileName);
                }
            }
        }
        private void btnOpenLocation_Click(object sender, EventArgs e)
        {
            if (currentAudioFilePath.Length > 0)
            {
                string strFolderPath = Path.GetDirectoryName(currentAudioFilePath);
                System.Diagnostics.Process.Start(strFolderPath);
            }
        }
        private void btnLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (wplayer != null)
            {
                if (btnLoop.Checked)
                {
                    wplayer.settings.playCount = 1000;
                }
                else
                {
                    wplayer.settings.playCount = 1;
                }
            }
            StoreSettings();
        }
        private void btnAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            StoreSettings();
        }
        private void txtFileNameFilter_TextChanged(object sender, EventArgs e)
        {
            lastSearchString = txtFileNameFilter.Text;
            StoreSettings();
        }
        private void speed_ValueChanged(object sender, EventArgs e)
        {
            if (wplayer != null)
            {
                WMPLib.WMPPlayState ps = wplayer.playState;                
                wplayer.settings.rate = (speed.Value / 100.0f);
                if (ps == WMPLib.WMPPlayState.wmppsPlaying) wplayer.controls.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(wplayer!=null)
            {
                WMPLib.WMPPlayState ps = wplayer.playState;
                if (ps == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    playerTrack.Value = (int)wplayer.controls.currentPosition;
                    int hh = (int)Math.Floor(wplayer.controls.currentPosition / 3600.0);
                    int mm = (int)Math.Floor((wplayer.controls.currentPosition - (hh * 3600)) / 60.0);
                    int ss = (int)Math.Floor((wplayer.controls.currentPosition - ((hh * 3600) + (mm * 60)) / 60.0));
                    txtPosition.Text = hh.ToString("D2") + ":" + mm.ToString("D2") + ":" + ss.ToString("D2");
                }
            }
        }
        private void txtFileNameFilter_KeyUp(object sender, KeyEventArgs e)
        {
            RebuildTree();
        }
        private void playerTrack_Scroll(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition = playerTrack.Value;
        }
    }
}
