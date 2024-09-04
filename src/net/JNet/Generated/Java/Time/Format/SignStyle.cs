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

namespace Java.Time.Format
{
    #region SignStyle declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html"/>
    /// </summary>
    public partial class SignStyle : Java.Lang.Enum<Java.Time.Format.SignStyle>
    {
        const string _bridgeClassName = "java.time.format.SignStyle";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SignStyle() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SignStyle(params object[] args) : base(args) { }

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

    #region SignStyle implementation
    public partial class SignStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#ALWAYS"/>
        /// </summary>
        public static Java.Time.Format.SignStyle ALWAYS { get { if (!_ALWAYSReady) { _ALWAYSContent = SGetField<Java.Time.Format.SignStyle>(LocalBridgeClazz, "ALWAYS"); _ALWAYSReady = true; } return _ALWAYSContent; } }
        private static Java.Time.Format.SignStyle _ALWAYSContent = default;
        private static bool _ALWAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#EXCEEDS_PAD"/>
        /// </summary>
        public static Java.Time.Format.SignStyle EXCEEDS_PAD { get { if (!_EXCEEDS_PADReady) { _EXCEEDS_PADContent = SGetField<Java.Time.Format.SignStyle>(LocalBridgeClazz, "EXCEEDS_PAD"); _EXCEEDS_PADReady = true; } return _EXCEEDS_PADContent; } }
        private static Java.Time.Format.SignStyle _EXCEEDS_PADContent = default;
        private static bool _EXCEEDS_PADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NEVER"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NEVER { get { if (!_NEVERReady) { _NEVERContent = SGetField<Java.Time.Format.SignStyle>(LocalBridgeClazz, "NEVER"); _NEVERReady = true; } return _NEVERContent; } }
        private static Java.Time.Format.SignStyle _NEVERContent = default;
        private static bool _NEVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NORMAL"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Java.Time.Format.SignStyle>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
        private static Java.Time.Format.SignStyle _NORMALContent = default;
        private static bool _NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#NOT_NEGATIVE"/>
        /// </summary>
        public static Java.Time.Format.SignStyle NOT_NEGATIVE { get { if (!_NOT_NEGATIVEReady) { _NOT_NEGATIVEContent = SGetField<Java.Time.Format.SignStyle>(LocalBridgeClazz, "NOT_NEGATIVE"); _NOT_NEGATIVEReady = true; } return _NOT_NEGATIVEContent; } }
        private static Java.Time.Format.SignStyle _NOT_NEGATIVEContent = default;
        private static bool _NOT_NEGATIVEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.SignStyle"/></returns>
        public static Java.Time.Format.SignStyle ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.SignStyle>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/format/SignStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/SignStyle.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.SignStyle"/></returns>
        public static Java.Time.Format.SignStyle[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Format.SignStyle>(LocalBridgeClazz, "values", "()[Ljava/time/format/SignStyle;");
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