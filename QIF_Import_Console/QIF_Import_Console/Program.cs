using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;

namespace QIF_Import_Console
{
	public class QIFSerializer
	{
		public QIFDocumentType CreateQIFDocument(string xmlFileName)
		{
			Console.WriteLine("Reading with Stream");

			// Create an instance of the XmlSerializer.
			XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

			// Declare an object variable of the type to be deserialized.
			QIFDocumentType qifDoc = null;

			using (Stream reader = new FileStream(xmlFileName, FileMode.Open))
			{
				// Call the Deserialize method to restore the object's state.
				qifDoc = (QIFDocumentType)serializer.Deserialize(reader);
			}

			return qifDoc;
		}

		public void Write(QIFDocumentType doc, string xmlFileName)
		{
			// Create an instance of the XmlSerializer.
			XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

			using (Stream writer = new FileStream(xmlFileName, FileMode.Create))
			{
				// Call the Deserialize method to restore the object's state.
				serializer.Serialize(writer, doc);
			}
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("No arguments!");
				return;
			}

			string filename = args[0];

			QIFSerializer qifImport = new QIFSerializer();
			QIFDocumentType document = qifImport.CreateQIFDocument(filename);

			if (document != null)
			{
				Console.WriteLine(document.QPId);
			}

			qifImport.Write(document, @"F:\temp\test.qif");
		}

		static void Validate()
		{
			XmlSchemaSet schemas = new XmlSchemaSet();
			schemas.Add("", @"F:\Projects\KBoSys\Projects\Metrology\QIF_Import_Console\xsd\QIFApplications\QIFDocument.xsd");

			XDocument doc = XDocument.Load(@"F:/Projects/KBoSys/Projects/Metrology/Examples/QIF/QIF_PLAN_SAMPLE.QIF");

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
