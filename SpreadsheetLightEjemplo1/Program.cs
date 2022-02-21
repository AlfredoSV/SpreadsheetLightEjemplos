using SpreadsheetLight;
using System;
using System.Data;

namespace SpreadsheetLightEjemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "hola.xlsx";

            var sp = new SLDocument();



            var style = new SLStyle();
            style.Font.FontSize = 15;
            sp.SetColumnWidth(1, 30);
            sp.SetColumnWidth(2, 30);
            sp.SetColumnStyle(1, style);
            sp.SetColumnStyle(2, style);
            var dt = new DataTable();

            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Fecha de Nacimiento", typeof(string));

            dt.Rows.Add(new Object[] { "Alfredo", DateTime.Now.ToString() });

            sp.ImportDataTable(1, 1, dt, true);

            sp.SaveAs(path);

        }
    }
}
