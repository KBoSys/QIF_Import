/*! \file BoundingBoxType.cs
	\brief defines the dimensions of a box that usually bounds a shape object.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The BoundingBoxType defines the dimensions of a box that usually bounds a shape object./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BoundingBoxType
    {
        /// <remarks The Length element gives the length of the box./>
        public LinearValueType Length { get; set; }

        /// <remarks The Width element gives the width of the box./>
        public LinearValueType Width { get; set; }

        /// <remarks The Height element gives the height of the box./>
        public LinearValueType Height { get; set; }
    }
}
