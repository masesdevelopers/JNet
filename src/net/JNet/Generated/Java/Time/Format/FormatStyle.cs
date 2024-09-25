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
    #region FormatStyle declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html"/>
    /// </summary>
    public partial class FormatStyle : Java.Lang.Enum<Java.Time.Format.FormatStyle>
    {
        const string _bridgeClassName = "java.time.format.FormatStyle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FormatStyle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FormatStyle(params object[] args) : base(args) { }

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

    #region FormatStyle implementation
    public partial class FormatStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle FULL { get { if (!_FULLReady) { _FULLContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static Java.Time.Format.FormatStyle _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#LONG"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle LONG { get { if (!_LONGReady) { _LONGContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
        private static Java.Time.Format.FormatStyle _LONGContent = default;
        private static bool _LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#MEDIUM"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle MEDIUM { get { if (!_MEDIUMReady) { _MEDIUMContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "MEDIUM"); _MEDIUMReady = true; } return _MEDIUMContent; } }
        private static Java.Time.Format.FormatStyle _MEDIUMContent = default;
        private static bool _MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.FormatStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static Java.Time.Format.FormatStyle _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.FormatStyle"/></returns>
        public static Java.Time.Format.FormatStyle ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/FormatStyle.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.FormatStyle"/></returns>
        public static Java.Time.Format.FormatStyle[] Values()
        {
            return SExecuteArray<Java.Time.Format.FormatStyle>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}