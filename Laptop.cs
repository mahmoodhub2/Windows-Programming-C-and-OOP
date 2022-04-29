/*
* NAME : Laptop
* PURPOSE : This class inherits from the device class, and it contains a unique property called laptopCharger which is something that is
* unqiue to a Laptop. It has one unique method that returns the unique property. It inherits the three functions of device, in which the
* first one overrides the device's method by returning the incremntation of the device's properties and the unqie property of Laptop.
* It overloads the function that it inherited from the Device by having a third paramter.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming
{
    class Laptop : Device
    {
        private string laptopCharger;
        Device device = new Device();
        public string LaptopCharger
        {
            get { return laptopCharger; }
            set { laptopCharger = value; }
        }

        public string unqiueLaptoptMethod(string newLaptopCharger)
        {
            laptopCharger = newLaptopCharger;
            return laptopCharger;
        }

        public override string overridenByAll(string newType, string newName)
        {
            device.Type = newType;
            device.Name = newName;
            return device.Type + " " + device.Name + " " + laptopCharger;
        }

        public string overloadedByAll(string newType, string newName, string newLaptopCharger)
        {
            device.Type = newType;
            device.Name = newName;
            laptopCharger = newLaptopCharger;
            return device.Type + " " + device.Name + " " + laptopCharger;
        }
    }
}