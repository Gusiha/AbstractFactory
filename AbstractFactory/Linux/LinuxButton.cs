using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Linux
{
    internal class LinuxButton : IButton
    {
        public string Description { get; set; }

        public LinuxButton()
        {
            Description = "Button : Linux\n";
        }
    }
}
