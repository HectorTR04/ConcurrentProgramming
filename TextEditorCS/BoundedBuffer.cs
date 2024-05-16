using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditor
{
    public class BoundedBuffer
    {
        public enum BufferStatus { Empty, Checked, New}
        public event EventHandler<string> WriterAction;
        public event EventHandler<string> ModifierAction;
        public event EventHandler<string> ReaderAction;
        public event EventHandler ReaderWriteToDestination;
        private string[] buffer;
        private BufferStatus[] status;
        private int writePosition;
        private int readPosition;
        private int modifyPosition;
        private const int bufferSize = 25;
        private object lockObj = new object();
        public string[] Buffer { get { return buffer; } }
        public void OnWriterAction(string action)
        {
            WriterAction?.Invoke(this, action);
        }

        public void OnModifierAction(string action)
        {
            ModifierAction?.Invoke(this, action);
        }

        public void OnReaderAction(string action)
        {
            ReaderAction?.Invoke(this, action);
        }
        public void OnRead()
        {
            ReaderWriteToDestination?.Invoke(this, EventArgs.Empty);
        }
        public BoundedBuffer()
        {
            buffer = new string[bufferSize];
            status = new BufferStatus[bufferSize];
            writePosition = 0;
            readPosition = 0;
            modifyPosition = 0;
            for (int i = 0; i < bufferSize; i++)
            {
                status[i] = BufferStatus.Empty;
            }
        }

        public void Write(string line)
        {
            Monitor.Enter(lockObj);
            try
            {
                while (status[writePosition] != BufferStatus.Empty)
                {
                    Monitor.Wait(lockObj);
                }
                buffer[writePosition] = line;
                status[writePosition] = BufferStatus.New;
                writePosition = (writePosition + 1) % bufferSize;
            }
            finally {
                Monitor.PulseAll(lockObj);
                Monitor.Exit(lockObj); }
        }

        public void Modify(string find, string replace)
        {
            Monitor.Enter(lockObj);
            try
            {
                while (status[modifyPosition] != BufferStatus.New)
                {
                    Monitor.Wait(lockObj);
                }
                var line = buffer[modifyPosition];

                string modifiedLine = line.Replace(find, replace);
                if (modifiedLine != line)
                {
                    buffer[modifyPosition] = modifiedLine;
                }
                status[modifyPosition] = BufferStatus.Checked;
                modifyPosition = (modifyPosition + 1) % bufferSize;
            }
            finally 
            {
                Monitor.PulseAll(lockObj);
                Monitor.Exit(lockObj); 
            }
           
        }
        public void Read()
        {
            Monitor.Enter(lockObj);
            try
            {
                while (status[readPosition] != BufferStatus.Checked)
                {
                    Monitor.Wait(lockObj);
                }
                status[readPosition] = BufferStatus.Empty;
                OnRead();
                readPosition = (readPosition + 1) % bufferSize;
            }
            finally {
                Monitor.PulseAll(lockObj);
                Monitor.Exit(lockObj); }          
        }

        public void PrintBuffer()
        {
            Console.WriteLine("Buffer Contents:");
            for (int i = 0; i < bufferSize; i++)
            {
                Console.WriteLine($"Position {i}: {buffer[i]}");
                Console.WriteLine($"Status {i}: {status[i]}");
            }
        }
    }
}
