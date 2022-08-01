/*! \file CylindricalSegmentFeatureNominalType.cs
    \brief Defines the cylindrical segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The CylindricalSegmentFeatureNominalType defines the cylindrical
    /// segment feature nominal information for an individual cylindrical segment feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricalSegmentFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Axis element gives the nominal location of the start
        /// point and the nominal unit cylindrical segment axis vector.
        /// The direction of the axis vector points into the cylindrical segment./>
        public AxisType Axis { get; set; }

        /// <remarks The Sweep element gives the start direction and swept angle
        /// for a cylindrical segment.The StartVector of the Sweep
        /// must lie in a plane normal to the axis of the cylinder./>
        public SweepType Sweep { get; set; }

        /// <remarks The optional Constructed element signifies that the
        /// cylindrical segment is constructed and provides details of
        /// the construction method./>
        public CylindricalSegmentConstructionMethodType Constructed { get; set; }
    }

    /// <remarks The CylindricalSegmentConstructionMethodType defines the method for
    /// constructing a unique nominal or measured cylindrical segment feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricalSegmentConstructionMethodType
    {
        /// <remarks This optional compositor provides a choice of the construction method for the cylindrical segment./>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(CylindricalSegmentBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(CylindricalSegmentCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(CylindricalSegmentCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(CylindricalSegmentRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(CylindricalSegmentTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
