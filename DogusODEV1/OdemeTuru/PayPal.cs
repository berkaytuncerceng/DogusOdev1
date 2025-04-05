using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusODEV1.OdemeTuru
{
    public class PayPal : IOdeme
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL tutarındaki ödeme PayPal ile yapıldı.";
        }
    }
   
}
