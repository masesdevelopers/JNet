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

namespace Java.Awt.EventNs
{
    #region ComponentAdapter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html"/>
    /// </summary>
    public partial class ComponentAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ComponentAdapter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.ComponentAdapter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ComponentAdapterDirect declaration
    /// <summary>
    /// Direct override of <see cref="ComponentAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class ComponentAdapterDirect : ComponentAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.ComponentAdapter";
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

    #region ComponentAdapter implementation
    public partial class ComponentAdapter
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
        /// Handlers initializer for <see cref="ComponentAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("componentHidden", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComponentHiddenEventHandler));
            AddEventHandler("componentMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComponentMovedEventHandler));
            AddEventHandler("componentResized", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComponentResizedEventHandler));
            AddEventHandler("componentShown", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComponentShownEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentHidden(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentHidden"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentHidden { get; set; } = null;

        bool hasOverrideComponentHidden = true;
        void ComponentHiddenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnComponentHidden != null) ? OnComponentHidden : ComponentHidden;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.ComponentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideComponentHidden;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentHidden(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentHidden(Java.Awt.EventNs.ComponentEvent arg0)
        {
            hasOverrideComponentHidden = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentMoved(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentMoved { get; set; } = null;

        bool hasOverrideComponentMoved = true;
        void ComponentMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnComponentMoved != null) ? OnComponentMoved : ComponentMoved;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.ComponentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideComponentMoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentMoved(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentMoved(Java.Awt.EventNs.ComponentEvent arg0)
        {
            hasOverrideComponentMoved = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentResized(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentResized"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentResized { get; set; } = null;

        bool hasOverrideComponentResized = true;
        void ComponentResizedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnComponentResized != null) ? OnComponentResized : ComponentResized;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.ComponentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideComponentResized;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentResized(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentResized(Java.Awt.EventNs.ComponentEvent arg0)
        {
            hasOverrideComponentResized = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentShown(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnComponentShown"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentShown { get; set; } = null;

        bool hasOverrideComponentShown = true;
        void ComponentShownEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnComponentShown != null) ? OnComponentShown : ComponentShown;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.ComponentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideComponentShown;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentShown(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentShown(Java.Awt.EventNs.ComponentEvent arg0)
        {
            hasOverrideComponentShown = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ComponentAdapterDirect implementation
    public partial class ComponentAdapterDirect
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentHidden(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public override void ComponentHidden(Java.Awt.EventNs.ComponentEvent arg0)
        {
            IExecuteWithSignature("componentHidden", "(Ljava/awt/event/ComponentEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentMoved(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public override void ComponentMoved(Java.Awt.EventNs.ComponentEvent arg0)
        {
            IExecuteWithSignature("componentMoved", "(Ljava/awt/event/ComponentEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentResized(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public override void ComponentResized(Java.Awt.EventNs.ComponentEvent arg0)
        {
            IExecuteWithSignature("componentResized", "(Ljava/awt/event/ComponentEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentShown(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public override void ComponentShown(Java.Awt.EventNs.ComponentEvent arg0)
        {
            IExecuteWithSignature("componentShown", "(Ljava/awt/event/ComponentEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}