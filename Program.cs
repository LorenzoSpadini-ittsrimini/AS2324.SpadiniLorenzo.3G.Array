using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire il numero di persone:");
            int dimensione = int.Parse(Console.ReadLine());
            int[] età = new int[dimensione];
            double[] pesi = new double[dimensione];
            CaricaVettori(ref pesi, ref età);

        }
        static void CaricaVettori(ref double[] pesi, ref int[] età)
        {
            Random random = new Random();
            for (int i = 0; i < età.Length; i++)
            {
                età[i] = random.Next(18, 100);
                pesi[i] = random.Next(50, 101);
            }
        }

}




