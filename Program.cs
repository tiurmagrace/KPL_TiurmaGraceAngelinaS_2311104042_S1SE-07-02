using System;

namespace tpmodul5_2311104042
{
    class Program
    {
        static void Main(string[] args)
        {
            // Panggil method generic dari class HaloGeneric
            HaloGeneric.SapaUser("Tiurma"); // Ganti dengan nama panggilan kamu

            // Panggil method dari class DataGeneric
            DataGeneric<string> data = new DataGeneric<string>("2311104042"); // Ganti dengan NIM kamu
            data.PrintData();

            Console.ReadLine(); // Supaya console nggak langsung nutup
        }
    }
}
