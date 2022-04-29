/*
* NAME : Desktop
* PURPOSE : This class inherits from the device class, and it contains a unique property called desktopCase which is something that is
* unqiue to a desktop. It has one unique method that returns the unique property. It inherits the three functions of device, in which the
* first one overrides the device's method by returning the incremntation of the device's properties and the unqie property of Desktop.
* It overloads the function that it inherited from the Device by having a third paramter.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming
{
    class Desktop : Device
    {
        private string desktopCase;
        Device device = new Device();
        public string DesktopCase
        {
            get { return desktopCase; }
            set { desktopCase = value; }
        }

        public string unqiueDesktopMethod(string newDesktopCase)
        {
            desktopCase = newDesktopCase;
            return desktopCase;
        }

        public override string overridenByAll(string newType, string newName)
        {
            device.Type = newType;
            device.Name = newName;
            return device.Type + " " + device.Name + " " + desktopCase;
        }

        public string overloadedByAll(string newType, string newName, string newDesktopCase)
        {
            device.Type = newType;
            device.Name = newName;
            desktopCase = newDesktopCase;
            return device.Type + " " + device.Name + " " + desktopCase;
        }
    }
}