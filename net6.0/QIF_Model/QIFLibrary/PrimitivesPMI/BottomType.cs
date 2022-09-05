/*! \file BottomType.cs
    \brief The BottomType defines the bottom type for a 3D internal feature type, a feature created by removing material.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The BottomEnumType enumerates values that describe the bottom type for a 3D internal feature type, a feature created by removing material.</remarks>
    public enum BottomEnumType
    {
        BLIND, THROUGH, UNDEFINED
    }

    /// <remarks> The BottomType defines the bottom type for a 3D internal feature type, a feature created by removing material.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class BottomType
    {
        #region Choice
        /// <remarks> The BottomEnum element describes an often-used bottom type for a 3D internal feature type.</remarks>
        [XmlElement]
        public BottomEnumType BottomEnum { get; set; }

        /// <remarks> The OtherBottom element describes the bottom type for a 3D internal feature type in natural language.</remarks>
        [XmlElement]
        public string? OtherBottom { get; set; }
        #endregion
    }
}
