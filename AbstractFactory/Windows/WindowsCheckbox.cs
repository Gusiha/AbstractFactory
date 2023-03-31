using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WindowsCheckbox : ICheckbox
    {
        public string Description { get; set; }

        public WindowsCheckbox()
        {
            Description = "Checkbox : Windows\n";

        }
    }
}
