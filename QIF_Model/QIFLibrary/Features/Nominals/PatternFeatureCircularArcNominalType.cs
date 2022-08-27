/*! \file PatternFeatureCircularArcNominalType.cs
    \brief Defines the pattern feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The PatternFeatureCircularArcNominalType defines the pattern
    /// feature nominal information for an individual circular arc pattern
    /// feature. The nominal location of first element of the circular arc
    /// pattern is the nominal location of the first feature in the pattern
    /// (which is not necessarily the first feature in the feature set).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureCircularArcNominalType : PatternFeatureNominalBaseType
    {
        /// <remarks> The Normal element is the normal of the plane of the arc.</remarks>
        public UnitVectorType Normal { get; set; }

        /// <remarks> The Center element is the center of the arc.</remarks>
        public PointType Center { get; set; }

        /// <remarks> The FirstFeatureLocation element identifies the nominal
        /// feature whose location is the location of the first element
        /// of the pattern.The distance from the center of the arc to
        /// this feature must equal the radius of the arc. The other
        /// nominal features in the feature set must be in locations
        /// defined by the pattern.</remarks>
        public QIFReferenceType FirstFeatureLocation { get; set; }
    }
}
