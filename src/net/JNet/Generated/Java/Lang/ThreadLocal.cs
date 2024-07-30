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

namespace Java.Lang
{
    #region ThreadLocal
    public partial class ThreadLocal
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#withInitial(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Java.Lang.ThreadLocal"/></returns>
        public static Java.Lang.ThreadLocal WithInitial(Java.Util.Function.Supplier arg0)
        {
            return SExecuteWithSignature<Java.Lang.ThreadLocal>(LocalBridgeClazz, "withInitial", "(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecuteWithSignature("remove", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Set(object arg0)
        {
            IExecuteWithSignature("set", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ThreadLocal<T>
    public partial class ThreadLocal<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.ThreadLocal{T}"/> to <see cref="Java.Lang.ThreadLocal"/>
        /// </summary>
        public static implicit operator Java.Lang.ThreadLocal(Java.Lang.ThreadLocal<T> t) => t.Cast<Java.Lang.ThreadLocal>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#withInitial(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="Arg0ExtendsS"><typeparamref name="S"/></typeparam>
        /// <returns><see cref="Java.Lang.ThreadLocal"/></returns>
        public static Java.Lang.ThreadLocal<S> WithInitial<S, Arg0ExtendsS>(Java.Util.Function.Supplier<Arg0ExtendsS> arg0) where Arg0ExtendsS : S
        {
            return SExecuteWithSignature<Java.Lang.ThreadLocal<S>>(LocalBridgeClazz, "withInitial", "(Ljava/util/function/Supplier;)Ljava/lang/ThreadLocal;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecuteWithSignature("remove", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadLocal.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void Set(T arg0)
        {
            IExecuteWithSignature("set", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}