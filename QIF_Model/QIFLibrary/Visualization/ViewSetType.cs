/*! \file ViewSetType.cs
	\brief defines a container for storing all views present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The ViewSetType defines a container for storing all views present in the CAD scene./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ViewSetType
    {
        /// <remarks The optional CameraSet element is a set of Camera objects./>
        public CameraSetType CameraSet { get; set; }

        /// <remarks The optional SavedViewSet element is a set of saved view objects./>
        public SavedViewSetType SavedViewSet { get; set; }

        /// <remarks The optional AnnotationViewSet element is a set of annotation view objects./>
        public AnnotationViewSetType AnnotationViewSet { get; set; }

        /// <remarks The optional SimplifiedRepresentationSet element is a set of simplified representation objects./>
        public SimplifiedRepresentationSetType SimplifiedRepresentationSet { get; set; }

        /// <remarks The optional ExplodedViewSet element is a set of exploded view objects./>
        public ExplodedViewSetType ExplodedViewSet { get; set; }

        /// <remarks The optional DisplayStyleSet element is a set of display style objects./>
        public DisplayStyleSetType DisplayStyleSet { get; set; }

        /// <remarks The optional ZoneSectionSet element is a set of zone section objects./>
        public ZoneSectionSetType ZoneSectionSet { get; set; }

        /// <remarks The optional HatchStyleSet element is a set of hatch style objects./>
        public HatchStyleSetType HatchStyleSet { get; set; }
    }
}
