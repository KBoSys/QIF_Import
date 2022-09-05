/*! \file PointSetReferenceBaseType.cs
 	\brief The abstract PointSetReferenceBaseType is the base type for
        references to all or portions of point sets, either nominal or
        measured.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The abstract PointSetReferenceBaseType is the base type for
    /// references to all or portions of point sets, either nominal or measured.</remarks>
    public abstract class PointSetReferenceBaseType : QIFReferenceType
    {
    }

    /// <remarks> The PointSetReferenceWholeType defines a reference to a whole point set.</remarks>
    public class PointSetReferenceWholeType : PointSetReferenceBaseType
    {
    }

    /// <remarks> The PointSetReferenceType defines a reference to a point set with a range of point indexes.</remarks>
    public class PointSetReferenceRangeType : PointSetReferenceBaseType
    {
        //private Natural2Type rangeField;

        /// <remarks> The required range attribute is a pair of two indexes indicating the start and end(inclusive) of a range of
        /// points in a point set.</remarks>
        [XmlAttribute("range")]
        public uint[]? Range { get; set; }
    }

    /// <remarks> The PointSetReferenceSingleType defines a reference to a single point within a point set but its index.</remarks>
    public class PointSetReferenceSingleType : PointSetReferenceBaseType
    {
        /// <remarks> The required index attribute is the index of a single point in a point set.</remarks>
        [XmlAttribute("index")]
        public uint Index { get; set; }
    }

}