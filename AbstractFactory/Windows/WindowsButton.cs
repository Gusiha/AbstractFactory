using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WindowsButton : IButton
    {
        public string Description { get; set; }


        public WindowsButton()
        {
            Description = "Button : Windows\n";
        }
    }
}
