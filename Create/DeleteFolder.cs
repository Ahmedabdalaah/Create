using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    internal class DeleteFolder
    {
        public DeleteFolder(String name)
        {
            Directory.Delete(name);
        }
    }
}
