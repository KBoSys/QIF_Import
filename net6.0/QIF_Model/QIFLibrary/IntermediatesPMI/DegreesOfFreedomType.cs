/*! \file DegreesOfFreedomType.cs
 	\brief Defines the degrees of freedom available for fitting or controlled by a datum reference frame

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks>
    /// ASME Y14.5 - 2009 Section 4.2 and Figure 4-1 
    /// </remarks>
    public enum ASMEDegreeOfFreedomEnum
    {
        U,
        V,
        W,
        X,
        Y,
        Z,
    }
    /// <remarks>
    /// ISO specific degrees of freedon
    /// </remarks>
    public enum ISODegreeOfFreedomEnum
    {
        Rx,
        Ry,
        Rz,
        Tx,
        Ty,
        Tz,
    }

    public abstract class DegreeOfFreedom
    {
        public abstract bool IsISO();
    }

    public abstract class DegreeOfFreedomBase<T> : DegreeOfFreedom where T : System.Enum
    {
    }

    /// <remarks>
    /// The DegreeOfFreedomEnumType enumerates values that describe a
    /// degree of freedom of a datum as specified by degrees of freedom
    /// modifiers found in a feature control frame, e.g., [Au, v, z|Bx, y|Cw]. 
    /// 
    /// ASME Y14.5 - 2009 Section 4.2 and Figure 4-1 
    /// </remarks>
    public class ASMEDegreeOfFreedomEnumType : DegreeOfFreedomBase<ASMEDegreeOfFreedomEnum>
    {
        public override bool IsISO() { return false; }
    }

    /// <remarks>
    /// (ISO specific) The ISODegreeOfFreedomEnumType enumerates values
    /// that describe a degree of freedom of a datum as specified by
    /// degrees of freedom modifiers found in a feature control frame.</remarks>
    public class ISODegreeOfFreedomEnumType : DegreeOfFreedomBase<ISODegreeOfFreedomEnum>
    {
        public override bool IsISO() { return true; }
    }

    /// <remarks>
    /// The DegreesOfFreedomType defines the degrees of freedom available
    /// for fitting or controlled by a datum reference frame (DRF = datum reference frame). </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DegreesOfFreedomType : ArrayBaseType<DegreeOfFreedom>
    {
        /// <remarks>
        /// This compositor provides a choice between the ASME Y14.5 and
        /// ISO 1101 implementations of datum degrees of freedom.
        /// 
        /// Each DegreeOfFreedom element specifies which degree of freedom is controlled. </remarks>
        [XmlElement(ElementName = "DegreeOfFreedom", Type = typeof(ASMEDegreeOfFreedomEnumType))]
        [XmlElement(ElementName = "ISODegreeOfFreedom", Type = typeof(ISODegreeOfFreedomEnumType))]
        public DegreeOfFreedom[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
