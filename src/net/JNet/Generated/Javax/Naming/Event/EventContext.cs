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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
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

    #region EventContext
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
            IExecute("addNamingListener", arg0, arg1, arg2);
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
            IExecute("addNamingListener", arg0, arg1, arg2);
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