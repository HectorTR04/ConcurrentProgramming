using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackup
{
    public class FileData
    {
        // Automatic properties for simplification
        public string FullPath { get; private set; }
        public string FileName { get; private set; }
        public string NameOnly { get; private set; }
        public string Extension { get; private set; }
        public string ErrorMsg { get; set; }
        public string PathOnly { get; private set; }
        public string BkpFullPath { get; set; }

        // Constructor
        // other methods

    }
}
