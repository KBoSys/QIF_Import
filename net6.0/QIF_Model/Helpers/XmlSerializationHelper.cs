/*! \file XmlSerializationHelper.cs
    \brief Helper functions for XML serialization

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.IO;
using System.Xml.Serialization;

namespace QIF_Model.Helpers
{
    /// <summary>
    /// Generic class to serialize and desrialize c# classes
    /// </summary>
    public static class XmlSerializationHelper
    {
        /// <summary>
        /// Deserialize the input string into oblect of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toDeserialize"></param>
        /// <returns></returns>
        public static T? Deserialize<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T?)xmlSerializer.Deserialize(textReader);
            }
        }

        /// <summary>
        /// Serialize the specified object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toSerialize"></param>
        /// <returns></returns>
        public static string? Serialize<T>(this T toSerialize)
        {
            if (toSerialize is not null)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, toSerialize);
                    return textWriter.ToString();
                }
            }
            return null;
        }
    }
}
