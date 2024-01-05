// un programa en el que realizaras un array que contenga 3 valores los cuales luego van a ser utilizados para sacar el promedio de estos valores, luego que diga la raiz de dicho promedio, utilizando funciones.

class program
{
    static int [] numero = new int[3];
    
    static void Main(string[] args)
    {
        num();
        
    }

    static void num()
    {
        int promedio;
        double raiz;

        Console.WriteLine("Ingrese 3 valores diferentes");
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            numero[i] = Convert.ToInt32(Console.ReadLine());
        }

        promedio = numero[0] + numero[1] + numero[2]/3;
        Console.WriteLine("El promedio de los valores es: ");
        Console.WriteLine(promedio);

        raiz = Math.Sqrt(promedio);
        Console.WriteLine("la raiz del promedio dado es:");
        Console.WriteLine(raiz);

    }

   
    


}



