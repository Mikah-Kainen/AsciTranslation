#include <iostream>
#include <random>
#include <ctime>


int randInt(int min, int max)
{
    return std::rand() % (max - min) + min;
}

int main()
{
    std::srand(std::time(nullptr)); // seed

    for (int i =0; i < 100; i++)
    {
        std::cout << randInt(5,30) << "\n";
    }

    // print ou

    return 0;
}