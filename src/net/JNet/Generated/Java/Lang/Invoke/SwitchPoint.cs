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

namespace Java.Lang.Invoke
{
    #region SwitchPoint declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SwitchPoint.html"/>
    /// </summary>
    public partial class SwitchPoint : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SwitchPoint>
    {
        const string _bridgeClassName = "java.lang.invoke.SwitchPoint";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SwitchPoint() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SwitchPoint(params object[] args) : base(args) { }

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

    #region SwitchPoint implementation
    public partial class SwitchPoint
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SwitchPoint.html#invalidateAll(java.lang.invoke.SwitchPoint[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.SwitchPoint"/></param>
        public static void InvalidateAll(Java.Lang.Invoke.SwitchPoint[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "invalidateAll", "([Ljava/lang/invoke/SwitchPoint;)V", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SwitchPoint.html#hasBeenInvalidated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBeenInvalidated()
        {
            return IExecuteWithSignature<bool>("hasBeenInvalidated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/SwitchPoint.html#guardWithTest(java.lang.invoke.MethodHandle,java.lang.invoke.MethodHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodHandle"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodHandle"/></returns>
        public Java.Lang.Invoke.MethodHandle GuardWithTest(Java.Lang.Invoke.MethodHandle arg0, Java.Lang.Invoke.MethodHandle arg1)
        {
            return IExecute<Java.Lang.Invoke.MethodHandle>("guardWithTest", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}