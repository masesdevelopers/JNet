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

namespace Java.Nio.Channels
{
    #region ServerSocketChannel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html"/>
    /// </summary>
    public partial class ServerSocketChannel : Java.Nio.Channels.Spi.AbstractSelectableChannel
    {
        const string _bridgeClassName = "java.nio.channels.ServerSocketChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ServerSocketChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ServerSocketChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ServerSocketChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ServerSocketChannel(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region ServerSocketChannel implementation
    public partial class ServerSocketChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.ServerSocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.ServerSocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.ServerSocketChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.ServerSocketChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/ServerSocketChannel;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#socket()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.ServerSocket"/></returns>
        public Java.Net.ServerSocket Socket()
        {
            return IExecuteWithSignature<Java.Net.ServerSocket>("socket", "()Ljava/net/ServerSocket;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#bind(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.ServerSocketChannel Bind(Java.Net.SocketAddress arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Nio.Channels.ServerSocketChannel>("bind", "(Ljava/net/SocketAddress;I)Ljava/nio/channels/ServerSocketChannel;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#accept()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel Accept()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("accept", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/ServerSocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel SetOption(Java.Net.SocketOption arg0, object arg1)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/nio/channels/NetworkChannel;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}