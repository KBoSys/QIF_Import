/*! \file CriterionOutOfType.cs
    \brief defines numerical limits to be used as a criterion as integer values outside of which an issue will exist.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The CriterionOutOfType defines numerical limits to be used as a
    /// criterion as integer values outside of which an issue will exist.
    /// The limit is defined as N out of M, for example 2 out of 3, N being
    /// the numerator and M being the denominator.The limit can be
    /// optionally qualified to allow a number of items to exceed the limit.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionOutOfType
    {
        /// <remarks> The Numerator element defines the numerator N.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint Numerator { get; set; }

        /// <remarks> The Denominator element defines the denominator M.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint Denominator { get; set; }

        /// <remarks> The NumberAllowedExceptions element defines the number of items
        /// that can lie outside the limit without an issue existing.</remarks>
        public LimitingNumberType NumberAllowedExceptions { get; set; }
    }
}
