/*! \file PointWithNormalBaseType.cs
    \brief base type for measurement and point-defined-feature points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The abstract PointWithNormalBaseType is the base type for
    /// measurement and point-defined-feature points. The direction of the
    /// optional normal vector is away from the material.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefiningPointNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasurePointNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PointWithNormalBaseType
    {
        /// <remarks> The Point element is the location of the individual point.</remarks>
        public PointType? Point { get; set; }

        /// <remarks> The optional Normal element is the unit vector normal to the material at the locating point.</remarks>
        public UnitVectorType? Normal { get; set; }

        /// <remarks> The QIF id of the measured point set, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; } = new QIFApplications.QIFIdType();

        /// <remarks> The required id attribute is the QIF id of the measured point set, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public UInt32 Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The DefiningPointNominalType defines a nominal feature defining
    /// point. Each nominal defining point has a sequence number used both
    /// to order the nominal defining points, and to provide a reference
    /// for corresponding measured defining points.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DefiningPointNominalType : PointWithNormalBaseType
    {
        /// <remarks> The SequenceNumber element is an ordinal number defining the
        /// order of the nominal feature defining points.</remarks>
        public uint SequenceNumber { get; set; }
    }
}
