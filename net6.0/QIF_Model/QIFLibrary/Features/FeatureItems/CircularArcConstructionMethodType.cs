/*! \file CircularArcConstructionMethodType.cs
    \brief Defines the method for constructing a unique nominal or measured circular arc feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The CircularArcConstructionMethodType defines the method for
    /// constructing a unique nominal or measured circular arc feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(CircularArcBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(CircularArcCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(CircularArcCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(CircularArcExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(CircularArcFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersection", typeof(CircularArcIntersectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Projection", typeof(CircularArcProjectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(CircularArcRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(CircularArcTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}