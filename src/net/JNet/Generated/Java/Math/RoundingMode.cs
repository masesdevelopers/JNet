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

namespace Java.Math
{
    #region RoundingMode definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html"/>
    /// </summary>
    public partial class RoundingMode : Java.Lang.Enum<Java.Math.RoundingMode>
    {
        const string _bridgeClassName = "java.math.RoundingMode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RoundingMode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RoundingMode(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region RoundingMode
    public partial class RoundingMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#CEILING"/>
        /// </summary>
        public static Java.Math.RoundingMode CEILING { get { if (!_CEILINGReady) { _CEILINGContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "CEILING"); _CEILINGReady = true; } return _CEILINGContent; } }
        private static Java.Math.RoundingMode _CEILINGContent = default;
        private static bool _CEILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#DOWN"/>
        /// </summary>
        public static Java.Math.RoundingMode DOWN { get { if (!_DOWNReady) { _DOWNContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "DOWN"); _DOWNReady = true; } return _DOWNContent; } }
        private static Java.Math.RoundingMode _DOWNContent = default;
        private static bool _DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#FLOOR"/>
        /// </summary>
        public static Java.Math.RoundingMode FLOOR { get { if (!_FLOORReady) { _FLOORContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "FLOOR"); _FLOORReady = true; } return _FLOORContent; } }
        private static Java.Math.RoundingMode _FLOORContent = default;
        private static bool _FLOORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_DOWN"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_DOWN { get { if (!_HALF_DOWNReady) { _HALF_DOWNContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_DOWN"); _HALF_DOWNReady = true; } return _HALF_DOWNContent; } }
        private static Java.Math.RoundingMode _HALF_DOWNContent = default;
        private static bool _HALF_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_EVEN"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_EVEN { get { if (!_HALF_EVENReady) { _HALF_EVENContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_EVEN"); _HALF_EVENReady = true; } return _HALF_EVENContent; } }
        private static Java.Math.RoundingMode _HALF_EVENContent = default;
        private static bool _HALF_EVENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#HALF_UP"/>
        /// </summary>
        public static Java.Math.RoundingMode HALF_UP { get { if (!_HALF_UPReady) { _HALF_UPContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "HALF_UP"); _HALF_UPReady = true; } return _HALF_UPContent; } }
        private static Java.Math.RoundingMode _HALF_UPContent = default;
        private static bool _HALF_UPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#UNNECESSARY"/>
        /// </summary>
        public static Java.Math.RoundingMode UNNECESSARY { get { if (!_UNNECESSARYReady) { _UNNECESSARYContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "UNNECESSARY"); _UNNECESSARYReady = true; } return _UNNECESSARYContent; } }
        private static Java.Math.RoundingMode _UNNECESSARYContent = default;
        private static bool _UNNECESSARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#UP"/>
        /// </summary>
        public static Java.Math.RoundingMode UP { get { if (!_UPReady) { _UPContent = SGetField<Java.Math.RoundingMode>(LocalBridgeClazz, "UP"); _UPReady = true; } return _UPContent; } }
        private static Java.Math.RoundingMode _UPContent = default;
        private static bool _UPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode ValueOf(int arg0)
        {
            return SExecuteWithSignature<Java.Math.RoundingMode>(LocalBridgeClazz, "valueOf", "(I)Ljava/math/RoundingMode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Math.RoundingMode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.RoundingMode"/></returns>
        public static Java.Math.RoundingMode[] Values()
        {
            return SExecuteWithSignatureArray<Java.Math.RoundingMode>(LocalBridgeClazz, "values", "()[Ljava/math/RoundingMode;");
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