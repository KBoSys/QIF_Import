/*! \file SurfaceFeatureDefinitionBaseType.cs
	
	The SurfaceFeatureDefinitionBaseType is the abstract base type for
    shape feature definitions for features composed of surfaces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The SurfaceFeatureDefinitionBaseType is the abstract base type for shape feature definitions for features composed of surfaces.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureDefinitionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SurfaceFeatureDefinitionBaseType : ShapeFeatureDefinitionBaseType
    {
    }

    /// <remarks> The ElongatedCylinderFeatureDefinitionType defines the elongated
    /// cylinder feature nominal information that can be common to one or
    /// more elongated cylinder features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCylinderFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Diameter element is the nominal diameter of the elongated cylinder.</remarks>
        public LinearValueType? Diameter { get; set; }

        /// <remarks> The Length element is the length (i.e., size) of the elongated cylinder from cylindrical end to cylindrical end.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The optional Depth element is the depth of the elongated cylinder.</remarks>
        public LinearValueType? Depth { get; set; }
    }
}
