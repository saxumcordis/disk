using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk
{
    class File
    {
        private byte[] content;
        public string path;
        public File(string path, byte[] content)
        {
            this.path = path;
            this.content = content;
        }
        public string getPath()
        {
            return path;
        }
        public int getSize()
        {
            return content.Length;
        }

        public byte[] getContent()
        {
            return content;
        }
    }
}
