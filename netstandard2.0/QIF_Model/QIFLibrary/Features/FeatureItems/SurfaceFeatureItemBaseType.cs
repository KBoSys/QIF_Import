/*! \file SurfaceFeatureItemBaseType.cs
    \brief Abstract base type for shape feature items for features composed of surfaces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The SurfaceFeatureItemBaseType is the abstract base type for shape feature items for features composed of surfaces.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SurfaceFeatureItemBaseType : ShapeFeatureItemBaseType
    {
    }
}
