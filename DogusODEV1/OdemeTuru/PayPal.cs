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
