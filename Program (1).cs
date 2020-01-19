using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioArvioitavaTehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            OlutCTRL OlutCTRL1 = new OlutCTRL();

            int K = 0;

            do
            {
                Console.WriteLine("1=pieni tuoppi, 2=iso tuoppi, 3=tilitä");
                try
                {
                    K = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Mitä mahdoit tehdä? Jos vaan laittasit 1 tai 2 tai 3. Miten ois?");
                    K = 0;
                }
                switch (K)
                {
                    case 1:
                        OlutCTRL1.ValutaPieniTuoppi();
                        break;
                    case 2:
                        OlutCTRL1.ValutaIsoTuoppi();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }                 
            } while (K != 3);

            OlutCTRL1.TulostaLaskuri();
            Console.WriteLine(OlutCTRL1.MaaraIsoTuoppi);
            Console.WriteLine(OlutCTRL1.MaaraPieniTuoppi);

            Console.ReadKey();
        }
    }
    class OlutCTRL
    {
        int maaraPieniTuoppi;
        int maaraIsoTuoppi;

        public int MaaraIsoTuoppi
        {
            get
            {
                return maaraIsoTuoppi;
            }
        }
        public int MaaraPieniTuoppi
        {
            get
            {
                return maaraPieniTuoppi;
            }
        }
        public OlutCTRL()
        {
            maaraPieniTuoppi = 0;
            maaraIsoTuoppi = 0;
        }
        public void ValutaPieniTuoppi()
        {
            Console.WriteLine("Valutetaan pientä tuoppia");
            maaraPieniTuoppi++;
        }
        public void ValutaIsoTuoppi()
        {
            Console.WriteLine("Valutetaan isoa tuoppia");
            maaraIsoTuoppi++;
        }
        private void NollaaLaskurit()
        {
            maaraIsoTuoppi = 0;
            maaraPieniTuoppi = 0;
        }
        public void TulostaLaskuri()
        {
            Console.WriteLine("Pieniä tuoppeja: " + maaraPieniTuoppi);
            Console.WriteLine("Isoja tuoppeja: " + maaraIsoTuoppi);
            NollaaLaskurit();
        }
    }
}
