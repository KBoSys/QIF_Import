/*! \file QIFIdAndReferenceBaseType.cs

        The QIFIdandReferenceBaseType defines an unsigned integer with no
        leading zeros. It is used as the base type for ids and references
        to ids. It is not used as the type of an element or attribute.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
	public abstract class QIFIdAndReferenceBaseType : UInt32Type
	{
		protected QIFIdAndReferenceBaseType() { }
		protected QIFIdAndReferenceBaseType(System.UInt32 value) : base(value) { }
	}
}
