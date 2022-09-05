/*! \file ThreadedFeatureNominalType.cs
    \brief Defines the threaded feature nominal information for an individual threaded feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The ThreadedFeatureNominalType defines the threaded feature nominal information for an individual threaded feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureNominalType : SpecifiedFeatureNominalBaseType
    {
        /// <remarks></remarks>
        public AxisType? Axis { get; set; }

        /// <remarks></remarks>
        public ThreadedFeatureConstructionMethodType? Constructed { get; set; }
    }
}
