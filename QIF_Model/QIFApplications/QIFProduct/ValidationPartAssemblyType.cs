/*! \file ValidationPartAssemblyType.cs
	\brief defines a set of part/assembly validation properties.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The ValidationPartAssemblyType defines a set of part/assembly validation properties.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationPartAssemblyType
    {
        /// <remarks> The optional Area element is the part/assembly area.</remarks>
        public double Area { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreaSpecified { get; set; }

        /// <remarks> The optional Centroid element is the part/assembly center of mass.</remarks>
        public PointSimpleType Centroid { get; set; }

        /// <remarks> The optional Volume element is the part/assembly volume.</remarks>
        public double Volume { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VolumeSpecified { get; set; }

        /// <remarks> The optional Box element is the part/assembly bounding box.</remarks>
        public BoundingBoxAxisAlignedType Box { get; set; }

        /// <remarks> The optional FacePoints element is a set of points that lie on the part/assembly faces.</remarks>
        public ValidationPointsType FacePoints { get; set; }

        /// <remarks> The optional EdgePoints element is a set of points that lie on the part/assembly edges.</remarks>
        public ValidationPointsType EdgePoints { get; set; }

        /// <remarks> The optional Instances element is an array of instance validation properties.</remarks>
        public ValidationPartAssemblyInstancesType Instances { get; set; }
    }
}
