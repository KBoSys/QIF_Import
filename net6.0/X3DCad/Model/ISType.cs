/*! \file ISType.cs
	\brief the IS statement connects node fields defined inside a ProtoBody declaration back to corresponding ProtoInterface fields.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// Functional summary: the IS statement connects node fields defined inside a ProtoBody declaration back to corresponding ProtoInterface fields.
    /// IS/connect statements can be added if the parent node is within a ProtoBody and connect statements define correspondences between prototype 
    /// fields and built-in node fields.
    /// </summary>
    public class ISType : X3DStatement
    {
        [XmlElement("connect", typeof(ConnectType))]
        public ConnectType[]? Connect { get; set; }
    }

    /// <summary>
    /// Functional summary: connect statements define event-routing connections between node fields defined inside a ProtoBody declaration 
    /// back to corresponding ProtoInterface fields.
    /// </summary>
    public class ConnectType : X3DStatement
    {
        [XmlAttribute("nodeField", DataType ="token")]
        public string? NodeField { get; set; }

        [XmlAttribute("protoField", DataType = "token")]
        public string? ProtoField { get; set; }
    }
}
