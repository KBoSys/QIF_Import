using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.Helpers
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
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Replace;
            ws.Indent = true;
            ws.OmitXmlDeclaration = false;
            ws.NewLineOnAttributes = false;

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

            using (XmlWriter wr = XmlWriter.Create(xmlFileName, ws))
            {
                serializer.Serialize(wr, doc);
            }
        }
	}
}
