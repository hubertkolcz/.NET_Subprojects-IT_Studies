# .NET_Subprojects_Studies
 
## (Pętle, tablice) - 1
### Projekt 1
Napisz program wyświetlający w porządku malejącym liczby od 100 do 1 podzielne przez trzy, ale niepodzielne przez 2. Zadanie wykonaj za pomocą trzech rodzajów pętli (for, while, do..while)
### Projekt 2 
1. Utwórz tablicę liczb typu int zaprezentowaną poniżej. Wypełnij kolejne komórki wartościami malejącymi od 10 do 1. Do utworzenia tablicy i wypełnienia jej danymi wykorzystaj pętlę typu for.
2. Utwórz tablicę dwuwymiarową, w której liczba komórek w kolejnych rzędach będzie równa dziesięciu kolejnym wartościom ciągu Fibonacciego, poczynając od elementu o wartości 1 (1, 1, 2, 3, 5 itd.). Wartość każdej komórki powinna być jej numerem w danym wierszu w kolejności malejącej (czyli dla wiersza o długości pięciu komórek kolejne wartości to 5, 4, 3, 2, 1). Zawartość tablicy wyświetl na ekranie

## (Przeciążanie konstruktorów) – 2
### Projekt 3
Napisz klasę zawierającą dwa pola: pierwsze typu double i drugie typu char(np. liczba i znak). Dopisz pięć przeciążonych konstruktorów: pierwszy przyjmujący jeden argument typu double, drugi przyjmujący jeden argument typu char, trzeci przyjmujący dwa argumenty — pierwszy typu double, drugi typu char — i czwarty przyjmujący również dwa argumenty typu typu double. Czwarty konstruktor niech liczy NWD Euklidesa. Piąty konstruktor (przyjmuje tablice int) Sito Erastotenesa – liczby pierwsze
### Projekt 4
Napisz klasę Kwadrat przechowującą informację o kwadracie. Klasa powinna mieć konstruktory (dowolne) umożliwiające przekazanie parametrów o następujących znaczeniach:
a) współrzędne lewego górnego rogu oraz prawego dolnego,
b) współrzędne lewego górnego rogu oraz długość boku,
c) współrzędne środka i długość boku,
d) współrzędne środka i pole
### Projekt 5
Do klasy Kwadrat z ćwiczenia poprzedniego dopisz metodę Main testującą działanie wszystkich konstruktorów (wypisać to co zostało wpisane konstruktorem)

## (Wyjątki) – 3
### Projekt 6 
Napisz przykładowy program, w którym zostaną wygenerowane dwa różne wyjątki (ArithmeticException, Exception). Wyświetl na ekranie systemowe komunikaty, (JAK TO ZROBIĆ)?
### Projekt 7
Napisz program, który pobierze od użytkownika tablice 10 liczb całkowitych. Przekaz tablicę do konstruktora, który posortuje tablicę metodą bąbelkową, i zwróci tablicę do metody main(). Wykorzystaj konstrukcję try – catch (np. przekroczenie zakresu tablicy).

## (Standardowe wejście i wyjście) – 4
### Projekt 8
Napisz program, który będzie realizował tzw. szyfr Cezara (modyfikacja o 1) działający na znakach wprowadzanych bezpośrednio z klawiatury. Naciśnięcie klawisza odpowiadającego literze a ma powodować pojawianie się litery o podany przez użytkownika klucz. Możesz ograniczyć się do przekodowywania tylko małych liter z alfabetu łacińskiego. (q lub escape kończy działanie)
### Projekt 9
Napisz program rozwiązujący równania kwadratowe, w którym parametry A, B i C będą wprowadzane przez użytkownika z klawiatury.
### Projekt 10
Napisz program, który umożliwi użytkownikowi wprowadzenie wiersza tekstu zawierającego liczby całkowite oddzielone znakiem separatora (np. przecinkiem), a więc przykładowego ciągu 1,5,24,8,150,2. Program powinien następnie wyświetlić liczy pierwsze (sito Eratostenesa)(wyszukiwanie liczby najmniejszej – dowolna metodą)

