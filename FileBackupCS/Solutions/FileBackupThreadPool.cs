using System.ComponentModel;
using System.IO;
using System;
using System.Threading;

namespace FileBackup
{
    internal class FileBackupThreadPool
    {
        MainForm mainForm; 
        FileManager fileManager;
        public string[] FilePaths { get; private set; }
        public FileBackupThreadPool(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.fileManager = new FileManager();
        }
        public void Start()
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                BackupFiles();
            });
        }

        public string[] GetFilePaths()
        {
            FilePaths = fileManager.GetDirectoryFiles();

            if (FilePaths != null)
            {
                mainForm.lstSource.Items.Clear();
                mainForm.lstSource.Items.AddRange(FilePaths);
            }

            return FilePaths;
        }

        public void BackupFiles()
        {
            string directory = fileManager.SelectedDirectory.ToString();
            string backupDirectory = Path.Combine(directory, "Backup");
            if (!Directory.Exists(backupDirectory))
            {
                Directory.CreateDirectory(backupDirectory);
            }
            foreach (string file in FilePaths)
            {
                string fileName = Path.GetFileName(file);
                string destinationFile = Path.Combine(backupDirectory, fileName);
                File.Copy(file, destinationFile, true);
                mainForm.Invoke(new Action(() =>
                {
                    mainForm.lstTarget.Items.Add(destinationFile);
                }));
            }
        }

    }
}
