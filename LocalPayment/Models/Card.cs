
namespace LocalPayment.Models
{
    public class Card
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        public Person persona { get; set; }
        public double limite { get; set; }
        public double tasa { get; set; }
    }
}
