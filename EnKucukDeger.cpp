#include <iostream>
using namespace std;

int min_(int x[], int size) {
    int enKucuk = x[0];

    for (int i = 1; i < size; ++i) {
        if (x[i] < enKucuk) {
            enKucuk = x[i];
        }
    }

    return enKucuk;
}

int main() {
    int s1, s2, s3;

    cout << "1. sayı : ";
    cin >> s1;

    cout << "2. sayı : ";
    cin >> s2;

    cout << "3. sayı : ";
    cin >> s3;

    int liste[] = {s1, s2, s3};
    int size = sizeof(liste) / sizeof(liste[0]);

    int result = min_(liste, size);
    cout << "En küçük sayı: " << result << std::endl;

    return 0;
}
