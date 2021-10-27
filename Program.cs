using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Zvarych54558
{
    class Program
    { //moje inicjały mz
        static bool mzRealizacjaZeŚledzeniem;

        static void Main(string[] args)
        {
            ConsoleKeyInfo mzMenu;
            
            Console.WriteLine("\n\n\tProgram KALKULATOR_Zvarych_54558 umożliwia obliczanie wartości wybranych wielkości matematycznych");

            do
            {
                Console.WriteLine("\n\n\tMENU funkcjonalne programu ObliczanieWielkościMatematycznych:");
                Console.WriteLine("\n\tA. Obliczanie ceny jednostki paszy (in-line)");
                Console.WriteLine("\n\tB. Obliczanie ceny jednostki paszy (method-call)");
                Console.WriteLine("\n\tC. Obliczanie średniej harmonicznej (in-line)");
                Console.WriteLine("\n\tD. Obliczanie średniej harmonicznej (method-call)");
                Console.WriteLine("\n\tE. Obliczanie średniej geometrycznej (in-line)");
                Console.WriteLine("\n\tF. Obliczanie średniej geometrycznej (method-call)");
                Console.WriteLine("\n\tG. Obliczanie średniej kwadratowej (in-line)");
                Console.WriteLine("\n\tH. Obliczanie średniej kwadratowej (method-call)");
                Console.WriteLine("\n\tI. Obliczanie średniej potęgowej <średnie uogólnienie> (in-line)");
                Console.WriteLine("\n\tJ. Obliczanie średniej potęgowej <średnie uogólnienie> (method-call)");
                Console.WriteLine("\n\tK. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym" +
                    " o podanej \n\t(przez użytkownika programu) podstaswie liczenia (in-line)");
                Console.WriteLine("\n\tL. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym" +
                    " o podanej \n\t(przez użytkownika programu) podstaswie liczenia (method-call)");


                Console.WriteLine("\n\tX. Zakończenie (wyjście z) programu");

                Console.WriteLine("\n\tNaciśnięciem odpowiedniego klawisza wybierz jedną z podanych funkcjonalności");

                mzMenu = Console.ReadKey();

                Console.WriteLine("\n\tJeżeli chcesz, aby program realizował obliczenia ze śledzeniem, to naciśnij klawisz T (lub t), " + 
                    "\n\ta gdy naciśniesz dowolny inny klawisz, to uznam, że rezygnujesz ze śledzenia: ");
                if (Console.ReadKey().Key == ConsoleKey.T)
                    mzRealizacjaZeŚledzeniem = true;
                else
                    mzRealizacjaZeŚledzeniem = false;


                if (mzMenu.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n\n\tWYBRANO: A. Obliczanie ceny jednostki paszy (in-line)");
                    ushort mzN;

                    do
                    {
                        Console.WriteLine("\n\tPodaj ilosc składników n: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzN))
                        {
                            Console.WriteLine("\n\tW zapisie ilości składników wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj ilość składników ponownie: ");
                        }
                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana ilość składników wynosi: {0} ", mzN);
                        if (mzN == 0)
                            Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

                    } while (mzN == 0);

                    float mzM, mzSuma;
                    var mzLiczbaKg = new Dictionary<int, float>();

                    mzSuma = 0.0F;

                    for (int i = 1; i <= mzN; i++)
                    {
                        Console.WriteLine("\n\tPodaj {0}-ą liczbę kg składników w mieszance: ", i);
                        while (!float.TryParse(Console.ReadLine(), out mzM))
                        {
                            Console.WriteLine("\n\tW zapisie liczby kg składników wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj liczbę kg składników ponownie: ");
                        }

                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana liczba kg dla n {0}-go składnika wynosi: {1} ",i, mzM);

                        mzLiczbaKg[i] = mzM;
                        mzSuma += mzM;
                    }

                    float mzC;
                    var mzCena = new Dictionary<int, float>();
                    for (int i = 1; i <= mzN; i++)
                    {
                        Console.WriteLine("\n\tPodaj cenę {0}-go  składnika w mieszance: ", i);
                        while (!float.TryParse(Console.ReadLine(), out mzC))
                        {
                            Console.WriteLine("\n\tW zapisie ceny składnika wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj cenę składników ponownie: ");
                        }

                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana cena za kg dla {0}-go składnika wynosi: {1} ", i, mzC);
                        mzCena[i] = mzC;
                    }

                    float mzWyn, mzWyn1;
                    mzWyn1 = 0.0F;
                    for (int i = 1; i <= mzN; i++)
                    {
                        mzWyn = (mzLiczbaKg[i] * mzCena[i]);

                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Obliczona cena za {0} składnik wynosi: {1} ", i, mzWyn);

                        mzWyn1 += mzWyn;
                        
                    }

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Cena całej mieszanki wynosi: {0} ", mzWyn1);

                    float mzWynnik;
                    mzWynnik = mzWyn1 / mzSuma;

                    Console.WriteLine("\n\tObliczona cena jednostki paszy dla n = {0} wynosi: {1, 8:G}", mzN, mzWynnik + " (zł)");
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else


                if (mzMenu.Key == ConsoleKey.B)
                {
                    Console.WriteLine("\n\n\tWYBRANO: B. Obliczanie ceny jednostki paszy (method-call)");

                    mzObliczanieJednostkiPaszy();
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();

                }
                else


                if (mzMenu.Key == ConsoleKey.C)
                {
                    Console.WriteLine("\n\n\tWYBRANO: C. Obliczanie średniej harmonicznej (in-line)");

                    ushort mzIlosc;

                    do
                    {
                        Console.WriteLine("\n\tPodaj ilosc liczb: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                        {
                            Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj ilość liczb ponownie: ");
                        }
                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Podana ilość liczb wynosi: {0} ", mzIlosc);

                        if (mzIlosc == 0)
                            Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

                    } while (mzIlosc == 0);

                    Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

                    double mzSum = 0;
                    for (int i = 0; i < mzIlosc; i++)
                    {
                        mzSum += 1 / Convert.ToDouble(Console.ReadLine());
                    }

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Suma w mianowniku wynosi: {0} ", mzSum);

                    double mzResult = mzIlosc / mzSum;

                    Console.WriteLine("\n\tSrednia harmoniczna tych liczb dla n = {0} wynosi: {1, 8:G}", mzIlosc, mzResult);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else


                if (mzMenu.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\n\n\tWYBRANO: D. Obliczanie średniej harmonicznej (method-call)");
                    Console.WriteLine("\n\tSrednia harmoniczna tych liczb to: " + mzSredniaHarmoniczna());
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();

                }
                else


                if (mzMenu.Key == ConsoleKey.E)
                {
                    Console.WriteLine("\n\n\tWYBRANO: E. Obliczanie średniej geometrycznej (in-line)");

                    ushort mzIlosc;

                    do
                    {
                        Console.WriteLine("\n\tPodaj ilosc liczb: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                        {
                            Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj ilość liczb ponownie: ");
                        }
                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                        if (mzIlosc == 0)
                            Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

                    } while (mzIlosc == 0);

                    Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

                    double mzPrzemnozoneLiczby = 1;
                    for (int i = 0; i < mzIlosc; i++)
                    {
                        mzPrzemnozoneLiczby *= Convert.ToDouble(Console.ReadLine());
                    }
                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Przemnozone liczby pod pierwiastkiem wynoszą: {0} ", mzPrzemnozoneLiczby);

                    double mzResult1 = Math.Pow(mzPrzemnozoneLiczby, 1.0 / mzIlosc);
                    Console.WriteLine("\n\tSrednia geometryczna tych liczb dla n = {0} wynosi: {1, 8:G}", mzIlosc, mzResult1);

                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.F)
                {
                    Console.WriteLine("\n\n\tWYBRANO: F. Obliczanie średniej geometrycznej (method-call)");
                    Console.WriteLine("\n\tSrednia geometryczna tych liczb to: " + mzSredniaGeometryczna());
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.G)
                {
                    Console.WriteLine("\n\n\tWYBRANO: G. Obliczanie średniej kwadratowej (in-line)");
                    
                    ushort mzIlosc;

                    do
                    {
                        Console.WriteLine("\n\tPodaj ilosc liczb: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                        {
                            Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj ilość liczb ponownie: ");
                        }
                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                        if (mzIlosc == 0)
                            Console.WriteLine("Liczba zero jest nieprawidłowa");

                    } while (mzIlosc == 0);

                    Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

                    double mzSum = 0;
                    for (int i = 0; i < mzIlosc; i++)
                    {
                        mzSum += Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
                    }

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Suma wszystkich liczb do drugiej potęgi wynosi: {0} ", mzSum);

                    double mzResult2 = Math.Sqrt(mzSum / mzIlosc);

                    Console.WriteLine("\n\tSrednia kwadratowa tych liczb dla n = {0} wynosi: {1, 8:G}", mzIlosc, mzResult2);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.H)
                {
                    Console.WriteLine("\n\n\tWYBRANO: H. Obliczanie średniej kwadratowej (method-call)");
                    Console.WriteLine("\n\tSrednia kwadratowa tych liczb to: " + mzSredniaKwadratowa());
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.I)
                {
                    Console.WriteLine("\n\n\tWYBRANO: I. Obliczanie średniej potęgowej <średnie uogólnienie> (in-line)");

                    ushort mzIlosc;

                    do
                    {
                        Console.WriteLine("\n\tPodaj ilosc liczb: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                        {
                            Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj ilość liczb ponownie: ");
                        }
                        if (mzRealizacjaZeŚledzeniem)
                            Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                        if (mzIlosc == 0)
                            Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

                    } while (mzIlosc == 0);

                    Console.WriteLine("\n\tKtórego rzędu ma być średnia potęgowa?");
                    int mzRzed = Convert.ToInt32(Console.ReadLine());

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Wczytany rzęd wynosi: {0} ", mzRzed);

                    Console.WriteLine("\n\tPodaj liczby i naciśnij enter żeby podać następną: ");

                    double mzSum = 0;
                    for (int i = 0; i < mzIlosc; i++)
                    {
                        mzSum += Math.Pow(Convert.ToDouble(Console.ReadLine()), mzRzed);
                    }

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Suma liczb do {0}-tej potęgi wynosi: {1} ", mzRzed, mzSum);

                    double mzRes = mzSum / mzIlosc;

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Wynnik dzielenia pod pierwiastkiem wynosi: {0} ", mzRes);

                    double mzResult3 = Math.Pow(mzRes, (1.0 / mzRzed));

                    Console.WriteLine("\n\tSrednia potęgowa tych liczb dla n = {0} wynosi: {1, 8:G}", mzIlosc, mzResult3);
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.J)
                {
                    Console.WriteLine("\n\n\tWYBRANO: J. Obliczanie średniej potęgowej <średnie uogólnienie> (method-call)");
                    Console.WriteLine("\n\tSrednia potęgowa tych liczb to: " + mzSredniaPotęgowa());
                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                }
                else

                 if (mzMenu.Key == ConsoleKey.K)
                {
                    Console.WriteLine("\n\n\tWYBRANO: K. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym" +
                    " \n\to podanej (przez użytkownika programu) podstaswie liczenia (in-line)");

                    ushort mzLiczba;

                    do
                    {
                        Console.WriteLine("\n\tPodaj liczbe w systemie dziesiętnym od 0 do 65535: ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzLiczba))
                        {
                            Console.WriteLine("\n\tW zapisie liczby wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj liczbę ponownie: ");
                        }

                    } while (mzLiczba == 0);

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Wczytana liczba wynosi: {0} ", mzLiczba);

                    ushort mzPSL;

                    do
                    {
                        Console.WriteLine("\n\tPodaj podstawę systemu liczbowego poprawnie (2, 8 lub 16): ");
                        while (!ushort.TryParse(Console.ReadLine(), out mzPSL))
                        {
                            Console.WriteLine("\n\tW zapisie PSL wystąpił niedozwolony znak!");
                            Console.Write("\n\tPodaj PSL ponownie: ");
                        }

                    } while (mzPSL != 2 && mzPSL != 8 && mzPSL != 16);

                    if (mzRealizacjaZeŚledzeniem)
                        Console.WriteLine("\n\t\t TRACE: Wczytana podstawa systemu liczbowego wynosi: {0} ", mzPSL);

                    int[] mzTab = new int[32];
                    int i = 0;

                    switch (mzPSL)
                    {                      
                        case 2:

                            while (mzLiczba > 0) 
                            {
                                mzTab[i++] = mzLiczba % 2;
                                mzLiczba /= 2;
                            }

                            Console.WriteLine("\n\tLiczba w systemie dwójkowym wynosi: ");

                            for (int j = i - 1; j >= 0; j--)
                            {
                                Console.Write(mzTab[j]);
                            }

                            Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                            Console.ReadKey();

                            break;

                        case 8:

                            while (mzLiczba > 0) 
                            {
                                mzTab[i++] = mzLiczba % 8;
                                mzLiczba /= 8;
                            }

                            Console.WriteLine("\n\tLiczba w systemie ósemkowym wynosi: ");

                            for (int j = i - 1; j >= 0; j--)
                            {  
                                Console.Write(mzTab[j]);
                            }

                            Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                            Console.ReadKey();

                            break;

                        case 16:

                            var mzDict = new Dictionary<int, string>
                            {
                                { 10, "A" },
                                { 11, "B" },
                                { 12, "C" },
                                { 13, "D" },
                                { 14, "E" },
                                { 15, "F" }
                            };

                            string[] mzString = new string[32];

                            while (mzLiczba > 0) 
                            {
                                mzString[i++] = Convert.ToString(mzLiczba % 16);

                                int mzInt = Convert.ToInt32(mzString[i - 1]);

                                if (mzInt >= 10) 
                                {
                                    mzString[i - 1] = mzDict[mzInt];
                                }

                                mzLiczba /= 16;
                            }

                            Console.WriteLine("\n\tLiczba w systemie szesnastkowym wynosi: ");

                            for (int j = i - 1; j >= 0; j--)
                            { 
                                Console.Write(mzString[j]);
                            }

                            Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                            Console.ReadKey();

                            break;

                    } 
                }
                else

                 if (mzMenu.Key == ConsoleKey.L)
                {
                    Console.WriteLine("\n\n\tWYBRANO: L. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym" +
                    " \n\to podanej (przez użytkownika programu) podstaswie liczenia (method-call)");

                    mzKonwersja();
                }

            } while (mzMenu.Key != ConsoleKey.X);


            Console.WriteLine("\n\n\tAutor programu: Maryana Zvarych, Nr albumu 54558");
            Console.WriteLine("\n\tDzisiejsza data: {0}", DateTime.Now);
            Console.WriteLine("\n\n\tDla zakończenia działania programu naciśnij dowolny klawisz...");
            Console.ReadKey();
        }

        static void mzObliczanieJednostkiPaszy()
        {

            ushort mzN;

            do
            {
                Console.WriteLine("\n\tPodaj ilosc składników n: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzN))
                {
                    Console.WriteLine("\n\tW zapisie ilości składników wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj ilość składników ponownie: ");
                }
                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana ilość składników wynosi: {0} ", mzN);
                if (mzN == 0)
                    Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

            } while (mzN == 0);

            float mzM, mzSuma;
            var mzLiczbaKg = new Dictionary<int, float>();

            mzSuma = 0.0F;

            for (int i = 1; i <= mzN; i++)
            {
                Console.WriteLine("\n\tPodaj {0}-ą liczbę kg składników w mieszance: ", i);
                while (!float.TryParse(Console.ReadLine(), out mzM))
                {
                    Console.WriteLine("\n\tW zapisie liczby kg składników wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj liczbę kg składników ponownie: ");
                }

                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana liczba kg dla {0}-go składnika wynosi: {1} ", i, mzM);

                mzLiczbaKg[i] = mzM;
                mzSuma += mzM;
            }

            float mzC;
            var mzCena = new Dictionary<int, float>();
            for (int i = 1; i <= mzN; i++)
            {
                Console.WriteLine("\n\tPodaj cenę {0}-go  składnika w mieszance: ", i);
                while (!float.TryParse(Console.ReadLine(), out mzC))
                {
                    Console.WriteLine("\n\tW zapisie ceny składnika wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj cenę składników ponownie: ");
                }

                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana cena za kg dla {0}-go składnika wynosi: {1} ", i, mzC);
                mzCena[i] = mzC;
            }

            float mzWyn, mzWyn1;
            mzWyn1 = 0.0F;
            for (int i = 1; i <= mzN; i++)
            {
                mzWyn = (mzLiczbaKg[i] * mzCena[i]);

                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Obliczona cena za {0} składnik wynosi: {1} ", i, mzWyn);

                mzWyn1 += mzWyn;

            }

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Cena całej mieszanki wynosi: {0} ", mzWyn1);

            float mzWynnik;
            mzWynnik = mzWyn1 / mzSuma;

            Console.WriteLine("\n\tObliczona cena jednostki paszy dla n = {0} wynosi: {1, 8:G}", mzN, mzWynnik + " (zł)");
        }

        static double mzSredniaHarmoniczna()
        {
            ushort mzIlosc;

            do
            {
                Console.WriteLine("\n\tPodaj ilosc liczb: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                {
                    Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj ilość liczb ponownie: ");
                }
                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Podana ilość liczb wynosi: {0} ", mzIlosc);

                if (mzIlosc == 0)
                    Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

            } while (mzIlosc == 0);

            Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

            double mzSum = 0;
            for (int i = 0; i < mzIlosc; i++)
            {
                mzSum += 1 / Convert.ToDouble(Console.ReadLine());
            }

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Suma w mianowniku wynosi: {0} ", mzSum);

            return mzIlosc / mzSum;
        }

        static double mzSredniaGeometryczna()
        {
            ushort mzIlosc;

            do
            {
                Console.WriteLine("\n\tPodaj ilosc liczb: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                {
                    Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj ilość liczb ponownie: ");
                }
                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                if (mzIlosc == 0)
                    Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

            } while (mzIlosc == 0);

            Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

            double mzPrzemnozoneLiczby = 1;
            for (int i = 0; i < mzIlosc; i++)
            {
                mzPrzemnozoneLiczby *= Convert.ToDouble(Console.ReadLine());
            }
            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Przemnozone liczby pod pierwiastkiem wynoszą: {0} ", mzPrzemnozoneLiczby);

            return Math.Pow(mzPrzemnozoneLiczby, 1.0 / mzIlosc);
        }

        static double mzSredniaKwadratowa()
        {
            ushort mzIlosc;

            do
            {
                Console.WriteLine("\n\tPodaj ilosc liczb: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                {
                    Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj ilość liczb ponownie: ");
                }
                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                if (mzIlosc == 0)
                    Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

            } while (mzIlosc == 0);

            Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

            double mzSum = 0;
            for (int i = 0; i < mzIlosc; i++)
            {
                mzSum += Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
            }

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Suma wszystkich liczb do drugiej potęgi wynosi: {0} ", mzSum);

            return Math.Sqrt(mzSum / mzIlosc);
        }

        static double mzSredniaPotęgowa()
        {
            ushort mzIlosc;

            do
            {
                Console.WriteLine("\n\tPodaj ilosc liczb: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzIlosc))
                {
                    Console.WriteLine("\n\tW zapisie ilości liczb wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj ilość liczb ponownie: ");
                }
                if (mzRealizacjaZeŚledzeniem)
                    Console.WriteLine("\n\t\t TRACE: Wczytana ilość liczb wynosi: {0} ", mzIlosc);

                if (mzIlosc == 0)
                    Console.WriteLine("\n\tLiczba zero jest nieprawidłowa");

            } while (mzIlosc == 0);

            Console.WriteLine("\n\tKtórego rzędu ma być średnia potęgowa?");
            int mzRzed = Convert.ToInt32(Console.ReadLine());

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Wczytany rzęd wynosi: {0} ", mzRzed);

            Console.WriteLine("\n\tPodaj liczbę i naciśnij enter żeby podać następną: ");

            double mzSum = 0;
            for (int i = 0; i < mzIlosc; i++)
            {
                mzSum += Math.Pow(Convert.ToDouble(Console.ReadLine()), mzRzed);
            }

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Suma liczb do {0}-tej potęgi wynosi: {1} ", mzRzed, mzSum);

            double mzRes = mzSum / mzIlosc;

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Wynnik dzielenia pod pierwiastkiem wynosi: {0} ", mzRes);

            return Math.Pow(mzRes, (1.0 / mzRzed));
        }

        static void mzKonwersja()
        {
            ushort mzLiczba;

            do
            {
                Console.WriteLine("\n\tPodaj liczbe w systemie dziesiętnym od 0 do 65535: ");
                while (!ushort.TryParse(Console.ReadLine(), out mzLiczba))
                {
                    Console.WriteLine("\n\tW zapisie liczby wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj liczbę ponownie: ");
                }

            } while (mzLiczba == 0);

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Wczytana liczba wynosi: {0} ", mzLiczba);

            ushort mzPSL;

            do
            {
                Console.WriteLine("\n\tPodaj podstawę systemu liczbowego poprawnie (2, 8 lub 16): ");
                while (!ushort.TryParse(Console.ReadLine(), out mzPSL))
                {
                    Console.WriteLine("\n\tW zapisie PSL wystąpił niedozwolony znak!");
                    Console.Write("\n\tPodaj PSL ponownie: ");
                }

            } while (mzPSL != 2 && mzPSL != 8 && mzPSL != 16);

            if (mzRealizacjaZeŚledzeniem)
                Console.WriteLine("\n\t\t TRACE: Wczytana podstawa systemu liczbowego wynosi: {0} ", mzPSL);

            int[] mzTab = new int[32];
            int i = 0;

            switch (mzPSL)
            {
                case 2:

                    while (mzLiczba > 0) 
                    {
                        mzTab[i++] = mzLiczba % 2;
                        mzLiczba /= 2;
                    }

                    Console.WriteLine("\n\tLiczba w systemie dwójkowym wynosi: ");

                    for (int j = i - 1; j >= 0; j--)
                    {
                        Console.Write(mzTab[j]);
                    }

                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();

                    break;

                case 8:

                    while (mzLiczba > 0) 
                    {
                        mzTab[i++] = mzLiczba % 8;
                        mzLiczba /= 8;
                    }

                    Console.WriteLine("\n\tLiczba w systemie ósemkowym wynosi: ");

                    for (int j = i - 1; j >= 0; j--)
                    {
                        Console.Write(mzTab[j]);
                    }

                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();

                    break;

                case 16:

                    var mzDict = new Dictionary<int, string>
                            {
                                { 10, "A" },
                                { 11, "B" },
                                { 12, "C" },
                                { 13, "D" },
                                { 14, "E" },
                                { 15, "F" }
                            };

                    string[] mzString = new string[32];

                    while (mzLiczba > 0) 
                    {
                        mzString[i++] = Convert.ToString(mzLiczba % 16);

                        int mzInt = Convert.ToInt32(mzString[i - 1]);

                        if (mzInt >= 10)
                        {
                            mzString[i - 1] = mzDict[mzInt];
                        }

                        mzLiczba /= 16;
                    }

                    Console.WriteLine("\n\tLiczba w systemie szesnastkowym wynosi: ");

                    for (int j = i - 1; j >= 0; j--)
                    {
                        Console.Write(mzString[j]);
                    }

                    Console.WriteLine("\n\tNaciśnij dowolny klawisz...");
                    Console.ReadKey();

                    break;
            }
        }
    }
}
