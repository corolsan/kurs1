using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Vvedite chto vi hotite");
            Console.WriteLine("1 - dobavit");
            Console.WriteLine("2 - ydalenie");
            Console.WriteLine("3 - vivesti massiv");
            Console.WriteLine("4 - zadanie");

            Presentor zadanie = new Presentor();

            String o = "0";

            while( o != "net")
            {
                Console.WriteLine("Hotite li vi prodolgit?(da or net)");

                o = Console.ReadLine();

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        zadanie.Vvod();
                        break;
                    case 2:
                        Console.WriteLine("kakoi vi hotite element udalit");
                        int i = Convert.ToInt32(Console.ReadLine());
                        zadanie.Udal(i);
                        break;
                    case 3:
                        zadanie.GetInfo();
                        break;
                    case 4:
                        zadanie.Variant();
                        break;
                    default:
                        Console.WriteLine("ohibka, vi visli za predel vozmoznostey programmi");
                        break;
                }
            }
            Console.ReadKey();//выход
        }
    }
    class Presentor
    {
        public int[] arr = new int[8];
        public int k;
        public Random rand = new Random();
        public Presentor() // собирает массив случайных чисел 
        {
            Console.WriteLine("scolko vi hotite elementov ");
            k = Convert.ToInt32(Console.ReadLine());
            arr = new int[k];
            for (int q = 0; q < k; q++)
                arr[q] = rand.Next(0, 10);
        }
        public void GetInfo()// просто выводит массив
        {
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"e {j} element {arr[j]}");
            }
        }
        public void Vvod()// добавляет элемент в массив 
        {
            int[] brr = new int[k + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                brr[i] = arr[i];
            }
            arr = new int[k + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = brr[i];
            }
            Console.WriteLine($"Vvedite { k + 1} element");
            arr[k] = Convert.ToInt32(Console.ReadLine());
            k++;

        }
        public void Udal(int n)// удаляет выбраный элемент из массива
        {
            int[] brr = new int[k - 1];

            for (int i = 0; i < n; i++)
            {
                brr[i] = arr[i];
            }

            for (int i = (n+1); i < brr.Length; i++)
            {
                brr[i] = arr[i];
            }

            arr = new int[k - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = brr[i];
            }

            k--;

        }
        public void Variant()//сортирует по возрастанию четные элементы
        {
            for (int i = 2; i < arr.Length - 1; i += 2)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                   
                    if (j % 2 == 0 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }


        }



    }

}
