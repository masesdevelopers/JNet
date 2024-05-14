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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Invoke
{
    #region SwitchPoint
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