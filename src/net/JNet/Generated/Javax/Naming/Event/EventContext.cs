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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region EventContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html"/>
    /// </summary>
    public partial class EventContext : Javax.Naming.Context
    {
        const string _bridgeClassName = "javax.naming.event.EventContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EventContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EventContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EventContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EventContext(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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

        // TODO: complete the class

    }
    #endregion

    #region IEventContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEventContext : Javax.Naming.IContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#targetMustExist()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        bool TargetMustExist();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(java.lang.String,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(Java.Lang.String arg0, int arg1, Javax.Naming.Event.NamingListener arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(javax.naming.Name,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(Javax.Naming.Name arg0, int arg1, Javax.Naming.Event.NamingListener arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#removeNamingListener(javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void RemoveNamingListener(Javax.Naming.Event.NamingListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventContext implementation
    public partial class EventContext : Javax.Naming.Event.IEventContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#OBJECT_SCOPE"/>
        /// </summary>
        public static int OBJECT_SCOPE { get { if (!_OBJECT_SCOPEReady) { _OBJECT_SCOPEContent = SGetField<int>(LocalBridgeClazz, "OBJECT_SCOPE"); _OBJECT_SCOPEReady = true; } return _OBJECT_SCOPEContent; } }
        private static int _OBJECT_SCOPEContent = default;
        private static bool _OBJECT_SCOPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#ONELEVEL_SCOPE"/>
        /// </summary>
        public static int ONELEVEL_SCOPE { get { if (!_ONELEVEL_SCOPEReady) { _ONELEVEL_SCOPEContent = SGetField<int>(LocalBridgeClazz, "ONELEVEL_SCOPE"); _ONELEVEL_SCOPEReady = true; } return _ONELEVEL_SCOPEContent; } }
        private static int _ONELEVEL_SCOPEContent = default;
        private static bool _ONELEVEL_SCOPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#SUBTREE_SCOPE"/>
        /// </summary>
        public static int SUBTREE_SCOPE { get { if (!_SUBTREE_SCOPEReady) { _SUBTREE_SCOPEContent = SGetField<int>(LocalBridgeClazz, "SUBTREE_SCOPE"); _SUBTREE_SCOPEReady = true; } return _SUBTREE_SCOPEContent; } }
        private static int _SUBTREE_SCOPEContent = default;
        private static bool _SUBTREE_SCOPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#targetMustExist()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public bool TargetMustExist()
        {
            return IExecuteWithSignature<bool>("targetMustExist", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(java.lang.String,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(Java.Lang.String arg0, int arg1, Javax.Naming.Event.NamingListener arg2)
        {
            IExecuteWithSignature("addNamingListener", "(Ljava/lang/String;ILjavax/naming/event/NamingListener;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#addNamingListener(javax.naming.Name,int,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(Javax.Naming.Name arg0, int arg1, Javax.Naming.Event.NamingListener arg2)
        {
            IExecuteWithSignature("addNamingListener", "(Ljavax/naming/Name;ILjavax/naming/event/NamingListener;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventContext.html#removeNamingListener(javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void RemoveNamingListener(Javax.Naming.Event.NamingListener arg0)
        {
            IExecuteWithSignature("removeNamingListener", "(Ljavax/naming/event/NamingListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}