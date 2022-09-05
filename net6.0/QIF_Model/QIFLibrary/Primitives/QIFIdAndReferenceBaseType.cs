/*! \file QIFIdAndReferenceBaseType.cs

        The QIFIdandReferenceBaseType defines an unsigned integer with no
        leading zeros. It is used as the base type for ids and references
        to ids. It is not used as the type of an element or attribute.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    public abstract class QIFIdAndReferenceBaseType
    {
        private uint valueField;

        protected QIFIdAndReferenceBaseType() { }
        protected QIFIdAndReferenceBaseType(uint value) { valueField = value; }

        /// Implicit conversion from System.UInt32 to QIFIdType
        public static implicit operator uint(QIFIdAndReferenceBaseType refType)
        {
            return refType.Value;
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get => this.valueField;
            set => this.valueField = value;
        }
    }
}