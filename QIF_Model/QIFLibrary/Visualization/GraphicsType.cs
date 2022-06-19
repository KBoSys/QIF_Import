/*! \file GraphicsType.cs
	\brief defines additional graphical presentation data.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The GraphicsType defines additional graphical presentation data.
    /// These visualization data allow specifying user-defined 3D annotations that have no semantic representation in a QIF file./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GraphicsType
    {
        /// <remarks The optional Polylines element is a set of 2D polylines./>
        public Polylines2dType Polylines { get; set; }

        /// <remarks The optional Areas element is a set of 2D areas./>
        public Areas2dType Areas { get; set; }
    }
}
