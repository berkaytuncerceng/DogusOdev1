namespace DogusODEV1.OdemeTuru
{
    public class Nakit : IOdeme
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL tutarındaki ödeme nakit olarak yapıldı.";
        }

    }
}
