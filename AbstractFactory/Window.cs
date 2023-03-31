using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    internal class Window
    {
        private readonly string _info;


        public IButton Button { get; set; }
        public ICheckbox Checkbox { get; set; }
        public IScroller Scroller { get; set; }


        public Window(IWindowFactory windowFactory)
        {
            Button = windowFactory.CreateButton();
            Checkbox = windowFactory.CreateCheckbox();
            Scroller= windowFactory.CreateScroller();
            _info = $"{Button.Description}{Checkbox.Description}{Scroller.Description}";
        }


        public void PrintInfo()
        {
            Console.WriteLine(_info);
        }


    }
}
