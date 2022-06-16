/*! \file ViewSetType.cs
	\brief TODO

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ViewSetType
    {

        private CameraSetType cameraSetField;

        private SavedViewSetType savedViewSetField;

        private AnnotationViewSetType annotationViewSetField;

        private SimplifiedRepresentationSetType simplifiedRepresentationSetField;

        private ExplodedViewSetType explodedViewSetField;

        private DisplayStyleSetType displayStyleSetField;

        private ZoneSectionSetType zoneSectionSetField;

        private HatchStyleSetType hatchStyleSetField;

        /// <remarks/>
        public CameraSetType CameraSet
        {
            get
            {
                return this.cameraSetField;
            }
            set
            {
                this.cameraSetField = value;
            }
        }

        /// <remarks/>
        public SavedViewSetType SavedViewSet
        {
            get
            {
                return this.savedViewSetField;
            }
            set
            {
                this.savedViewSetField = value;
            }
        }

        /// <remarks/>
        public AnnotationViewSetType AnnotationViewSet
        {
            get
            {
                return this.annotationViewSetField;
            }
            set
            {
                this.annotationViewSetField = value;
            }
        }

        /// <remarks/>
        public SimplifiedRepresentationSetType SimplifiedRepresentationSet
        {
            get
            {
                return this.simplifiedRepresentationSetField;
            }
            set
            {
                this.simplifiedRepresentationSetField = value;
            }
        }

        /// <remarks/>
        public ExplodedViewSetType ExplodedViewSet
        {
            get
            {
                return this.explodedViewSetField;
            }
            set
            {
                this.explodedViewSetField = value;
            }
        }

        /// <remarks/>
        public DisplayStyleSetType DisplayStyleSet
        {
            get
            {
                return this.displayStyleSetField;
            }
            set
            {
                this.displayStyleSetField = value;
            }
        }

        /// <remarks/>
        public ZoneSectionSetType ZoneSectionSet
        {
            get
            {
                return this.zoneSectionSetField;
            }
            set
            {
                this.zoneSectionSetField = value;
            }
        }

        /// <remarks/>
        public HatchStyleSetType HatchStyleSet
        {
            get
            {
                return this.hatchStyleSetField;
            }
            set
            {
                this.hatchStyleSetField = value;
            }
        }
    }
}
