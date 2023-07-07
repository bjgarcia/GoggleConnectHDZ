using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GoggleConnectHDZ
{
    internal struct FileProp
    {
        public string filename;
        public string createdate;
        public string filesize;

        public FileProp(string line)
        {
            string[] field = line.Split(new char[] {});
            filename = field[4];
            createdate = field[1] + " " + field[2];
            filesize = field[0];
        }

    }
}
