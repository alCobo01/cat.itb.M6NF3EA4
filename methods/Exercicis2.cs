using cat.itb.M6NF3EA3.cruds;

namespace cat.itb.M6NF3EA3.methods
{
    public static class Exercicis2
    {
        public static void A()
        {
            Console.WriteLine("A) Mostra el nombre de països on es parla Anglès");
            var numPaisos = CountryCRUD.GetEnglishCountriesCount();

            Console.WriteLine($"Es parla anglès a {numPaisos} països!");
        }

        public static void B()
        {
            Console.WriteLine("B) Mostra la regió amb més països");
            CountryCRUD.GetMostCountriesRegion();
        }

        public static void C()
        {
            Console.WriteLine("C) Mostra el nombre de països que conté cada subregió");
            CountryCRUD.GetCountriesPerSubregion();
        }

        public static void D()
        {
            Console.WriteLine("D) Mostra el país on es parlen més idiomes");
            CountryCRUD.GetMoreLanguagesCountry();
        }

        public static void E()
        {
            Console.WriteLine("E) Mostra el nombre de vegades que apareix cada score");
            RestaurantCRUD.ShowNumberOfScores();
        }

        public static void F()
        {
            Console.WriteLine("F) Mostra els codi postals de cada barri");
            RestaurantCRUD.ShowPostalCodesByBorough();
        }

        public static void G()
        {
            Console.WriteLine("G) Mostra quants restaurants hi ha per cuina");
            RestaurantCRUD.ShowRestaurantsPerCuisine();
        }

        public static void H()
        {
            Console.WriteLine("H) Mostra el nombre de valoracions per restaurant");
            RestaurantCRUD.ShowNumberOfGradesPerRestaurant();

        }

        public static void I()
        {
            Console.WriteLine("I) Mostra els tipus de cuina per cada barri");
            RestaurantCRUD.ShowCuisinesByBorough();

        }

        public static void J()
        {
            Console.WriteLine("J) Mostra la valoracio mes alta per cada restaurant");
            RestaurantCRUD.ShowHighestScorePerRestaurant();

        }

        public static void K()
        {
            Console.WriteLine("K) Mostra el nombre de categories que te cada producte");
            ProductCRUD.DisplayCategoryCount();

        }

        public static void L()
        {
            Console.WriteLine("L) Mostra totes les categories dels productes sense que es repeteixin");
            ProductCRUD.GetAllCategories();
        }
    }
}
