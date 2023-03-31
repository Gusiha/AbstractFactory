using AbstractFactory.Interfaces;
using AbstractFactory.MacOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class MacOSFactory : IWindowFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

        public IScroller CreateScroller()
        {
            return new MacOSScroller();
        }
    }
}
