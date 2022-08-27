/*! \file FileUnits.cs
    \brief Defines the units used in the file

        The FileUnitsType defines the units for quantities found in an
        instance file. If an instance file includes a FileUnits element,
        and any quantity of a given unit type appears in the instance file,
        the corresponding data type must appear in the PrimaryUnits,
        OtherUnits or UserDefinedUnits of the FileUnitsType. Common XML
        file checkers will signal an error if this rule is violated.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Units
{
    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FileUnitsType
    {
        public FileUnitsType() { }

        #region Properties
        /// <remarks> The PrimaryUnits element describes the primary set of units.</remarks>
        [System.Xml.Serialization.XmlElement]
        public PrimaryUnitsType PrimaryUnits { get; set; }

        /// <remarks> The optional OtherUnits element describes a set of other units predefined by QIF types.</remarks>
        [System.Xml.Serialization.XmlElement]
        public OtherUnitsType[] OtherUnits { get; set; }

        /// <remarks> The optional UserDefinedUnits element describes a set of user-defined units.</remarks>
        [System.Xml.Serialization.XmlElement]
        public UserDefinedUnitsType[] UserDefinedUnits { get; set; }
        #endregion
    }
}
