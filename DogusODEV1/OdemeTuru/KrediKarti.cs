namespace DogusODEV1.OdemeTuru
{
    public class KrediKarti : IOdeme
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL tutarındaki ödeme kredi kartı ile yapıldı.";
        }
    }
}
