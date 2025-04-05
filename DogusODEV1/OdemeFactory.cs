using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DogusODEV1
{
    public class OdemeFactory
    {
        public IOdeme YeniOdemeOlustur(string odemeYontemi)
        {
            string classFullName = "DogusODEV1.OdemeTuru." + odemeYontemi;
            var newObject = Assembly.GetAssembly(typeof(IOdeme)).CreateInstance(classFullName);
            return (IOdeme)newObject;
        }
    }
}
