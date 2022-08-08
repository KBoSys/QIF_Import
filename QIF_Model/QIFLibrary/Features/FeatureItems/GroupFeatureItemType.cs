/*! \file GroupFeatureItemType.cs
    \brief A group feature is a complex feature defined by a set of features

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks The GroupFeatureItemType is an individual group feature. A group
    /// feature is a complex feature defined by a set of features, some or
    /// all of which may themselves be group features./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GroupFeatureItemType : ShapeFeatureItemBaseType
    {
    }
}
