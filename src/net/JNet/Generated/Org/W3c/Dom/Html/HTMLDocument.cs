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

namespace Org.W3c.Dom.Html
{
    #region HTMLDocument declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html"/>
    /// </summary>
    public partial class HTMLDocument : Org.W3c.Dom.Document
    {
        const string _bridgeClassName = "org.w3c.dom.html.HTMLDocument";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HTMLDocument class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLDocument() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HTMLDocument class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HTMLDocument(params object[] args) : base(args) { }

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

    #region IHTMLDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLDocument : Org.W3c.Dom.IDocument
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getAnchors()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Anchors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getApplets()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Applets { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getBody()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setBody(org.w3c.dom.html.HTMLElement)"/>
        /// </summary>
        Org.W3c.Dom.Html.HTMLElement Body { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getCookie()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setCookie(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Cookie { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getDomain()"/> 
        /// </summary>
        Java.Lang.String Domain { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getForms()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Forms { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getImages()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Images { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getLinks()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Links { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getReferrer()"/> 
        /// </summary>
        Java.Lang.String Referrer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setTitle(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Title { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getURL()"/> 
        /// </summary>
        Java.Lang.String URL { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getElementsByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        Org.W3c.Dom.NodeList GetElementsByName(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#close()"/>
        /// </summary>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#open()"/>
        /// </summary>
        void Open();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void Write(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#writeln(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void Writeln(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLDocument implementation
    public partial class HTMLDocument : Org.W3c.Dom.Html.IHTMLDocument
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getAnchors()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Anchors
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getAnchors", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getApplets()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Applets
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getApplets", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getBody()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setBody(org.w3c.dom.html.HTMLElement)"/>
        /// </summary>
        public Org.W3c.Dom.Html.HTMLElement Body
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLElement>("getBody", "()Lorg/w3c/dom/html/HTMLElement;"); } set { IExecuteWithSignature("setBody", "(Lorg/w3c/dom/html/HTMLElement;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getCookie()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setCookie(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Cookie
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCookie", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCookie", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getDomain()"/> 
        /// </summary>
        public Java.Lang.String Domain
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDomain", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getForms()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Forms
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getForms", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getImages()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Images
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getImages", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getLinks()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Links
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Html.HTMLCollection>("getLinks", "()Lorg/w3c/dom/html/HTMLCollection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getReferrer()"/> 
        /// </summary>
        public Java.Lang.String Referrer
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getReferrer", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#setTitle(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Title
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTitle", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTitle", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getURL()"/> 
        /// </summary>
        public Java.Lang.String URL
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getURL", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#getElementsByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.NodeList"/></returns>
        public Org.W3c.Dom.NodeList GetElementsByName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.NodeList>("getElementsByName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#open()"/>
        /// </summary>
        public void Open()
        {
            IExecuteWithSignature("open", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Write(Java.Lang.String arg0)
        {
            IExecuteWithSignature("write", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLDocument.html#writeln(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Writeln(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeln", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}