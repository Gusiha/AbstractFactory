using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacOSCheckbox : ICheckbox
    {
        public string Description { get; set; }
        public MacOSCheckbox()
        {
            Description = "Checkbox : MacOS\n";

        }
    }
}
