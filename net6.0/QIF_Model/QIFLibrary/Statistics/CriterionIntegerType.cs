/*! \file CriterionIntegerType.cs
    \brief defines a numerical limit to be used as a criterion as an integer value outside of which an issue will exist.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The CriterionIntegerType defines a numerical limit to be used as a
    /// criterion as an integer value outside of which an issue will exist.
    /// The limit can be optionally qualified to allow a number of items to
    /// exceed the limit as long as none are outside a specified extreme limit.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionIntegerType
    {
        /// <remarks> The Limit element defines a limit outside of which an issue will exist.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint Limit { get; set; }

        /// <remarks> The NumberAllowedExceptions element defines the number of
        /// items that can lie between the limit and the extreme limit without an issue existing.</remarks>
        public LimitingNumberType NumberAllowedExceptions { get; set; }

        /// <remarks> The optional ExtremeLimit element defines the extreme limit
        /// outside of which no item can lie or an issue will exist.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint ExtremeLimit { get; set; }
    }
}
