using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod4
    {
        /*
         * Задача: Система отчетов
         * Разработайте систему отчетов, используя паттерн "Фабричный метод". В системе должны быть различные типы отчетов, такие как:
         * 
         * PDFReport
         * ExcelReport
         * WordReport
         */

        public interface IReport
        {
            void Generate();
        }

        public class PdfReport : IReport
        {
            public void Generate()
            {
                Console.WriteLine("Report PDF");
            }
        }

        public class ExcelReport : IReport
        {
            public void Generate()
            {
                Console.WriteLine("Report Excel");
            }
        }

        public class WordReport : IReport
        {
            public void Generate()
            {
                Console.WriteLine("Report Word");
            }
        }

        public interface IReportFactory
        {
            IReport CreateReport();
        }

        public class PdfReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport()
            {
                return new PdfReport();
            }
        }

        public class ExcelReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport()
            {
                return new ExcelReport();
            }
        }
        public class WordReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport()
            {
                return new WordReport();
            }
        }

        public static void Run()
        {
            IReportFactory reportFactory = new PdfReportFactory();
            IReport report = reportFactory.CreateReport();
            report.Generate();

            reportFactory=new ExcelReportFactory();
            report.Generate();
            report=reportFactory.CreateReport();
            report.Generate();

            reportFactory=new WordReportFactory();
            report= reportFactory.CreateReport();
            report.Generate();
        }
    }
}
