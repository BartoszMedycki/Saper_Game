using System;
using System.Collections.Generic;

namespace Saper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            plansza p = new plansza();


            p.przypisanieTab();
            p.przypisanie_tab_poczatkowej();

            for (int i = 0; i <= 64 - 1; i++)
            {
                p.WyspietlaniePlanszy();

                int c = int.Parse(Console.ReadLine());
                p.podmianka(c);
                if (p.gameOver(c)) break;

            }
            // sprawdzamy zmiany w Gicie 2
            // sprawdzamy zmiany w Gicie 2
            // sprawdzamy zmiany w Gicie 3



            Console.WriteLine();
            

            

            Console.ReadLine();
        }
    }

  
    class plansza
    {
        static int p = 9;
        static int q;
        static int c = 0;
        int dlugosc = 8;
        string[] tab = new string[64];
        int dlugoscPomocnicza = 8;
        string[] tabPomocnicza = new string[64];
        static int klip = -9;
        static int ku = 7;
        static int koko = -9;

        public void przypisanieTab()
        {

            for (int kk = 0; kk < 8; kk++)
            {
                for (int i = 0; i <= tab.Length - 1; i++)
                { tab[i] = "~"; }

            }




        }
        public void przypisanie_tab_poczatkowej()
        {


            Random bomba = new Random();
            for (int qq = 0; qq <= 8; qq++)
            {
                int a = bomba.Next(0, 63);
                Console.WriteLine();
                tabPomocnicza[19] = "B";


            }
            ValueAddition();
            

         
            
        }
       
        public void nadanieWartosci(int n, int zmienna)
        {
            if (tabPomocnicza[n] != "B")
            {
                tabPomocnicza[n] = zmienna.ToString();
            }
        }
        
    
        public void podmianka(int zmiana)
        {
            tab[zmiana] = tabPomocnicza[zmiana];

        }
        public void ValueAddition()
        {
            for (int n = 0; n <= tabPomocnicza.Length - 7; n++)
            {

                int zmiennaPoczatkowa = 0;
                int zmienna = 0;
                int q = 0;





                for (int k = 0; k <= 2; k++)
                {

                    if ((n + ku) <= 63)
                    {
                        if (tabPomocnicza[n + ku] == "B") zmiennaPoczatkowa++;
                        if (tabPomocnicza[n + 1] == "B")
                        {
                            q = 1; ;

                        }
                    }
                    if ((n + koko) >= 0)
                    {
                        if (tabPomocnicza[n + koko] == "B") zmiennaPoczatkowa++;
                        if (tabPomocnicza[n - 1] == "B")
                        {
                            q = 1; ;

                        }
                    };
                    ku++;
                    koko++;
                    zmienna = zmiennaPoczatkowa + q;
                }
                ku = 7;
                koko = -9;
                nadanieWartosci(n, zmienna);








            }
        }
        public bool gameOver(int zmienna)
        {
            if (tabPomocnicza[zmienna] == "B")
            {
                Console.Clear();
                Console.WriteLine("Trafiles bombe");
            }
            return tabPomocnicza[zmienna] == "B";
        }

        public void WyspietlaniePlanszy()
        {



            for (int k = 0; k <= 8 - 1; k++)
            {


                for (int q = 0; q <= 8 - 1; q++)
                {

                    Console.Write(tab[c] + "||");
                    c++;
                }


                Console.WriteLine();
                Console.Write("===========================");
                Console.WriteLine();
            }
            c = 0;






            Console.WriteLine();
        }

        
            
        
    }



}
class probka
{
    


}