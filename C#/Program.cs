using System;

namespace Lab_8
{
    class rating
    {
        public int[] mas = new int[10];
        public static float average_rating;
        public void input()
        {
            for (int i = 0; i < 10; i++)
            {
                mas[i] = i + 1;
            }
        }
        public static void print_average_rating()
        {
            System.Console.WriteLine("average rating = " + rating.average_rating);
        }
        public void print()
        {
            System.Console.Write( "rating: ");
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(mas[i] + " ");
            }
            System.Console.WriteLine();
        }
    };

    internal class Program
    {

        static void Main(string[] args)
        {
            rating student = new rating();
            student.input();
            for (int i = 0; i < 10; i++) { rating.average_rating += student.mas[i]; }
            rating.average_rating /= 10;
            student.print();
            rating.print_average_rating();
        }
    }
}
