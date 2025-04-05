using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogusODEV1
{
    public class OdemeIslemcisi
    {
        public IOdeme odemeYontemi;

        public OdemeIslemcisi(IOdeme odemeYontemi)
        {
            this.odemeYontemi = odemeYontemi;
        }

        public string OdemeYap(decimal tutar)
        {
            if (odemeYontemi == null)
            {
                throw new InvalidOperationException("Ödeme yöntemi seçilmedi.");
            }
            return odemeYontemi.Ode(tutar);
        }

        public void OdemeYontemiDegistir(IOdeme yeniOdemeYontemi)
        {
            this.odemeYontemi = yeniOdemeYontemi;
        }

    }
}
