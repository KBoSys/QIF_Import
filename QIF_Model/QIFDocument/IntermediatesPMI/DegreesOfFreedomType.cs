/*! \file DegreesOfFreedomType.cs
 	\brief Defines the degrees of freedom available for fitting or controlled by a datum reference frame

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks
    /// ASME Y14.5 - 2009 Section 4.2 and Figure 4-1 
    /// />
    public enum ASMEDegreeOfFreedomEnum
    {
        U,
        V,
        W,
        X,
        Y,
        Z,
    }
    /// <remarks
    /// ISO specific degrees of freedon
    /// />
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

    /// <remarks
    /// The DegreeOfFreedomEnumType enumerates values that describe a
    /// degree of freedom of a datum as specified by degrees of freedom
    /// modifiers found in a feature control frame, e.g., [Au, v, z|Bx, y|Cw]. 
    /// 
    /// ASME Y14.5 - 2009 Section 4.2 and Figure 4-1 
    /// />
    public class ASMEDegreeOfFreedomEnumType : DegreeOfFreedomBase<ASMEDegreeOfFreedomEnum>
	{
        public override bool IsISO() { return false; }
    }

    /// <remarks
    /// (ISO specific) The ISODegreeOfFreedomEnumType enumerates values
    /// that describe a degree of freedom of a datum as specified by
    /// degrees of freedom modifiers found in a feature control frame./>
    public class ISODegreeOfFreedomEnumType : DegreeOfFreedomBase<ISODegreeOfFreedomEnum>
    {
        public override bool IsISO() { return true; }
    }

    /// <remarks
    /// The DegreesOfFreedomType defines the degrees of freedom available
    /// for fitting or controlled by a datum reference frame (DRF = datum reference frame). />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DegreesOfFreedomType
	{
        /// <remarks
        /// This compositor provides a choice between the ASME Y14.5 and
        /// ISO 1101 implementations of datum degrees of freedom.
        /// 
        /// Each DegreeOfFreedom element specifies which degree of freedom is controlled. />
        [XmlElement(ElementName = "DegreeOfFreedom", Type = typeof(ASMEDegreeOfFreedomEnumType))]
        [XmlElement(ElementName = "ISODegreeOfFreedom", Type = typeof(ISODegreeOfFreedomEnumType))]
        public DegreeOfFreedom[] DegreesOfFreedom { get; set; }

        /// <remarks The required n attribute is the number of degrees of freedom available for fitting./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.DegreesOfFreedom.Length;
        }
    }
}
