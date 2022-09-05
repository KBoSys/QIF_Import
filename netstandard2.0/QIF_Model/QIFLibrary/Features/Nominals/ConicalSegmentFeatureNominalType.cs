/*! \file ConicalSegmentFeatureNominalType.cs
    \brief Defines the conical segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The ConicalSegmentFeatureNominalType defines the conical segment
    /// feature nominal information for an individual conical segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The Axis element is the nominal locating point and nominal
        /// unit axis vector of the conical segment which points from
        /// the locating point into the expanding end of the conical segment.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Sweep element gives the start direction and the swept
        /// angle for a conical segment feature.The StartVector of the
        /// Sweep must lie in a plane normal to the axis of the cone.</remarks>
        public SweepType Sweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the conical
        /// segment is constructed and provides details of the construction method.</remarks>
        public ConicalSegmentConstructionMethodType Constructed { get; set; }
    }
}
