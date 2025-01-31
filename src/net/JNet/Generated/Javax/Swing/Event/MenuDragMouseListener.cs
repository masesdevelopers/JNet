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

namespace Javax.Swing.Event
{
    #region MenuDragMouseListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html"/>
    /// </summary>
    public partial class MenuDragMouseListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MenuDragMouseListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.MenuDragMouseListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region MenuDragMouseListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="MenuDragMouseListener"/> or its generic type if there is one
    /// </summary>
    public partial class MenuDragMouseListenerDirect : MenuDragMouseListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.MenuDragMouseListener";
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

    #region IMenuDragMouseListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MenuDragMouseListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html"/>
    /// </summary>
    public partial interface IMenuDragMouseListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseDragged(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseEntered(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseExited(Javax.Swing.Event.MenuDragMouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        void MenuDragMouseReleased(Javax.Swing.Event.MenuDragMouseEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuDragMouseListener implementation
    public partial class MenuDragMouseListener : Javax.Swing.Event.IMenuDragMouseListener
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
        /// Handlers initializer for <see cref="MenuDragMouseListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("menuDragMouseDragged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuDragMouseDraggedEventHandler));
            AddEventHandler("menuDragMouseEntered", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuDragMouseEnteredEventHandler));
            AddEventHandler("menuDragMouseExited", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuDragMouseExitedEventHandler));
            AddEventHandler("menuDragMouseReleased", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuDragMouseReleasedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseDragged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseDragged { get; set; } = null;

        bool hasOverrideMenuDragMouseDragged = true;
        void MenuDragMouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMenuDragMouseDragged = true;
            var methodToExecute = (OnMenuDragMouseDragged != null) ? OnMenuDragMouseDragged : MenuDragMouseDragged;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuDragMouseEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMenuDragMouseDragged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseDragged(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            hasOverrideMenuDragMouseDragged = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseEntered"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseEntered { get; set; } = null;

        bool hasOverrideMenuDragMouseEntered = true;
        void MenuDragMouseEnteredEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMenuDragMouseEntered = true;
            var methodToExecute = (OnMenuDragMouseEntered != null) ? OnMenuDragMouseEntered : MenuDragMouseEntered;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuDragMouseEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMenuDragMouseEntered;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseEntered(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            hasOverrideMenuDragMouseEntered = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseExited"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseExited { get; set; } = null;

        bool hasOverrideMenuDragMouseExited = true;
        void MenuDragMouseExitedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMenuDragMouseExited = true;
            var methodToExecute = (OnMenuDragMouseExited != null) ? OnMenuDragMouseExited : MenuDragMouseExited;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuDragMouseEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMenuDragMouseExited;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseExited(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            hasOverrideMenuDragMouseExited = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDragMouseReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuDragMouseEvent> OnMenuDragMouseReleased { get; set; } = null;

        bool hasOverrideMenuDragMouseReleased = true;
        void MenuDragMouseReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMenuDragMouseReleased = true;
            var methodToExecute = (OnMenuDragMouseReleased != null) ? OnMenuDragMouseReleased : MenuDragMouseReleased;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuDragMouseEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMenuDragMouseReleased;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public virtual void MenuDragMouseReleased(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            hasOverrideMenuDragMouseReleased = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuDragMouseListenerDirect implementation
    public partial class MenuDragMouseListenerDirect : Javax.Swing.Event.IMenuDragMouseListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseDragged(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public override void MenuDragMouseDragged(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            IExecuteWithSignature("menuDragMouseDragged", "(Ljavax/swing/event/MenuDragMouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseEntered(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public override void MenuDragMouseEntered(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            IExecuteWithSignature("menuDragMouseEntered", "(Ljavax/swing/event/MenuDragMouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseExited(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public override void MenuDragMouseExited(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            IExecuteWithSignature("menuDragMouseExited", "(Ljavax/swing/event/MenuDragMouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuDragMouseListener.html#menuDragMouseReleased(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public override void MenuDragMouseReleased(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            IExecuteWithSignature("menuDragMouseReleased", "(Ljavax/swing/event/MenuDragMouseEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}