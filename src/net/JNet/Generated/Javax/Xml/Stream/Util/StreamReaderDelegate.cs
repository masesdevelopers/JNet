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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Util
{
    #region StreamReaderDelegate
    public partial class StreamReaderDelegate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#%3Cinit%3E(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        public StreamReaderDelegate(Javax.Xml.Stream.XMLStreamReader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        public Java.Lang.String CharacterEncodingScheme
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCharacterEncodingScheme", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getElementText()"/> 
        /// </summary>
        public Java.Lang.String ElementText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getElementText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEncoding()"/> 
        /// </summary>
        public Java.Lang.String Encoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecuteWithSignature<int>("getEventType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocalName()"/> 
        /// </summary>
        public Java.Lang.String LocalName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecuteWithSignature<Javax.Xml.Stream.Location>("getLocation", "()Ljavax/xml/stream/Location;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getName()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName Name
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.QName>("getName", "()Ljavax/xml/namespace/QName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceContext()"/> 
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceCount()"/> 
        /// </summary>
        public int NamespaceCount
        {
            get { return IExecuteWithSignature<int>("getNamespaceCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI()"/> 
        /// </summary>
        public Java.Lang.String NamespaceURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#setParent(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader Parent
        {
            get { return IExecuteWithSignature<Javax.Xml.Stream.XMLStreamReader>("getParent", "()Ljavax/xml/stream/XMLStreamReader;"); } set { IExecuteWithSignature("setParent", "(Ljavax/xml/stream/XMLStreamReader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPIData()"/> 
        /// </summary>
        public Java.Lang.String PIData
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPIData", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPITarget()"/> 
        /// </summary>
        public Java.Lang.String PITarget
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPITarget", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPrefix()"/> 
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrefix", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getText()"/> 
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextCharacters()"/> 
        /// </summary>
        public char[] TextCharacters
        {
            get { return IExecuteWithSignatureArray<char>("getTextCharacters", "()[C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextLength()"/> 
        /// </summary>
        public int TextLength
        {
            get { return IExecuteWithSignature<int>("getTextLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextStart()"/> 
        /// </summary>
        public int TextStart
        {
            get { return IExecuteWithSignature<int>("getTextStart", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasName()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasName()
        {
            return IExecuteWithSignature<bool>("hasName", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasText()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasText()
        {
            return IExecuteWithSignature<bool>("hasText", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isAttributeSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeSpecified(int arg0)
        {
            return IExecuteWithSignature<bool>("isAttributeSpecified", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isCharacters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCharacters()
        {
            return IExecuteWithSignature<bool>("isCharacters", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isEndElement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEndElement()
        {
            return IExecuteWithSignature<bool>("isEndElement", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStandalone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecuteWithSignature<bool>("isStandalone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStartElement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStartElement()
        {
            return IExecuteWithSignature<bool>("isStartElement", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isWhiteSpace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWhiteSpace()
        {
            return IExecuteWithSignature<bool>("isWhiteSpace", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#standaloneSet()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StandaloneSet()
        {
            return IExecuteWithSignature<bool>("standaloneSet", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextCharacters(int,char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int GetTextCharacters(int arg0, char[] arg1, int arg2, int arg3)
        {
            return IExecute<int>("getTextCharacters", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int NextTag()
        {
            return IExecuteWithSignature<int>("nextTag", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeLocalName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeLocalName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeLocalName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeNamespace(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeNamespace", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributePrefix(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributePrefix", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeType(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeType", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeValue(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeValue", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getAttributeValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespacePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespacePrefix(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespacePrefix", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespaceURI(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespaceURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
        public Javax.Xml.Namespace.QName GetAttributeName(int arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Namespace.QName>("getAttributeName", "(I)Ljavax/xml/namespace/QName;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#require(int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Require(int arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("require", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}