/*! \file FeatureBaseType.cs
    \brief abstract base type for feature definitions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <summary>
    /// The FeatureBaseType is the abstract base type for feature
    /// definitions, feature nominals, feature items, and feature
    /// measurements.It describes a subset of information common to all features.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureItems.FeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureDefinitions.FeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureMeasurement.FeatureMeasurementBaseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class FeatureBaseType : QIFApplications.QIFIdTypeBase
    {
        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }
    }

    /// <summary>
    /// The SetFeatureType defines that a feature has a set value rather
    /// than a checked (directly measured or constructed) value. The set
    /// feature type is used in cases where a non-measurable basic value
    /// needs to be tracked by virtue of appearing on a product print, For
    /// example, a circle representing the area in which weld splatter is not allowed.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SetFeatureType
    {
    }

    /// <summary>
    /// The MeasuredFeatureType defines that a feature is measured.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MeasuredFeatureType
    {
        /// <remarks The optional PointList element is a list of references to nominal target measurement points for the feature./>
        public PointListType PointList { get; set; }
    }
}
