using System.Data;
using System.Runtime.CompilerServices;

namespace Feladatsor
{
    internal class Program
    {

        static int Bekeres(string q)
        {
            Console.Write(q);   
            int? number = null;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható át számmá, add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"A megadott számnak {int.MinValue} és {int.MaxValue} közti értéknek kell lennie, add meg újra: ");
                }
            }
            while (number is null);
            return (int)number;
        }

        static double TortBekeres(string d)
        {
            Console.Write(d);
            double? number = null;
            do
            {
                try
                {
                    number = double.Parse(Console.ReadLine()!.Replace('.',','));
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható át számmá, add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"A megadott számnak {double.MinValue} és {double.MaxValue} közti értéknek kell lennie, add meg újra: ");
                }
            }
            while (number is null);
            return (double)number;
        }

        static double Prim(double sz)
        {
            int count = 1;
            for (int i = 1; i < sz; i++)
            {
                if (sz % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                Console.Write("Ez egy prímszám: ");
                return sz;
            }
            else
            {
                Console.Write("Ez nem egy prímszám: ");
                return sz;
            }
        }


        static void F1()
        {
            Console.WriteLine("1. Feladat");
            Console.WriteLine("Hello, world!");
        }

        static void F2()
        {
            Console.WriteLine("2. Feladat");
            Console.Write("Kérem a felhasználó neved: ");
            string fnev = Console.ReadLine()!;
            Console.WriteLine($"Üdvözlöm: {fnev}");
        }

        static void F3()
        {
            Console.WriteLine("3. Feladat");
            Console.Write("Adj meg egy számot: ");
            int? number = null;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"A megadott szám kétszeres: {number * (long)2}");
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható át számmá, add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"A megadott számnak {int.MinValue} és {int.MaxValue} közti értéknek kell lennie, add meg újra: ");
                }
            }
            while (number is null);
            
            
            
            
            // Console.WriteLine($"Itt a szám kétszerese: {Bekeres() * 2}");
        }


        static void F4()
        {
            int a = Bekeres("Kérem az első számot: ");
            int b = Bekeres("Kérem a második számot: ");
            Console.WriteLine("4. Feladat");
            Console.WriteLine($"A két szám összege: {a + b}");
            Console.WriteLine($"A két szám külömbsége: {a - b}");
            Console.WriteLine($"A két szám szorzatuk: {a * b}");

            if (b == 0)
            {
                Console.WriteLine("Nullával nem lehet osztani");
            }
            else
            {
                Console.WriteLine($"A két szám hányadosa: {a / b}"); 
            }
        }

        static void F5()
        {
            Console.WriteLine("5. Feladat");
            int a = Bekeres("Kérem az első számot: ");
            int b = Bekeres("Kérem a második számot: ");

            if ( a > b )
            {
                Console.WriteLine($"Ez a szám nagyobbik: {a}");
            }
            else
            {
                Console.WriteLine($"Ez a szám a nagyobbik: {b}");
            }
        }

        static void F6()
        {
            Console.WriteLine("6. Feladat");

            int a = Bekeres("Háromszög a oldala: ");
            int b = Bekeres("Háromszög b oldala: ");
            int c = Bekeres("Háromszög c oldala");
            int[] t = new int[3];
            t[0] = a;
            t[1] = b;
            t[2] = c;
            int smallest = t.Min();
            Console.WriteLine($"A legkisebb szám: {smallest}");
            
        }


        static void F7()
        {
            Console.WriteLine("7. Feladat");

            int a = Bekeres("Add meg az általános háromszög a oldalát: ");
            int b = Bekeres("Add meg az általános háromszög b oldalát: ");
            int c = Bekeres("Add meg az általános háromszög c oldalát: ");
            int[] t = new int[3];
            t[0] = a;
            t[1] = b;
            t[2] = c;
            int smallest = t.Min();
            Array.Sort( t );
            if (t[0] + t[1] > t[2])
            {
                Console.WriteLine("Van ilyen háromszög");
            }
            else
            {
                Console.WriteLine("Nincs ilyen háromszög");
            }


        }

        static void F8()
        {
            Console.WriteLine("8. Feladat");


            int a = Bekeres("Kérem az első számot: ");
            int b = Bekeres("Kérem a második számot: ");

            if (a >= 0 && b >= 0)
            {
                Console.WriteLine($"A két szám mértani közepe: {Math.Round(Math.Sqrt(a * b), 4)}");
                double oszt = (a + b) / 2;
                Console.WriteLine($"A két szám számtani közepe: {Math.Round(oszt, 4)}");
            }
            else
            {
                Console.WriteLine("Az egyik szám nem pozitív");
            }
        }

        static void F9()
        {
            Console.WriteLine("Feladat 9.");
            int a = Bekeres("Kérem az első számot: ");
            int b = Bekeres("Kérem a második számot: ");
            int c = Bekeres("Kérem a harmadik számot: ");
            if (b * b - 4 * a * c >= 0)
            {
                Console.WriteLine("A másodfokú egyenletnek van értéke");
            }
            else
            {
                Console.WriteLine("Nem értelmezhető a valós számok halmazán.");
            }
        }

        static void F10()
        {
            Console.WriteLine("10. Feladat");
            int a = Bekeres("Kérem az első számot: ");
            int b = Bekeres("Kérem a második számot: ");
            int c = Bekeres("Kérem a harmadik számot: ");
            int differens = (int)Math.Round(Math.Sqrt(b * b - 4 * a * c), 4);
            if (b * b - 4 * a * c >= 0)
            {
                Console.WriteLine("A másodfokú egyenletnek van értéke");
                Console.WriteLine($"Az első gyöke: {(-b + differens) / (2*a)}");
                Console.WriteLine($"A második gyöke: {(-b - differens) / (2*a)}");
            }
            else
            {
                Console.WriteLine("Nem értelmezhető");
            }


        }


        static void F11()
        {
            Console.WriteLine("11. Feladat");
            double a = TortBekeres("Add meg a derékszögű háromszög egyik befogóját: ");
            double b = TortBekeres("Add meg a derékszögű háromszög másik befogóját: ");
            double c = a*a + b*b;

            Console.WriteLine($"A derékszögű háromszög átfogoja: {Math.Sqrt(Math.Round(c, 2))}");
        }

        static void F12()
        {
            Console.WriteLine("12. Feladat");

            double a = TortBekeres("Add meg a téglatest a oldalát centiméterben: ");
            double b = TortBekeres("Add meg a téglatest b oldalát centiméterben: ");
            double c = TortBekeres("Add meg a téglatest c oldalát centiméterben: ");

            Console.WriteLine($"A téglatest térfogata: {a * b * c} köbcentiméter");
            Console.WriteLine($"A téglatest felszíne: {2 * (a * b + a * c + b * c)} négyzetcentiméter");
        }

        static void F13()
        {
            Console.WriteLine("13. Feladat");


            double d = TortBekeres("Add meg a kör átmérőjét: ");
            double r = d / 2;

            Console.WriteLine($"A kör kerülete: {d * Math.PI}");
            Console.WriteLine($"A kör területe: {(r*r) * Math.PI}");
        }

        static void F14()
        {
            Console.WriteLine("14. Feladat");

            double r = TortBekeres("Add meg a kör sugarát: ");
            double alfa = TortBekeres("Add meg a körcikk szögének fokát: ");

            Console.WriteLine($"Körcikkiv hossza: {2 * r * Math.PI * (alfa / 360)}");
            Console.WriteLine($"Körcikk területe: {(r*r*alfa)/2}");
        }

        static void F15()
        {
            Console.WriteLine("15. Feladat");

            int szam = Bekeres("Addj meg egy számot ameddig ki akarod iratni az elötte lévő egész számokat: ");
            int szamlalo = 0;

            for (int i = 0; i <= szam; i++)
            {
                Console.Write($"{szamlalo} ");
                szamlalo++;
            }
        }

        static void F16()
        {
            Console.WriteLine("16. Feladat");

            int szam = Bekeres("Addj meg egy számot ameddig ki akarod iratni az elötte lévő egész számokat egymás alá: ");

            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine($"{i} ");
            }
        }

        static void F17()
        {
            Console.WriteLine("17. Feladat");

            int szam = Bekeres("Adj meg egy számot melynek az osztóit szeretnéd tudni: ");

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    
                    Console.Write($"{i} ");
                }

            }
        }

        static void F18()
        {
            Console.WriteLine("18. Feladat");

            int szam = Bekeres("Adj meg egy számot melynek az osztóinak összegét szeretnéd látni: ");
            int szamlalo = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    szamlalo += 1;
                    
                }

            }
            Console.WriteLine($"A szám osztóinak összege: {szamlalo}");
        }

        static void F19()
        {
            Console.WriteLine("19. Feladat");

            int szam = Bekeres("Adj meg egy számot amiről megszeretnéd tudni hogy tökéletes szám e: ");
            int ossz = 0;
            for (int i = 1; i <= szam; i++)
            {
                if ((szam % i) == 0)
                {
                    ossz += i;
                }
            }
            if (ossz == 2 * szam)
            {
                Console.WriteLine("Ez egy tökéletes szám");
            }
            else
            {
                Console.WriteLine("Ez nem egy tökéletes szám");
            }
        }

        static void F20()
        {
            Console.WriteLine("20. Feladat");


            int alap = Bekeres("Add meg az alap számot: ");
            int kitevo = Bekeres("Add meg a kitevőjét: ");

            if (alap > 0 && kitevo > 0)
            {
                Console.WriteLine($"Hatványérték: {Math.Pow(alap, kitevo)}");
            }
            else
            {
                Console.WriteLine("Egész pozitív számot kell megadni");
            }

        }

        static void F21()
        {
            Console.WriteLine("21. Feladat");

            double num = TortBekeres("Adj meg egy pozitív számot: ");

            if (num > 0)
            {
                Console.WriteLine("Ez egy pozitív szám!");
            }
            else
            {
                Console.WriteLine("Ez a szám nem egy pozitív szám!");
            }
        }

        static void F22()
        {
            Console.WriteLine("22. Feladat");
            double num = 0;
            double sum = 0;

            while (num < 10)
            {
                num = TortBekeres("Adj meg egy számot ami kisebb mint tíz: ");
                if (num < 10)
                {
                    sum += num;
                    
                }
            }
            Console.WriteLine($"Ez az eddigi megadott számoknak az összege: {sum}");
        }


        static void F23()
        {
            Console.WriteLine("23. Feladat");


            int num = Bekeres("Kérek egy egész számot: ");
            bool div = true;

            while (div)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"2*");
                    num /= 2;
                }
                else
                {
                    Console.Write($"{num}");
                    div = false;
                }
            }
        }

        static void F24()
        {
            Console.WriteLine("24. Feladat");

            Console.Write("Írd be az alma szót: ");
            string input = Console.ReadLine()!;

            while (input != "alma")
            {
                Console.Write("Nem jó, próbáld újra: ");
                input = Console.ReadLine()!;
            }
            Console.WriteLine("Az alma gyümölcs!");

        }

        static void F25()
        {
            Console.WriteLine("25. Feladat");


            int num = Bekeres("Kérek egy egész számot: ");
            bool minus = true;
            int numm = num;
            int szor = 0;
            
            while (minus)
            {
                if (numm > 3)
                {
                    numm -= 3;
                    szor++;
                    if (numm < 3)
                    {
                        minus = false;
                        Console.WriteLine($"{num} = {szor}*3+{num%3}");
                        break;
                    }
                }
            }
        }

        static void F26()
        {
            Console.WriteLine("26. Feladat");

            int num = Bekeres("Kérek egy számot, amiről megakarod tudni hogy prím-e: ");
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine("Ez nem egy prímszám");
            }
            else
            {
                Console.WriteLine("Ez egy prímszám");
            }
        }


        static void F27()
        {
            Console.WriteLine("27. Feladat");

            int num = Bekeres("Kérek egy számot, ameddig szeretnéd tudni a prímszámokat: ");

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Prim(i));   
            }
        }

        static void F28()
        {
            Console.WriteLine("28. Feladat");

            int num = Bekeres("Kérek egy számot prím felbontásra: ");
            int count = 1;
            Console.WriteLine("Ezek a számok a prímosztói a megadott számnak:");
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;

                        }
                        
                    }
                    if (count == 2)
                    {
                        Console.Write($"{i} ");

                    }
                    count = 1;
                }
            }
            

        }

        static void F29()
        {
            Console.WriteLine("29. Feladat");

            int num = Bekeres("Kérek egy számot prím felbontásra: ");
            for (int i = 1; i < num; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            //F1();
            //F2();
            //F3();
            //F4();
            //F5();
            //F6();
            //F7();
            //F8();
            //F9();
            //F10();
            //F11();
            //F12();
            //F13();
            //F14();
            //F15();
            //F16();
            //F17();
            //F18();
            //F19();
            //F20();
            //F21();
            //F22();
            //F23();
            //F24();
            //F25();
            //F26();
            //F27();
            //F28();
            F29();
        }
    }
}