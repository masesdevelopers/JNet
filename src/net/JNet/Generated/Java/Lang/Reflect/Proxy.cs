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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region Proxy
    public partial class Proxy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Proxy.html#isProxyClass(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsProxyClass(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isProxyClass", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Proxy.html#newProxyInstance(java.lang.ClassLoader,java.lang.Class[],java.lang.reflect.InvocationHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.InvocationHandler"/></param>
        /// <returns><see cref="object"/></returns>
        public static object NewProxyInstance(Java.Lang.ClassLoader arg0, Java.Lang.Class[] arg1, Java.Lang.Reflect.InvocationHandler arg2)
        {
            return SExecute(LocalBridgeClazz, "newProxyInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Proxy.html#getInvocationHandler(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Reflect.InvocationHandler"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Java.Lang.Reflect.InvocationHandler GetInvocationHandler(object arg0)
        {
            return SExecuteWithSignature<Java.Lang.Reflect.InvocationHandler>(LocalBridgeClazz, "getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;", arg0);
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