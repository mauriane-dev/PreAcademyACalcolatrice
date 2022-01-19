// See https://aka.ms/new-console-template for more information
using PreAcademyACalcolatrice.Core;

Calculator c = new Calculator();

Console.WriteLine("Calcolatrice\n");

bool continua = true;
while (continua)
{
    Console.WriteLine("Inserisci il primo numero (a): ");
    double a = InserisciNumero();
    Console.WriteLine("Inserisci il secondo numero (b): ");
    double b = InserisciNumero();

    Console.WriteLine($"Hai inserito a={a} e b={b}");
    int scelta = Menu();
    AnalizzaScelta(scelta, a, b);

    Console.WriteLine("Vuoi continuare? Y se vuoi continuare, qualsiasi altro tasto per uscire.");
    if (Console.ReadLine() != "Y")
    {
        continua = false;
        Console.WriteLine("Arrivederci");
    }
}




void AnalizzaScelta(int scelta, double a, double b)
{
    switch (scelta)
    {
        case 1:
            double somma = c.SommaNumeri(a, b);
            Console.WriteLine($"La somma è: {somma}");
            break;

        case 2:
            double differenza;
            differenza = c.SottraiNumeri(a, b);
            Console.WriteLine($"La somma è: {differenza}");
            break;

        case 3:
            double prodotto = c.MoltiplicaNumeri(a, b);
            Console.WriteLine($"\nIl Prodotto è: {prodotto}");
            break;

        case 4:
            double? quoziente = c.DividiNumeri(a, b);
            if (quoziente == null)
            {
                Console.WriteLine("\nImpossibile");
                break;
            }
            Console.WriteLine($"\nIl Quoziente è: {quoziente}");
            break;

        case 5:
            bool esito=c.VerificaSeAMaggioreDiB(a, b);
            if (esito == true)
            {
                Console.WriteLine($"{a} è maggiore o uguale a {b}");
            }
            else
            {
                Console.WriteLine($"{a} è minore {b}");
            }
            break;
        default:
            Console.WriteLine("Scelta errata");
            break;
    }
}

static double InserisciNumero()
{
    double numero;
    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("InserisciNumero un numero valido");
    }
    return numero;
}

static int Menu()
{
    Console.WriteLine("Scegli 1 per fare la somma dei 2 numeri inseriti.");
    Console.WriteLine("Scegli 2 per fare la sottrazione tra i 2 numeri inseriti.");
    Console.WriteLine("Scegli 3 per fare la moltiplicazione tra 2 numeri inseriti.");
    Console.WriteLine("Scegli 4 per fare la divisione tra i 2 numeri inseriti.");
    Console.WriteLine("Scegli 5 per verificare se il primo numero è >= del secondo numero.");

    int scelta;
    do
    {
        Console.WriteLine("Scegli un'opzione:");
    } while (!int.TryParse(Console.ReadLine(), out scelta) /*|| scelta < 1 || scelta > 5*/);
    return scelta;
}
