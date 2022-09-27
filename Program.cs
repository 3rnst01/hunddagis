namespace TränaKlasser;

    internal class Program
    {
        internal static void Main(string[] args)    
        {
                HundDagis hund = new HundDagis();
            
                Console.WriteLine("Vänligen skriv hundens namn");
                hund.dogName = Console.ReadLine();

                Console.WriteLine("Vänligen skriv hundens ålder");
                hund.dogAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vänligen skriv hundens ras");
                hund.dogBreed = Console.ReadLine();

                Console.WriteLine("Vänligen skriv hundens ägare namn");
                hund.dogOwnerName = Console.ReadLine();
            
        }
    }

