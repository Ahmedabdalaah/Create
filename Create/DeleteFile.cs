using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    internal class DeleteFile
    {
        public DeleteFile( String name)
        {
            File.Delete(name);
        }
    }
}
