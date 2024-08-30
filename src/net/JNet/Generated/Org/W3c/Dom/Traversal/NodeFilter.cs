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

namespace Org.W3c.Dom.Traversal
{
    #region NodeFilter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html"/>
    /// </summary>
    public partial class NodeFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NodeFilter>
    {
        const string _bridgeClassName = "org.w3c.dom.traversal.NodeFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("NodeFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public NodeFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("NodeFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public NodeFilter(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region INodeFilter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INodeFilter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#acceptNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        short AcceptNode(Org.W3c.Dom.Node arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeFilter implementation
    public partial class NodeFilter : Org.W3c.Dom.Traversal.INodeFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ALL"/>
        /// </summary>
        public static int SHOW_ALL { get { if (!_SHOW_ALLReady) { _SHOW_ALLContent = SGetField<int>(LocalBridgeClazz, "SHOW_ALL"); _SHOW_ALLReady = true; } return _SHOW_ALLContent; } }
        private static int _SHOW_ALLContent = default;
        private static bool _SHOW_ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ATTRIBUTE"/>
        /// </summary>
        public static int SHOW_ATTRIBUTE { get { if (!_SHOW_ATTRIBUTEReady) { _SHOW_ATTRIBUTEContent = SGetField<int>(LocalBridgeClazz, "SHOW_ATTRIBUTE"); _SHOW_ATTRIBUTEReady = true; } return _SHOW_ATTRIBUTEContent; } }
        private static int _SHOW_ATTRIBUTEContent = default;
        private static bool _SHOW_ATTRIBUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_CDATA_SECTION"/>
        /// </summary>
        public static int SHOW_CDATA_SECTION { get { if (!_SHOW_CDATA_SECTIONReady) { _SHOW_CDATA_SECTIONContent = SGetField<int>(LocalBridgeClazz, "SHOW_CDATA_SECTION"); _SHOW_CDATA_SECTIONReady = true; } return _SHOW_CDATA_SECTIONContent; } }
        private static int _SHOW_CDATA_SECTIONContent = default;
        private static bool _SHOW_CDATA_SECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_COMMENT"/>
        /// </summary>
        public static int SHOW_COMMENT { get { if (!_SHOW_COMMENTReady) { _SHOW_COMMENTContent = SGetField<int>(LocalBridgeClazz, "SHOW_COMMENT"); _SHOW_COMMENTReady = true; } return _SHOW_COMMENTContent; } }
        private static int _SHOW_COMMENTContent = default;
        private static bool _SHOW_COMMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT"/>
        /// </summary>
        public static int SHOW_DOCUMENT { get { if (!_SHOW_DOCUMENTReady) { _SHOW_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "SHOW_DOCUMENT"); _SHOW_DOCUMENTReady = true; } return _SHOW_DOCUMENTContent; } }
        private static int _SHOW_DOCUMENTContent = default;
        private static bool _SHOW_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT_FRAGMENT"/>
        /// </summary>
        public static int SHOW_DOCUMENT_FRAGMENT { get { if (!_SHOW_DOCUMENT_FRAGMENTReady) { _SHOW_DOCUMENT_FRAGMENTContent = SGetField<int>(LocalBridgeClazz, "SHOW_DOCUMENT_FRAGMENT"); _SHOW_DOCUMENT_FRAGMENTReady = true; } return _SHOW_DOCUMENT_FRAGMENTContent; } }
        private static int _SHOW_DOCUMENT_FRAGMENTContent = default;
        private static bool _SHOW_DOCUMENT_FRAGMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_DOCUMENT_TYPE"/>
        /// </summary>
        public static int SHOW_DOCUMENT_TYPE { get { if (!_SHOW_DOCUMENT_TYPEReady) { _SHOW_DOCUMENT_TYPEContent = SGetField<int>(LocalBridgeClazz, "SHOW_DOCUMENT_TYPE"); _SHOW_DOCUMENT_TYPEReady = true; } return _SHOW_DOCUMENT_TYPEContent; } }
        private static int _SHOW_DOCUMENT_TYPEContent = default;
        private static bool _SHOW_DOCUMENT_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ELEMENT"/>
        /// </summary>
        public static int SHOW_ELEMENT { get { if (!_SHOW_ELEMENTReady) { _SHOW_ELEMENTContent = SGetField<int>(LocalBridgeClazz, "SHOW_ELEMENT"); _SHOW_ELEMENTReady = true; } return _SHOW_ELEMENTContent; } }
        private static int _SHOW_ELEMENTContent = default;
        private static bool _SHOW_ELEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ENTITY"/>
        /// </summary>
        public static int SHOW_ENTITY { get { if (!_SHOW_ENTITYReady) { _SHOW_ENTITYContent = SGetField<int>(LocalBridgeClazz, "SHOW_ENTITY"); _SHOW_ENTITYReady = true; } return _SHOW_ENTITYContent; } }
        private static int _SHOW_ENTITYContent = default;
        private static bool _SHOW_ENTITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_ENTITY_REFERENCE"/>
        /// </summary>
        public static int SHOW_ENTITY_REFERENCE { get { if (!_SHOW_ENTITY_REFERENCEReady) { _SHOW_ENTITY_REFERENCEContent = SGetField<int>(LocalBridgeClazz, "SHOW_ENTITY_REFERENCE"); _SHOW_ENTITY_REFERENCEReady = true; } return _SHOW_ENTITY_REFERENCEContent; } }
        private static int _SHOW_ENTITY_REFERENCEContent = default;
        private static bool _SHOW_ENTITY_REFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_NOTATION"/>
        /// </summary>
        public static int SHOW_NOTATION { get { if (!_SHOW_NOTATIONReady) { _SHOW_NOTATIONContent = SGetField<int>(LocalBridgeClazz, "SHOW_NOTATION"); _SHOW_NOTATIONReady = true; } return _SHOW_NOTATIONContent; } }
        private static int _SHOW_NOTATIONContent = default;
        private static bool _SHOW_NOTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_PROCESSING_INSTRUCTION"/>
        /// </summary>
        public static int SHOW_PROCESSING_INSTRUCTION { get { if (!_SHOW_PROCESSING_INSTRUCTIONReady) { _SHOW_PROCESSING_INSTRUCTIONContent = SGetField<int>(LocalBridgeClazz, "SHOW_PROCESSING_INSTRUCTION"); _SHOW_PROCESSING_INSTRUCTIONReady = true; } return _SHOW_PROCESSING_INSTRUCTIONContent; } }
        private static int _SHOW_PROCESSING_INSTRUCTIONContent = default;
        private static bool _SHOW_PROCESSING_INSTRUCTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#SHOW_TEXT"/>
        /// </summary>
        public static int SHOW_TEXT { get { if (!_SHOW_TEXTReady) { _SHOW_TEXTContent = SGetField<int>(LocalBridgeClazz, "SHOW_TEXT"); _SHOW_TEXTReady = true; } return _SHOW_TEXTContent; } }
        private static int _SHOW_TEXTContent = default;
        private static bool _SHOW_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_ACCEPT"/>
        /// </summary>
        public static short FILTER_ACCEPT { get { if (!_FILTER_ACCEPTReady) { _FILTER_ACCEPTContent = SGetField<short>(LocalBridgeClazz, "FILTER_ACCEPT"); _FILTER_ACCEPTReady = true; } return _FILTER_ACCEPTContent; } }
        private static short _FILTER_ACCEPTContent = default;
        private static bool _FILTER_ACCEPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_REJECT"/>
        /// </summary>
        public static short FILTER_REJECT { get { if (!_FILTER_REJECTReady) { _FILTER_REJECTContent = SGetField<short>(LocalBridgeClazz, "FILTER_REJECT"); _FILTER_REJECTReady = true; } return _FILTER_REJECTContent; } }
        private static short _FILTER_REJECTContent = default;
        private static bool _FILTER_REJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#FILTER_SKIP"/>
        /// </summary>
        public static short FILTER_SKIP { get { if (!_FILTER_SKIPReady) { _FILTER_SKIPContent = SGetField<short>(LocalBridgeClazz, "FILTER_SKIP"); _FILTER_SKIPReady = true; } return _FILTER_SKIPContent; } }
        private static short _FILTER_SKIPContent = default;
        private static bool _FILTER_SKIPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeFilter.html#acceptNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        public short AcceptNode(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<short>("acceptNode", "(Lorg/w3c/dom/Node;)S", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}