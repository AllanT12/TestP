using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cutie[] cuties;
            cuties = new Cutie[10];
            int a=1,i=0,z=0;
            Console.WriteLine("A – adaugare cutie\nL – afisare date despre toate cutiile\nF – afisati cutiile de o anumita culoare\nC - Afisati pentru fiecare cutie acele cutii (id-urile lor) care se pot plasa in interiorul ei\nX-iesire");
            while(a!=0)
            {
                string optiune = Console.ReadLine();
                switch(optiune)
                {
                    case"a":
                        Console.WriteLine("lungime:");
                        string lungime=Console.ReadLine();
                        Console.WriteLine("latime");
                        string latime = Console.ReadLine();
                        Console.WriteLine("adancime");
                        string adancime = Console.ReadLine();
                        cuties[i] = new Cutie(Convert.ToInt32(lungime), Convert.ToInt32(latime), Convert.ToInt32(adancime));
                        Console.WriteLine("culoare:");
                        int opptiune = Convert.ToInt32(Console.ReadLine());
                        cuties[i].Culoare = (Culoare)opptiune;
                        i++;
                        break;
                    case "l":for(int n=0;n<i;n++)
                        {
                            Console.Write("Cutia {0} ",n);
                            Console.WriteLine(cuties[n].ConversieLaSir());
                        }
                        break;
                    case "f":Console.WriteLine("Ce culoare vreti sa gasiti");
                        string culoare = Console.ReadLine();
                        for (int n = 0; n < i; n++)
                        {
                            if(culoare==Convert.ToString(cuties[n].Culoare))
                            {
                                Console.WriteLine(cuties[n].ConversieLaSir());
                                z++;//in caz ca gaseste
                            }
                        }
                        if(z==0)
                        {
                            Console.WriteLine("nu exista");
                        }
                            break;
                    case "x":a = 0;break;
                }
            }
        }
    }
}
