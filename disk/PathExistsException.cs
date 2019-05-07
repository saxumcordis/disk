using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disk
{
    class PathExistsException : Exception
    {
        public PathExistsException()
        {
            MessageBox.Show("The name already exists");
        }
    }
}
