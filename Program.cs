using cat.itb.M6NF3EA3.cruds;
using cat.itb.M6NF3EA3.methods;
using cat.itb.M6NF3EA3.models.books;

namespace cat.itb.M6NF3EA3
{
    public class Program
    {
        public static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Escriu el nombre de l'exericici que vols executar (per exemple, per fer l'exercici 1 escriu '1')");
                Console.WriteLine("Exercicis disponibles: 1-2");
                Console.WriteLine("Per sortir del programa escriu '3'");
                Console.Write("Quin exercici vols executar? ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Exercici1();
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        Console.Clear();
                        Exercici2();
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Fins la pròxima!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opció invàlida. Torna a intertar-ho \n ");
                        break;
                }
            }
        }

        private static void Exercici1()
        {
            CountryCRUD.LoadCollection();
            MyFunctions.PrintAndContinue();
            RestaurantCRUD.LoadCollection();
            MyFunctions.PrintAndContinue();
            ProductCRUD.LoadCollection();
            MyFunctions.PrintAndContinue();
        }

        private static void Exercici2()
        {
            Exercicis2.A();
            MyFunctions.PrintAndContinue();
            Exercicis2.B();
            MyFunctions.PrintAndContinue();
            Exercicis2.C();
            MyFunctions.PrintAndContinue();
            Exercicis2.D();
            MyFunctions.PrintAndContinue();
            Exercicis2.E();
            MyFunctions.PrintAndContinue();
            Exercicis2.F();
            MyFunctions.PrintAndContinue();
            Exercicis2.G();
            MyFunctions.PrintAndContinue();
            Exercicis2.H();
            MyFunctions.PrintAndContinue();
            Exercicis2.I();
            MyFunctions.PrintAndContinue();
            Exercicis2.J();
            MyFunctions.PrintAndContinue();
            Exercicis2.K();
            MyFunctions.PrintAndContinue();
            Exercicis2.L();
            MyFunctions.PrintAndContinue();
        }
   
    }
}
