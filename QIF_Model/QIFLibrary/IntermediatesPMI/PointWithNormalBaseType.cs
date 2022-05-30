/*! \file PointWithNormalBaseType.cs
    \brief base type for measurement and point-defined-feature points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The abstract PointWithNormalBaseType is the base type for
    /// measurement and point-defined-feature points. The direction of the
    /// optional normal vector is away from the material./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefiningPointNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasurePointNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PointWithNormalBaseType
    {
        /// <remarks The Point element is the location of the individual point./>
        public PointType Point { get; set; }

        /// <remarks The optional Normal element is the unit vector normal to the material at the locating point./>
        public UnitVectorType Normal { get; set; }

        /// <remarks The id attribute is the QIF id of the point with normal, used for referencing./>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public QIFApplications.QIFIdType Id { get; set; }
    }

    /// <remarks The DefiningPointNominalType defines a nominal feature defining
    /// point. Each nominal defining point has a sequence number used both
    /// to order the nominal defining points, and to provide a reference
    /// for corresponding measured defining points./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DefiningPointNominalType : PointWithNormalBaseType
    {
        /// <remarks The SequenceNumber element is an ordinal number defining the
        /// order of the nominal feature defining points./>
        public uint SequenceNumber { get; set; }
    }
}
