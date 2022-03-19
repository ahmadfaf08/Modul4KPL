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
            Console.WriteLine("\n");
            SimpleDataBase<double> allData = new SimpleDataBase<double>();

            allData.AddNewData(13);

            allData.AddNewData(02);

            allData.AddNewData(20);

            allData.PrintAllData();
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

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(" Data " + (i + 1) + " berisi : " + storedData[i] + ", Yang disimpan pada waktu UCT: " + inputDates[i] + " AM\n");
            }
        }

    }

}