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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLBodyElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLBodyElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getALink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setALink(java.lang.String)"/>
        /// </summary>
        Java.Lang.String ALink { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setBackground(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Background { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        Java.Lang.String BgColor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getLink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setLink(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Link { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setText(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Text { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getVLink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setVLink(java.lang.String)"/>
        /// </summary>
        Java.Lang.String VLink { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLBodyElement
    public partial class HTMLBodyElement : Org.W3c.Dom.Html.IHTMLBodyElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getALink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setALink(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ALink
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getALink", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setALink", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setBackground(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Background
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBackground", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBackground", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getBgColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setBgColor(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String BgColor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBgColor", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setBgColor", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getLink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setLink(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Link
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLink", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLink", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setText", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#getVLink()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLBodyElement.html#setVLink(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String VLink
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVLink", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setVLink", "(Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}