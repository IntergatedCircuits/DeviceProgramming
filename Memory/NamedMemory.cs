using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProgramming.Memory
{
    public class NamedMemory : RawMemory
    {
        public string Name { get; private set; }

        public NamedMemory(string name)
            : base()
        {
            Name = name;
        }
    }
}
