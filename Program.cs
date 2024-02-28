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

            double min = pesi[0];
            double max = pesi[0];
            double media = 0.0;
            Statistiche(ref pesi, ref media, ref min, ref max);
            Console.WriteLine($"Il peso minimo estratto è: {min}\nIl peso massimo estratto è: {max}\nLa media è {media}");
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

        static void Statistiche(ref double[] pesi, ref double media, ref double min, ref double max)
        {
            double sommaPesi = 0.0;
            for (int i = 0; i < pesi.Length; i++)
            {
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
                sommaPesi += pesi[i];
            }
            media = sommaPesi / (double)pesi.Length;
        }

}




