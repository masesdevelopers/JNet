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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Event
{
    #region IObjectChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.naming.event.ObjectChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html"/>
    /// </summary>
    public partial interface IObjectChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html#objectChanged(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        void ObjectChanged(Javax.Naming.Event.NamingEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjectChangeListener
    public partial class ObjectChangeListener : Javax.Naming.Event.IObjectChangeListener
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
        /// Handlers initializer for <see cref="ObjectChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("namingExceptionThrown", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>>>(NamingExceptionThrownEventHandler));
            AddEventHandler("objectChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>>>(ObjectChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNamingExceptionThrown"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingExceptionEvent> OnNamingExceptionThrown { get; set; } = null;

        void NamingExceptionThrownEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingExceptionEvent>> data)
        {
            var methodToExecute = (OnNamingExceptionThrown != null) ? OnNamingExceptionThrown : NamingExceptionThrown;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingExceptionEvent"/></param>
        public virtual void NamingExceptionThrown(Javax.Naming.Event.NamingExceptionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html#objectChanged(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnObjectChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Naming.Event.NamingEvent> OnObjectChanged { get; set; } = null;

        void ObjectChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Naming.Event.NamingEvent>> data)
        {
            var methodToExecute = (OnObjectChanged != null) ? OnObjectChanged : ObjectChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html#objectChanged(javax.naming.event.NamingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Event.NamingEvent"/></param>
        public virtual void ObjectChanged(Javax.Naming.Event.NamingEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}