package com.company;

public class Main {

    public static void main(String[] args) {
        rating student = new rating();
        student.input();
        for (int i = 0; i < 10; i++) { rating.average_rating += student.mas[i]; }
        rating.average_rating /= 10;
        student.print();
        rating.print_average_rating();
    }
}
