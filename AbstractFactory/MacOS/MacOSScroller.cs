using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacOSScroller : IScroller
    {
        public string Description { get; set; }
        public MacOSScroller()
        {
            Description = "Scroller : MacOS\n";
        }
    }
}
