using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID
{
    interface  IPdfFormatter
    {
        object ToPdf();
    }

    interface IExcelFormatter
    {
        object ToExcel();
    }

    class Report : IPdfFormatter, IExcelFormatter
    {
        public object ToExcel()
        {
            Console.WriteLine("Excel generated");
            return new object();
        }

        public object ToPdf()
        {
            var obj = ToExcel();
            Console.WriteLine("Pdf generated");
            return new object();
        }
    }

    class Poem : IPdfFormatter
    {
        public object ToPdf()
        {
            Console.WriteLine("Pdf generated");
            return new object();
        }
    }
}
