/*! \file QIFReferenceBaseType.cs

        The QIFReferenceBaseType is the base type for references
        to 'id' attributes. It is not used as the type of an element
        or attribute.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
	public abstract class QIFReferenceBaseType : QIFIdAndReferenceBaseType
	{
		protected QIFReferenceBaseType() { }
		protected QIFReferenceBaseType(System.UInt32 value) : base(value) { }
	}
}
