using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Data
    {
        public class Flags
        {
            string? Name { get; set; }
            public bool Status { get; set; }
        }

        public class Params 
        { 
            public string? Name { get; set; }
            public bool Status { get; set; }
        }

        public class ImgsByte
        { 
            public string? FilePath{ get; set;}
            public byte[]? FileByte{ get; set;}
        }

    }
}
