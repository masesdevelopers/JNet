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
    #region AppForegroundListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html"/>
    /// </summary>
    public partial class AppForegroundListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppForegroundListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.desktop.AppForegroundListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region AppForegroundListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="AppForegroundListener"/> or its generic type if there is one
    /// </summary>
    public partial class AppForegroundListenerDirect : AppForegroundListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.desktop.AppForegroundListener";
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

    #region IAppForegroundListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.AppForegroundListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html"/>
    /// </summary>
    public partial interface IAppForegroundListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        void AppMovedToBackground(Java.Awt.DesktopNs.AppForegroundEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        void AppRaisedToForeground(Java.Awt.DesktopNs.AppForegroundEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AppForegroundListener implementation
    public partial class AppForegroundListener : Java.Awt.DesktopNs.IAppForegroundListener
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
        /// Handlers initializer for <see cref="AppForegroundListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("appMovedToBackground", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AppMovedToBackgroundEventHandler));
            AddEventHandler("appRaisedToForeground", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AppRaisedToForegroundEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppMovedToBackground"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.AppForegroundEvent> OnAppMovedToBackground { get; set; } = null;

        bool hasOverrideAppMovedToBackground = true;
        void AppMovedToBackgroundEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnAppMovedToBackground != null) ? OnAppMovedToBackground : AppMovedToBackground;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.DesktopNs.AppForegroundEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAppMovedToBackground;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public virtual void AppMovedToBackground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            hasOverrideAppMovedToBackground = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppRaisedToForeground"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.AppForegroundEvent> OnAppRaisedToForeground { get; set; } = null;

        bool hasOverrideAppRaisedToForeground = true;
        void AppRaisedToForegroundEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnAppRaisedToForeground != null) ? OnAppRaisedToForeground : AppRaisedToForeground;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.DesktopNs.AppForegroundEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAppRaisedToForeground;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public virtual void AppRaisedToForeground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            hasOverrideAppRaisedToForeground = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AppForegroundListenerDirect implementation
    public partial class AppForegroundListenerDirect : Java.Awt.DesktopNs.IAppForegroundListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public override void AppMovedToBackground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            IExecuteWithSignature("appMovedToBackground", "(Ljava/awt/desktop/AppForegroundEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public override void AppRaisedToForeground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            IExecuteWithSignature("appRaisedToForeground", "(Ljava/awt/desktop/AppForegroundEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}