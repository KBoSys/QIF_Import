/*! \file BoundingBoxAxisAlignedType.cs
    \brief defines a bounding box as a cuboid with axes parallel to the model coordinate system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks The BoundingBoxAxisAlignedType defines a bounding box
    /// as a cuboid with axes parallel to the model coordinate system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BoundingBoxAxisAlignedType
    {
        /// <remarks The PointMin element is the minimal point of the bounding box (the corner with the minimum X, Y, and Z values)./>
        public PointSimpleType PointMin { get; set; }

        /// <remarks The PointMin element is the maximal point of the bounding box (the corner with the maximum X, Y, and Z values). />
        public PointSimpleType PointMax { get; set; }
    }
}
