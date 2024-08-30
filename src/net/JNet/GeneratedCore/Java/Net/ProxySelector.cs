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

namespace Java.Net
{
    #region ProxySelector definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html"/>
    /// </summary>
    public partial class ProxySelector : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ProxySelector>
    {
        const string _bridgeClassName = "java.net.ProxySelector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ProxySelector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProxySelector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ProxySelector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProxySelector(params object[] args) : base(args) { }

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

    #region ProxySelector
    public partial class ProxySelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#getDefault()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#setDefault(java.net.ProxySelector)"/>
        /// </summary>
        public static Java.Net.ProxySelector Default
        {
            get { return SExecuteWithSignature<Java.Net.ProxySelector>(LocalBridgeClazz, "getDefault", "()Ljava/net/ProxySelector;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Ljava/net/ProxySelector;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#of(java.net.InetSocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetSocketAddress"/></param>
        /// <returns><see cref="Java.Net.ProxySelector"/></returns>
        public static Java.Net.ProxySelector Of(Java.Net.InetSocketAddress arg0)
        {
            return SExecuteWithSignature<Java.Net.ProxySelector>(LocalBridgeClazz, "of", "(Ljava/net/InetSocketAddress;)Ljava/net/ProxySelector;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#select(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.Proxy> Select(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.Proxy>>("select", "(Ljava/net/URI;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#connectFailed(java.net.URI,java.net.SocketAddress,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg2"><see cref="Java.Io.IOException"/></param>
        public void ConnectFailed(Java.Net.URI arg0, Java.Net.SocketAddress arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            IExecute("connectFailed", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}