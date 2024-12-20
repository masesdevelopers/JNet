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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Ls
{
    #region LSParser declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html"/>
    /// </summary>
    public partial class LSParser : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LSParser>
    {
        const string _bridgeClassName = "org.w3c.dom.ls.LSParser";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LSParser class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LSParser() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LSParser class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LSParser(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ILSParser
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSParser
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getAsync()"/> 
        /// </summary>
        bool Async { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getBusy()"/> 
        /// </summary>
        bool Busy { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getDomConfig()"/> 
        /// </summary>
        Org.W3c.Dom.DOMConfiguration DomConfig { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#setFilter(org.w3c.dom.ls.LSParserFilter)"/>
        /// </summary>
        Org.W3c.Dom.Ls.LSParserFilter Filter { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parse(org.w3c.dom.ls.LSInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Document Parse(Org.W3c.Dom.Ls.LSInput arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Document ParseURI(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseWithContext(org.w3c.dom.ls.LSInput,org.w3c.dom.Node,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Node ParseWithContext(Org.W3c.Dom.Ls.LSInput arg0, Org.W3c.Dom.Node arg1, short arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#abort()"/>
        /// </summary>
        void Abort();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSParser implementation
    public partial class LSParser : Org.W3c.Dom.Ls.ILSParser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_APPEND_AS_CHILDREN"/>
        /// </summary>
        public static short ACTION_APPEND_AS_CHILDREN { get { if (!_ACTION_APPEND_AS_CHILDRENReady) { _ACTION_APPEND_AS_CHILDRENContent = SGetField<short>(LocalBridgeClazz, "ACTION_APPEND_AS_CHILDREN"); _ACTION_APPEND_AS_CHILDRENReady = true; } return _ACTION_APPEND_AS_CHILDRENContent; } }
        private static short _ACTION_APPEND_AS_CHILDRENContent = default;
        private static bool _ACTION_APPEND_AS_CHILDRENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_INSERT_AFTER"/>
        /// </summary>
        public static short ACTION_INSERT_AFTER { get { if (!_ACTION_INSERT_AFTERReady) { _ACTION_INSERT_AFTERContent = SGetField<short>(LocalBridgeClazz, "ACTION_INSERT_AFTER"); _ACTION_INSERT_AFTERReady = true; } return _ACTION_INSERT_AFTERContent; } }
        private static short _ACTION_INSERT_AFTERContent = default;
        private static bool _ACTION_INSERT_AFTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_INSERT_BEFORE"/>
        /// </summary>
        public static short ACTION_INSERT_BEFORE { get { if (!_ACTION_INSERT_BEFOREReady) { _ACTION_INSERT_BEFOREContent = SGetField<short>(LocalBridgeClazz, "ACTION_INSERT_BEFORE"); _ACTION_INSERT_BEFOREReady = true; } return _ACTION_INSERT_BEFOREContent; } }
        private static short _ACTION_INSERT_BEFOREContent = default;
        private static bool _ACTION_INSERT_BEFOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_REPLACE"/>
        /// </summary>
        public static short ACTION_REPLACE { get { if (!_ACTION_REPLACEReady) { _ACTION_REPLACEContent = SGetField<short>(LocalBridgeClazz, "ACTION_REPLACE"); _ACTION_REPLACEReady = true; } return _ACTION_REPLACEContent; } }
        private static short _ACTION_REPLACEContent = default;
        private static bool _ACTION_REPLACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_REPLACE_CHILDREN"/>
        /// </summary>
        public static short ACTION_REPLACE_CHILDREN { get { if (!_ACTION_REPLACE_CHILDRENReady) { _ACTION_REPLACE_CHILDRENContent = SGetField<short>(LocalBridgeClazz, "ACTION_REPLACE_CHILDREN"); _ACTION_REPLACE_CHILDRENReady = true; } return _ACTION_REPLACE_CHILDRENContent; } }
        private static short _ACTION_REPLACE_CHILDRENContent = default;
        private static bool _ACTION_REPLACE_CHILDRENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getAsync()"/> 
        /// </summary>
        public bool Async
        {
            get { return IExecuteWithSignature<bool>("getAsync", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getBusy()"/> 
        /// </summary>
        public bool Busy
        {
            get { return IExecuteWithSignature<bool>("getBusy", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getDomConfig()"/> 
        /// </summary>
        public Org.W3c.Dom.DOMConfiguration DomConfig
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.DOMConfiguration>("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#setFilter(org.w3c.dom.ls.LSParserFilter)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSParserFilter Filter
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Ls.LSParserFilter>("getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;"); } set { IExecuteWithSignature("setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parse(org.w3c.dom.ls.LSInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Document Parse(Org.W3c.Dom.Ls.LSInput arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Document ParseURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseWithContext(org.w3c.dom.ls.LSInput,org.w3c.dom.Node,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Node ParseWithContext(Org.W3c.Dom.Ls.LSInput arg0, Org.W3c.Dom.Node arg1, short arg2)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}