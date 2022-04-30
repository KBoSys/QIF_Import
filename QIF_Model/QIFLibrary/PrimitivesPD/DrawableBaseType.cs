/*! \file DrawableBaseType.cs
	\brief The DrawableBaseType is the abstract base type for drawable elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using QIF_Model.QIFApplications;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
	/// <remarks Drawable attributes/>
	public class AttrDrawable
	{
		#region Fields
		private ColorType colorTypeField = new ColorType();
		private TransparencyType transparencyTypeField = new TransparencyType();
		private Primitives.DoublePositiveType sizeField = new Primitives.DoublePositiveType();
		#endregion

		public ColorType Color { get => colorTypeField; set => colorTypeField = value; }
		public TransparencyType Transparency { get => transparencyTypeField; set => transparencyTypeField = value; }
		public bool Hidden { get; set; } = false;
		public Primitives.DoublePositiveType Size { get => sizeField; set => sizeField = value; }
	}

	/// <remarks The DrawableBaseType is the abstract base type for drawable
	/// elements.It contains data necessary for a model entity visualization./>
	public abstract class DrawableBaseType : NodeWithIdBaseType
	{
		private AttrDrawable attrDrawable = new AttrDrawable();

		/// <remarks The optional color attribute defines the RGB color property of a model entity./>
		[XmlElement("color", IsNullable = true)]
		public ColorType Color { get => this.attrDrawable.Color; set => this.attrDrawable.Color = value; }

		/// <remarks The optional transparency attribute defines the transparency property of a model entity./>
		[XmlAttribute("transparency")]
		public double Transparency { get => this.attrDrawable.Transparency; set => this.attrDrawable.Transparency = value; }

		/// <remarks The optional hidden attribute defines the visibility property of a model entity in the graphical window./>
		[XmlAttribute("hidden")]
		public bool Hidden { get => this.attrDrawable.Hidden; set => this.attrDrawable.Hidden = value; }

		/// <remarks The optional size attribute defines a recommended size for
		/// visualization of an infinite drawable element such as plane,
		/// cylinder, axis, etc., or objects without explicit geometric parameters(e.g.coordinate system)./>
		[XmlAttribute("size")]
		public double Size { get => this.attrDrawable?.Size; set => this.attrDrawable.Size = value; }
	}
}
