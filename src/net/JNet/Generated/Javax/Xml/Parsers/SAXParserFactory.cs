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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Parsers
{
    #region SAXParserFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html"/>
    /// </summary>
    public partial class SAXParserFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SAXParserFactory>
    {
        const string _bridgeClassName = "javax.xml.parsers.SAXParserFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SAXParserFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SAXParserFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SAXParserFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SAXParserFactory(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region SAXParserFactory implementation
    public partial class SAXParserFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newDefaultInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/parsers/SAXParserFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/parsers/SAXParserFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Parsers.SAXParserFactory"/></returns>
        public static Javax.Xml.Parsers.SAXParserFactory NewInstance(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.SAXParserFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#getSchema()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setSchema(javax.xml.validation.Schema)"/>
        /// </summary>
        public Javax.Xml.Validation.Schema Schema
        {
            get { return IExecuteWithSignature<Javax.Xml.Validation.Schema>("getSchema", "()Ljavax/xml/validation/Schema;"); } set { IExecuteWithSignature("setSchema", "(Ljavax/xml/validation/Schema;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#newSAXParser()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.SAXParser"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Parsers.SAXParser NewSAXParser()
        {
            return IExecuteWithSignature<Javax.Xml.Parsers.SAXParser>("newSAXParser", "()Ljavax/xml/parsers/SAXParser;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setFeature", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isNamespaceAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecuteWithSignature<bool>("isNamespaceAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isValidating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecuteWithSignature<bool>("isValidating", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#isXIncludeAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecuteWithSignature<bool>("isXIncludeAware", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setNamespaceAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceAware(bool arg0)
        {
            IExecuteWithSignature("setNamespaceAware", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setValidating(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetValidating(bool arg0)
        {
            IExecuteWithSignature("setValidating", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/parsers/SAXParserFactory.html#setXIncludeAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetXIncludeAware(bool arg0)
        {
            IExecuteWithSignature("setXIncludeAware", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}