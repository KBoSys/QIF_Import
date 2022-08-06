/*! \file ExternalFileReferenceType.cs
	\brief Defines an external file reference

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The FileSpecEnumType enumerates values that describe common file formats.
    /// The values are common file name suffixes that indicate file type./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CommonFileSpecEnumType
    {
        /// <remarks/>
        AVI,

        /// <remarks/>
        BMP,

        /// <remarks/>
        DOC,

        /// <remarks/>
        DOCX,

        /// <remarks/>
        DXF,

        /// <remarks/>
        DTD,

        /// <remarks/>
        GIF,

        /// <remarks/>
        GZIP,

        /// <remarks/>
        HTML,

        /// <remarks/>
        IGES,

        /// <remarks/>
        JPEG,

        /// <remarks/>
        JPG,

        /// <remarks/>
        MOV,

        /// <remarks/>
        MPEG,

        /// <remarks/>
        MPG,

        /// <remarks/>
        PDF,

        /// <remarks/>
        PNG,

        /// <remarks/>
        PPM,

        /// <remarks/>
        PPT,

        /// <remarks/>
        PRT,

        /// <remarks/>
        RAR,

        /// <remarks/>
        RTF,

        /// <remarks/>
        STL,

        /// <remarks/>
        STEP,

        /// <remarks/>
        STP,

        /// <remarks/>
        TAR,

        /// <remarks/>
        TIF,

        /// <remarks/>
        TIFF,

        /// <remarks/>
        TXT,

        /// <remarks/>
        WMV,

        /// <remarks/>
        XLS,

        /// <remarks/>
        XLSX,

        /// <remarks/>
        XML,

        /// <remarks/>
        XSD,

        /// <remarks/>
        X_T,

        /// <remarks/>
        ZIP,
    }

    /// <summary>
    /// The ExternalFileReferenceType defines an external file reference
    /// including the file's location, type and description.
    /// </summary>
    public class ExternalFileReferenceType
    {
        /// <remarks The URI element is a Uniform Resource Identifier for the
        /// information, which may be, for example, a file or a web site./>
        [XmlElement]
        public QIFLibrary.Primitives.UriType URI { get; set; }

        /// <remarks The FileSpec element describes the file type of the file found at the URI./>
        [XmlElement]
        public FileSpecType FileSpec { get; set; }

        /// <remarks The Description element is a description of the information in the file found at the URI./>
        [XmlElement]
        public string Description { get; set; }
    }

    /// <remarks The FileSpecType defines the format of a file./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FileSpecType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommonFileSpecEnum", typeof(CommonFileSpecEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFileSpec", typeof(string))]
        public object Item { get; set; }
    }

    /// <summary>
    /// The ExternalFileReferencesType defines a list of external file references.
    /// </summary>
    public class ExternalFileReferencesType
    {
        /// <remarks Each ExternalQIFDocument element contains information about an external QIF document referenced by this QIF document./>
        [XmlElement("ExternalFileReference", Type = typeof(ExternalFileReferenceType))]
        public ExternalFileReferenceType[] ExternalFileReferences { get; set; }

        /// <remarks The required n attribute is the number of employees in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.ExternalFileReferences.Length;
            set { }
        }
    }
}
