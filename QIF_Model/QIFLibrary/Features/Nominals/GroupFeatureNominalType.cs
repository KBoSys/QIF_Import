/*! \file GroupFeatureNominalType.cs
    \brief Defines the group feature nominal information for an individual group feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The GroupFeatureNominalType is defines the group feature nominal information for an individual group feature./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GroupFeatureNominalType : ShapeFeatureNominalBaseType
    {
        /// <remarks The FeatureNominalIds element is a list of QIF ids of the
        /// set of feature items comprising the group feature.
        /// Having a single QIF id in the list is OK because it is
        /// allowable to reference another group feature. />
        public ArrayReferenceFullType FeatureNominalIds { get; set; }
    }
}
