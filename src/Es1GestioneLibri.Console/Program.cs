
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();
        Console.WriteLine("Inserisci il numero di libri acquistati");
        int numeroLibri = int.Parse(Console.ReadLine());
        if(numeroLibri<=0){
            Console.WriteLine("Numero di libri non valido");
            return;
        }
        Console.WriteLine("Inserisci il prezzo del singolo libro");
        int prezzoLibro = int.Parse(Console.ReadLine());
        if(prezzoLibro <= 0){
                Console.WriteLine("Prezzo del libro non valido");
                return;
        }
        Console.WriteLine("Il Cliente e' uno studente? (si/no)");
        string Risposta = Console.ReadLine();
        if (Risposta != "si" && Risposta != "no")
        {
            Console.WriteLine("Valore non valido");
            return;
        }
        else if (Risposta == "si") {
            bool isStudente = true;
        }
        else {
            bool isStudente = false;
        }
        Console.WriteLine("Tipo di consegna? (spedizione/ritiro)");
        string tipoConsegna = Console.ReadLine();
        if(tipoConsegna != "spedizione" && tipoConsegna != "ritiro"){
            Console.WriteLine("Tipo di consegna non valido");
            return;
        }

        int costoSpedizione = 5;

        int costoTotale = numeroLibri * prezzoLibro;

        if (tipoConsegna == "spedizione")
        {
            costoTotale += costoSpedizione;
        }
        else{
            costoSpedizione = 0;
        }

        Console.WriteLine($"L'ordine del cliente {nomeCliente} e' composto da {numeroLibri} libri, per un costo unitario di {prezzoLibro} euro con tipo di consegna: {tipoConsegna} che costa {costoSpedizione} euro.");
        Console.WriteLine($"Il costo totale dell'ordine e' di {costoTotale} euro.");

        if (numeroLibri < 5) {
            Console.WriteLine("");
            Console.WriteLine("Importo totale inferiore a 5 libri, ordine non valido");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Ordine valido");
        }
    }
}
