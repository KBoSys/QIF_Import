/*! \file OtherSurfaceFeatureNominalType.cs
    \brief Defines the other surface feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The OtherSurfaceFeatureNominalType defines the other surface
    /// feature nominal information for an individual other surface
    /// feature.An other surface feature is intended to be used by having
    /// it reference a collection of faces in an internal or external CAD
    /// definition.An other surface feature must not be used to represent
    /// a feature that can be represented as a more specific type of feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ClosedSurface", typeof(InternalExternalEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(OtherSurfaceConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("PolyLine", typeof(PolyLineType))]
        public object? Item { get; set; }
    }
}
