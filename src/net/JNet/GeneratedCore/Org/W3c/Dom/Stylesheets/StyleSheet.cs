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

namespace Org.W3c.Dom.Stylesheets
{
    #region StyleSheet definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html"/>
    /// </summary>
    public partial class StyleSheet : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StyleSheet>
    {
        const string _bridgeClassName = "org.w3c.dom.stylesheets.StyleSheet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("StyleSheet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public StyleSheet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("StyleSheet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public StyleSheet(params object[] args) : base(args) { }

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

    #region IStyleSheet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStyleSheet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#setDisabled(boolean)"/>
        /// </summary>
        bool Disabled { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getHref()"/> 
        /// </summary>
        Java.Lang.String Href { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getMedia()"/> 
        /// </summary>
        Org.W3c.Dom.Stylesheets.MediaList Media { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getOwnerNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node OwnerNode { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getParentStyleSheet()"/> 
        /// </summary>
        Org.W3c.Dom.Stylesheets.StyleSheet ParentStyleSheet { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getTitle()"/> 
        /// </summary>
        Java.Lang.String Title { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getType()"/> 
        /// </summary>
        Java.Lang.String Type { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StyleSheet
    public partial class StyleSheet : Org.W3c.Dom.Stylesheets.IStyleSheet
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#setDisabled(boolean)"/>
        /// </summary>
        public bool Disabled
        {
            get { return IExecuteWithSignature<bool>("getDisabled", "()Z"); } set { IExecuteWithSignature("setDisabled", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getHref()"/> 
        /// </summary>
        public Java.Lang.String Href
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHref", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getMedia()"/> 
        /// </summary>
        public Org.W3c.Dom.Stylesheets.MediaList Media
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Stylesheets.MediaList>("getMedia", "()Lorg/w3c/dom/stylesheets/MediaList;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getOwnerNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node OwnerNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getOwnerNode", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getParentStyleSheet()"/> 
        /// </summary>
        public Org.W3c.Dom.Stylesheets.StyleSheet ParentStyleSheet
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Stylesheets.StyleSheet>("getParentStyleSheet", "()Lorg/w3c/dom/stylesheets/StyleSheet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getTitle()"/> 
        /// </summary>
        public Java.Lang.String Title
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTitle", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}