﻿/*! \file ValidationBodyType.cs
    \brief defines a set of body validation properties.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks The ValidationBodyType defines a set of body validation properties./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationBodyType
    {
        /// <remarks The optional Area element is the body area./>
        public double Area { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreaSpecified { get; set; }

        /// <remarks The Centroid element is the body center of mass./>
        public PointSimpleType Centroid { get; set; }

        /// <remarks The optional Volume element is the body volume./>
        public double Volume { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VolumeSpecified { get; set; }

        /// <remarks The optional Box element is the body bounding box./>
        public BoundingBoxAxisAlignedType Box { get; set; }

        /// <remarks The optional FacePoints element is a set of points that lie on the body faces./>
        public ValidationPointsType FacePoints { get; set; }

        /// <remarks The optional EdgesPoints element is a set of points that lie on the body edges./>
        public ValidationPointsType EdgePoints { get; set; }
    }
}
