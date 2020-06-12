using System;

using Tugas_Lab_7.Interface;

namespace Tugas_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbtractionClass

            //Handphone handphone;

            //Console.WriteLine();
            //handphone = new Samsung();
            //handphone.Buatan();

            //Console.WriteLine();
            //handphone = new Vivo();
            //handphone.Buatan();

            //Console.WriteLine();
            //handphone = new Xiaomi();
            //handphone.Buatan();




            //Interface

            IHandphone handphone;
            ILokasi lokasi;

            handphone = new Oppo();
            handphone.Buatan();
            lokasi = new Oppo();
            lokasi.Kota();

            Console.WriteLine();
            handphone = new Vivo();
            handphone.Buatan();
            lokasi = new Vivo();
            lokasi.Kota();

            Console.WriteLine();
            handphone = new Xiaomi();
            handphone.Buatan();
            lokasi = new Xiaomi();
            lokasi.Kota();



            Console.ReadKey();
        }
    }
}
