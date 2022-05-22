/*! \file ScaleType.cs
    \brief defines scaling about an origin point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
	/// <summary>
	/// The ScaleType defines scaling about an origin point.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ScaleType
	{
		/// <remarks The Origin element is the origin for the scaling./>
		[XmlElement]
		public Primitives.PointType Origin { get; set; }

		/// <remarks The AxialDifferentialScale element signifies axial differential scaling about the origin point/>
		[System.Xml.Serialization.XmlElementAttribute("AxialDifferentialScale", typeof(AxialDifferentialScaleType))]
		/// <remarks The RadialDifferentialScale element signifies radial differential scaling about the origin point/>
		[System.Xml.Serialization.XmlElementAttribute("RadialDifferentialScale", typeof(RadialDifferentialScaleType))]
		/// <remarks The UniformScale element signifies uniform scaling about the origin point./>
		[System.Xml.Serialization.XmlElementAttribute("UniformScale", typeof(UniformScaleType))]
		public object Item { get; set; }
	}

    /// <remarks The AxialDifferentialScaleType defines three scale factors applied along three specified orthogonal directions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AxialDifferentialScaleType
    {
        /// <remarks The XScaleFactor element is the scale factor applied in the
        /// specified X direction, a scale factor of 1.0 indicates no change./>
        public decimal XScaleFactor { get; set; }

        /// <remarks The XaxisDirection element specifies the direction of the X axis for differential scaling./>
        public Primitives.UnitVectorType XaxisDirection { get; set; }

        /// <remarks The YScaleFactor element is the scale factor applied in the specified Y direction, a scale factor of 1.0 indicates no change./>
        public decimal YScaleFactor { get; set; }

        /// <remarks The YaxisDirection element specifies the direction of the Y axis for differential scaling./>
        public Primitives.UnitVectorType YaxisDirection { get; set; }

        /// <remarks The ZScaleFactor element is the scale factor applied in the
        /// specified Z direction, a scale factor of 1.0 indicates no change./>
        public decimal ZScaleFactor { get; set; }

        /// <remarks The ZaxisDirection element specifies the direction of the Z axis for differential scaling./>
        public Primitives.UnitVectorType ZaxisDirection { get; set; }
    }

    /// <remarks The RadialDifferentialScaleType defines two scale factors applied parallel and perpendicular to a specified direction./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class RadialDifferentialScaleType
    {
        /// <remarks The PerpendicularScaleFactor element is the scale factor
        /// applied perpendicular to the specified direction, a scale factor of 1.0 indicates no change./>
        public decimal PerpendicularScaleFactor { get; set; }

        /// <remarks The ParallelScaleFactor element is the scale factor applied
        /// parallel to the specified direction, a scale factor of 1.0 indicates no change./>
        public decimal ParallelScaleFactor { get; set; }

        /// <remarks The Direction element specifies the direction for the differential scaling./>
        public Primitives.UnitVectorType Direction { get; set; }
    }

    /// <remarks The UniformScaleType defines a scale factor applied uniformly in all directions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UniformScaleType
    {
        /// <remarks The ScaleFactor element is the scale factor, a scale factor of 1.0 indicates no change./>
        public decimal ScaleFactor { get; set; }
    }
}
