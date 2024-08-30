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

namespace Java.Beans.Beancontext
{
    #region BeanContextServicesListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html"/>
    /// </summary>
    public partial class BeanContextServicesListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BeanContextServicesListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.beans.beancontext.BeanContextServicesListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region BeanContextServicesListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="BeanContextServicesListener"/> or its generic type if there is one
    /// </summary>
    public partial class BeanContextServicesListenerDirect : BeanContextServicesListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.beans.beancontext.BeanContextServicesListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IBeanContextServicesListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.beans.beancontext.BeanContextServicesListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html"/>
    /// </summary>
    public partial interface IBeanContextServicesListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedListener.html#serviceRevoked(java.beans.beancontext.BeanContextServiceRevokedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedEvent"/></param>
        void ServiceRevoked(Java.Beans.Beancontext.BeanContextServiceRevokedEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html#serviceAvailable(java.beans.beancontext.BeanContextServiceAvailableEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceAvailableEvent"/></param>
        void ServiceAvailable(Java.Beans.Beancontext.BeanContextServiceAvailableEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextServicesListener implementation
    public partial class BeanContextServicesListener : Java.Beans.Beancontext.IBeanContextServicesListener
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
        /// Handlers initializer for <see cref="BeanContextServicesListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("serviceRevoked", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextServiceRevokedEvent>>>(ServiceRevokedEventHandler));
            AddEventHandler("serviceAvailable", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextServiceAvailableEvent>>>(ServiceAvailableEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedListener.html#serviceRevoked(java.beans.beancontext.BeanContextServiceRevokedEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnServiceRevoked"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.Beancontext.BeanContextServiceRevokedEvent> OnServiceRevoked { get; set; } = null;

        void ServiceRevokedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextServiceRevokedEvent>> data)
        {
            var methodToExecute = (OnServiceRevoked != null) ? OnServiceRevoked : ServiceRevoked;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedListener.html#serviceRevoked(java.beans.beancontext.BeanContextServiceRevokedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedEvent"/></param>
        public virtual void ServiceRevoked(Java.Beans.Beancontext.BeanContextServiceRevokedEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html#serviceAvailable(java.beans.beancontext.BeanContextServiceAvailableEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnServiceAvailable"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.Beancontext.BeanContextServiceAvailableEvent> OnServiceAvailable { get; set; } = null;

        void ServiceAvailableEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.Beancontext.BeanContextServiceAvailableEvent>> data)
        {
            var methodToExecute = (OnServiceAvailable != null) ? OnServiceAvailable : ServiceAvailable;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html#serviceAvailable(java.beans.beancontext.BeanContextServiceAvailableEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceAvailableEvent"/></param>
        public virtual void ServiceAvailable(Java.Beans.Beancontext.BeanContextServiceAvailableEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextServicesListenerDirect implementation
    public partial class BeanContextServicesListenerDirect : Java.Beans.Beancontext.IBeanContextServicesListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedListener.html#serviceRevoked(java.beans.beancontext.BeanContextServiceRevokedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedEvent"/></param>
        public override void ServiceRevoked(Java.Beans.Beancontext.BeanContextServiceRevokedEvent arg0)
        {
            IExecute("serviceRevoked", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServicesListener.html#serviceAvailable(java.beans.beancontext.BeanContextServiceAvailableEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceAvailableEvent"/></param>
        public override void ServiceAvailable(Java.Beans.Beancontext.BeanContextServiceAvailableEvent arg0)
        {
            IExecuteWithSignature("serviceAvailable", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}