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

namespace Javax.Sql
{
    #region RowSetListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html"/>
    /// </summary>
    public partial class RowSetListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RowSetListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.sql.RowSetListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region RowSetListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="RowSetListener"/> or its generic type if there is one
    /// </summary>
    public partial class RowSetListenerDirect : RowSetListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.sql.RowSetListener";
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

    #region IRowSetListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sql.RowSetListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html"/>
    /// </summary>
    public partial interface IRowSetListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void CursorMoved(Javax.Sql.RowSetEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void RowChanged(Javax.Sql.RowSetEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void RowSetChanged(Javax.Sql.RowSetEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetListener implementation
    public partial class RowSetListener : Javax.Sql.IRowSetListener
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
        /// Handlers initializer for <see cref="RowSetListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("cursorMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(CursorMovedEventHandler));
            AddEventHandler("rowChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(RowChangedEventHandler));
            AddEventHandler("rowSetChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(RowSetChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCursorMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sql.RowSetEvent> OnCursorMoved { get; set; } = null;

        void CursorMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnCursorMoved != null) ? OnCursorMoved : CursorMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void CursorMoved(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRowChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sql.RowSetEvent> OnRowChanged { get; set; } = null;

        void RowChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnRowChanged != null) ? OnRowChanged : RowChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void RowChanged(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRowSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sql.RowSetEvent> OnRowSetChanged { get; set; } = null;

        void RowSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnRowSetChanged != null) ? OnRowSetChanged : RowSetChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void RowSetChanged(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetListenerDirect implementation
    public partial class RowSetListenerDirect : Javax.Sql.IRowSetListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public override void CursorMoved(Javax.Sql.RowSetEvent arg0)
        {
            IExecuteWithSignature("cursorMoved", "(Ljavax/sql/RowSetEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public override void RowChanged(Javax.Sql.RowSetEvent arg0)
        {
            IExecuteWithSignature("rowChanged", "(Ljavax/sql/RowSetEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public override void RowSetChanged(Javax.Sql.RowSetEvent arg0)
        {
            IExecuteWithSignature("rowSetChanged", "(Ljavax/sql/RowSetEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}