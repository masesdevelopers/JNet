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
    #region PopupMenuListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html"/>
    /// </summary>
    public partial class PopupMenuListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PopupMenuListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.PopupMenuListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region PopupMenuListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="PopupMenuListener"/> or its generic type if there is one
    /// </summary>
    public partial class PopupMenuListenerDirect : PopupMenuListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.PopupMenuListener";
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

    #region IPopupMenuListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.PopupMenuListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html"/>
    /// </summary>
    public partial interface IPopupMenuListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuCanceled(Javax.Swing.Event.PopupMenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuWillBecomeInvisible(Javax.Swing.Event.PopupMenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuWillBecomeVisible(Javax.Swing.Event.PopupMenuEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PopupMenuListener implementation
    public partial class PopupMenuListener : Javax.Swing.Event.IPopupMenuListener
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
        /// Handlers initializer for <see cref="PopupMenuListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("popupMenuCanceled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PopupMenuCanceledEventHandler));
            AddEventHandler("popupMenuWillBecomeInvisible", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PopupMenuWillBecomeInvisibleEventHandler));
            AddEventHandler("popupMenuWillBecomeVisible", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PopupMenuWillBecomeVisibleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuCanceled { get; set; } = null;

        bool hasOverridePopupMenuCanceled = true;
        void PopupMenuCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePopupMenuCanceled = true;
            var methodToExecute = (OnPopupMenuCanceled != null) ? OnPopupMenuCanceled : PopupMenuCanceled;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.PopupMenuEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePopupMenuCanceled;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuCanceled(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            hasOverridePopupMenuCanceled = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuWillBecomeInvisible"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuWillBecomeInvisible { get; set; } = null;

        bool hasOverridePopupMenuWillBecomeInvisible = true;
        void PopupMenuWillBecomeInvisibleEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePopupMenuWillBecomeInvisible = true;
            var methodToExecute = (OnPopupMenuWillBecomeInvisible != null) ? OnPopupMenuWillBecomeInvisible : PopupMenuWillBecomeInvisible;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.PopupMenuEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePopupMenuWillBecomeInvisible;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuWillBecomeInvisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            hasOverridePopupMenuWillBecomeInvisible = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuWillBecomeVisible"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuWillBecomeVisible { get; set; } = null;

        bool hasOverridePopupMenuWillBecomeVisible = true;
        void PopupMenuWillBecomeVisibleEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePopupMenuWillBecomeVisible = true;
            var methodToExecute = (OnPopupMenuWillBecomeVisible != null) ? OnPopupMenuWillBecomeVisible : PopupMenuWillBecomeVisible;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.PopupMenuEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePopupMenuWillBecomeVisible;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuWillBecomeVisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            hasOverridePopupMenuWillBecomeVisible = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PopupMenuListenerDirect implementation
    public partial class PopupMenuListenerDirect : Javax.Swing.Event.IPopupMenuListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public override void PopupMenuCanceled(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            IExecuteWithSignature("popupMenuCanceled", "(Ljavax/swing/event/PopupMenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public override void PopupMenuWillBecomeInvisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            IExecuteWithSignature("popupMenuWillBecomeInvisible", "(Ljavax/swing/event/PopupMenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public override void PopupMenuWillBecomeVisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            IExecuteWithSignature("popupMenuWillBecomeVisible", "(Ljavax/swing/event/PopupMenuEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}