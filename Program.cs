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

            Ordina(pesi, età);
            for (int j = 0; j < dimensione; j++)
                Console.WriteLine($"età:{età[j]} - peso:{pesi[j]}");

            int count = 0;
            for (int i = 0; i < pesi.Length; i++)
            {
                bool trovato = false;

                for (int j = 0; j < i; j++)
                {
                    if (pesi[j] == pesi[i])
                    {
                        trovato = true;
                        break;
                    }
                }
                if (!trovato)              
                    count++;
                
            }

            int[] frequenze = new int[count];
            double[] pesiDistinti = new double[count];

            CalcolaFrequenze(pesi, ref frequenze,  ref pesiDistinti);
            for (int j = 0; j < count; j++)
                Console.WriteLine($"peso:{pesiDistinti[j]} - frequenza:{frequenze[j]}");

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
                    max = pesi[i];

                if (pesi[i] < min)
                    min = pesi[i];

                sommaPesi += pesi[i];
            }
            media = sommaPesi / (double)pesi.Length;
        }
        static void Ordina(double[] pesi, int[] età)
        {
            for (int i = 0; i < età.Length - 1; i++)
            {
                for (int j = 0; j < età.Length - i - 1; j++)
                {
                    if (età[j] > età[j + 1])
                    {
                        int tempEtà = età[j];
                        età[j] = età[j + 1];
                        età[j + 1] = tempEtà;
                        double tempPeso = pesi[j];
                        pesi[j] = pesi[j + 1];
                        pesi[j + 1] = tempPeso;
                    }
                }
            }
        }

    static void CalcolaFrequenze(double[] pesi,ref int[] frequenze, ref double[] pesiDistinti)
    {
        Array.Sort(pesi);
        int indiceCorrente = 0;
        for (int i = 0; i < pesi.Length; i++)
        {
            double pesoCorrente = pesi[i];

            if (i > 0 && pesoCorrente != pesi[i - 1])   
                indiceCorrente++;
            
            pesiDistinti[indiceCorrente] = pesoCorrente;
            frequenze[indiceCorrente]++;
        }
    }

}




