/*! \file Curve13.cs
	\brief The global Curve13 element is a 3D curve and is the head of a substitution group.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
	/// <remarks The Curve13BaseType is the abstract base type for all geometric
	/// 3D curves(curve(t):R1->R3) present in the CAD scene./>
	public abstract class Curve13BaseType : GeometryBaseType
	{
	}

	/// <remarks />
	public class Segment13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class ArcConic13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class ArcCircular13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Nurbs13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Spline13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Aggregate13 : Curve13BaseType
	{
	}

	/// <remarks />
	public class Polyline13Core : Curve13BaseType
	{
	}

	/// <remarks />
	public class Polyline13Type : Curve13BaseType
	{
	}

	/// <remarks />
	public class Aggregate13Type : Curve13BaseType
	{
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class Polyline13CoreType : CurveCoreBaseType
	{

		private object itemField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPointType))]
		[System.Xml.Serialization.XmlElementAttribute("PointsBinary", typeof(ArrayBinaryType))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}

	/// <remarks The Aggregate12CoreType defines the mathematical core of the
	/// geometric entity 'aggregate_curve(t):R1->R2'.
	/// The aggregate curve is a sequence of parametric sub-curves./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class Aggregate13CoreType : CurveCoreBaseType
	{
		/// <remarks/>
		public ArraySubCurve13Type SubCurves { get; set; }
	}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Spline13CoreType : CurveCoreBaseType
    {

        private ArrayDoubleType knotsField;

        private ArrayNaturalType ordersField;

        private ArrayPointType coefficientsField;

        private bool normalizedField;

        public Spline13CoreType()
        {
            this.normalizedField = false;
        }

        /// <remarks/>
        public ArrayDoubleType Knots
        {
            get
            {
                return this.knotsField;
            }
            set
            {
                this.knotsField = value;
            }
        }

        /// <remarks/>
        public ArrayNaturalType Orders
        {
            get
            {
                return this.ordersField;
            }
            set
            {
                this.ordersField = value;
            }
        }

        /// <remarks/>
        public ArrayPointType Coefficients
        {
            get
            {
                return this.coefficientsField;
            }
            set
            {
                this.coefficientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool normalized
        {
            get
            {
                return this.normalizedField;
            }
            set
            {
                this.normalizedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Nurbs13CoreType : CurveCoreBaseType
    {

        private uint orderField;

        private ArrayDoubleType knotsField;

        private object itemField;

        private ArrayDoubleType weightsField;

        /// <remarks/>
        public uint Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public ArrayDoubleType Knots
        {
            get
            {
                return this.knotsField;
            }
            set
            {
                this.knotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CPs", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("CPsBinary", typeof(ArrayBinaryType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public ArrayDoubleType Weights
        {
            get
            {
                return this.weightsField;
            }
            set
            {
                this.weightsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcCircular13CoreType : CurveCoreBaseType
    {

        private double radiusField;

        private string centerField;

        private string dirBegField;

        private string normalField;

        /// <remarks/>
        public double Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }

        /// <remarks/>
        public string Center
        {
            get
            {
                return this.centerField;
            }
            set
            {
                this.centerField = value;
            }
        }

        /// <remarks/>
        public string DirBeg
        {
            get
            {
                return this.dirBegField;
            }
            set
            {
                this.dirBegField = value;
            }
        }

        /// <remarks/>
        public string Normal
        {
            get
            {
                return this.normalField;
            }
            set
            {
                this.normalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcConic13CoreType : CurveCoreBaseType
    {

        private double aField;

        private double bField;

        private string centerField;

        private string dirBegField;

        private string normalField;

        private ArcConicFormEnumType formField;

        /// <remarks/>
        public double A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        public double B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public string Center
        {
            get
            {
                return this.centerField;
            }
            set
            {
                this.centerField = value;
            }
        }

        /// <remarks/>
        public string DirBeg
        {
            get
            {
                return this.dirBegField;
            }
            set
            {
                this.dirBegField = value;
            }
        }

        /// <remarks/>
        public string Normal
        {
            get
            {
                return this.normalField;
            }
            set
            {
                this.normalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArcConicFormEnumType form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Segment13CoreType : CurveCoreBaseType
    {

        private string startPointField;

        private string endPointField;

        /// <remarks/>
        public string StartPoint
        {
            get
            {
                return this.startPointField;
            }
            set
            {
                this.startPointField = value;
            }
        }

        /// <remarks/>
        public string EndPoint
        {
            get
            {
                return this.endPointField;
            }
            set
            {
                this.endPointField = value;
            }
        }
    }

}
