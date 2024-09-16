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

namespace Org.W3c.Dom.Html
{
    #region HTMLAnchorElement declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html"/>
    /// </summary>
    public partial class HTMLAnchorElement : Org.W3c.Dom.Html.HTMLElement
    {
        const string _bridgeClassName = "org.w3c.dom.html.HTMLAnchorElement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HTMLAnchorElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLAnchorElement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HTMLAnchorElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLAnchorElement(params object[] args) : base(args) { }

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

    #region IHTMLAnchorElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLAnchorElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getAccessKey()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setAccessKey(java.lang.String)"/>
        /// </summary>
        Java.Lang.String AccessKey { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setCharset(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Charset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getCoords()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setCoords(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Coords { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getHref()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setHref(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Href { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getHreflang()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setHreflang(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Hreflang { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setName(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Name { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getRel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setRel(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Rel { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getRev()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setRev(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Rev { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getShape()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setShape(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Shape { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getTabIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setTabIndex(int)"/>
        /// </summary>
        int TabIndex { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Target { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setType(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Type { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#blur()"/>
        /// </summary>
        void Blur();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#focus()"/>
        /// </summary>
        void Focus();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLAnchorElement implementation
    public partial class HTMLAnchorElement : Org.W3c.Dom.Html.IHTMLAnchorElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getAccessKey()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setAccessKey(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AccessKey
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAccessKey", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAccessKey", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setCharset(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Charset
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCharset", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCharset", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getCoords()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setCoords(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Coords
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCoords", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCoords", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getHref()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setHref(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Href
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHref", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHref", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getHreflang()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setHreflang(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Hreflang
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHreflang", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHreflang", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getRel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setRel(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Rel
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRel", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRel", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getRev()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setRev(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Rev
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRev", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRev", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getShape()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setShape(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Shape
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getShape", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setShape", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getTabIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setTabIndex(int)"/>
        /// </summary>
        public int TabIndex
        {
            get { return IExecuteWithSignature<int>("getTabIndex", "()I"); } set { IExecuteWithSignature("setTabIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Target
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTarget", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTarget", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#getType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#setType(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setType", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#blur()"/>
        /// </summary>
        public void Blur()
        {
            IExecuteWithSignature("blur", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLAnchorElement.html#focus()"/>
        /// </summary>
        public void Focus()
        {
            IExecuteWithSignature("focus", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}