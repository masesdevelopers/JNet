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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Css
{
    #region CSSRule
    public partial class CSSRule
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#CHARSET_RULE"/>
        /// </summary>
        public static short CHARSET_RULE { get { return SGetField<short>(LocalBridgeClazz, "CHARSET_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#FONT_FACE_RULE"/>
        /// </summary>
        public static short FONT_FACE_RULE { get { return SGetField<short>(LocalBridgeClazz, "FONT_FACE_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#IMPORT_RULE"/>
        /// </summary>
        public static short IMPORT_RULE { get { return SGetField<short>(LocalBridgeClazz, "IMPORT_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#MEDIA_RULE"/>
        /// </summary>
        public static short MEDIA_RULE { get { return SGetField<short>(LocalBridgeClazz, "MEDIA_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#PAGE_RULE"/>
        /// </summary>
        public static short PAGE_RULE { get { return SGetField<short>(LocalBridgeClazz, "PAGE_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#STYLE_RULE"/>
        /// </summary>
        public static short STYLE_RULE { get { return SGetField<short>(LocalBridgeClazz, "STYLE_RULE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#UNKNOWN_RULE"/>
        /// </summary>
        public static short UNKNOWN_RULE { get { return SGetField<short>(LocalBridgeClazz, "UNKNOWN_RULE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#setCssText(java.lang.String)"/>
        /// </summary>
        public string CssText
        {
            get { return IExecute<string>("getCssText"); } set { IExecute("setCssText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentRule()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSRule ParentRule
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSRule>("getParentRule"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getParentStyleSheet()"/> 
        /// </summary>
        public Org.W3c.Dom.Css.CSSStyleSheet ParentStyleSheet
        {
            get { return IExecute<Org.W3c.Dom.Css.CSSStyleSheet>("getParentStyleSheet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSRule.html#getType()"/> 
        /// </summary>
        public short Type
        {
            get { return IExecute<short>("getType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}