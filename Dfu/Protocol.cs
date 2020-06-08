using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProgramming.Dfu
{
    public static class Protocol
    {
        /// <summary>
        /// The version of the official DFU specification
        /// </summary>
        public static readonly Version LatestVersion = new Version(1, 1);

        /// <summary>
        /// ST Microelectronics-specific Extension (DFUSE) version number
        /// </summary>
        public static readonly Version SeVersion = new Version(0x1, 0x1a);
    }
}
