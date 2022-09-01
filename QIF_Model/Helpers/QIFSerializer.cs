using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace QIF_Model.Helpers
{
	/// <summary>
	/// Helper class to read and write QIF files
	/// </summary>
	public class QIFSerializer
	{
        /// <summary>
        /// Import the QIF file into QIFDocument
        /// </summary>
        /// <param name="qifFileName">The imput file name</param>
        /// <returns></returns>
        public QIFDocumentType CreateQIFDocument(string qifFileName)
		{
			Console.WriteLine("Reading with Stream");

			// Create an instance of the XmlSerializer.
			XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

			// Declare an object variable of the type to be deserialized.
			QIFDocumentType qifDoc = null;

			using (Stream reader = new FileStream(qifFileName, FileMode.Open))
			{
				// Call the Deserialize method to restore the object's state.
				qifDoc = (QIFDocumentType)serializer.Deserialize(reader);
			}

			return qifDoc;
		}

        /// <summary>
        /// Export the QIFDocument to the specified output file
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="qifFileName"></param>
        public void Write(QIFDocumentType doc, string qifFileName)
		{
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Replace;
            ws.Indent = true;
            ws.OmitXmlDeclaration = false;
            ws.NewLineOnAttributes = false;

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

            using (XmlWriter wr = XmlWriter.Create(qifFileName, ws))
            {
                serializer.Serialize(wr, doc);
            }
        }

        static public bool Validate(string _filename, string _namespace, string _xsd)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(_namespace, _xsd);

            XDocument doc = XDocument.Load(_filename);

            bool valid = true;
            doc.Validate(schemas, (o, e) =>
            {
                Console.WriteLine(e.Message);
                valid = false;
            });
            Console.WriteLine("{0} {1}", _filename, valid ? "validated" : "did not validate");
            return valid;
        }

    }
}
