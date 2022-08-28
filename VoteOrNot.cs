internal class Program
{
    private static void Main(string[] args)
    { 
        //Teste de Git
        string ano;
        ano = Console.ReadLine();
        int anoInt = Convert.ToInt16(ano);
        if(anoInt > 15 && < 18) {
            Console.WriteLine("Pode votar");
        
        } else if (anoInt >=18 ){   
            Console.WriteLine("Tem que voltar")
        }
            else {
            Console.WriteLine("Nao Pode votar");
        }
    
    }

}
