using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    internal class AddFile
    {
        public AddFile(String name)
        {
            File.Create(name);
        }
    }
}
