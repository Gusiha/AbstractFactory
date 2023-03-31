using AbstractFactory;
using AbstractFactory.Factories;

LinuxFactory linuxFactory = new();
WindowsFactory windowsFactory = new();
MacOSFactory MacOSFactory = new();

Window window = new(MacOSFactory);
window.PrintInfo();




