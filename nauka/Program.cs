namespace nauka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, wyb;
            Console.WriteLine("KALKULATOR");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("-----------------------");
            wyb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (wyb)
            {
                case 1:
                    Console.WriteLine("Wynik dodawania: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Wynik odejmowania: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Wynik mnożenia: " + (a * b));
                    break;
                case 4:
                    if (a == 0 || b == 0)
                    {
                        Console.WriteLine("NIE DZIELIMY PRZEZ 0!");
                    }
                    else
                    {
                        Console.WriteLine("Wynik dzielenia: " + (a / b));
                    }
                    break;
            }
        }
    }
}