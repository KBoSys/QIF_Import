/*! \file MeasuredPointWithNormalBaseType.cs
    \brief base type for the results of measurement and measured point-defined-feature points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The abstract MeasuredPointWithNormalBaseType is the base type for
    /// the results of measurement and measured point-defined-feature points. 
    /// The direction of the optional normal vector is away from the material./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefiningPointMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MeasuredPointWithNormalBaseType
    {
        /// <remarks The Point element is the location of the individual point./>
        public MeasuredPointType Point { get; set; }

        /// <remarks The optional Normal element is the unit vector normal to the
        /// material at the locating point./>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks The DefiningPointMeasurementType defines a measured feature
    /// defining point.The sequence number of each DefiningPointMeasurementType corresponds to the sequence number of
    /// a DefiningPointNominalType.It is possible that a nominal feature defining point may not have a corresponding measured feature
    /// defining point but each measured feature defining point must have a corresponding nominal feature defining point./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DefiningPointMeasurementType : MeasuredPointWithNormalBaseType
    {
        /// <remarks The SequenceNumber element is an ordinal number referencing
        /// the sequence number of the corresponding nominal feature defining point./>
        public uint SequenceNumber { get; set; }
    }
}
