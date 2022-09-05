/*! \file ExternalFileReferenceType.cs
	\brief Defines an external file reference

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The FileSpecEnumType enumerates values that describe common file formats.
    /// The values are common file name suffixes that indicate file type.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CommonFileSpecEnumType
    {
        /// <remarks></remarks>
        AVI,

        /// <remarks></remarks>
        BMP,

        /// <remarks></remarks>
        DOC,

        /// <remarks></remarks>
        DOCX,

        /// <remarks></remarks>
        DXF,

        /// <remarks></remarks>
        DTD,

        /// <remarks></remarks>
        GIF,

        /// <remarks></remarks>
        GZIP,

        /// <remarks></remarks>
        HTML,

        /// <remarks></remarks>
        IGES,

        /// <remarks></remarks>
        JPEG,

        /// <remarks></remarks>
        JPG,

        /// <remarks></remarks>
        MOV,

        /// <remarks></remarks>
        MPEG,

        /// <remarks></remarks>
        MPG,

        /// <remarks></remarks>
        PDF,

        /// <remarks></remarks>
        PNG,

        /// <remarks></remarks>
        PPM,

        /// <remarks></remarks>
        PPT,

        /// <remarks></remarks>
        PRT,

        /// <remarks></remarks>
        RAR,

        /// <remarks></remarks>
        RTF,

        /// <remarks></remarks>
        STL,

        /// <remarks></remarks>
        STEP,

        /// <remarks></remarks>
        STP,

        /// <remarks></remarks>
        TAR,

        /// <remarks></remarks>
        TIF,

        /// <remarks></remarks>
        TIFF,

        /// <remarks></remarks>
        TXT,

        /// <remarks></remarks>
        WMV,

        /// <remarks></remarks>
        XLS,

        /// <remarks></remarks>
        XLSX,

        /// <remarks></remarks>
        XML,

        /// <remarks></remarks>
        XSD,

        /// <remarks></remarks>
        X_T,

        /// <remarks></remarks>
        ZIP,
    }

    /// <summary>
    /// The ExternalFileReferenceType defines an external file reference
    /// including the file's location, type and description.
    /// </summary>
    public class ExternalFileReferenceType
    {
        /// <remarks> The URI element is a Uniform Resource Identifier for the
        /// information, which may be, for example, a file or a web site.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.UriType? URI { get; set; }

        /// <remarks> The FileSpec element describes the file type of the file found at the URI.</remarks>
        [XmlElement]
        public FileSpecType? FileSpec { get; set; }

        /// <remarks> The Description element is a description of the information in the file found at the URI.</remarks>
        [XmlElement]
        public string? Description { get; set; }
    }

    /// <remarks> The FileSpecType defines the format of a file.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FileSpecType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CommonFileSpecEnum", typeof(CommonFileSpecEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFileSpec", typeof(string))]
        public object? Item { get; set; }
    }

    /// <summary>
    /// The ExternalFileReferencesType defines a list of external file references.
    /// </summary>
    public class ExternalFileReferencesType : ArrayBaseType<ExternalFileReferenceType>
    {
        /// <remarks> Each ExternalQIFDocument element contains information about an external QIF document referenced by this QIF document.</remarks>
        [XmlElement("ExternalFileReference", Type = typeof(ExternalFileReferenceType))]
        public ExternalFileReferenceType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
