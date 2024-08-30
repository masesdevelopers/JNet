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

namespace Java.Nio.Channels
{
    #region SelectableChannel definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html"/>
    /// </summary>
    public partial class SelectableChannel : Java.Nio.Channels.Spi.AbstractInterruptibleChannel
    {
        const string _bridgeClassName = "java.nio.channels.SelectableChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SelectableChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectableChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SelectableChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectableChannel(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region SelectableChannel
    public partial class SelectableChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#isBlocking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBlocking()
        {
            return IExecuteWithSignature<bool>("isBlocking", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#isRegistered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegistered()
        {
            return IExecuteWithSignature<bool>("isRegistered", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#validOps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ValidOps()
        {
            return IExecuteWithSignature<int>("validOps", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#blockingLock()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object BlockingLock()
        {
            return IExecuteWithSignature("blockingLock", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#configureBlocking(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectableChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SelectableChannel ConfigureBlocking(bool arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.SelectableChannel>("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#keyFor(java.nio.channels.Selector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.Selector"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectionKey"/></returns>
        public Java.Nio.Channels.SelectionKey KeyFor(Java.Nio.Channels.Selector arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.SelectionKey>("keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#register(java.nio.channels.Selector,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.Selector"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectionKey"/></returns>
        /// <exception cref="Java.Nio.Channels.ClosedChannelException"/>
        public Java.Nio.Channels.SelectionKey Register(Java.Nio.Channels.Selector arg0, int arg1, object arg2)
        {
            return IExecute<Java.Nio.Channels.SelectionKey>("register", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.SelectorProvider"/></returns>
        public Java.Nio.Channels.Spi.SelectorProvider Provider()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Spi.SelectorProvider>("provider", "()Ljava/nio/channels/spi/SelectorProvider;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectableChannel.html#register(java.nio.channels.Selector,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.Selector"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectionKey"/></returns>
        /// <exception cref="Java.Nio.Channels.ClosedChannelException"/>
        public Java.Nio.Channels.SelectionKey Register(Java.Nio.Channels.Selector arg0, int arg1)
        {
            return IExecute<Java.Nio.Channels.SelectionKey>("register", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}