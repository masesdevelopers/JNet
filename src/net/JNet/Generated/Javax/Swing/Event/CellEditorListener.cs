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
    #region CellEditorListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html"/>
    /// </summary>
    public partial class CellEditorListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CellEditorListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.CellEditorListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region CellEditorListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="CellEditorListener"/> or its generic type if there is one
    /// </summary>
    public partial class CellEditorListenerDirect : CellEditorListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.CellEditorListener";
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

    #region ICellEditorListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.CellEditorListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html"/>
    /// </summary>
    public partial interface ICellEditorListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void EditingStopped(Javax.Swing.Event.ChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CellEditorListener implementation
    public partial class CellEditorListener : Javax.Swing.Event.ICellEditorListener
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
        /// Handlers initializer for <see cref="CellEditorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("editingCanceled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>>>(EditingCanceledEventHandler));
            AddEventHandler("editingStopped", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>>>(EditingStoppedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEditingCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ChangeEvent> OnEditingCanceled { get; set; } = null;

        void EditingCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>> data)
        {
            var methodToExecute = (OnEditingCanceled != null) ? OnEditingCanceled : EditingCanceled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEditingStopped"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ChangeEvent> OnEditingStopped { get; set; } = null;

        void EditingStoppedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>> data)
        {
            var methodToExecute = (OnEditingStopped != null) ? OnEditingStopped : EditingStopped;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void EditingStopped(Javax.Swing.Event.ChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CellEditorListenerDirect implementation
    public partial class CellEditorListenerDirect : Javax.Swing.Event.ICellEditorListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public override void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0)
        {
            IExecuteWithSignature("editingCanceled", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public override void EditingStopped(Javax.Swing.Event.ChangeEvent arg0)
        {
            IExecuteWithSignature("editingStopped", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}