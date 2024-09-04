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

namespace Java.Util.Concurrent
{
    #region Executors declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html"/>
    /// </summary>
    public partial class Executors : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Executors>
    {
        const string _bridgeClassName = "java.util.concurrent.Executors";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Executors() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Executors(params object[] args) : base(args) { }

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

    #region Executors implementation
    public partial class Executors
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<T> Callable<T>(Java.Lang.Runnable arg0, T arg1)
        {
            return SExecute<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "callable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedCallable(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<T> PrivilegedCallableMethod<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<T> PrivilegedCallableUsingCurrentClassLoaderMethod<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Lang.Runnable arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Security.PrivilegedAction<object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Security.PrivilegedExceptionAction<object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newCachedThreadPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newCachedThreadPool(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newFixedThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newFixedThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newFixedThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newWorkStealingPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newWorkStealingPool", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newWorkStealingPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newWorkStealingPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#unconfigurableExecutorService(java.util.concurrent.ExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService UnconfigurableExecutorService(Java.Util.Concurrent.ExecutorService arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newScheduledThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newScheduledThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newScheduledThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService UnconfigurableScheduledExecutorService(Java.Util.Concurrent.ScheduledExecutorService arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#defaultThreadFactory()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        public static Java.Util.Concurrent.ThreadFactory DefaultThreadFactoryMethod()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ThreadFactory>(LocalBridgeClazz, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedThreadFactory()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        public static Java.Util.Concurrent.ThreadFactory PrivilegedThreadFactoryMethod()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ThreadFactory>(LocalBridgeClazz, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
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