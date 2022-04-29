/*
* NAME : Device
* PURPOSE : This class contains the name and type properties, which indicate the 
* type of the device wither it is a phone or laptop or desktop
* and the name (brand) of that device.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming
{
    public class Device {
        private string type;
        private string name;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string usedByAll(string newType, string newName)
        {
            type = newType;
            name = newName;
            return type + " " + name;
        }
        public virtual string overridenByAll(string newType, string newName)
        {
            type = newType;
            name = newName;
            return type + " " + name;
        }
        public string overloadedByAll(string newType, string newName){
            type = newType;
            name = newName;

            return type + " " + name;
        }

    }


}
