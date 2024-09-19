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
    #region TableColumnModelListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html"/>
    /// </summary>
    public partial class TableColumnModelListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableColumnModelListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.TableColumnModelListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region TableColumnModelListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="TableColumnModelListener"/> or its generic type if there is one
    /// </summary>
    public partial class TableColumnModelListenerDirect : TableColumnModelListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.TableColumnModelListener";
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

    #region ITableColumnModelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TableColumnModelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html"/>
    /// </summary>
    public partial interface ITableColumnModelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableColumnModelListener implementation
    public partial class TableColumnModelListener : Javax.Swing.Event.ITableColumnModelListener
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
        /// Handlers initializer for <see cref="TableColumnModelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("columnAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ColumnAddedEventHandler));
            AddEventHandler("columnMarginChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ColumnMarginChangedEventHandler));
            AddEventHandler("columnMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ColumnMovedEventHandler));
            AddEventHandler("columnRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ColumnRemovedEventHandler));
            AddEventHandler("columnSelectionChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ColumnSelectionChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnAdded { get; set; } = null;

        bool hasOverrideColumnAdded = true;
        void ColumnAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideColumnAdded = true;
            var methodToExecute = (OnColumnAdded != null) ? OnColumnAdded : ColumnAdded;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.TableColumnModelEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideColumnAdded;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            hasOverrideColumnAdded = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnMarginChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ChangeEvent> OnColumnMarginChanged { get; set; } = null;

        bool hasOverrideColumnMarginChanged = true;
        void ColumnMarginChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideColumnMarginChanged = true;
            var methodToExecute = (OnColumnMarginChanged != null) ? OnColumnMarginChanged : ColumnMarginChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.ChangeEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideColumnMarginChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0)
        {
            hasOverrideColumnMarginChanged = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnMoved { get; set; } = null;

        bool hasOverrideColumnMoved = true;
        void ColumnMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideColumnMoved = true;
            var methodToExecute = (OnColumnMoved != null) ? OnColumnMoved : ColumnMoved;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.TableColumnModelEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideColumnMoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            hasOverrideColumnMoved = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnRemoved { get; set; } = null;

        bool hasOverrideColumnRemoved = true;
        void ColumnRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideColumnRemoved = true;
            var methodToExecute = (OnColumnRemoved != null) ? OnColumnRemoved : ColumnRemoved;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.TableColumnModelEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideColumnRemoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            hasOverrideColumnRemoved = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnSelectionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ListSelectionEvent> OnColumnSelectionChanged { get; set; } = null;

        bool hasOverrideColumnSelectionChanged = true;
        void ColumnSelectionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideColumnSelectionChanged = true;
            var methodToExecute = (OnColumnSelectionChanged != null) ? OnColumnSelectionChanged : ColumnSelectionChanged;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Swing.Event.ListSelectionEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideColumnSelectionChanged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public virtual void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            hasOverrideColumnSelectionChanged = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableColumnModelListenerDirect implementation
    public partial class TableColumnModelListenerDirect : Javax.Swing.Event.ITableColumnModelListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public override void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public override void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0)
        {
            IExecuteWithSignature("columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public override void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public override void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            IExecuteWithSignature("columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public override void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            IExecuteWithSignature("columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}