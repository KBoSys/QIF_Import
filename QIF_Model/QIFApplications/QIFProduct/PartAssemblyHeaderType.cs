/*! \file PartAssemblyHeaderType.cs
    \brief The PartAssemblyHeaderType defines information about the creation of
        the file containing the CAD model and global parameters of the model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The PartAssemblyHeaderType defines information about the creation of the file containing the CAD model and global parameters of the model.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartAssemblyHeaderType
    {
        /// <remarks> The optional Name element is the name of the model.</remarks>
        [XmlElement()]
        public string Name { get; set; }

        /// <remarks> The optional File element specifies the QIF file used in the model.</remarks>
        [XmlElement()]
        public FileInternalType File { get; set; }

        /// <remarks> The optional Application element is information about the
        /// software application wherein the model was most recently edited.</remarks>
        [XmlElement()]
        public ApplicationType Application { get; set; }

        /// <remarks> The optional Author element is the author who created this file.</remarks>
        [XmlElement()]
        public AuthorType Author { get; set; }

        /// <remarks> The optional ApplicationSource element is the name of the
        /// software application wherein the model was created.</remarks>
        [XmlElement()]
        public ApplicationType ApplicationSource { get; set; }

        /// <remarks> The optional Description element is a description of the model.</remarks>
        [XmlElement()]
        public string Description { get; set; }
    }
}
