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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region SimpleTimeZone declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html"/>
    /// </summary>
    public partial class SimpleTimeZone : Java.Util.TimeZone
    {
        const string _bridgeClassName = "java.util.SimpleTimeZone";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleTimeZone() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleTimeZone(params object[] args) : base(args) { }

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

    #region SimpleTimeZone implementation
    public partial class SimpleTimeZone
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#%3Cinit%3E(int,java.lang.String,int,int,int,int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <param name="arg12"><see cref="int"/></param>
        public SimpleTimeZone(int arg0, Java.Lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#%3Cinit%3E(int,java.lang.String,int,int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public SimpleTimeZone(int arg0, Java.Lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#%3Cinit%3E(int,java.lang.String,int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public SimpleTimeZone(int arg0, Java.Lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#%3Cinit%3E(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public SimpleTimeZone(int arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#STANDARD_TIME"/>
        /// </summary>
        public static int STANDARD_TIME { get { if (!_STANDARD_TIMEReady) { _STANDARD_TIMEContent = SGetField<int>(LocalBridgeClazz, "STANDARD_TIME"); _STANDARD_TIMEReady = true; } return _STANDARD_TIMEContent; } }
        private static int _STANDARD_TIMEContent = default;
        private static bool _STANDARD_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#UTC_TIME"/>
        /// </summary>
        public static int UTC_TIME { get { if (!_UTC_TIMEReady) { _UTC_TIMEContent = SGetField<int>(LocalBridgeClazz, "UTC_TIME"); _UTC_TIMEReady = true; } return _UTC_TIMEContent; } }
        private static int _UTC_TIMEContent = default;
        private static bool _UTC_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#WALL_TIME"/>
        /// </summary>
        public static int WALL_TIME { get { if (!_WALL_TIMEReady) { _WALL_TIMEContent = SGetField<int>(LocalBridgeClazz, "WALL_TIME"); _WALL_TIMEReady = true; } return _WALL_TIMEContent; } }
        private static int _WALL_TIMEContent = default;
        private static bool _WALL_TIMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setDSTSavings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDSTSavings(int arg0)
        {
            IExecuteWithSignature("setDSTSavings", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setEndRule(int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public void SetEndRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
        {
            IExecuteWithSignature("setEndRule", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setEndRule(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetEndRule(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setEndRule", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setEndRule(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetEndRule(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setEndRule", "(III)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setStartRule(int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public void SetStartRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
        {
            IExecuteWithSignature("setStartRule", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setStartRule(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetStartRule(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setStartRule", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setStartRule(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetStartRule(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setStartRule", "(III)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SimpleTimeZone.html#setStartYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStartYear(int arg0)
        {
            IExecuteWithSignature("setStartYear", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}