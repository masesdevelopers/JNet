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

namespace Org.W3c.Dom.Html
{
    #region HTMLImageElement declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html"/>
    /// </summary>
    public partial class HTMLImageElement : Org.W3c.Dom.Html.HTMLElement
    {
        const string _bridgeClassName = "org.w3c.dom.html.HTMLImageElement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HTMLImageElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLImageElement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HTMLImageElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLImageElement(params object[] args) : base(args) { }

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

    #region IHTMLImageElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLImageElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Align { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getAlt()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setAlt(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Alt { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Border { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setHeight(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Height { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getHspace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setHspace(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Hspace { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getIsMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setIsMap(boolean)"/>
        /// </summary>
        bool IsMap { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getLongDesc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setLongDesc(java.lang.String)"/>
        /// </summary>
        Java.Lang.String LongDesc { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getLowSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setLowSrc(java.lang.String)"/>
        /// </summary>
        Java.Lang.String LowSrc { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setName(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Name { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Src { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getUseMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setUseMap(java.lang.String)"/>
        /// </summary>
        Java.Lang.String UseMap { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getVspace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setVspace(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Vspace { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Width { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLImageElement implementation
    public partial class HTMLImageElement : Org.W3c.Dom.Html.IHTMLImageElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Align
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlign", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAlign", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getAlt()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setAlt(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Alt
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlt", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAlt", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setBorder(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Border
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBorder", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBorder", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setHeight(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Height
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHeight", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHeight", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getHspace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setHspace(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Hspace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHspace", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHspace", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getIsMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setIsMap(boolean)"/>
        /// </summary>
        public bool IsMap
        {
            get { return IExecuteWithSignature<bool>("getIsMap", "()Z"); } set { IExecuteWithSignature("setIsMap", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getLongDesc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setLongDesc(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LongDesc
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLongDesc", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLongDesc", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getLowSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setLowSrc(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LowSrc
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLowSrc", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLowSrc", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Src
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSrc", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSrc", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getUseMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setUseMap(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String UseMap
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUseMap", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setUseMap", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getVspace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setVspace(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Vspace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVspace", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setVspace", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLImageElement.html#setWidth(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Width
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getWidth", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setWidth", "(Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}