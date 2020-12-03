
#include <iostream>
#include <cstdlib>

using namespace std;
int ile, suma = 0, tablica[100000], ile2;

int main()
{
    cin >> ile2;
    for (int j = 1; j <= ile2; j++)
    {
        cin >> ile;
        for (int k = 0; k < ile; k++)
        {
            cin >> tablica[k];
        }
        for (int i = 0; i < ile; i++)
        {
            suma += tablica[i];
        }
        cout << suma << endl;
        suma = 0;


    }
    return 0;
}