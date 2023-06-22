/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region IEventDirContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEventDirContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(java.lang.String,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(string arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3, Javax.Naming.Event.NamingListener arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(java.lang.String,java.lang.String,javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(string arg0, string arg1, Javax.Naming.Directory.SearchControls arg2, Javax.Naming.Event.NamingListener arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(javax.naming.Name,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(Javax.Naming.Name arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3, Javax.Naming.Event.NamingListener arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(javax.naming.Name,java.lang.String,javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void AddNamingListener(Javax.Naming.Name arg0, string arg1, Javax.Naming.Directory.SearchControls arg2, Javax.Naming.Event.NamingListener arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventDirContext
    public partial class EventDirContext : Javax.Naming.Event.IEventDirContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Event.EventDirContext"/> to <see cref="Javax.Naming.Event.EventContext"/>
        /// </summary>
        public static implicit operator Javax.Naming.Event.EventContext(Javax.Naming.Event.EventDirContext t) => t.Cast<Javax.Naming.Event.EventContext>();
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Event.EventDirContext"/> to <see cref="Javax.Naming.Directory.DirContext"/>
        /// </summary>
        public static implicit operator Javax.Naming.Directory.DirContext(Javax.Naming.Event.EventDirContext t) => t.Cast<Javax.Naming.Directory.DirContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(java.lang.String,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(string arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3, Javax.Naming.Event.NamingListener arg4)
        {
            IExecute("addNamingListener", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(java.lang.String,java.lang.String,javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(string arg0, string arg1, Javax.Naming.Directory.SearchControls arg2, Javax.Naming.Event.NamingListener arg3)
        {
            IExecute("addNamingListener", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(javax.naming.Name,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(Javax.Naming.Name arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3, Javax.Naming.Event.NamingListener arg4)
        {
            IExecute("addNamingListener", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/EventDirContext.html#addNamingListener(javax.naming.Name,java.lang.String,javax.naming.directory.SearchControls,javax.naming.event.NamingListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Event.NamingListener"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void AddNamingListener(Javax.Naming.Name arg0, string arg1, Javax.Naming.Directory.SearchControls arg2, Javax.Naming.Event.NamingListener arg3)
        {
            IExecute("addNamingListener", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}