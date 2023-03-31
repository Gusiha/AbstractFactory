using AbstractFactory.Interfaces;
using AbstractFactory.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class WindowsFactory : IWindowFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }

        public IScroller CreateScroller()
        {
            return new WindowsScroller();
        }
    }
}
