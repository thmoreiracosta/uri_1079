using System;
using System.Globalization;

namespace uri_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double a, b, c, mediap;
            

            N = int.Parse(Console.ReadLine());   
            //count = 0;         
            
            for (int i = 1; i <= N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                a = double.Parse(vet[0], CultureInfo.InvariantCulture);                  
                b = double.Parse(vet[1], CultureInfo.InvariantCulture);                  
                c = double.Parse(vet[2], CultureInfo.InvariantCulture);
                mediap = (a*2.0 + b*3.0 + c*5.0) / (2.0+3.0+5.0);
                Console.WriteLine(mediap.ToString("F1", CultureInfo.InvariantCulture));          
            }      
            
            
        }
    }
}
