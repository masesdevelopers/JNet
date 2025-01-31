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
    #region NetworkInterface declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html"/>
    /// </summary>
    public partial class NetworkInterface : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NetworkInterface>
    {
        const string _bridgeClassName = "java.net.NetworkInterface";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NetworkInterface() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NetworkInterface(params object[] args) : base(args) { }

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

    #region NetworkInterface implementation
    public partial class NetworkInterface
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByIndex(int arg0)
        {
            return SExecuteWithSignature<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByIndex", "(I)Ljava/net/NetworkInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByInetAddress(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByInetAddress(Java.Net.InetAddress arg0)
        {
            return SExecuteWithSignature<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getNetworkInterfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Util.Enumeration<Java.Net.NetworkInterface> GetNetworkInterfaces()
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Net.NetworkInterface>>(LocalBridgeClazz, "getNetworkInterfaces", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#networkInterfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Util.Stream.Stream<Java.Net.NetworkInterface> NetworkInterfaces()
        {
            return SExecuteWithSignature<Java.Util.Stream.Stream<Java.Net.NetworkInterface>>(LocalBridgeClazz, "networkInterfaces", "()Ljava/util/stream/Stream;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getDisplayName()"/> 
        /// </summary>
        public Java.Lang.String DisplayName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getHardwareAddress()"/> 
        /// </summary>
        public byte[] HardwareAddress
        {
            get { return IExecuteWithSignatureArray<byte>("getHardwareAddress", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecuteWithSignature<int>("getIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getInterfaceAddresses()"/> 
        /// </summary>
        public Java.Util.List<Java.Net.InterfaceAddress> InterfaceAddresses
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Net.InterfaceAddress>>("getInterfaceAddresses", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getMTU()"/> 
        /// </summary>
        public int MTU
        {
            get { return IExecuteWithSignature<int>("getMTU", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getParent()"/> 
        /// </summary>
        public Java.Net.NetworkInterface Parent
        {
            get { return IExecuteWithSignature<Java.Net.NetworkInterface>("getParent", "()Ljava/net/NetworkInterface;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isLoopback()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsLoopback()
        {
            return IExecuteWithSignature<bool>("isLoopback", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isPointToPoint()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsPointToPoint()
        {
            return IExecuteWithSignature<bool>("isPointToPoint", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isUp()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsUp()
        {
            return IExecuteWithSignature<bool>("isUp", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isVirtual()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVirtual()
        {
            return IExecuteWithSignature<bool>("isVirtual", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#supportsMulticast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool SupportsMulticast()
        {
            return IExecuteWithSignature<bool>("supportsMulticast", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getInetAddresses()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Net.InetAddress> GetInetAddresses()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Net.InetAddress>>("getInetAddresses", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getSubInterfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Net.NetworkInterface> GetSubInterfaces()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Net.NetworkInterface>>("getSubInterfaces", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#inetAddresses()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Net.InetAddress> InetAddresses()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Net.InetAddress>>("inetAddresses", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#subInterfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Net.NetworkInterface> SubInterfaces()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Net.NetworkInterface>>("subInterfaces", "()Ljava/util/stream/Stream;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}