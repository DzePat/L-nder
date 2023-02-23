using System.Security.Cryptography.X509Certificates;

namespace Länder
{
    class Program
    {

        public class Land
        {
            public string namn, styrestyp, huvudstad, invånarantal;

            public void print()
            {
                Console.WriteLine($"namn: {namn}");
                Console.WriteLine($"    styrestyp: {styrestyp}");
                Console.WriteLine($"    huvudstad: {huvudstad}");
                Console.WriteLine($"    invånarantal: {invånarantal}");
            }
        }
        public static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = "10512820" };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånarantal = "83783902" };
            Land sanMarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånarantal = "33600" };
            
            

            Land[] test = new Land[7];
            test[0] = sverige;
            test[1] = tyskland;
            test[2] = sanMarino;
            test[3] = new Land() { namn = "Danmark", styrestyp = "monarki", huvudstad = "Köpenhamn", invånarantal = "5928364" };
            test[4] = new Land() { namn = "Italien", styrestyp = "republik", huvudstad = "Rom", invånarantal = "58853482" };
            test[5] = new Land() { namn = "Tjekien", styrestyp = "republik", huvudstad = "San Marino", invånarantal = "10551219" };
            test[6] = new Land() { namn = "Rumänien", styrestyp = "republik", huvudstad = "Bukarest", invånarantal = "19760314" };


            foreach(Land land in test)
            {
                land.print();
            }

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i].styrestyp == "republik")
                {
                    Console.WriteLine(test[i].namn);
                }
            }


        }

        

    }
}