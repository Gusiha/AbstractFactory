using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WindowsScroller : IScroller
    {
        public string Description { get; set; }

        public WindowsScroller()
        {
            Description = "Scroller : Windows\n";

        }

    }
}
