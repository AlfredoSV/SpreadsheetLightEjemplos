using SpreadsheetLight;
using System;

namespace SpreadsheetLightEjemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "hola.xlsx";

            using (var sp = new SLDocument(path))
            {
                var wsn = sp.GetWorksheetStatistics();

                for (int i = 1; i <= wsn.EndRowIndex; i++)
                {
                    Console.WriteLine(sp.GetCellValueAsString(i, 1));
                }


            }



        }
    }
}
