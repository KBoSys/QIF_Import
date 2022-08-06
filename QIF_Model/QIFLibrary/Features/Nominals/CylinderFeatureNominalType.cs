/*! \file CylinderFeatureNominalType.cs
    \brief Defines the cylinder feature nominal information for an individual cylinder feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <summary>
    /// The CylinderFeatureNominalType defines the cylinder feature nominal information for an individual cylinder feature.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CylinderFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Axis element gives the nominal location of the start point and the nominal unit cylinder axis vector.
        /// The direction of the axis vector points into the cylinder.
        /// The cylinder does not extend from the start point in the direction opposite the axis vector./>
        public AxisType Axis { get; set; }

        /// <remarks The optional Sweep element gives the start direction and
        /// the swept angle for a partial cylinder.The swept angle is
        /// typically greater than 180 degrees for a feature of size.
        /// If the sweep is not specified the feature subtends a full
        /// 360 degrees.The StartVector of the Sweep must lie in a
        /// plane normal to the axis of the cylinder./>
        public SweepType Sweep { get; set; }

        /// <remarks The optional Constructed element signifies that the
        /// cylinder is constructed and provides details of the construction method./>
        public CylinderConstructionMethodType Constructed { get; set; }
    }
}
