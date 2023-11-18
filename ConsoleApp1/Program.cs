class Zad
{
    static void Main(string[] args)
    {
        int rozmiar;
        Console.WriteLine("Podaj liczbę elementów tablicy: ");
        rozmiar = int.Parse(Console.ReadLine());
        int[] tablica = new int[rozmiar];
        for (int i=0;i<tablica.Length;i++)
        {
            Console.WriteLine("Podaj liczbę: ");
            tablica[i] = int.Parse(Console.ReadLine());
        }
        for (int i=0;i<tablica.Length;i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.ReadKey();
    }
}