//hacer una funcion que duelva la suma de un arreglo o array.

class program
{
    static int [] num = new int[5];
    
    static void Main(string []args)
    { 
       Suma(); 
    }

    static void Suma()
    {
        Console.WriteLine("Ingrese los valores a sumar:");

        for (int i = 0; i < 5; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = num.Sum();

        Console.WriteLine("La suma de los valores es: " + suma);

        Console.ReadKey();
    }


}

