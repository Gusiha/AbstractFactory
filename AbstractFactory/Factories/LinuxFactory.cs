using AbstractFactory.Interfaces;
using AbstractFactory.Linux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class LinuxFactory : IWindowFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public IScroller CreateScroller()
        {
            return new LinuxScroller();
        }
    }
}
