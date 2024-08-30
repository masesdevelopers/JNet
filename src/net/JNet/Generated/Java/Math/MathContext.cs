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
    #region MathContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html"/>
    /// </summary>
    public partial class MathContext : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.math.MathContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MathContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MathContext(params object[] args) : base(args) { }

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

    #region MathContext implementation
    public partial class MathContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(int,java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.RoundingMode"/></param>
        public MathContext(int arg0, Java.Math.RoundingMode arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public MathContext(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public MathContext(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL128"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL128 { get { if (!_DECIMAL128Ready) { _DECIMAL128Content = SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL128"); _DECIMAL128Ready = true; } return _DECIMAL128Content; } }
        private static Java.Math.MathContext _DECIMAL128Content = default;
        private static bool _DECIMAL128Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL32"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL32 { get { if (!_DECIMAL32Ready) { _DECIMAL32Content = SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL32"); _DECIMAL32Ready = true; } return _DECIMAL32Content; } }
        private static Java.Math.MathContext _DECIMAL32Content = default;
        private static bool _DECIMAL32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL64"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL64 { get { if (!_DECIMAL64Ready) { _DECIMAL64Content = SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL64"); _DECIMAL64Ready = true; } return _DECIMAL64Content; } }
        private static Java.Math.MathContext _DECIMAL64Content = default;
        private static bool _DECIMAL64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#UNLIMITED"/>
        /// </summary>
        public static Java.Math.MathContext UNLIMITED { get { if (!_UNLIMITEDReady) { _UNLIMITEDContent = SGetField<Java.Math.MathContext>(LocalBridgeClazz, "UNLIMITED"); _UNLIMITEDReady = true; } return _UNLIMITEDContent; } }
        private static Java.Math.MathContext _UNLIMITEDContent = default;
        private static bool _UNLIMITEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#getPrecision()"/> 
        /// </summary>
        public int Precision
        {
            get { return IExecuteWithSignature<int>("getPrecision", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#getRoundingMode()"/> 
        /// </summary>
        public Java.Math.RoundingMode RoundingMode
        {
            get { return IExecuteWithSignature<Java.Math.RoundingMode>("getRoundingMode", "()Ljava/math/RoundingMode;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}