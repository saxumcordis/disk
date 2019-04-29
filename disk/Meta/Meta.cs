using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk.Meta
{
    public class Meta
    {
        public int index { get; set; }
        public int length { get; set; }
        public string path { get; set; }
        public Meta(int index, int length, string path)
        {
            this.index = index;
            this.length = length;
            this.path = path;
        }
        public static int spaceBetween(Meta first, Meta second)
        {
            if (first.index == second.index)
                throw new SameIndexException();
            var result = first.index < second.index
                    ? second.index - first.index - first.length
                    : first.index - second.index - second.length;
            if (result < 0)
                throw new ArgumentException();
            return result;
        }
    }
}
