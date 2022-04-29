/*
* NAME : Program
* PURPOSE : This class contains the main function that provides the user-interface of the application. In it I've assigned values to the
* class's properties and passed arguments to the class's methods then I've written them to the console.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();
            device.Type = "Device";
            device.Name = "DeviceName";
            Console.WriteLine(device.usedByAll("Device", "DeviceName"));
            Console.WriteLine(device.overridenByAll("Device", "DeviceName"));
            Console.WriteLine(device.overloadedByAll("Device", "DeviceName"));
            
            Phone phone = new Phone();
            phone.Type = "Phone";
            phone.Name = "IPhone";
            phone.PhoneCharger = "USB Type C";
            Console.WriteLine(phone.usedByAll("Phone", "Iphone"));
            Console.WriteLine(phone.overridenByAll("Phone", "Iphone"));
            Console.WriteLine(phone.overloadedByAll("Phone", "Iphone", "USB Type C"));
            Console.WriteLine(phone.uniquePhoneMethod("USB Type C"));
            
            Laptop laptop = new Laptop();
            laptop.Type = "laptop";
            laptop.Name = "Lenovo";
            laptop.LaptopCharger = "45W Lenovo";
            Console.WriteLine(laptop.usedByAll("laptop", "Lenovo"));
            Console.WriteLine(laptop.overridenByAll("laptop", "Lenovo"));
            Console.WriteLine(laptop.overloadedByAll("laptop", "Lenovo", "45W Lenovo"));
            Console.WriteLine(laptop.unqiueLaptoptMethod("45W Lenovo"));

            Desktop desktop = new Desktop();
            desktop.Type = "Desktop";
            desktop.Name = "LG ";
            desktop.DesktopCase = "chiefTech LG";
            Console.WriteLine(desktop.usedByAll("Desktop", "LG"));
            Console.WriteLine(desktop.overridenByAll("Desktop", "LG"));
            Console.WriteLine(desktop.overloadedByAll("Desktop", "LG", "chiefTech LG"));
            Console.WriteLine(desktop.unqiueDesktopMethod("chiefTech LG"));
        }
    }
}