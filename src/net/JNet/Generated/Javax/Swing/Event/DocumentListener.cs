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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region DocumentListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html"/>
    /// </summary>
    public partial class DocumentListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DocumentListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.DocumentListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region DocumentListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="DocumentListener"/> or its generic type if there is one
    /// </summary>
    public partial class DocumentListenerDirect : DocumentListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.DocumentListener";
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

    #region IDocumentListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.DocumentListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html"/>
    /// </summary>
    public partial interface IDocumentListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#changedUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        void ChangedUpdate(Javax.Swing.Event.DocumentEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#insertUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        void InsertUpdate(Javax.Swing.Event.DocumentEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#removeUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        void RemoveUpdate(Javax.Swing.Event.DocumentEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentListener implementation
    public partial class DocumentListener : Javax.Swing.Event.IDocumentListener
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
        /// Handlers initializer for <see cref="DocumentListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("changedUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ChangedUpdateEventHandler));
            AddEventHandler("insertUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InsertUpdateEventHandler));
            AddEventHandler("removeUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(RemoveUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#changedUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChangedUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.DocumentEvent> OnChangedUpdate { get; set; } = null;

        bool hasOverrideChangedUpdate = true;
        void ChangedUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideChangedUpdate = true;
            var methodToExecute = (OnChangedUpdate != null) ? OnChangedUpdate : ChangedUpdate;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.DocumentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideChangedUpdate;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#changedUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public virtual void ChangedUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            hasOverrideChangedUpdate = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#insertUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInsertUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.DocumentEvent> OnInsertUpdate { get; set; } = null;

        bool hasOverrideInsertUpdate = true;
        void InsertUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInsertUpdate = true;
            var methodToExecute = (OnInsertUpdate != null) ? OnInsertUpdate : InsertUpdate;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.DocumentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInsertUpdate;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#insertUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public virtual void InsertUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            hasOverrideInsertUpdate = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#removeUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRemoveUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.DocumentEvent> OnRemoveUpdate { get; set; } = null;

        bool hasOverrideRemoveUpdate = true;
        void RemoveUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideRemoveUpdate = true;
            var methodToExecute = (OnRemoveUpdate != null) ? OnRemoveUpdate : RemoveUpdate;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.DocumentEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideRemoveUpdate;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#removeUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public virtual void RemoveUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            hasOverrideRemoveUpdate = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentListenerDirect implementation
    public partial class DocumentListenerDirect : Javax.Swing.Event.IDocumentListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#changedUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public override void ChangedUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            IExecute("changedUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#insertUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public override void InsertUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            IExecute("insertUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/DocumentListener.html#removeUpdate(javax.swing.event.DocumentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        public override void RemoveUpdate(Javax.Swing.Event.DocumentEvent arg0)
        {
            IExecute("removeUpdate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}