using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302200084
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 20));

        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T inputsatu, T inputdua, T inputtiga)
        {
            dynamic jumlah1 = inputsatu;
            dynamic jumlah2 = inputdua;
            dynamic jumlah3 = inputtiga;

            return jumlah1 + jumlah2 + jumlah3;

        }
    }

}