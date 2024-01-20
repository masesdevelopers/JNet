/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Events
{
    #region IXMLEvent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLEvent : Javax.Xml.Stream.IXMLStreamConstants
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getEventType()"/> 
        /// </summary>
        int EventType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getLocation()"/> 
        /// </summary>
        Javax.Xml.Stream.Location Location { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getSchemaType()"/> 
        /// </summary>
        Javax.Xml.Namespace.QName SchemaType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isAttribute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsAttribute();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isCharacters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsCharacters();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndDocument()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEndDocument();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEndElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEntityReference()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEntityReference();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isNamespace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsNamespace();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isProcessingInstruction()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsProcessingInstruction();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartDocument()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsStartDocument();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsStartElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asCharacters()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        Javax.Xml.Stream.Events.Characters AsCharacters();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asEndElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.EndElement"/></returns>
        Javax.Xml.Stream.Events.EndElement AsEndElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asStartElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        Javax.Xml.Stream.Events.StartElement AsStartElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#writeAsEncodedUnicode(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        void WriteAsEncodedUnicode(Java.Io.Writer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLEvent
    public partial class XMLEvent : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecute<int>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecute<Javax.Xml.Stream.Location>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#getSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName SchemaType
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getSchemaType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isAttribute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAttribute()
        {
            return IExecute<bool>("isAttribute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isCharacters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCharacters()
        {
            return IExecute<bool>("isCharacters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndDocument()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEndDocument()
        {
            return IExecute<bool>("isEndDocument");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEndElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEndElement()
        {
            return IExecute<bool>("isEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isEntityReference()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEntityReference()
        {
            return IExecute<bool>("isEntityReference");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isNamespace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamespace()
        {
            return IExecute<bool>("isNamespace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isProcessingInstruction()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsProcessingInstruction()
        {
            return IExecute<bool>("isProcessingInstruction");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartDocument()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStartDocument()
        {
            return IExecute<bool>("isStartDocument");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#isStartElement()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStartElement()
        {
            return IExecute<bool>("isStartElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asCharacters()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.Characters"/></returns>
        public Javax.Xml.Stream.Events.Characters AsCharacters()
        {
            return IExecute<Javax.Xml.Stream.Events.Characters>("asCharacters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asEndElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.EndElement"/></returns>
        public Javax.Xml.Stream.Events.EndElement AsEndElement()
        {
            return IExecute<Javax.Xml.Stream.Events.EndElement>("asEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#asStartElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.Events.StartElement"/></returns>
        public Javax.Xml.Stream.Events.StartElement AsStartElement()
        {
            return IExecute<Javax.Xml.Stream.Events.StartElement>("asStartElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/XMLEvent.html#writeAsEncodedUnicode(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void WriteAsEncodedUnicode(Java.Io.Writer arg0)
        {
            IExecute("writeAsEncodedUnicode", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}