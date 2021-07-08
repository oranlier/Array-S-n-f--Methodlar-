using System;

namespace Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("**********Sırasız dizi**************");
            foreach (var item in sayidizisi)
                Console.WriteLine(item);
            
            Console.WriteLine("**********Sıralı dizi**************");
            Array.Sort(sayidizisi);
            foreach (var item in sayidizisi)
                Console.WriteLine(item);

            Console.WriteLine("**********Array Clear**************");
            Array.Clear(sayidizisi,2,2);
            foreach (var item in sayidizisi)
                Console.WriteLine(item);

            Console.WriteLine("**********Reverse**************");
            Array.Reverse(sayidizisi);
            foreach (var item in sayidizisi)
                Console.WriteLine(item);
            
            Console.WriteLine("**********IndexOf**************");
            Console.WriteLine(Array.IndexOf(sayidizisi,23));

            Console.WriteLine("**********Resize**************");
            Array.Resize<int>(ref sayidizisi,9);
            sayidizisi[8] = 99;
            foreach (var item in sayidizisi)
                Console.WriteLine(item);

        }
    }
}
