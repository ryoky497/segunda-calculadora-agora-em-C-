namespace estudo;

class Program
{
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("digite o número 1: ");
        float numero = float.Parse(Console.ReadLine());
        Console.WriteLine("digite o número 2: ");
        float numero2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("digite +, -, * ou /");
        String operador = (Console.ReadLine());
        
        
        
        if (operador == "+")
        {
            Console.WriteLine(numero + numero2);
        }
        else if (operador == "*")
        {
            Console.WriteLine(numero * numero2);
        }
        else if (operador == "/")
        {
            if (numero2 == 0)
            {
                Console.WriteLine("impossivel dividir por 0");
            }
            else
            {
                Console.WriteLine(numero / numero2);
            }
        }
        else if (operador == "-")
        {
            Console.WriteLine(numero - numero2);
        }
        else
        {
            Console.WriteLine("impossível realizar   esta operação")
        }
        Console.WriteLine("deseja continuar?");
        string resposta = Console.ReadLine();
        if (resposta == "sim")
        {
            continue;
        }
        else if (resposta == "não")
        {
            break;
        }
        
      }  
    }
}