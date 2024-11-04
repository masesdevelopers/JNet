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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region Socket declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html"/>
    /// </summary>
    public partial class Socket : Java.Io.Closeable
    {
        const string _bridgeClassName = "java.net.Socket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Socket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Socket(params object[] args) : base(args) { }

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

    #region Socket implementation
    public partial class Socket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.lang.String,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Lang.String arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Net.UnknownHostException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.InetAddress,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Net.InetAddress arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Net.InetAddress arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.Proxy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Proxy"/></param>
        public Socket(Java.Net.Proxy arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSocketImplFactory(java.net.SocketImplFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketImplFactory"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void SetSocketImplFactory(Java.Net.SocketImplFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setSocketImplFactory", "(Ljava/net/SocketImplFactory;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getChannel()"/> 
        /// </summary>
        public Java.Nio.Channels.SocketChannel Channel
        {
            get { return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("getChannel", "()Ljava/nio/channels/SocketChannel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getInetAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress InetAddress
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getInetAddress", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getKeepAlive()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setKeepAlive(boolean)"/>
        /// </summary>
        public bool KeepAlive
        {
            get { return IExecuteWithSignature<bool>("getKeepAlive", "()Z"); } set { IExecuteWithSignature("setKeepAlive", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getLocalAddress", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalPort()"/> 
        /// </summary>
        public int LocalPort
        {
            get { return IExecuteWithSignature<int>("getLocalPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalSocketAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalSocketAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOOBInline()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setOOBInline(boolean)"/>
        /// </summary>
        public bool OOBInline
        {
            get { return IExecuteWithSignature<bool>("getOOBInline", "()Z"); } set { IExecuteWithSignature("setOOBInline", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecuteWithSignature<int>("getPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getReceiveBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        public int ReceiveBufferSize
        {
            get { return IExecuteWithSignature<int>("getReceiveBufferSize", "()I"); } set { IExecuteWithSignature("setReceiveBufferSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getRemoteSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteSocketAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getRemoteSocketAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getReuseAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setReuseAddress(boolean)"/>
        /// </summary>
        public bool ReuseAddress
        {
            get { return IExecuteWithSignature<bool>("getReuseAddress", "()Z"); } set { IExecuteWithSignature("setReuseAddress", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSendBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSendBufferSize(int)"/>
        /// </summary>
        public int SendBufferSize
        {
            get { return IExecuteWithSignature<int>("getSendBufferSize", "()I"); } set { IExecuteWithSignature("setSendBufferSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSoLinger()"/> 
        /// </summary>
        public int SoLinger
        {
            get { return IExecuteWithSignature<int>("getSoLinger", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSoTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSoTimeout(int)"/>
        /// </summary>
        public int SoTimeout
        {
            get { return IExecuteWithSignature<int>("getSoTimeout", "()I"); } set { IExecuteWithSignature("setSoTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getTcpNoDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setTcpNoDelay(boolean)"/>
        /// </summary>
        public bool TcpNoDelay
        {
            get { return IExecuteWithSignature<bool>("getTcpNoDelay", "()Z"); } set { IExecuteWithSignature("setTcpNoDelay", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getTrafficClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setTrafficClass(int)"/>
        /// </summary>
        public int TrafficClass
        {
            get { return IExecuteWithSignature<int>("getTrafficClass", "()I"); } set { IExecuteWithSignature("setTrafficClass", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket SetOption<T>(Java.Net.SocketOption<T> arg0, T arg1)
        {
            return IExecuteWithSignature<Java.Net.Socket>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/net/Socket;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOption(java.net.SocketOption)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public T GetOption<T>(Java.Net.SocketOption<T> arg0)
        {
            return IExecuteWithSignature<T>("getOption", "(Ljava/net/SocketOption;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isBound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecuteWithSignature<bool>("isBound", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isInputShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInputShutdown()
        {
            return IExecuteWithSignature<bool>("isInputShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isOutputShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputShutdown()
        {
            return IExecuteWithSignature<bool>("isOutputShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#supportedOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Net.SocketOption<object>> SupportedOptions()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Net.SocketOption<object>>>("supportedOptions", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Bind(Java.Net.SocketAddress arg0)
        {
            IExecuteWithSignature("bind", "(Ljava/net/SocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#connect(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Java.Net.SocketAddress arg0, int arg1)
        {
            IExecuteWithSignature("connect", "(Ljava/net/SocketAddress;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Java.Net.SocketAddress arg0)
        {
            IExecuteWithSignature("connect", "(Ljava/net/SocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#sendUrgentData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SendUrgentData(int arg0)
        {
            IExecuteWithSignature("sendUrgentData", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setPerformancePreferences(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetPerformancePreferences(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setPerformancePreferences", "(III)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSoLinger(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetSoLinger(bool arg0, int arg1)
        {
            IExecuteWithSignature("setSoLinger", "(ZI)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#shutdownInput()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownInput()
        {
            IExecuteWithSignature("shutdownInput", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#shutdownOutput()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownOutput()
        {
            IExecuteWithSignature("shutdownOutput", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}