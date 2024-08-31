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

namespace Javax.Naming.Ldap
{
    #region UnsolicitedNotificationListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html"/>
    /// </summary>
    public partial class UnsolicitedNotificationListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UnsolicitedNotificationListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.naming.ldap.UnsolicitedNotificationListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region UnsolicitedNotificationListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="UnsolicitedNotificationListener"/> or its generic type if there is one
    /// </summary>
    public partial class UnsolicitedNotificationListenerDirect : UnsolicitedNotificationListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.naming.ldap.UnsolicitedNotificationListener";
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

    #region IUnsolicitedNotificationListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.naming.ldap.UnsolicitedNotificationListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html"/>
    /// </summary>
    public partial interface IUnsolicitedNotificationListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html#notificationReceived(javax.naming.ldap.UnsolicitedNotificationEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.UnsolicitedNotificationEvent"/></param>
        void NotificationReceived(Javax.Naming.Ldap.UnsolicitedNotificationEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnsolicitedNotificationListener implementation
    public partial class UnsolicitedNotificationListener : Javax.Naming.Ldap.IUnsolicitedNotificationListener
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
        /// Handlers initializer for <see cref="UnsolicitedNotificationListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("namingExceptionThrown", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>>>(NamingExceptionThrownEventHandler));
            AddEventHandler("notificationReceived", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Ldap.UnsolicitedNotificationEvent>>>(NotificationReceivedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNamingExceptionThrown"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Event.NamingExceptionEvent> OnNamingExceptionThrown { get; set; } = null;

        void NamingExceptionThrownEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>> data)
        {
            var methodToExecute = (OnNamingExceptionThrown != null) ? OnNamingExceptionThrown : NamingExceptionThrown;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public virtual void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html#notificationReceived(javax.naming.ldap.UnsolicitedNotificationEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotificationReceived"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Ldap.UnsolicitedNotificationEvent> OnNotificationReceived { get; set; } = null;

        void NotificationReceivedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Ldap.UnsolicitedNotificationEvent>> data)
        {
            var methodToExecute = (OnNotificationReceived != null) ? OnNotificationReceived : NotificationReceived;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html#notificationReceived(javax.naming.ldap.UnsolicitedNotificationEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.UnsolicitedNotificationEvent"/></param>
        public virtual void NotificationReceived(Javax.Naming.Ldap.UnsolicitedNotificationEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnsolicitedNotificationListenerDirect implementation
    public partial class UnsolicitedNotificationListenerDirect : Javax.Naming.Ldap.IUnsolicitedNotificationListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public override void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            IExecute("namingExceptionThrown", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationListener.html#notificationReceived(javax.naming.ldap.UnsolicitedNotificationEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.UnsolicitedNotificationEvent"/></param>
        public override void NotificationReceived(Javax.Naming.Ldap.UnsolicitedNotificationEvent arg0)
        {
            IExecuteWithSignature("notificationReceived", "(Ljavax/naming/ldap/UnsolicitedNotificationEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}