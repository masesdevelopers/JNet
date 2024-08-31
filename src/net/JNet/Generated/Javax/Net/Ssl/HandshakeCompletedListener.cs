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

namespace Javax.Net.Ssl
{
    #region HandshakeCompletedListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html"/>
    /// </summary>
    public partial class HandshakeCompletedListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HandshakeCompletedListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.net.ssl.HandshakeCompletedListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region HandshakeCompletedListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="HandshakeCompletedListener"/> or its generic type if there is one
    /// </summary>
    public partial class HandshakeCompletedListenerDirect : HandshakeCompletedListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.net.ssl.HandshakeCompletedListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IHandshakeCompletedListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.net.ssl.HandshakeCompletedListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html"/>
    /// </summary>
    public partial interface IHandshakeCompletedListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedEvent"/></param>
        void HandshakeCompleted(Javax.Net.Ssl.HandshakeCompletedEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HandshakeCompletedListener implementation
    public partial class HandshakeCompletedListener : Javax.Net.Ssl.IHandshakeCompletedListener
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
        /// Handlers initializer for <see cref="HandshakeCompletedListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("handshakeCompleted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.HandshakeCompletedEvent>>>(HandshakeCompletedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnHandshakeCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Net.Ssl.HandshakeCompletedEvent> OnHandshakeCompleted { get; set; } = null;

        void HandshakeCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Net.Ssl.HandshakeCompletedEvent>> data)
        {
            var methodToExecute = (OnHandshakeCompleted != null) ? OnHandshakeCompleted : HandshakeCompleted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedEvent"/></param>
        public virtual void HandshakeCompleted(Javax.Net.Ssl.HandshakeCompletedEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HandshakeCompletedListenerDirect implementation
    public partial class HandshakeCompletedListenerDirect : Javax.Net.Ssl.IHandshakeCompletedListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedListener.html#handshakeCompleted(javax.net.ssl.HandshakeCompletedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedEvent"/></param>
        public override void HandshakeCompleted(Javax.Net.Ssl.HandshakeCompletedEvent arg0)
        {
            IExecuteWithSignature("handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}