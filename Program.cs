using System.Security.Cryptography.X509Certificates;

namespace Länder
{
    class Program
    {

        public class Land
        {
            public string namn, styrestyp, huvudstad, invånarantal;
        }
        public static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = "10512820" };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånarantal = "83783902" };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånarantal = "33600" };
        }
    }
}