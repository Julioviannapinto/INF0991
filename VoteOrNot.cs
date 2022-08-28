internal class Program
{
    private static void Main(string[] args)
    { 
        string ano;
        ano = Console.ReadLine();
        int anoInt = Convert.ToInt16(ano);
        if(anoInt > 15) {
            Console.WriteLine("Pode votar");
        } else {
            Console.WriteLine("Nao Pode votar");
        }
    
    }

}
