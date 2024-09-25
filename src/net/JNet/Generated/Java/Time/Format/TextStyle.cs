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

namespace Java.Time.Format
{
    #region TextStyle declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html"/>
    /// </summary>
    public partial class TextStyle : Java.Lang.Enum<Java.Time.Format.TextStyle>
    {
        const string _bridgeClassName = "java.time.format.TextStyle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextStyle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextStyle(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TextStyle implementation
    public partial class TextStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL { get { if (!_FULLReady) { _FULLContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static Java.Time.Format.TextStyle _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL_STANDALONE { get { if (!_FULL_STANDALONEReady) { _FULL_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL_STANDALONE"); _FULL_STANDALONEReady = true; } return _FULL_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _FULL_STANDALONEContent = default;
        private static bool _FULL_STANDALONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW { get { if (!_NARROWReady) { _NARROWContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW"); _NARROWReady = true; } return _NARROWContent; } }
        private static Java.Time.Format.TextStyle _NARROWContent = default;
        private static bool _NARROWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW_STANDALONE { get { if (!_NARROW_STANDALONEReady) { _NARROW_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW_STANDALONE"); _NARROW_STANDALONEReady = true; } return _NARROW_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _NARROW_STANDALONEContent = default;
        private static bool _NARROW_STANDALONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static Java.Time.Format.TextStyle _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT_STANDALONE { get { if (!_SHORT_STANDALONEReady) { _SHORT_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT_STANDALONE"); _SHORT_STANDALONEReady = true; } return _SHORT_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _SHORT_STANDALONEContent = default;
        private static bool _SHORT_STANDALONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Java.Time.Format.TextStyle>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle[] Values()
        {
            return SExecuteArray<Java.Time.Format.TextStyle>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#isStandalone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecute<bool>("isStandalone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asNormal()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsNormal()
        {
            return IExecute<Java.Time.Format.TextStyle>("asNormal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asStandalone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsStandalone()
        {
            return IExecute<Java.Time.Format.TextStyle>("asStandalone");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}