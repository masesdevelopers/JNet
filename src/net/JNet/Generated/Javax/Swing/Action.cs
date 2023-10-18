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

namespace Javax.Swing
{
    #region IAction
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.Action implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html"/>
    /// </summary>
    public partial interface IAction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutValue(string arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Accept(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Action
    public partial class Action : Javax.Swing.IAction
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
        /// Handlers initializer for <see cref="Action"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("isEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEnabledEventHandler));
            AddEventHandler("getValue", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(GetValueEventHandler));
            AddEventHandler("actionPerformed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ActionEvent>>>(ActionPerformedEventHandler));
            AddEventHandler("addPropertyChangeListener", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>>>(AddPropertyChangeListenerEventHandler));
            AddEventHandler("putValue", new System.EventHandler<CLRListenerEventArgs<CLREventData<string>>>(PutValueEventHandler));
            AddEventHandler("removePropertyChangeListener", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>>>(RemovePropertyChangeListenerEventHandler));
            AddEventHandler("setEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(SetEnabledEventHandler));
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(AcceptEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnIsEnabled { get; set; } = null;

        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnIsEnabled != null) ? OnIsEnabled : IsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetValue"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<string, object> OnGetValue { get; set; } = null;

        void GetValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            var methodToExecute = (OnGetValue != null) ? OnGetValue : GetValue;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object GetValue(string arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnActionPerformed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.ActionEvent> OnActionPerformed { get; set; } = null;

        void ActionPerformedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ActionEvent>> data)
        {
            var methodToExecute = (OnActionPerformed != null) ? OnActionPerformed : ActionPerformed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        public virtual void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAddPropertyChangeListener"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Beans.PropertyChangeListener> OnAddPropertyChangeListener { get; set; } = null;

        void AddPropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>> data)
        {
            var methodToExecute = (OnAddPropertyChangeListener != null) ? OnAddPropertyChangeListener : AddPropertyChangeListener;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPutValue"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<string, object> OnPutValue { get; set; } = null;

        void PutValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> data)
        {
            var methodToExecute = (OnPutValue != null) ? OnPutValue : PutValue;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void PutValue(string arg0, object arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRemovePropertyChangeListener"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Beans.PropertyChangeListener> OnRemovePropertyChangeListener { get; set; } = null;

        void RemovePropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeListener>> data)
        {
            var methodToExecute = (OnRemovePropertyChangeListener != null) ? OnRemovePropertyChangeListener : RemovePropertyChangeListener;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<bool> OnSetEnabled { get; set; } = null;

        void SetEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
        {
            var methodToExecute = (OnSetEnabled != null) ? OnSetEnabled : SetEnabled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public virtual void SetEnabled(bool arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, bool> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Accept(object arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}