/*! \file PointAndVectorType.cs
    \brief Defines a line by its starting point and direction vector.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The PointAndVectorType defines a line by its starting point and direction vector.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointAndVectorType
    {
        /// <remarks> The StartPoint element is the starting point of the line.</remarks>
        public PointType? StartPoint { get; set; }

        /// <remarks> The Vector element is a unit vector giving the direction of the line.</remarks>
        public UnitVectorType? Vector { get; set; }
    }
}
