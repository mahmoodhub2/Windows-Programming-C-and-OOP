/*
* NAME : Phone
* PURPOSE : This class inherits from the device class, and it contains a unique property called PhoneCharger which is something that is
* unqiue to a Phone. It has one unique method that returns the unique property. It inherits the three functions of device, in which the
* first one overrides the device's method by returning the incremntation of the device's properties and the unqie property of Phone.
* It overloads the function that it inherited from the Device by having a third paramter.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming
{
    class Phone : Device
    {
        private string phoneCharger;
        Device device = new Device();
        public string PhoneCharger
        {
            get { return phoneCharger; }
            set { phoneCharger = value; }
        }

        public string uniquePhoneMethod(string newphoneCharger) {
            phoneCharger = newphoneCharger;
            return phoneCharger;
        }

        public override string overridenByAll(string newType, string newName)
        {
            device.Type = newType;
            device.Name = newName;
            return device.Type + " " + device.Name + " " + phoneCharger;
        }

        public string overloadedByAll(string newType, string newName, string newphoneCharger)
        {
            device.Type = newType;
            device.Name = newName;
            phoneCharger = newphoneCharger;
            return device.Type + " " + device.Name + " " + phoneCharger;
        }
    }
}
