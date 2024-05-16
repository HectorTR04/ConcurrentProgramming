using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackup
{
    internal class FileBackupAsync
    {
        MainForm mainForm;
        FileManager fileManager;
        public string[] FilePaths { get; private set; }

        public FileBackupAsync(MainForm mainForm)
        {
            this.mainForm = mainForm;
            fileManager = new FileManager();
        }

        public void Start()
        {
            Task startTask = Task.Run( async () =>
            {
                await GetFilePaths();
                BackupFiles();
            });
        }
        public async Task<string[]> GetFilePaths()
        {
            Task<string[]> filePathTask = Task.Run(async () =>
            {
                if (mainForm.InvokeRequired)
                {
                    mainForm.Invoke(new Action(() =>
                    {
                        FilePaths = fileManager.GetDirectoryFiles();
                        if (FilePaths != null)
                        {
                            mainForm.lstSource.Items.Clear();
                            mainForm.lstSource.Items.AddRange(FilePaths);
                        }
                    }));
                    
                }             
                await Task.Delay(500);

                return FilePaths;
            });
            string[] filePaths = await filePathTask;
            return filePaths;          
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
