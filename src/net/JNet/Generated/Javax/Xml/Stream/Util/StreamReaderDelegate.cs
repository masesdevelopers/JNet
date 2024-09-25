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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Stream.Util
{
    #region StreamReaderDelegate declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html"/>
    /// </summary>
    public partial class StreamReaderDelegate : Javax.Xml.Stream.XMLStreamReader
    {
        const string _bridgeClassName = "javax.xml.stream.util.StreamReaderDelegate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamReaderDelegate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamReaderDelegate(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region StreamReaderDelegate implementation
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
            get { return IExecute<int>("getAttributeCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getCharacterEncodingScheme()"/> 
        /// </summary>
        public Java.Lang.String CharacterEncodingScheme
        {
            get { return IExecute<Java.Lang.String>("getCharacterEncodingScheme"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getElementText()"/> 
        /// </summary>
        public Java.Lang.String ElementText
        {
            get { return IExecute<Java.Lang.String>("getElementText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEncoding()"/> 
        /// </summary>
        public Java.Lang.String Encoding
        {
            get { return IExecute<Java.Lang.String>("getEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecute<int>("getEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocalName()"/> 
        /// </summary>
        public Java.Lang.String LocalName
        {
            get { return IExecute<Java.Lang.String>("getLocalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getLocation()"/> 
        /// </summary>
        public Javax.Xml.Stream.Location Location
        {
            get { return IExecute<Javax.Xml.Stream.Location>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getName()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName Name
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceContext()"/> 
        /// </summary>
        public Javax.Xml.Namespace.NamespaceContext NamespaceContext
        {
            get { return IExecute<Javax.Xml.Namespace.NamespaceContext>("getNamespaceContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceCount()"/> 
        /// </summary>
        public int NamespaceCount
        {
            get { return IExecute<int>("getNamespaceCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI()"/> 
        /// </summary>
        public Java.Lang.String NamespaceURI
        {
            get { return IExecute<Java.Lang.String>("getNamespaceURI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#setParent(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLStreamReader Parent
        {
            get { return IExecute<Javax.Xml.Stream.XMLStreamReader>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPIData()"/> 
        /// </summary>
        public Java.Lang.String PIData
        {
            get { return IExecute<Java.Lang.String>("getPIData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPITarget()"/> 
        /// </summary>
        public Java.Lang.String PITarget
        {
            get { return IExecute<Java.Lang.String>("getPITarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getPrefix()"/> 
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecute<Java.Lang.String>("getPrefix"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getText()"/> 
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecute<Java.Lang.String>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextCharacters()"/> 
        /// </summary>
        public char[] TextCharacters
        {
            get { return IExecuteArray<char>("getTextCharacters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextLength()"/> 
        /// </summary>
        public int TextLength
        {
            get { return IExecute<int>("getTextLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getTextStart()"/> 
        /// </summary>
        public int TextStart
        {
            get { return IExecute<int>("getTextStart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecute<Java.Lang.String>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasName()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasName()
        {
            return IExecute<bool>("hasName");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#hasText()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasText()
        {
            return IExecute<bool>("hasText");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isAttributeSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeSpecified(int arg0)
        {
            return IExecute<bool>("isAttributeSpecified", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isCharacters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCharacters()
        {
            return IExecute<bool>("isCharacters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isEndElement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEndElement()
        {
            return IExecute<bool>("isEndElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStandalone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecute<bool>("isStandalone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isStartElement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStartElement()
        {
            return IExecute<bool>("isStartElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#isWhiteSpace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWhiteSpace()
        {
            return IExecute<bool>("isWhiteSpace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#standaloneSet()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StandaloneSet()
        {
            return IExecute<bool>("standaloneSet");
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
            return IExecute<int>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public int NextTag()
        {
            return IExecute<int>("nextTag");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeLocalName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeLocalName(int arg0)
        {
            return IExecute<Java.Lang.String>("getAttributeLocalName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeNamespace(int arg0)
        {
            return IExecute<Java.Lang.String>("getAttributeNamespace", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributePrefix(int arg0)
        {
            return IExecute<Java.Lang.String>("getAttributePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeType(int arg0)
        {
            return IExecute<Java.Lang.String>("getAttributeType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeValue(int arg0)
        {
            return IExecute<Java.Lang.String>("getAttributeValue", arg0);
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
            return IExecute<Java.Lang.String>("getNamespacePrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespaceURI(int arg0)
        {
            return IExecute<Java.Lang.String>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespaceURI(Java.Lang.String arg0)
        {
            return IExecute<Java.Lang.String>("getNamespaceURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Namespace.QName"/></returns>
        public Javax.Xml.Namespace.QName GetAttributeName(int arg0)
        {
            return IExecute<Javax.Xml.Namespace.QName>("getAttributeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/StreamReaderDelegate.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecute("close");
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