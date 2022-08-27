/*! \file OppositeAngledLinesFeatureDefinitionType.cs
	\brief Defines the nominal information that can be common to one or more opposite angled lines features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OppositeAngledLinesFeatureDefinitionType defines the nominal
    /// information that can be common to one or more opposite angled lines features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature
        /// is internal (slot, groove) or external(rib, web, block).</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Width element is the nominal width of this feature of size.
        /// Because the feature is tapered, the width applies at the locating point.</remarks>
        public LinearValueType Width { get; set; }

        /// <remarks> The optional Length element is the nominal length of the
        /// feature from end to end along the centerline.</remarks>
        public LinearValueType Length { get; set; }

        /// <remarks> The EndType element is the type of the opposite angled lines feature's ends: round, flat, expanded, or open.</remarks>
        public SlotEndType EndType { get; set; }

        /// <remarks> The TaperAngle element is the nominal taper angle of the feature.
        /// If positive, the opposite angled lines of the feature open in the direction of the centerline vector, and
        /// if negative, the opposite angled lines close in the direction of the centerline vector.</remarks>
        public AngularValueType TaperAngle { get; set; }

        /// <remarks> The optional SingleOpenEnd element is a designator that
        /// this feature has one open end.It has meaning only with
        /// FLAT, ROUND or EXPANDED end types.If this element exists
        /// and is set to "true" then the end in the direction of the
        /// centerline vector is open and the other end is closed.</remarks>
        public bool SingleOpenEnd { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleOpenEndSpecified { get; set; }

        /// <remarks> The optional EndRadius1 element is the radius of a complex
        /// end in the direction opposite the centerline vector.If the
        /// end type is flat, then the opposite angled lines feature
        /// has a filleted flat end, and the value must be small enough
        /// that a portion of the end is flat.If the end type is
        /// round, this value must be such that the end is an outward
        /// circular arc. If the end radius is greater than that of a
        /// tangent round end then whether the end expands in size like
        /// a dumbbell or not is defined by the Expanded element.</remarks>
        public EndRadiusType EndRadius1 { get; set; }

        /// <remarks> The optional EndRadius2 element is the radius of the
        /// complex end in the direction of the centerline vector.If
        /// the end type is flat, then the opposite angled lines
        /// feature has a filleted flat end, and the value must be
        /// small enough that a portion of the end is flat.If the end
        /// type is round, this value must be such that the end is an
        /// outward circular arc. If the end radius is greater than
        /// that of a tangent round end then whether the end expands in
        /// size like a dumbbell or not is defined by the Expanded element.</remarks>
        public EndRadiusType EndRadius2 { get; set; }
    }
}
