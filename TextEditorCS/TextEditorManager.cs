using System;
using System.Threading;

namespace TextEditor
{
    public class TextEditorManager
    {
        public BoundedBuffer buffer;
        public MainForm mainForm;
        Mutex lineMutex = new Mutex();
        int nextWriteIndex = 0;
        int nextReadIndex = 0;
        int nextModifyIndex = 0;
        bool writerRunning = true;
        bool modifierRunning = true;
        bool readerRunning = true;

        public TextEditorManager(MainForm mainForm)
        {
            buffer = new BoundedBuffer();
            this.mainForm = mainForm;
            buffer.WriterAction += (sender, action) => UpdateStatusListBox(action);
            buffer.ModifierAction += (sender, action) => UpdateStatusListBox(action);
            buffer.ReaderAction += (sender, action) => UpdateStatusListBox(action);
        }   

        public void StartThreads()
        {
            for (int i  = 0; i < 3; i++)
            {
                Thread writerThread = new Thread(WriterThread);
                writerThread.Start();
            }
            for (int i = 0; i < 4; i++)
            {
                Thread modifierThread = new Thread(ModifierThread);
                modifierThread.Start();
            }
            Thread readerThread = new Thread(ReaderThread);
            readerThread.Start();
        }

        private void WriterThread()
        {
            while (writerRunning)
            {
                lineMutex.WaitOne();
                if (nextWriteIndex < mainForm.Lines.Length)
                {
                    buffer.Write(mainForm.Lines[nextWriteIndex]);
                    string action = $"Writer wrote: '{mainForm.Lines[nextWriteIndex]}' at Index {nextWriteIndex}";
                    buffer.OnWriterAction(action);
                    nextWriteIndex++;           
                }
                else 
                { 
                    writerRunning = false;
                    buffer.PrintBuffer();
                }
                lineMutex.ReleaseMutex();
            }
        }

        private void ModifierThread()
        {
            while (modifierRunning)
            {
                if (nextModifyIndex < mainForm.Lines.Length)
                {
                    string input = mainForm.TxTFind.Text;
                    string output = mainForm.TxTReplace.Text;
                    buffer.Modify(input, output);
                    string action = $"Modifier modified: Replaced '{input}' with '{output}' at Index {nextModifyIndex}";
                    buffer.OnModifierAction(action);
                    nextModifyIndex++;
                }
                else { modifierRunning = false; }
            }
                     
        }

        private void ReaderThread()
        {
            while (readerRunning)
            {
                if (nextReadIndex < mainForm.Lines.Length)
                {
                    buffer.Read();
                    string action = $"Reader read line '{mainForm.Lines[nextReadIndex]}' at Index {nextWriteIndex}";
                    buffer.OnReaderAction(action);
                    nextReadIndex++;
                }
                else {  readerRunning = false; }
            }
        }
        private void UpdateStatusListBox(string action)
        {
            if (mainForm.ListStatus.InvokeRequired)
            {
                mainForm.ListStatus.Invoke(new Action(() => mainForm.ListStatus.Items.Add(action)));
            }
            else
            {
                mainForm.ListStatus.Items.Add(action);
            }
        }

    }
}
