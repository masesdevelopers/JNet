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
    #region IUndoableEditListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.UndoableEditListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/UndoableEditListener.html"/>
    /// </summary>
    public partial interface IUndoableEditListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/UndoableEditListener.html#undoableEditHappened(javax.swing.event.UndoableEditEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditEvent"/></param>
        void UndoableEditHappened(Javax.Swing.Event.UndoableEditEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UndoableEditListener
    public partial class UndoableEditListener : Javax.Swing.Event.IUndoableEditListener
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
        /// Handlers initializer for <see cref="UndoableEditListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("undoableEditHappened", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.UndoableEditEvent>>>(UndoableEditHappenedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/UndoableEditListener.html#undoableEditHappened(javax.swing.event.UndoableEditEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUndoableEditHappened"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.UndoableEditEvent> OnUndoableEditHappened { get; set; } = null;

        void UndoableEditHappenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.UndoableEditEvent>> data)
        {
            var methodToExecute = (OnUndoableEditHappened != null) ? OnUndoableEditHappened : UndoableEditHappened;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/UndoableEditListener.html#undoableEditHappened(javax.swing.event.UndoableEditEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditEvent"/></param>
        public virtual void UndoableEditHappened(Javax.Swing.Event.UndoableEditEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UndoableEditListenerDirect
    public partial class UndoableEditListenerDirect : Javax.Swing.Event.IUndoableEditListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/UndoableEditListener.html#undoableEditHappened(javax.swing.event.UndoableEditEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditEvent"/></param>
        public override void UndoableEditHappened(Javax.Swing.Event.UndoableEditEvent arg0)
        {
            IExecuteWithSignature("undoableEditHappened", "(Ljavax/swing/event/UndoableEditEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}