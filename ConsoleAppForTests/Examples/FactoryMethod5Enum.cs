using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class FactoryMethod5Enum
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

        public enum ReportType
        {
            Pdf,
            Excel,
            Word
        }

        public interface IReportFactory
        {
            IReport CreateReport(ReportType reportType);
        }

        public class PdfReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport(ReportType reportType)
            {
                return new PdfReport();
            }
        }
        public class ExcelReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport(ReportType reportType)
            {
                return new ExcelReport();
            }
        }
        public class WordReportFactory : IReportFactory
        {
            IReport IReportFactory.CreateReport(ReportType reportType)
            {
                return new WordReport();
            }
        }

        public static void Run()
        {
            IReportFactory factory=new PdfReportFactory();
            IReport report=factory.CreateReport(ReportType.Pdf);
            report.Generate();

            factory=new ExcelReportFactory();
            report=factory.CreateReport(ReportType.Excel);
            report.Generate();

            factory=new WordReportFactory();
            report = factory.CreateReport(ReportType.Word);
            report.Generate();
        }
    }
}
