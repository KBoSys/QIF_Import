/*! \file PrecedenceType.cs
	\brief Defines the precedence of a datum in a feature control frame or compound datum.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks 
    /// The PrecedenceEnumType enumerates values that describe the precedence of a datum in a feature control frame or compound datum.
    /// />
    public enum PrecedenceEnumType
    {
        PRIMARY,
        SECONDARY,
        TERTIARY,
        QUATERNARY,
        QUINARY,
        SENARY,
    }

    /// <remarks 
    /// The PrecedenceType defines the precedence of a datum in a feature control frame or compound datum.
    /// />
    public class PrecedenceType
    {
        /// <remarks 
        /// The PrecedenceEnum element describes an often-used precedence of a datum in a feature control frame or compound datum.
        /// />
        [XmlElement]
        public PrecedenceEnumType PrecedenceEnum { get; set; }

        /// <remarks 
        /// The OtherPrecedence element describes the precedence of a datum in a feature control frame or compound datum in natural language.
        /// />
        [XmlElement]
        public string OtherPrecedence { get; set; }
    }
}
