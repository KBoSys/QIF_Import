/*! \file QuaternionType.cs
	\brief quaternion type

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks The Quaternion is the quaternion type/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QuaternionType
    {
        /// <remarks The Quaternion is defined in the following way: the first
        /// element is the scalar part(cos(theta/2)), the second, third,
        /// and fourth elements are the imaginary/"vector" part, (sin(theta/2) * axis)./>
        public D4Type Value { get; set; }
    }
}
