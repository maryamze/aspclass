using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the count of series");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=number;i++){
                for(int j=1;j<=number-i;j++){
                   Console.Write(" ");
                   Console.Write("\n");
                }
                for(int k=1;k<=i;k++){
                     Console.Write($"{k}");
                }
                for(int m=i-1;m>=1;m--){
                   Console.Write($"{m}");
                }

            }
           // Console.Write("\n");
        }
    }
}
