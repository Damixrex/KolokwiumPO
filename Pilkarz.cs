using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public abstract class Pilkarz
    {
       private Pilkarz() {}
        public string imie;
        public string nazwisko;
        public int numerNaKoszulce;

        public override string ToString()
        {
            return String.Concat(imie,nazwisko,numerNaKoszulce);
        }
           public class Napastnik : Pilkarz
            {
                public Napastnik(string name, string surname, int number)
                {
                    imie = name;
                    nazwisko = surname;
                    if(number%2!=0)
                        numerNaKoszulce = number;
                    else { };
                }
            }


          public class Obronca : Pilkarz
            {
                public Obronca(string name, string surname, int number)
                {
                    imie = name;
                    nazwisko = surname;
                    if (number % 2 == 0)
                        numerNaKoszulce = number;
                    else { };
                   
                }
            }
    }
}
