/*! \file PartAssemblyHeaderType.cs
    \brief The PartAssemblyHeaderType defines information about the creation of
        the file containing the CAD model and global parameters of the model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The PartAssemblyHeaderType defines information about the creation of the file containing the CAD model and global parameters of the model./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartAssemblyHeaderType
	{
        /// <remarks The optional Name element is the name of the model./>
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }

        /// <remarks The optional File element specifies the QIF file used in the model./>
        [XmlElement(IsNullable = true)]
        public FileInternalType File { get; set; }

        /// <remarks The optional Application element is information about the
        /// software application wherein the model was most recently edited./>
        [XmlElement(IsNullable = true)]
        public ApplicationType Application { get; set; }

        /// <remarks The optional Author element is the author who created this file./>
        [XmlElement(IsNullable = true)]
        public AuthorType Author { get; set; }

        /// <remarks The optional ApplicationSource element is the name of the
        /// software application wherein the model was created./>
        [XmlElement(IsNullable = true)]
        public ApplicationType ApplicationSource { get; set; }

        /// <remarks The optional Description element is a description of the model./>
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
    }
}
