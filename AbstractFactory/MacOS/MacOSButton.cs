using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacOSButton : IButton
    {
        public string Description { get; set; }

        public MacOSButton()
        {
            Description = "Button : MacOS\n";

        }

    }
}
