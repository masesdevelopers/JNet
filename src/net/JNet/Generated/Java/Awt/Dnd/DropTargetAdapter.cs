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

namespace Java.Awt.Dnd
{
    #region DropTargetAdapter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html"/>
    /// </summary>
    public partial class DropTargetAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DropTargetAdapter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.dnd.DropTargetAdapter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region DropTargetAdapterDirect declaration
    /// <summary>
    /// Direct override of <see cref="DropTargetAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class DropTargetAdapterDirect : DropTargetAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.dnd.DropTargetAdapter";
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region DropTargetAdapter implementation
    public partial class DropTargetAdapter
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
        /// Handlers initializer for <see cref="DropTargetAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("drop", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DropEventHandler));
            AddEventHandler("dragEnter", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DragEnterEventHandler));
            AddEventHandler("dragExit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DragExitEventHandler));
            AddEventHandler("dragOver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DragOverEventHandler));
            AddEventHandler("dropActionChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DropActionChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDrop"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDropEvent> OnDrop { get; set; } = null;

        bool hasOverrideDrop = true;
        void DropEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnDrop != null) ? OnDrop : Drop;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DropTargetDropEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideDrop;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        public virtual void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            hasOverrideDrop = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragEnter"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragEnter { get; set; } = null;

        bool hasOverrideDragEnter = true;
        void DragEnterEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnDragEnter != null) ? OnDragEnter : DragEnter;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DropTargetDragEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideDragEnter;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            hasOverrideDragEnter = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragExit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetEvent> OnDragExit { get; set; } = null;

        bool hasOverrideDragExit = true;
        void DragExitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnDragExit != null) ? OnDragExit : DragExit;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DropTargetEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideDragExit;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        public virtual void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            hasOverrideDragExit = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragOver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragOver { get; set; } = null;

        bool hasOverrideDragOver = true;
        void DragOverEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnDragOver != null) ? OnDragOver : DragOver;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DropTargetDragEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideDragOver;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            hasOverrideDragOver = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDropActionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDropActionChanged { get; set; } = null;

        bool hasOverrideDropActionChanged = true;
        void DropActionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnDropActionChanged != null) ? OnDropActionChanged : DropActionChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DropTargetDragEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideDropActionChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            hasOverrideDropActionChanged = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DropTargetAdapterDirect implementation
    public partial class DropTargetAdapterDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        public override void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            IExecute("drop", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dragEnter", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        public override void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            IExecuteWithSignature("dragExit", "(Ljava/awt/dnd/DropTargetEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dragOver", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public override void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecuteWithSignature("dropActionChanged", "(Ljava/awt/dnd/DropTargetDragEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}