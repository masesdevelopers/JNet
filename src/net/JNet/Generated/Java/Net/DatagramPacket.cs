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

namespace Java.Net
{
    #region DatagramPacket declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html"/>
    /// </summary>
    public partial class DatagramPacket : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DatagramPacket>
    {
        const string _bridgeClassName = "java.net.DatagramPacket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DatagramPacket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DatagramPacket(params object[] args) : base(args) { }

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

    #region DatagramPacket implementation
    public partial class DatagramPacket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public DatagramPacket(byte[] arg0, int arg1, int arg2, Java.Net.InetAddress arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int,int,java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Net.SocketAddress"/></param>
        public DatagramPacket(byte[] arg0, int arg1, int arg2, Java.Net.SocketAddress arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public DatagramPacket(byte[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DatagramPacket(byte[] arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int,java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.SocketAddress"/></param>
        public DatagramPacket(byte[] arg0, int arg1, Java.Net.SocketAddress arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#%3Cinit%3E(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public DatagramPacket(byte[] arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setAddress(java.net.InetAddress)"/>
        /// </summary>
        public Java.Net.InetAddress Address
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getAddress", "()Ljava/net/InetAddress;"); } set { IExecuteWithSignature("setAddress", "(Ljava/net/InetAddress;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getData()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setData(byte[])"/>
        /// </summary>
        public byte[] Data
        {
            get { return IExecuteWithSignatureArray<byte>("getData", "()[B"); } set { IExecuteWithSignature("setData", "([B)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getLength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setLength(int)"/>
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); } set { IExecuteWithSignature("setLength", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getOffset()"/> 
        /// </summary>
        public int Offset
        {
            get { return IExecuteWithSignature<int>("getOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getPort()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setPort(int)"/>
        /// </summary>
        public int Port
        {
            get { return IExecuteWithSignature<int>("getPort", "()I"); } set { IExecuteWithSignature("setPort", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#getSocketAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setSocketAddress(java.net.SocketAddress)"/>
        /// </summary>
        public Java.Net.SocketAddress SocketAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getSocketAddress", "()Ljava/net/SocketAddress;"); } set { IExecuteWithSignature("setSocketAddress", "(Ljava/net/SocketAddress;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramPacket.html#setData(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetData(byte[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setData", "([BII)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}