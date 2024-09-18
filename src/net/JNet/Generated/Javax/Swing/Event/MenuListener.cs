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

namespace Javax.Swing.Event
{
    #region MenuListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html"/>
    /// </summary>
    public partial class MenuListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MenuListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.MenuListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region MenuListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="MenuListener"/> or its generic type if there is one
    /// </summary>
    public partial class MenuListenerDirect : MenuListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.MenuListener";
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

    #region IMenuListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MenuListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html"/>
    /// </summary>
    public partial interface IMenuListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuCanceled(Javax.Swing.Event.MenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuDeselected(Javax.Swing.Event.MenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        void MenuSelected(Javax.Swing.Event.MenuEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuListener implementation
    public partial class MenuListener : Javax.Swing.Event.IMenuListener
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
        /// Handlers initializer for <see cref="MenuListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("menuCanceled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuCanceledEventHandler));
            AddEventHandler("menuDeselected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuDeselectedEventHandler));
            AddEventHandler("menuSelected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MenuSelectedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuCanceled { get; set; } = null;

        bool hasOverrideMenuCanceled = true;
        void MenuCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnMenuCanceled != null) ? OnMenuCanceled : MenuCanceled;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideMenuCanceled;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuCanceled(Javax.Swing.Event.MenuEvent arg0)
        {
            hasOverrideMenuCanceled = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuDeselected"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuDeselected { get; set; } = null;

        bool hasOverrideMenuDeselected = true;
        void MenuDeselectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnMenuDeselected != null) ? OnMenuDeselected : MenuDeselected;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideMenuDeselected;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuDeselected(Javax.Swing.Event.MenuEvent arg0)
        {
            hasOverrideMenuDeselected = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuSelected"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.MenuEvent> OnMenuSelected { get; set; } = null;

        bool hasOverrideMenuSelected = true;
        void MenuSelectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnMenuSelected != null) ? OnMenuSelected : MenuSelected;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.MenuEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideMenuSelected;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public virtual void MenuSelected(Javax.Swing.Event.MenuEvent arg0)
        {
            hasOverrideMenuSelected = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuListenerDirect implementation
    public partial class MenuListenerDirect : Javax.Swing.Event.IMenuListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuCanceled(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuCanceled(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuCanceled", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuDeselected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuDeselected(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuDeselected", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuListener.html#menuSelected(javax.swing.event.MenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuEvent"/></param>
        public override void MenuSelected(Javax.Swing.Event.MenuEvent arg0)
        {
            IExecuteWithSignature("menuSelected", "(Ljavax/swing/event/MenuEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}