using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    internal class CreateFolder
    {
        public CreateFolder(String name)
        {
            Directory.CreateDirectory(name);
        }
    }
}
