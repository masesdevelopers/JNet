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

namespace Java.Nio.Channels
{
    #region AsynchronousChannelGroup declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html"/>
    /// </summary>
    public partial class AsynchronousChannelGroup : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AsynchronousChannelGroup>
    {
        const string _bridgeClassName = "java.nio.channels.AsynchronousChannelGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AsynchronousChannelGroup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousChannelGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AsynchronousChannelGroup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousChannelGroup(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region AsynchronousChannelGroup implementation
    public partial class AsynchronousChannelGroup
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#withCachedThreadPool(java.util.concurrent.ExecutorService,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousChannelGroup WithCachedThreadPool(Java.Util.Concurrent.ExecutorService arg0, int arg1)
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousChannelGroup>(LocalBridgeClazz, "withCachedThreadPool", "(Ljava/util/concurrent/ExecutorService;I)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#withFixedThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousChannelGroup WithFixedThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousChannelGroup>(LocalBridgeClazz, "withFixedThreadPool", "(ILjava/util/concurrent/ThreadFactory;)Ljava/nio/channels/AsynchronousChannelGroup;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#withThreadPool(java.util.concurrent.ExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousChannelGroup WithThreadPool(Java.Util.Concurrent.ExecutorService arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousChannelGroup>(LocalBridgeClazz, "withThreadPool", "(Ljava/util/concurrent/ExecutorService;)Ljava/nio/channels/AsynchronousChannelGroup;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#awaitTermination(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool AwaitTermination(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecuteWithSignature<bool>("awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#isShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShutdown()
        {
            return IExecuteWithSignature<bool>("isShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#isTerminated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTerminated()
        {
            return IExecuteWithSignature<bool>("isTerminated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecuteWithSignature("shutdown", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#shutdownNow()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownNow()
        {
            IExecuteWithSignature("shutdownNow", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/AsynchronousChannelGroup.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.AsynchronousChannelProvider"/></returns>
        public Java.Nio.Channels.Spi.AsynchronousChannelProvider Provider()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Spi.AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}