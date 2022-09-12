/*! \file X3DCadSerializer.cs
	\brief X3D Serializer

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using X3DCad.Model;

namespace X3DCad.Helpers
{
    /// <summary>
    /// X3D Serializer
    /// </summary>
    public static class X3DCadSerializer
    {
        /// <summary>
        /// Imports x3d file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static X3D? Import(string fileName)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(X3D));

            // Declare an object variable of the type to be deserialized.
            X3D? x3d = null;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.MaxCharactersFromEntities = 1024;
            
            using (XmlReader reader = XmlReader.Create(fileName, settings))
            {
                // Call the Deserialize method to restore the object's state.
                x3d = (X3D?)serializer.Deserialize(reader);
            }

            return x3d;
        }

        public static void Export(X3D x3d, string fileName)
        {
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Replace;
            ws.Indent = true;
            ws.OmitXmlDeclaration = false;
            ws.NewLineOnAttributes = false;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("x3d", "http://www.w3.org/2001/XMLSchema-instance");

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(X3D));

            using (XmlWriter wr = XmlWriter.Create(fileName, ws))
            {
                wr.WriteDocType("X3D", "ISO//Web3D//DTD X3D 3.2//EN", "https://www.web3d.org/specifications/x3d-3.2.dtd", null);
                serializer.Serialize(wr, x3d, ns);
            }
        }
    }
}
