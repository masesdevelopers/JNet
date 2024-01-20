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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region IXPathNodes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathNodes
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int Size();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<Org.W3c.Dom.Node> Iterator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathException"/>
        Org.W3c.Dom.Node Get(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathNodes
    public partial class XPathNodes : Javax.Xml.Xpath.IXPathNodes
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Org.W3c.Dom.Node> Iterator()
        {
            return IExecute<Java.Util.Iterator<Org.W3c.Dom.Node>>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/xpath/XPathNodes.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathException"/>
        public Org.W3c.Dom.Node Get(int arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("get", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}