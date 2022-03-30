/*! \file QIFTypes.cs
    \brief Declaration of QIF Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
	/// <summary>
	/// All local (i.e. not significant outside the instance file) identifiers in the QIF schemas are of type QIFIdType.
	/// </summary>
	[System.SerializableAttribute()]
	public class QIFIdType
	{
		private uint _id;

		public QIFIdType()
		{
			this._id = 0;
		}
		/// As we are using implicit conversions we can keep the constructor private
		private QIFIdType(uint value)
		{
			this._id = value;
		}

		/// <summary>
		/// Implicitly converts a <see cref="System.Int32"/> to a QIFIdType.
		/// </summary>
		/// <param name="value">The <see cref="System.Int32"/> to convert.</param>
		/// <returns>A new Record with the specified value.</returns>
		public static implicit operator QIFIdType(uint value)
		{
			return new QIFIdType(value);
		}
		/// <summary>
		/// Implicitly converts a QIFIdType to a <see cref="System.Int32"/>.
		/// </summary>
		/// <param name="record">The QIFIdType to convert.</param>
		/// <returns>
		/// A <see cref="System.Int32"/> that is the specified QIFIdType's value.
		/// </returns>
		public static implicit operator uint(QIFIdType record)
		{
			return record._id;
		}
	}
}
