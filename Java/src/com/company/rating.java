package com.company;

public class rating {
    int[] mas = new int[10];
    static float average_rating;
    void input()
    {
        for (int i = 0; i < 10; i++)
        {
            mas[i] = i + 1;
        }
    }
    static void print_average_rating()
    {
        System.out.println("average rating = " + rating.average_rating);
    }
    void print()
    {
        System.out.print( "rating: ");
        for (int i = 0; i < 10; i++)
        {
            System.out.print(mas[i] + " ");
        }
        System.out.println();
    }
}
