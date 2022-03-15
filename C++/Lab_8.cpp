#include <iostream>

class rating {
public:
    int mas[10];
    static float average_rating;
    void input()
    {
        for (int i = 0; i < 10; i++) {
            mas[i] = i + 1;
        }
    }

    static void print_average_rating() {
        std::cout << "average rating = " << rating::average_rating << "\n";
    }

    void print() {
        std::cout << "rating: ";
        for (int i = 0; i < 10; i++) {
            std::cout << mas[i] << " ";
        }
        std::cout << "\n";
    }
};

float rating::average_rating = 0;

int main()
{
    rating student;
    student.input();
    for (int i = 0; i < 10; i++) { rating::average_rating += student.mas[i]; }
    rating::average_rating /= 10;
    student.print();
    rating::print_average_rating();
}

