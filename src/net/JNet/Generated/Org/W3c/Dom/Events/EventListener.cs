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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Events
{
    #region IEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.org.w3c.dom.events.EventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html"/>
    /// </summary>
    public partial interface IEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        void HandleEvent(Org.W3c.Dom.Events.Event arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EventListener
    public partial class EventListener : Org.W3c.Dom.Events.IEventListener
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
        /// Handlers initializer for <see cref="EventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("handleEvent", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.W3c.Dom.Events.Event>>>(HandleEventEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <remarks>If <see cref="OnHandleEvent"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.W3c.Dom.Events.Event> OnHandleEvent { get; set; } = null;

        void HandleEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.W3c.Dom.Events.Event>> data)
        {
            var methodToExecute = (OnHandleEvent != null) ? OnHandleEvent : HandleEvent;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/events/EventListener.html#handleEvent(org.w3c.dom.events.Event)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Events.Event"/></param>
        public virtual void HandleEvent(Org.W3c.Dom.Events.Event arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}