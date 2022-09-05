/*! \file TopologySetType.cs
    \brief Describes the main container for storing all topological entities presented in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The TopologySetType describes the main container for storing all topological entities presented in the CAD scene.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class TopologySetType
    {
        /// <remarks> The optional VertexSet element is a collection of all model vertices.</remarks>
        [XmlElement]
        public VertexSetType? VertexSet { get; set; }

        /// <remarks> The optional EdgeSet element is a collection of all model edges.</remarks>
        [XmlElement]
        public EdgeSetType? EdgeSet { get; set; }

        /// <remarks> The optional LoopSet element is a collection of all model loops.</remarks>
        [XmlElement]
        public LoopSetType? LoopSet { get; set; }

        /// <remarks> The optional FaceSet element is a collection of all model faces.</remarks>
        [XmlElement]
        public FaceSetType? FaceSet { get; set; }

        /// <remarks> The optional ShellSet element is a collection of all model shells.</remarks>
        [XmlElement]
        public ShellSetType? ShellSet { get; set; }

        /// <remarks> The optional BodySet element is a collection of all model bodies.</remarks>
        [XmlElement]
        public BodySetType? BodySet { get; set; }

        /// <remarks> The optional PointCloudSet element is a collection of all model point clouds.</remarks>
        [XmlElement]
        public PointCloudSetType? PointCloudSet { get; set; }
    }
}
