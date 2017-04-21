using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace sfxBrowser
{
    public class FileNode
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
        public System.Collections.Generic.List<FileNode> Nodes;
        public FileNode()
        {
        }
        void AddNode(FileNode child)
        {
            Nodes.Add(child);
        }
    }
}