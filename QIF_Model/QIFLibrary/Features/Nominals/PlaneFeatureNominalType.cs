/*! \file PlaneFeatureNominalType.cs
    \brief defines the plane feature nominal information for an individual plane feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The PlaneFeatureNominalType defines the plane feature nominal information for an individual plane feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Location element is the nominal location of a point on the plane./>
        public PointType Location { get; set; }

        /// <remarks The Normal element is the nominal unit normal vector of the plane./>
        public UnitVectorType Normal { get; set; }

        /// <remarks This optional compositor provides a choice among methods of representing the extent and boundary of the plane./>
        [System.Xml.Serialization.XmlElementAttribute("Circle", typeof(CircleType))]
        [System.Xml.Serialization.XmlElementAttribute("PolyLine", typeof(PolyLineType))]
        [System.Xml.Serialization.XmlElementAttribute("Rectangle", typeof(RectangleType))]
        public object Item { get; set; }

        /// <remarks The optional Constructed element signifies that the plane is constructed and provides details of the construction method./>
        public PlaneConstructionMethodType Constructed { get; set; }
    }
}
