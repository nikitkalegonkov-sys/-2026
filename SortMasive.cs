using System;

class Program
{
    static void Main()
    {
        // Тестовый массив
        int[] Masive = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("start Masive:");
        PrintMasive(Masive);
        
        // Сортировка выбором
        int[] selectionMasive = (int[])Masive.Clone();
        Sort(selectionMasive);
        Console.WriteLine("\nSort Masive:");
        PrintMasive(selectionMasive);
        
        
    
    }
    
    static void PrintMasive(int[] Masive)
    {
        Console.Write("[");
        for (int i = 0; i < Masive.Length; i++)
        {
            Console.Write(Masive[i]);
            if (i < Masive.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
    
    static bool MasiveEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
    
    public static void Sort(int[] Masive)
{
    int n = Masive.Length;
    
    for (int i = 0; i < n - 1; i++)
    {
      
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (Masive[j] > Masive[maxIndex]) 
            {
                maxIndex = j;
            }
        }
        
        if (maxIndex != i)
        {
            int temp = Masive[i];
            Masive[i] = Masive[maxIndex];
            Masive[maxIndex] = temp;
        }
    }
}
}