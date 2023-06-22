/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region IHTMLFormElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHTMLFormElement : Org.W3c.Dom.Html.IHTMLElement
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getAcceptCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setAcceptCharset(java.lang.String)"/>
        /// </summary>
        string AcceptCharset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setAction(java.lang.String)"/>
        /// </summary>
        string Action { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getElements()"/> 
        /// </summary>
        Org.W3c.Dom.Html.HTMLCollection Elements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getEnctype()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setEnctype(java.lang.String)"/>
        /// </summary>
        string Enctype { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getLength()"/> 
        /// </summary>
        int Length { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setMethod(java.lang.String)"/>
        /// </summary>
        string Method { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setName(java.lang.String)"/>
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        string Target { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#reset()"/>
        /// </summary>
        void Reset();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#submit()"/>
        /// </summary>
        void Submit();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HTMLFormElement
    public partial class HTMLFormElement : Org.W3c.Dom.Html.IHTMLFormElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getAcceptCharset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setAcceptCharset(java.lang.String)"/>
        /// </summary>
        public string AcceptCharset
        {
            get { return IExecute<string>("getAcceptCharset"); } set { IExecute("setAcceptCharset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setAction(java.lang.String)"/>
        /// </summary>
        public string Action
        {
            get { return IExecute<string>("getAction"); } set { IExecute("setAction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getElements()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLCollection Elements
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLCollection>("getElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getEnctype()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setEnctype(java.lang.String)"/>
        /// </summary>
        public string Enctype
        {
            get { return IExecute<string>("getEnctype"); } set { IExecute("setEnctype", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecute<int>("getLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setMethod(java.lang.String)"/>
        /// </summary>
        public string Method
        {
            get { return IExecute<string>("getMethod"); } set { IExecute("setMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#getTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#setTarget(java.lang.String)"/>
        /// </summary>
        public string Target
        {
            get { return IExecute<string>("getTarget"); } set { IExecute("setTarget", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLFormElement.html#submit()"/>
        /// </summary>
        public void Submit()
        {
            IExecute("submit");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}