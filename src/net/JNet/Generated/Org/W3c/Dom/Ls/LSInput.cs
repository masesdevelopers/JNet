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
    #region LSInput declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html"/>
    /// </summary>
    public partial class LSInput : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LSInput>
    {
        const string _bridgeClassName = "org.w3c.dom.ls.LSInput";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LSInput class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LSInput() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LSInput class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LSInput(params object[] args) : base(args) { }

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

    #region ILSInput
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSInput
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getBaseURI()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setBaseURI(java.lang.String)"/>
        /// </summary>
        Java.Lang.String BaseURI { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getByteStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setByteStream(java.io.InputStream)"/>
        /// </summary>
        Java.Io.InputStream ByteStream { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getCertifiedText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setCertifiedText(boolean)"/>
        /// </summary>
        bool CertifiedText { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getCharacterStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setCharacterStream(java.io.Reader)"/>
        /// </summary>
        Java.Io.Reader CharacterStream { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setEncoding(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Encoding { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getPublicId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setPublicId(java.lang.String)"/>
        /// </summary>
        Java.Lang.String PublicId { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getStringData()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setStringData(java.lang.String)"/>
        /// </summary>
        Java.Lang.String StringData { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setSystemId(java.lang.String)"/>
        /// </summary>
        Java.Lang.String SystemId { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSInput implementation
    public partial class LSInput : Org.W3c.Dom.Ls.ILSInput
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getBaseURI()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setBaseURI(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String BaseURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBaseURI", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBaseURI", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getByteStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setByteStream(java.io.InputStream)"/>
        /// </summary>
        public Java.Io.InputStream ByteStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getByteStream", "()Ljava/io/InputStream;"); } set { IExecuteWithSignature("setByteStream", "(Ljava/io/InputStream;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getCertifiedText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setCertifiedText(boolean)"/>
        /// </summary>
        public bool CertifiedText
        {
            get { return IExecuteWithSignature<bool>("getCertifiedText", "()Z"); } set { IExecuteWithSignature("setCertifiedText", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getCharacterStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setCharacterStream(java.io.Reader)"/>
        /// </summary>
        public Java.Io.Reader CharacterStream
        {
            get { return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "()Ljava/io/Reader;"); } set { IExecuteWithSignature("setCharacterStream", "(Ljava/io/Reader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setEncoding(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Encoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setEncoding", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getPublicId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setPublicId(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String PublicId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPublicId", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPublicId", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getStringData()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setStringData(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String StringData
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getStringData", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setStringData", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSInput.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}