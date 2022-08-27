/*! \file CarriagesType.cs
	\brief Defines a list of at least two carriages.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The CarriagesType defines a list of at least two carriages.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CarriagesType : ArrayBaseType<CarriageType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Carriage")]
        public CarriageType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CarriageType : MeasurementResourceBaseType
    {
        /// <remarks></remarks>
        public ArrayReferenceType ToolIds { get; set; }
    }
}
