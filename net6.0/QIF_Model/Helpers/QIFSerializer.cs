/*! \file QIFSerializer.cs
	\brief QIF Serializer

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
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
        public QIFDocumentType? CreateQIFDocument(string qifFileName)
		{
			// Create an instance of the XmlSerializer.
			XmlSerializer serializer = new XmlSerializer(typeof(QIFDocumentType));

			// Declare an object variable of the type to be deserialized.
			QIFDocumentType? qifDoc = null;

			using (Stream reader = new FileStream(qifFileName, FileMode.Open))
			{
				// Call the Deserialize method to restore the object's state.
				qifDoc = (QIFDocumentType?)serializer.Deserialize(reader);
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

        static uint errorsCount = 0;
        static List<string>? errorMessages;

        /// <summary>
        /// Validates XML file against XSD
        /// </summary>
        /// <param name="_filename">The file to be validated</param>
        /// <param name="_xsd">The XSD schema</param>
        /// <param name="maxErrCounts">Max error counts</param>
        /// <returns>A list of errors if any or empty list on success</returns>
        static public uint Validate(string _filename, string _xsd, uint maxErrCounts, out List<string> outErrorMessages)
        {
            errorMessages = new List<string>();
            errorsCount = 0;

            try
            {
                // Create the XmlSchemaSet class.
                XmlSchemaSet sc = new XmlSchemaSet();

                // Add the schema to the collection.
                sc.Add(null, _xsd);

                // Set the validation settings.
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(sc);
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += ValidationCallBack;

                // Create the XmlReader object.
                XmlReader reader = XmlReader.Create(_filename, settings);

                // Parse the file.
                while (errorMessages.Count < maxErrCounts && reader.Read()) ;
                reader.Close();
            }
            catch (Exception ex)
            {
                ++errorsCount;
                errorMessages.Add($"Exception: {ex.Message}");
            }

            outErrorMessages = errorMessages;
            errorMessages = null;

            return errorsCount;
        }

        // Display any validation errors.
        private static void ValidationCallBack(object? sender, ValidationEventArgs args)
        {
            errorMessages?.Add($"{args.Severity}: {args.Message}");
        
            // do not treat warning as error
            if (args.Severity == XmlSeverityType.Error)
                ++errorsCount;
        }
    }
}
