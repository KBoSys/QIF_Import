using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace QIF_Import_Console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			XmlSchemaSet schemas = new XmlSchemaSet();
			schemas.Add("", @"F:\Projects\KBoSys\Projects\Metrology\QIF_Import_Console\xsd\QIFApplications\QIFDocument.xsd");

			XDocument doc = XDocument.Load(@"F:\Projects\KBoSys\Projects\Metrology\Examples\QIF\QIF_PLAN_SAMPLE.QIF");

			Console.WriteLine("Attempting to validate");
			bool errors = false;
			doc.Validate(schemas, (o, e) =>
			{
				Console.WriteLine("{0}", e.Message);
				errors = true;
			});
			Console.WriteLine("custOrdDoc {0}", errors ? "did not validate" : "validated");

			Console.WriteLine();
		}
	}
}
