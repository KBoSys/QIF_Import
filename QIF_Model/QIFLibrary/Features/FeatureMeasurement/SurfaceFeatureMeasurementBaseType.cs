/*! \file SurfaceFeatureMeasurementBaseType.cs
    \brief abstract base type for shape feature measurements for features composed of surfaces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The SurfaceFeatureMeasurementBaseType is the abstract base type for shape feature measurements for features composed of surfaces./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SurfaceFeatureMeasurementBaseType : ShapeFeatureMeasurementBaseType
    {
    }
}
