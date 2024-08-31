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

namespace Javax.Naming.Event
{
    #region NamingEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html"/>
    /// </summary>
    public partial class NamingEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "javax.naming.event.NamingEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NamingEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NamingEvent(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

        // TODO: complete the class

    }
    #endregion

    #region NamingEvent implementation
    public partial class NamingEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#%3Cinit%3E(javax.naming.event.EventContext,int,javax.naming.Binding,javax.naming.Binding,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.EventContext"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Binding"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Binding"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public NamingEvent(Javax.Naming.Event.EventContext arg0, int arg1, Javax.Naming.Binding arg2, Javax.Naming.Binding arg3, object arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_ADDED"/>
        /// </summary>
        public static int OBJECT_ADDED { get { if (!_OBJECT_ADDEDReady) { _OBJECT_ADDEDContent = SGetField<int>(LocalBridgeClazz, "OBJECT_ADDED"); _OBJECT_ADDEDReady = true; } return _OBJECT_ADDEDContent; } }
        private static int _OBJECT_ADDEDContent = default;
        private static bool _OBJECT_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_CHANGED"/>
        /// </summary>
        public static int OBJECT_CHANGED { get { if (!_OBJECT_CHANGEDReady) { _OBJECT_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "OBJECT_CHANGED"); _OBJECT_CHANGEDReady = true; } return _OBJECT_CHANGEDContent; } }
        private static int _OBJECT_CHANGEDContent = default;
        private static bool _OBJECT_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_REMOVED"/>
        /// </summary>
        public static int OBJECT_REMOVED { get { if (!_OBJECT_REMOVEDReady) { _OBJECT_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "OBJECT_REMOVED"); _OBJECT_REMOVEDReady = true; } return _OBJECT_REMOVEDContent; } }
        private static int _OBJECT_REMOVEDContent = default;
        private static bool _OBJECT_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_RENAMED"/>
        /// </summary>
        public static int OBJECT_RENAMED { get { if (!_OBJECT_RENAMEDReady) { _OBJECT_RENAMEDContent = SGetField<int>(LocalBridgeClazz, "OBJECT_RENAMED"); _OBJECT_RENAMEDReady = true; } return _OBJECT_RENAMEDContent; } }
        private static int _OBJECT_RENAMEDContent = default;
        private static bool _OBJECT_RENAMEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getChangeInfo()"/> 
        /// </summary>
        public object ChangeInfo
        {
            get { return IExecuteWithSignature("getChangeInfo", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getEventContext()"/> 
        /// </summary>
        public Javax.Naming.Event.EventContext EventContext
        {
            get { return IExecuteWithSignature<Javax.Naming.Event.EventContext>("getEventContext", "()Ljavax/naming/event/EventContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getNewBinding()"/> 
        /// </summary>
        public Javax.Naming.Binding NewBinding
        {
            get { return IExecuteWithSignature<Javax.Naming.Binding>("getNewBinding", "()Ljavax/naming/Binding;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getOldBinding()"/> 
        /// </summary>
        public Javax.Naming.Binding OldBinding
        {
            get { return IExecuteWithSignature<Javax.Naming.Binding>("getOldBinding", "()Ljavax/naming/Binding;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#dispatch(javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingListener"/></param>
        public void Dispatch(Javax.Naming.Event.NamingListener arg0)
        {
            IExecuteWithSignature("dispatch", "(Ljavax/naming/event/NamingListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}