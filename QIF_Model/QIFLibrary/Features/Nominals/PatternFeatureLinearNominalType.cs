/*! \file PatternFeatureLinearNominalType.cs
    \brief Defines the pattern feature nominal information for an individual linear pattern feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The PatternFeatureLinearNominalType defines the pattern feature
    /// nominal information for an individual linear pattern feature. The
    /// nominal location of the linear pattern is the nominal location of
    /// the first feature in the pattern(which is not necessarily the
    /// first feature in the feature set)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureLinearNominalType : PatternFeatureNominalBaseType
    {
        /// <remarks The FirstFeatureLocation element identifies the nominal
        /// feature whose location is the location of the first element
        /// of the pattern.All of the remaining locations lie in the
        /// direction given by the LineDirection of the pattern
        /// definition./>
        public QIFReferenceType FirstFeatureLocation { get; set; }
    }
}
