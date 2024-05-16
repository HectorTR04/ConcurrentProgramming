using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        private FileManager fileMngr = new FileManager();
        private TextEditorManager textEditorManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            textEditorManager = new TextEditorManager(this);
            textEditorManager.buffer.ReaderWriteToDestination += (sender, action) => WriteToDestination();
        }

        private void WriteToDestination()
        {
            string[] text = textEditorManager.buffer.Buffer;
            if (text != null)
            {
                Invoke(new Action(() =>
                {
                    rtxtDest.Clear();
                }));
                foreach (string textLine in text)
                {
                    Invoke(new Action(() =>
                    {
                        rtxtDest.AppendText(textLine + "\n");
                    }));
                }
            }
        }

        private void InitializeGUI()
        {
            toolTip1.SetToolTip(txtFind, "Select a text from the source and copy here!");
            toolTip1.SetToolTip(txtReplace, "Select a text to replace the above with!");
            toolTip1.SetToolTip(rtxtSource, "You can also write or change the text here manually!");
        }
        private string[] lines;
        public string[] Lines { get { return lines; } }
        private void readDataFromTextFile(string fileName)
        {
            rtxtSource.Clear();
            lstStatus.Items.Clear();
            string errorMsg = string.Empty;
            lines = fileMngr.ReadFromTextFile(fileName, out errorMsg);
            lblSource.Text = "The Hobbit";
            if (lines != null)
            {
                foreach (string line in lines)
                {
                    rtxtSource.AppendText(line + "\n");
                }
                lstStatus.Items.Add("Lines read from the file: " + lines.Length);
            }
            else
                MessageBox.Show(errorMsg);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open file for reading as txt!";

            openFileDialog1.Filter = "Text files |*.txt| All files |*.*";
            openFileDialog1.FilterIndex = 0;
            var path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));

            openFileDialog1.InitialDirectory = newPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;  //important
                readDataFromTextFile(fileName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            textEditorManager.StartThreads();
        }
    }
}
