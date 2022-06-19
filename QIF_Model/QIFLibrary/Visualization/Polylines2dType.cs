﻿/*! \file Polylines2dType.cs
	\brief defines a polyline curve. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The Polyline2dType defines a polyline curve./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Polyline2dType
    {
        /// <remarks This compositor provides a choice of the representation method for the polyline points./>
        [System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPoint2dType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsBinary", typeof(ArrayBinaryType))]
        public object Item { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public ColorType Color { get; set; }

        /// <remarks The optional color attribute is the color for the polyline./>
        [System.Xml.Serialization.XmlAttributeAttribute("color")]
        public string ColorText
        {
            get => Color != null ? Color.ToString() : null;
            set => Color = ColorType.FromString(value);
        }
    }

    /// <remarks The Polylines2dType is a container for storing 2D polyline curves./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Polylines2dType
    {
        /// <remarks Each Polyline element is a polyline curve./>
        [System.Xml.Serialization.XmlElementAttribute("Polyline")]
        public Polyline2dType[] Items { get; set; }

        /// <remarks The required n attribute is the number of polyline curves in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }

    /// <remarks The Loops2dType defines a set of loops. The first loop is outer, the rest are inner loops./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Loops2dType
    {
        /// <remarks Each Loop element is a 2D loop defined as a polyline./>
        [System.Xml.Serialization.XmlElementAttribute("Loop")]
        public Polyline2dType[] Items { get; set; }

        /// <remarks The required n attribute is the number of loops in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
