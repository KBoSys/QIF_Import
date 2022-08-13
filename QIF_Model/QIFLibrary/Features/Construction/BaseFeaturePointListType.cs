/*! \file BaseFeaturePointListType.cs
    \brief defines a list of base feature points

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks The BaseFeaturePointListType defines a list of base feature points
    /// to be used in the construction of a re-compensated-for-probe-size
    /// best-fit feature.Each feature recompensation type will have a
    /// minimum number of points this list must contain./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BaseFeaturePointListType : ArrayBaseType<BaseFeaturePointSetType>
    {
        /// <remarks Each BaseFeaturePointSet element is an individual point or set of points for a best-fit construction./>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeaturePointSet")]
        public BaseFeaturePointSetType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks The BaseFeaturePointSetType defines a measurement point or points
    /// from a feature to be used in a re-compensated-for-probe-size best-fit./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BaseFeaturePointSetType
    {
        /// <remarks The FeatureId element is the QIF id of a feature nominal in the
        /// case where a construction is defined at the feature nominal
        /// level, or the QIF id of a feature item in the case where a
        /// construction is defined at the feature item level.The allowed
        /// values of FeatureId are restricted by key/keyref pairs./>
        public QIFReferenceType FeatureId { get; set; }

        /// <remarks The PointIndex element is a reference to a measurement point by
        /// a single index, or to several measurement points by a range, or
        /// by specifying all measurement points./>
        public PointIndexType PointIndex { get; set; }

        /// <remarks The ReferencedComponent element identifies whether the measured
        /// or nominal component of a measurement point or points on this
        /// feature is used in the construction./>
        public ReferencedComponentEnumType ReferencedComponent { get; set; }

        /// <remarks The SequenceNumber element is an ordinal number defining the
        /// order of the base feature in the construction./>
        public uint SequenceNumber { get; set; }
    }

    /// <remarks The PointIndexType defines a point, a range of points, or all points./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointIndexType
    {
        /// <remarks 
        /// The Single element is the index number of a single point. Index numbers start at 1 for the first point on a feature.
        /// The Range element is the range of point locations.
        /// The All element indicates all points are to be used./>
        [System.Xml.Serialization.XmlElementAttribute("All", typeof(string), DataType = "token")]
        [System.Xml.Serialization.XmlElementAttribute("Range", typeof(PointRangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Single", typeof(uint))]
        public object Item { get; set; }
    }

    /// <remarks The PointRangeType defines a range of point index numbers. 
    /// The points at the start and stop indexes are included. 
    /// Index numbers start at 1 for the first point on a feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointRangeType
    {
        /// <remarks The Start element is the index number of the starting point in the range.
        /// The value of the Start element must be 1 or greater and smaller than the value of the Stop element./>
        public uint Start { get; set; }

        /// <remarks The Stop element is the index number of the stopping point in the range. 
        /// The value of the Stop element must be greater than the value of the Start element and less than or equal to the
        /// number of points in the feature measurement point list./>
        public uint Stop { get; set; }
    }
}
