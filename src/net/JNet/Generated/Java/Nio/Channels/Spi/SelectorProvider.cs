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

namespace Java.Nio.Channels.Spi
{
    #region SelectorProvider definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html"/>
    /// </summary>
    public partial class SelectorProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SelectorProvider>
    {
        const string _bridgeClassName = "java.nio.channels.spi.SelectorProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SelectorProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectorProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SelectorProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectorProvider(params object[] args) : base(args) { }

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

    #region SelectorProvider
    public partial class SelectorProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.SelectorProvider"/></returns>
        public static Java.Nio.Channels.Spi.SelectorProvider Provider()
        {
            return SExecuteWithSignature<Java.Nio.Channels.Spi.SelectorProvider>(LocalBridgeClazz, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openDatagramChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel OpenDatagramChannel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.DatagramChannel>("openDatagramChannel", "()Ljava/nio/channels/DatagramChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openDatagramChannel(java.net.ProtocolFamily)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProtocolFamily"/></param>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel OpenDatagramChannel(Java.Net.ProtocolFamily arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.DatagramChannel>("openDatagramChannel", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openPipe()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Pipe"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Pipe OpenPipe()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Pipe>("openPipe", "()Ljava/nio/channels/Pipe;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openServerSocketChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.ServerSocketChannel OpenServerSocketChannel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.ServerSocketChannel>("openServerSocketChannel", "()Ljava/nio/channels/ServerSocketChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openSocketChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel OpenSocketChannel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("openSocketChannel", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openSelector()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.AbstractSelector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Spi.AbstractSelector OpenSelector()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Spi.AbstractSelector>("openSelector", "()Ljava/nio/channels/spi/AbstractSelector;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#inheritedChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Channel InheritedChannel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Channel>("inheritedChannel", "()Ljava/nio/channels/Channel;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}