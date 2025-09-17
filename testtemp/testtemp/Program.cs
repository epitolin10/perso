using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

static void Main(string[] args)
{
    Console.WriteLine("Veuillez choisir l'unité de mesure (fahrenheit ou celsius)");
    string choix = Convert.ToString(Console.ReadLine());
    if ( choix == "fahrenheit")
    {
        Console.WriteLine("Quelle est la temperature en fahrenheit");
        double temperature = Convert.ToDouble(Console.ReadLine());
    }
    if ( choix == "celsius")
    {
        Console.WriteLine("Quelle est la temperature en celsius");
        double temperature = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Erreur de frappe");
    }
}