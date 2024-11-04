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

namespace Javax.Swing.Event
{
    #region InternalFrameListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html"/>
    /// </summary>
    public partial class InternalFrameListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InternalFrameListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.InternalFrameListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region InternalFrameListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="InternalFrameListener"/> or its generic type if there is one
    /// </summary>
    public partial class InternalFrameListenerDirect : InternalFrameListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.InternalFrameListener";
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

    #region IInternalFrameListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.InternalFrameListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html"/>
    /// </summary>
    public partial interface IInternalFrameListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameActivated(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameClosed(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameClosing(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameDeactivated(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameDeiconified(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameIconified(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameOpened(Javax.Swing.Event.InternalFrameEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InternalFrameListener implementation
    public partial class InternalFrameListener : Javax.Swing.Event.IInternalFrameListener
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
        /// Handlers initializer for <see cref="InternalFrameListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("internalFrameActivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameActivatedEventHandler));
            AddEventHandler("internalFrameClosed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameClosedEventHandler));
            AddEventHandler("internalFrameClosing", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameClosingEventHandler));
            AddEventHandler("internalFrameDeactivated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameDeactivatedEventHandler));
            AddEventHandler("internalFrameDeiconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameDeiconifiedEventHandler));
            AddEventHandler("internalFrameIconified", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameIconifiedEventHandler));
            AddEventHandler("internalFrameOpened", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InternalFrameOpenedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameActivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameActivated { get; set; } = null;

        bool hasOverrideInternalFrameActivated = true;
        void InternalFrameActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameActivated = true;
            var methodToExecute = (OnInternalFrameActivated != null) ? OnInternalFrameActivated : InternalFrameActivated;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameActivated;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameActivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameActivated = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosed { get; set; } = null;

        bool hasOverrideInternalFrameClosed = true;
        void InternalFrameClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameClosed = true;
            var methodToExecute = (OnInternalFrameClosed != null) ? OnInternalFrameClosed : InternalFrameClosed;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameClosed;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameClosed(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameClosed = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameClosing"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosing { get; set; } = null;

        bool hasOverrideInternalFrameClosing = true;
        void InternalFrameClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameClosing = true;
            var methodToExecute = (OnInternalFrameClosing != null) ? OnInternalFrameClosing : InternalFrameClosing;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameClosing;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameClosing(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameClosing = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameDeactivated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeactivated { get; set; } = null;

        bool hasOverrideInternalFrameDeactivated = true;
        void InternalFrameDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameDeactivated = true;
            var methodToExecute = (OnInternalFrameDeactivated != null) ? OnInternalFrameDeactivated : InternalFrameDeactivated;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameDeactivated;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameDeactivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameDeactivated = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameDeiconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeiconified { get; set; } = null;

        bool hasOverrideInternalFrameDeiconified = true;
        void InternalFrameDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameDeiconified = true;
            var methodToExecute = (OnInternalFrameDeiconified != null) ? OnInternalFrameDeiconified : InternalFrameDeiconified;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameDeiconified;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameDeiconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameDeiconified = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameIconified"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameIconified { get; set; } = null;

        bool hasOverrideInternalFrameIconified = true;
        void InternalFrameIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameIconified = true;
            var methodToExecute = (OnInternalFrameIconified != null) ? OnInternalFrameIconified : InternalFrameIconified;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameIconified;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameIconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameIconified = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameOpened"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameOpened { get; set; } = null;

        bool hasOverrideInternalFrameOpened = true;
        void InternalFrameOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInternalFrameOpened = true;
            var methodToExecute = (OnInternalFrameOpened != null) ? OnInternalFrameOpened : InternalFrameOpened;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.InternalFrameEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInternalFrameOpened;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameOpened(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            hasOverrideInternalFrameOpened = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InternalFrameListenerDirect implementation
    public partial class InternalFrameListenerDirect : Javax.Swing.Event.IInternalFrameListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameActivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameActivated", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameClosed(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameClosed", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameClosing(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameClosing", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameDeactivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameDeactivated", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameDeiconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameDeiconified", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameIconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameIconified", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public override void InternalFrameOpened(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            IExecuteWithSignature("internalFrameOpened", "(Ljavax/swing/event/InternalFrameEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}