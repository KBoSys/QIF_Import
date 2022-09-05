/*! \file OppositeAngledPlanesFeatureDefinitionType.cs
	\brief defines the nominal information that can be common to one or more opposite angled planes features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.FeatureMeasurement;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OppositeAngledPlanesFeatureDefinitionType defines the nominal
    /// information that can be common to one or more opposite angled planes features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature
        /// is internal (slot, groove) or external(rib, web, block).</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Width element is the nominal width of this feature of size.
        /// Because the opposite angled planes of the feature are tapered or have a draft angle, the width applies at the locating point.</remarks>
        public LinearValueType? Width { get; set; }

        /// <remarks> The optional Length element is the nominal length of the
        /// feature parallel to the length vector in the center-plane.
        /// If the opposite angled planes feature has a draft angle
        /// then the length applies at the depth of the locating point.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The EndType element is the type of the opposite angled
        /// planes feature's ends: round, flat, expanded, or open. A
        /// flat end is formed by a plane perpendicular or at a draft
        /// angle to the LengthVector passing through the location
        /// point of the center plane.</remarks>
        public SlotEndType? EndType { get; set; }

        /// <remarks> The optional Depth element is the depth of the opposite angled planes feature.</remarks>
        public LinearValueType? Depth { get; set; }

        /// <remarks> The optional Bottom element is the type of bottom of the slot.
        /// If present, it must be BLIND or THROUGH.The bottom
        /// type affects the region available for probing.If the
        /// InternalExternal given in the opposite angled planes
        /// feature item is INTERNAL, the opposite angled planes
        /// feature fits the intuitive description of a slot, and in
        /// that case BLIND means that the slot has material at the
        /// bottom, while THROUGH means that the slot goes all the way
        /// through the product.If the InternalExternal is EXTERNAL,
        /// the slot is actually a boss with parallel planes for sides,
        /// and in that case BLIND means that there is material outside
        /// the boss at the base of the boss, while THROUGH means that
        /// there is no material there.</remarks>
        public BottomType? Bottom { get; set; }

        /// <remarks> The optional SingleOpenEnd element signifies that this
        /// feature has one open end.It has meaning only with FLAT,
        /// ROUND or EXPANDED end types.If this element exists and is
        /// set to "true" then the end in the direction of the length vector is open.</remarks>
        public bool SingleOpenEnd { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleOpenEndSpecified { get; set; }

        /// <remarks> The optional EndRadius1 element is the radius of a complex
        /// end in the direction opposite the centerline vector.The
        /// radius is measured in a plane passing through the location
        /// point and containing the LengthVector and the normal to the
        /// center plane. If the end type is flat, then the opposite
        /// angled planes feature has a filleted flat end, and the
        /// value must be small enough that a portion of the end is flat. 
        /// If the end type is round, this value must be such
        /// that the end is an outward cylindrical segment (or a
        /// conical segment if there is a draft). If the end radius is
        /// greater than that of a tangent round end then whether the
        /// end expands in size like a dumbbell or not is defined by the Expanded element.</remarks>
        public EndRadiusType? EndRadius1 { get; set; }

        /// <remarks> The optional EndRadius2 element is the radius of the
        /// complex end in the direction of the centerline vector.The
        /// radius is measured in a plane passing through the location
        /// point and containing the LengthVector and the normal to the
        /// center plane. If the end type is flat, then the opposite
        /// angled planes feature has a filleted flat end, and the
        /// value must be small enough that a portion of the end is flat. 
        /// If the end type is round, this value must be such
        /// that the end is an outward cylindrical segment (or a
        /// conical segment if there is a draft). If the end radius is
        /// greater than that of a tangent round end then whether the
        /// end expands in size like a dumbbell or not is defined by the Expanded element.</remarks>
        public EndRadiusType? EndRadius2 { get; set; }

        /// <remarks> This compositor allows for a taper angle or a draft angle, but not both.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DraftAngle", typeof(AngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("TaperAngle", typeof(AngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("AngleElementName")]
        public AngularValueType? Item { get; set; }

        /// <remarks> </remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public DraftOrTaperAngleEnum AngleElementName { get; set; }
    }
}
