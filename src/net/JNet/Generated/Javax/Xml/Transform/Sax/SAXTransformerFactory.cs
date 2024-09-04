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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform.Sax
{
    #region SAXTransformerFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html"/>
    /// </summary>
    public partial class SAXTransformerFactory : Javax.Xml.Transform.TransformerFactory
    {
        const string _bridgeClassName = "javax.xml.transform.sax.SAXTransformerFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SAXTransformerFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SAXTransformerFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SAXTransformerFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SAXTransformerFactory(params object[] args) : base(args) { }

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

    #region SAXTransformerFactory implementation
    public partial class SAXTransformerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#FEATURE_XMLFILTER"/>
        /// </summary>
        public static Java.Lang.String FEATURE_XMLFILTER { get { if (!_FEATURE_XMLFILTERReady) { _FEATURE_XMLFILTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_XMLFILTER"); _FEATURE_XMLFILTERReady = true; } return _FEATURE_XMLFILTERContent; } }
        private static Java.Lang.String _FEATURE_XMLFILTERContent = default;
        private static bool _FEATURE_XMLFILTERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTemplatesHandler()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TemplatesHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TemplatesHandler NewTemplatesHandler()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TemplatesHandler>("newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler(javax.xml.transform.Templates)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Templates"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler(Javax.Xml.Transform.Templates arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newXMLFilter(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Org.Xml.Sax.XMLFilter"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Org.Xml.Sax.XMLFilter NewXMLFilter(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Org.Xml.Sax.XMLFilter>("newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newXMLFilter(javax.xml.transform.Templates)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Templates"/></param>
        /// <returns><see cref="Org.Xml.Sax.XMLFilter"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Org.Xml.Sax.XMLFilter NewXMLFilter(Javax.Xml.Transform.Templates arg0)
        {
            return IExecuteWithSignature<Org.Xml.Sax.XMLFilter>("newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}