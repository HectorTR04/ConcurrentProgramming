using System;
using System.IO;
using System.Windows.Forms;

namespace FileBackup
{
    public class FileManager
    {
        public DirectoryInfo SelectedDirectory { get; private set; }

        public string[] GetDirectoryFiles()
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select a Directory";
                var result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    SelectedDirectory = new DirectoryInfo(folderBrowser.SelectedPath);

                    if (!SelectedDirectory.Exists)
                        return null;

                    FileInfo[] files = SelectedDirectory.GetFiles();
                    if (files.Length == 0)
                        return null;

                    string[] fileNames = new string[files.Length];

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileNames[i] = files[i].FullName;
                    }
                    return fileNames;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}


