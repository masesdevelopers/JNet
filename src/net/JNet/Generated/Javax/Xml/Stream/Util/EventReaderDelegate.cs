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
    #region EventReaderDelegate declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html"/>
    /// </summary>
    public partial class EventReaderDelegate : Javax.Xml.Stream.XMLEventReader
    {
        const string _bridgeClassName = "javax.xml.stream.util.EventReaderDelegate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventReaderDelegate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventReaderDelegate(params object[] args) : base(args) { }

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

    #region EventReaderDelegate implementation
    public partial class EventReaderDelegate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#%3Cinit%3E(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        public EventReaderDelegate(Javax.Xml.Stream.XMLEventReader arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getElementText()"/> 
        /// </summary>
        public Java.Lang.String ElementText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getElementText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#setParent(javax.xml.stream.XMLEventReader)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLEventReader Parent
        {
            get { return IExecuteWithSignature<Javax.Xml.Stream.XMLEventReader>("getParent", "()Ljavax/xml/stream/XMLEventReader;"); } set { IExecuteWithSignature("setParent", "(Ljavax/xml/stream/XMLEventReader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#next()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecuteWithSignature("next", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#nextEvent()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextEvent()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("nextEvent", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent NextTag()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("nextTag", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#peek()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Stream.Events.XMLEvent"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.Events.XMLEvent Peek()
        {
            return IExecuteWithSignature<Javax.Xml.Stream.Events.XMLEvent>("peek", "()Ljavax/xml/stream/events/XMLEvent;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/util/EventReaderDelegate.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecuteWithSignature("remove", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}