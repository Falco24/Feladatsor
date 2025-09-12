using System.Data;

namespace Feladatsor
{
    internal class Program
    {

        static int Bekeres()
        {
            Console.Write("Adj meg egy számot: ");
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

        static double TortBekeres()
        {
            Console.Write("Adj meg egy számot: ");
            double? number = null;
            do
            {
                try
                {
                    number = double.Parse(Console.ReadLine()!);
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

        static void F1()
        {
            Console.WriteLine("1. Feladat");
            Console.WriteLine("Hello World!");
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
            int a = Bekeres();
            int b = Bekeres();
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
            int a = Bekeres();
            int b = Bekeres();

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

            int a = Bekeres();
            int b = Bekeres();
            int c = Bekeres();
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

            int a = Bekeres();
            int b = Bekeres();
            int c = Bekeres();
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


            int a = Bekeres();
            int b = Bekeres();

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
            int a = Bekeres();
            int b = Bekeres();
            int c = Bekeres();
            if (b * b - 4 * a * c >= 0)
            {
                Console.WriteLine("A másodfokú egyenletnek van értéke");
            }
            else
            {
                Console.WriteLine("Nem értelmezhető");
            }
        }

        static void F10()
        {
            Console.WriteLine("10. Feladat");
            int a = Bekeres();
            int b = Bekeres();
            int c = Bekeres();
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
            double a = TortBekeres();
            double b = TortBekeres();
            double c = a*a + b*b;

            Console.WriteLine($"A derékszögű háromszög átfogoja: {Math.Sqrt(Math.Round(c, 2))}");
        }

        static void F12()
        {
            Console.WriteLine("12. Feladat");

            double a = TortBekeres();
            double b = TortBekeres();
            double c = TortBekeres();

            Console.WriteLine($"A téglatest térfogata: {a * b * c} köbcentiméter");
            Console.WriteLine($"A téglatest felszíne: {2 * (a * b + a * c + b * c)} négyzetcentiméter");
        }

        static void F13()
        {
            Console.WriteLine("13. Feladat");


            double d = TortBekeres();
            double r = d / 2;

            Console.WriteLine($"A kör kerülete: {d * Math.PI}");
            Console.WriteLine($"A kör területe: {(r*r) * Math.PI}");
        }

        static void F14()
        {
            Console.WriteLine("14. Feladat");

            double r = TortBekeres();
            double alfa = TortBekeres();

            Console.WriteLine($"Körcikkiv hossza: {2 * r * Math.PI * (alfa / 360)}");
            Console.WriteLine($"Körcikk területe: {(r*r*alfa)/2}");
        }

        static void F15()
        {
            Console.WriteLine("15. Feladat");

            int szam = Bekeres();
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

            int szam = Bekeres();

            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine($"{i} ");
            }
        }

        static void F17()
        {
            Console.WriteLine("17. Feladat");

            int szam = Bekeres();

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

            int szam = Bekeres();
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

            int szam = Bekeres();
            int ossz = 0;
            for (int i = 1; i <= szam; i++)
            {
                if ((szam % i) == 0)
                {
                    ossz += 1;
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


            int alap = Bekeres();
            int kitevo = Bekeres();

            if (alap > 0 && kitevo > 0)
            {
                Console.WriteLine($"Hatványérték: {Math.Pow(alap, kitevo)}");
            }
            else
            {
                Console.WriteLine("Egész pozitív számot kell megadni");
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
            F20();
        }
    }
}