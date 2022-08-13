/*! \file ValidationPartAssemblyInstancesType.cs
	\brief an array of instance validation properties. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The ValidationPartAssemblyInstancesType is an array of instance validation properties./>
    public class ValidationPartAssemblyInstancesType : ArrayBaseType<ValidationPartAssemblyInstanceType>
    {
        /// <remarks The Instance is a set of instance validation properties./>
        [System.Xml.Serialization.XmlElementAttribute("Instance")]
        public ValidationPartAssemblyInstanceType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks The ValidationPartAssemblyInstanceType defines a set of part/assembly instance validation properties./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationPartAssemblyInstanceType
    {
        /// <remarks The AsmPathId element is the identifier of the assembly path of this part/assembly./>
        public QIFReferenceType AsmPathId { get; set; }

        /// <remarks The optional Centroid element is the instance center of mass./>
        public PointSimpleType Centroid { get; set; }

        /// <remarks The optional Box element is the instance bounding box./>
        public BoundingBoxAxisAlignedType Box { get; set; }
    }
}
