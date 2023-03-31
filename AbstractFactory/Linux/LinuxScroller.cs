using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Linux
{
    internal class LinuxScroller : IScroller
    {
        public string Description { get; set; }

        public LinuxScroller()
        {
            Description = "Scroller : Linux\n";
        }
    }
}
