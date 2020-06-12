using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_7.Interface
{
    class Oppo : IHandphone, ILokasi
    {
        public void Buatan()
        {
            Console.WriteLine("Hp Oppo adalah Hp Buatan dari Negara Tiongkok");
        }
        public void Kota()
        {
            Console.WriteLine("Hp Oppo adalah Hp Buatan dari Kota Dongguan");
        }
    }
}
