using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace sfxBrowser
{
    public class ListItem
    {
        private string _filePath;
        private string _fileName;
        private string _fileExtension;
        public int ImageIndex { get; set; }
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                _fileName = Path.GetFileName(_filePath);
                _fileExtension = Path.GetExtension(_filePath);
            }
        }
        public string FileName
        {
            get { return _fileName; }
        }
        public string FileExtension
        {
            get { return _fileExtension; }
        }
        public System.Collections.Generic.List<ListItem> children;
        public ListItem()
        {
            children = new List<ListItem>();
            FilePath = "";
        }
        void AddNode(ListItem child)
        {
            children.Add(child);
        }
        public int MatchingChildCount(string fileNameFilter, bool allowWAV, bool allowMP3, bool allowOGG)
        {
            int matchingCount = 0;
            for (int c = 0; c < children.Count; c++)
            {
                if (children[c].ImageIndex == 1)
                {
                    string filename = children[c].FileName.ToLower();
                    string contains = fileNameFilter.ToLower();
                    if (filename.Contains(contains) || fileNameFilter == "")
                    {
                        if ((children[c].FileExtension == ".mp3" && allowMP3) || (children[c].FileExtension == ".wav" && allowWAV) || (children[c].FileExtension == ".ogg" && allowOGG))
                        {
                            matchingCount++;
                        }
                    }
                }
                else
                {
                    matchingCount += children[c].MatchingChildCount(fileNameFilter, allowWAV, allowMP3, allowOGG);
                }
            }
            return matchingCount;
        }
    }
}