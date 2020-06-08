using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProgramming.Memory
{
    public class NamedLayout : Layout
    {
        public string Name { get; private set; }

        public NamedLayout(string name)
            : base()
        {
            Name = name;
        }
    }
}
