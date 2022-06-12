/*! \file NodeBaseType.cs
	\brief The NodeBaseType is the abstract base type for model elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using QIF_Model.QIFApplications;
using QIF_Model.QIFApplications.QIFProduct;
using QIF_Model.QIFLibrary.Auxiliary;
using QIF_Model.QIFLibrary.Geometry;
using QIF_Model.QIFLibrary.Topology;
using QIF_Model.QIFLibrary.Visualization;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks The NodeBaseType is the abstract base type for model elements./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeWithIdBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnnotationViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimplifiedRepresentationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExplodedViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DisplayStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HatchStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ZoneSectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SavedViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CameraType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometryBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeshTriangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PathTriangulationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Torus23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sphere23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cylinder23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cone23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plane23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Offset23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ruled23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Extrude23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Revolution23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Curve13BaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Curve12BaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointEntityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrawableBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteFlagType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartNoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LayerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderPartAssemblyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderAssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderPartType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartAssemblyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryPlaneBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CADCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologyBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCloudType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BodyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShellType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VertexType))]
    public abstract class NodeBaseType
	{
		/// <remarks The optional label attribute is the model entity "nameplate".
		/// Normally it can be seen at the entity item in the project tree./>
		[XmlElement()]
		public string Label { get; set; }
	}
}
