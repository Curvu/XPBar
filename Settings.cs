using System;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace XPBar
{
    public class Settings : ISettings
    {
        public Settings()
        {
        }

        public ToggleNode Enable { get; set; } = new ToggleNode(true);

        public ToggleNode Debug { get; set; } = new ToggleNode(false);
    }
}
