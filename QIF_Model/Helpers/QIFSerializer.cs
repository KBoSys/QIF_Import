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

        static bool hasError;
        static public bool Validate(string _filename, string _namespace, string _xsd)
        {
            // Create the XmlSchemaSet class.
            XmlSchemaSet sc = new XmlSchemaSet();

            // Add the schema to the collection.
            sc.Add(_namespace, _xsd);

            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = sc;
            settings.ValidationEventHandler += ValidationCallBack;

            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create(_filename, settings);

            hasError = false;
            // Parse the file.
            while (reader.Read()) ;

            return !hasError;
        }

        // Display any validation errors.
        private static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            Console.WriteLine($"Validation Error:\n   {e.Message}\n");
            hasError = true;
        }
    }
}
