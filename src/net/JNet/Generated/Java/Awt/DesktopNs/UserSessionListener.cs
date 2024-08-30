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

namespace Java.Awt.DesktopNs
{
    #region UserSessionListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html"/>
    /// </summary>
    public partial class UserSessionListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UserSessionListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.desktop.UserSessionListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region UserSessionListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="UserSessionListener"/> or its generic type if there is one
    /// </summary>
    public partial class UserSessionListenerDirect : UserSessionListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.desktop.UserSessionListener";
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

    #region IUserSessionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.UserSessionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html"/>
    /// </summary>
    public partial interface IUserSessionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        void UserSessionActivated(Java.Awt.DesktopNs.UserSessionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        void UserSessionDeactivated(Java.Awt.DesktopNs.UserSessionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UserSessionListener implementation
    public partial class UserSessionListener : Java.Awt.DesktopNs.IUserSessionListener
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
        /// Handlers initializer for <see cref="UserSessionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("userSessionActivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>>>(UserSessionActivatedEventHandler));
            AddEventHandler("userSessionDeactivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>>>(UserSessionDeactivatedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUserSessionActivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.UserSessionEvent> OnUserSessionActivated { get; set; } = null;

        void UserSessionActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>> data)
        {
            var methodToExecute = (OnUserSessionActivated != null) ? OnUserSessionActivated : UserSessionActivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public virtual void UserSessionActivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUserSessionDeactivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.UserSessionEvent> OnUserSessionDeactivated { get; set; } = null;

        void UserSessionDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>> data)
        {
            var methodToExecute = (OnUserSessionDeactivated != null) ? OnUserSessionDeactivated : UserSessionDeactivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public virtual void UserSessionDeactivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UserSessionListenerDirect implementation
    public partial class UserSessionListenerDirect : Java.Awt.DesktopNs.IUserSessionListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public override void UserSessionActivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            IExecuteWithSignature("userSessionActivated", "(Ljava/awt/desktop/UserSessionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public override void UserSessionDeactivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            IExecuteWithSignature("userSessionDeactivated", "(Ljava/awt/desktop/UserSessionEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}