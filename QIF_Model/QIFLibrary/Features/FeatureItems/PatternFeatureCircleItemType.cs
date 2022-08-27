/*! \file PatternFeatureCircleItemType.cs
    \brief Defines an individual circle pattern feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PatternFeatureItemBaseType : GroupFeatureItemType
    {
    }

    /// <remarks> The PatternFeatureCircleItemType defines an individual circle pattern feature.</remarks>
    public class PatternFeatureCircleItemType : PatternFeatureItemBaseType
    {
    }
}
