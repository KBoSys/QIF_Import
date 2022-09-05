/*! \file VersionHistoryType.cs
    \brief The VersionsHistoryType defines information about earlier versions of a QIF instance file.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The VersionsHistoryType defines information about earlier versions of a QIF instance file</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class VersionHistoryType : ArrayBaseType<VersionReferenceType>
    {
        /// <summary>
        /// Each EarlierVersion element contains information about one
        /// earlier version of the QIF instance file in which the VersionHistoryType appears.
        /// </summary>
        [XmlElement(ElementName = "EarlierVersion", Type = typeof(VersionReferenceType))]
        public VersionReferenceType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The VersionReferenceType defines information about a version of an	external QIF instance file.</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class VersionReferenceType : VersionBaseType
    {
        public VersionReferenceType() { }

        /// <remarks> The optional QPIdReference element uses a QPId to identify a version of a QIF instance file.</remarks>
        [XmlElement()]
        public Primitives.QPIdReferenceType QPIdReference { get; set; }
    }
}
