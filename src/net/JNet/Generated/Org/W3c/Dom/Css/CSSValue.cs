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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Css
{
    #region CSSValue declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html"/>
    /// </summary>
    public partial class CSSValue : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CSSValue>
    {
        const string _bridgeClassName = "org.w3c.dom.css.CSSValue";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CSSValue class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CSSValue() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CSSValue class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CSSValue(params object[] args) : base(args) { }

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

    #region ICSSValue
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICSSValue
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#setCssText(java.lang.String)"/>
        /// </summary>
        Java.Lang.String CssText { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssValueType()"/> 
        /// </summary>
        short CssValueType { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CSSValue implementation
    public partial class CSSValue : Org.W3c.Dom.Css.ICSSValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_CUSTOM"/>
        /// </summary>
        public static short CSS_CUSTOM { get { if (!_CSS_CUSTOMReady) { _CSS_CUSTOMContent = SGetField<short>(LocalBridgeClazz, "CSS_CUSTOM"); _CSS_CUSTOMReady = true; } return _CSS_CUSTOMContent; } }
        private static short _CSS_CUSTOMContent = default;
        private static bool _CSS_CUSTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_INHERIT"/>
        /// </summary>
        public static short CSS_INHERIT { get { if (!_CSS_INHERITReady) { _CSS_INHERITContent = SGetField<short>(LocalBridgeClazz, "CSS_INHERIT"); _CSS_INHERITReady = true; } return _CSS_INHERITContent; } }
        private static short _CSS_INHERITContent = default;
        private static bool _CSS_INHERITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_PRIMITIVE_VALUE"/>
        /// </summary>
        public static short CSS_PRIMITIVE_VALUE { get { if (!_CSS_PRIMITIVE_VALUEReady) { _CSS_PRIMITIVE_VALUEContent = SGetField<short>(LocalBridgeClazz, "CSS_PRIMITIVE_VALUE"); _CSS_PRIMITIVE_VALUEReady = true; } return _CSS_PRIMITIVE_VALUEContent; } }
        private static short _CSS_PRIMITIVE_VALUEContent = default;
        private static bool _CSS_PRIMITIVE_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#CSS_VALUE_LIST"/>
        /// </summary>
        public static short CSS_VALUE_LIST { get { if (!_CSS_VALUE_LISTReady) { _CSS_VALUE_LISTContent = SGetField<short>(LocalBridgeClazz, "CSS_VALUE_LIST"); _CSS_VALUE_LISTReady = true; } return _CSS_VALUE_LISTContent; } }
        private static short _CSS_VALUE_LISTContent = default;
        private static bool _CSS_VALUE_LISTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#setCssText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CssText
        {
            get { return IExecute<Java.Lang.String>("getCssText"); } set { IExecute("setCssText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/css/CSSValue.html#getCssValueType()"/> 
        /// </summary>
        public short CssValueType
        {
            get { return IExecute<short>("getCssValueType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}