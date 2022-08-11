/*! \file SurfaceOfRevolutionFeatureNominalType.cs
    \brief Defines the nominal information for an individual surface of revolution feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The SurfaceOfRevolutionFeatureNominalType defines the nominal information for an individual surface of revolution feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks/>
        public AxisType Axis { get; set; }

        /// <remarks/>
        public SweepType Sweep { get; set; }

        /// <remarks/>
        public QIFReferenceFullType ReferenceFeatureNominalId { get; set; }

        /// <remarks/>
        public SurfaceOfRevolutionConstructionMethodType Constructed { get; set; }
    }
}
