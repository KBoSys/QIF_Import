/*! \file PointDefinedSurfaceFeatureNominalType.cs
    \brief Defines the point-defined surface feature nominal information for an individual point-defined surface feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The PointDefinedSurfaceFeatureNominalType defines the point-defined surface feature nominal information for an individual point-defined surface feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks></remarks>
        public DefiningPointsNominalType? DefiningPoints { get; set; }

        /// <remarks></remarks>
        public PointDefinedSurfaceConstructionMethodType? Constructed { get; set; }
    }
}
