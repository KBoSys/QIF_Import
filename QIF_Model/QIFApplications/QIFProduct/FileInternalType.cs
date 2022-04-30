﻿/*! \file FileInternalType.cs
    \brief The FileInternalType defines information identifying a file in QIF format.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The FileInternalType defines information identifying a file in QIF format./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FileInternalType
	{
        /// <remarks The Name element is the name of the file./>
        [XmlElement]
        public string Name { get; set; }

        /// <remarks The optional Version element gives version information about the file./>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.VersionType Version { get; set; }
    }
}
