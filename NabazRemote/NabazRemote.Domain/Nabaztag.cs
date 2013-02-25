using System;
using System.Collections.Generic;
using System.Text;

namespace NabazRemote.Domain
{
    public class Nabaztag
    {
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        private string serialNumber;
        private string name;
        private string token;        
    }
}
