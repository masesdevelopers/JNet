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

namespace Org.W3c.Dom.Css
{
    #region IRect
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRect
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getBottom()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSPrimitiveValue Bottom { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getLeft()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSPrimitiveValue Left { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getRight()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSPrimitiveValue Right { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getTop()"/> 
        /// </summary>
        Org.W3c.Dom.Css.CSSPrimitiveValue Top { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Rect
    public partial class Rect : Org.W3c.Dom.Css.IRect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getBottom()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSPrimitiveValue Bottom
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSPrimitiveValue>("getBottom"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getLeft()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSPrimitiveValue Left
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSPrimitiveValue>("getLeft"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getRight()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSPrimitiveValue Right
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSPrimitiveValue>("getRight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/Rect.html#getTop()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSPrimitiveValue Top
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSPrimitiveValue>("getTop"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}