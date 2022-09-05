/*! \file ValueTypes.cs
    \brief User Defined Value Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
    /// <summary>
    /// The UserDefinedUnitValueType defines a SpecifiedDecimalType with a
    /// required unitName attribute that identifies the unit being used by
    /// its UnitName.The units used in a UserDefinedUnitValueType must be UserDefinedUnits.
    /// </summary>
    public class UserDefinedUnitValueType : SpecifiedDecimalType
    {
        /// <summary>
        /// The (required) UnitName attribute is the unit name for the UserDefinedUnitValueType.
        /// </summary>
        [XmlAttributeAttribute("unitName")]
        public string UnitName { get; set; }
    }

    /// <summary>
    /// The MeasuredUserDefinedUnitValueType defines an MeasuredDecimalType
    /// with a required unitName attribute that identifies the unit
    /// being used by its UnitName.The units used in a
    /// MeasuredUserDefinedUnitValueType must be UserDefinedUnits.
    /// </summary>
    public class MeasuredUserDefinedUnitValueType : MeasuredDecimalType
    {
        /// <summary>
        /// The (required) UnitName attribute is the unit name for the UserDefinedUnitValueType.
        /// </summary>
        [XmlAttributeAttribute("unitName")]
        public string UnitName { get; set; }
    }
}