## Operacje na systemie plików – 5
### Projekt 11
Napisz  program, który w wierszu poleceń będzie przyjmował nazwę katalogu  oraz nazwę pliku, będzie tworzył katalog i plik, a w pliku umieści posortowaną tablicę 10-elementową liczb całkowitych algorytmem quicksort, wartości tablicy pobierze z pliku.
### Projekt 12
Napisz program usuwający plik lub katalog o nazwie przekazanej z wiersza poleceń. Program powinien zapytać użytkownika o potwierdzenie chęci wykonania tej operacji.
### Projekt 13
Napisz program wyświetlający sumaryczną wielkość plików zawartych w katalogu o nazwie przekazanej z wiersza poleceń.
Operacje na systemie plików cz. 2 – 6
### Projekt 14
Napisz program, obliczający przyblizona wartość liczby PI z wykorzystaniem metody Monte Carlo, a następnie uzyskaną wartośc zapisac do dowolnego pliku.

## Modyfikatory dostępu – 7 
### Projekt 15
Napisz program wyszukujący palindromy w 10 ciągach znakowych (jeden pod drugim), znajdujących się w pliku. Odszukaj je wypisz na standardowe wyjście.  (wykorzystaj StreamReader). Zmienną do której wczytasz słowo, zadeklaruj z użyciem modyfikatora private. Pokaż, że dostęp jest możliwy z użyciem metody danej klasy, a nie  bezpośrednio z metody main() innej klasy.

## Klasy i metody abstrakcyjne – 8
### Projekt 16
Napisz klasę First zawierającą abstrakcyjną metodę f i wirtualną r, z tej klasy wyprowadź klasę potomną Second zawierającą ciała metod f i r na podstawie metod f i r klasy bazowej.
Rozkład na czynniki pierwsze (Fermata lub klasyczny)
RLE (Run Length Encoding) (dokonać kompresji Unnniiiiwwerrrsyyyttttteeeeet Gddddaansssskkii

## Interfejsy – 9 
### Projekt 17
Napisz klasę która dziedziczy z interfejsu (który zawiera opis właściwości dwóch liczb oraz definicję metody NWW). Następnie w nowej klasie (metodzie main()) zaimplementuj algorytm NWW.
NWW(a,b)=a⋅b/NWD(a,b)

## Klasy zagnieżdżone – 10
### Projekt 18
Napisz implementację algorytmu Newtona-Raphsona w odpowiedniej metodzie  klasy  zagnieżdżonej, a następnie w innej klasie wywołaj, tą metodę klasy zagnieżdżonej. Oblicz √3, √5, √37

## Typy uogólnione/Typy generyczne – 11
### Projekt 19
Napisz program który wykorzystuje sortowanie przez  wstawianie. Sortowanie 10 elementowej tablicy, a deklarowane na początku 9 elementów. Dynamiczne zwiększenie tablicy.  

## Delegacje – 12
### Projekt 20
Dane w tabeli przedstawiają zużycie prądu w gospodarstwie domowym w zależności od liczby zamieszkałych w nim osób:
Zużycie prądu 90 160 280 450 550
Liczba mieszkańców 1 2 3 4 5
Dokonać analizy korelacji.
Utworzyć klasę Pearson, w której zadeklarować 2 zmienne prywatne typu  tablicowego, w których należy umieścić dane z treści zadania,  a następnie metody mające dostęp do tablic obliczające współczynnik korelacji Pearsona. Wywołanie  z programu głównego.
Wykorzystaj typy uogólnione

## Kolekcje, listy – 13
### Projekt 21
Posortuj listę 20 elementową liczb całkowitych z zakresu od 1 do 50. Wykorzystaj metodę sortowania przez zliczanie oraz listy ArrayList.
