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

namespace Javax.Naming.Event
{
    #region NamespaceChangeListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html"/>
    /// </summary>
    public partial class NamespaceChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NamespaceChangeListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.naming.event.NamespaceChangeListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region NamespaceChangeListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="NamespaceChangeListener"/> or its generic type if there is one
    /// </summary>
    public partial class NamespaceChangeListenerDirect : NamespaceChangeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.naming.event.NamespaceChangeListener";
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

    #region INamespaceChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.naming.event.NamespaceChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html"/>
    /// </summary>
    public partial interface INamespaceChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectAdded(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamespaceChangeListener implementation
    public partial class NamespaceChangeListener : Javax.Naming.Event.INamespaceChangeListener
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
        /// Handlers initializer for <see cref="NamespaceChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("objectAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ObjectAddedEventHandler));
            AddEventHandler("objectRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ObjectRemovedEventHandler));
            AddEventHandler("objectRenamed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ObjectRenamedEventHandler));
            AddEventHandler("namingExceptionThrown", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(NamingExceptionThrownEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Event.NamingEvent> OnObjectAdded { get; set; } = null;

        bool hasOverrideObjectAdded = true;
        void ObjectAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideObjectAdded = true;
            var methodToExecute = (OnObjectAdded != null) ? OnObjectAdded : ObjectAdded;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Naming.Event.NamingEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideObjectAdded;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectAdded(Javax.Naming.Event.NamingEvent arg0)
        {
            hasOverrideObjectAdded = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Event.NamingEvent> OnObjectRemoved { get; set; } = null;

        bool hasOverrideObjectRemoved = true;
        void ObjectRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideObjectRemoved = true;
            var methodToExecute = (OnObjectRemoved != null) ? OnObjectRemoved : ObjectRemoved;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Naming.Event.NamingEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideObjectRemoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0)
        {
            hasOverrideObjectRemoved = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectRenamed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Event.NamingEvent> OnObjectRenamed { get; set; } = null;

        bool hasOverrideObjectRenamed = true;
        void ObjectRenamedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideObjectRenamed = true;
            var methodToExecute = (OnObjectRenamed != null) ? OnObjectRenamed : ObjectRenamed;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Naming.Event.NamingEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideObjectRenamed;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0)
        {
            hasOverrideObjectRenamed = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNamingExceptionThrown"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Naming.Event.NamingExceptionEvent> OnNamingExceptionThrown { get; set; } = null;

        bool hasOverrideNamingExceptionThrown = true;
        void NamingExceptionThrownEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideNamingExceptionThrown = true;
            var methodToExecute = (OnNamingExceptionThrown != null) ? OnNamingExceptionThrown : NamingExceptionThrown;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Naming.Event.NamingExceptionEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideNamingExceptionThrown;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public virtual void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            hasOverrideNamingExceptionThrown = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamespaceChangeListenerDirect implementation
    public partial class NamespaceChangeListenerDirect : Javax.Naming.Event.INamespaceChangeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectAdded(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectAdded(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecute("objectAdded", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRemoved(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectRemoved(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecute("objectRemoved", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamespaceChangeListener.html#objectRenamed(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public override void ObjectRenamed(Javax.Naming.Event.NamingEvent arg0)
        {
            IExecute("objectRenamed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public override void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            IExecute("namingExceptionThrown", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}