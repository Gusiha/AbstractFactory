using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbstractFactory.Linux
{
    internal class LinuxCheckbox : ICheckbox
    {
        public string Description { get; set; }

        public LinuxCheckbox()
        {
            Description = "Checkbox : Linux\n";

        }
    }
}
