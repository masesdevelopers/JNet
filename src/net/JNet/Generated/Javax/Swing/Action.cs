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

namespace Javax.Swing
{
    #region Action declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html"/>
    /// </summary>
    public partial class Action : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Action() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.Action";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ActionDirect declaration
    /// <summary>
    /// Direct override of <see cref="Action"/> or its generic type if there is one
    /// </summary>
    public partial class ActionDirect : Action
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.Action";
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
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetValue(Java.Lang.String arg0);
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
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutValue(Java.Lang.String arg0, object arg1);
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

    #region Action implementation
    public partial class Action : Javax.Swing.IAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#ACCELERATOR_KEY"/>
        /// </summary>
        public static Java.Lang.String ACCELERATOR_KEY { get { if (!_ACCELERATOR_KEYReady) { _ACCELERATOR_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCELERATOR_KEY"); _ACCELERATOR_KEYReady = true; } return _ACCELERATOR_KEYContent; } }
        private static Java.Lang.String _ACCELERATOR_KEYContent = default;
        private static bool _ACCELERATOR_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#ACTION_COMMAND_KEY"/>
        /// </summary>
        public static Java.Lang.String ACTION_COMMAND_KEY { get { if (!_ACTION_COMMAND_KEYReady) { _ACTION_COMMAND_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_COMMAND_KEY"); _ACTION_COMMAND_KEYReady = true; } return _ACTION_COMMAND_KEYContent; } }
        private static Java.Lang.String _ACTION_COMMAND_KEYContent = default;
        private static bool _ACTION_COMMAND_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#DEFAULT"/>
        /// </summary>
        public static Java.Lang.String DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Java.Lang.String _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#DISPLAYED_MNEMONIC_INDEX_KEY"/>
        /// </summary>
        public static Java.Lang.String DISPLAYED_MNEMONIC_INDEX_KEY { get { if (!_DISPLAYED_MNEMONIC_INDEX_KEYReady) { _DISPLAYED_MNEMONIC_INDEX_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISPLAYED_MNEMONIC_INDEX_KEY"); _DISPLAYED_MNEMONIC_INDEX_KEYReady = true; } return _DISPLAYED_MNEMONIC_INDEX_KEYContent; } }
        private static Java.Lang.String _DISPLAYED_MNEMONIC_INDEX_KEYContent = default;
        private static bool _DISPLAYED_MNEMONIC_INDEX_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#LARGE_ICON_KEY"/>
        /// </summary>
        public static Java.Lang.String LARGE_ICON_KEY { get { if (!_LARGE_ICON_KEYReady) { _LARGE_ICON_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LARGE_ICON_KEY"); _LARGE_ICON_KEYReady = true; } return _LARGE_ICON_KEYContent; } }
        private static Java.Lang.String _LARGE_ICON_KEYContent = default;
        private static bool _LARGE_ICON_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#LONG_DESCRIPTION"/>
        /// </summary>
        public static Java.Lang.String LONG_DESCRIPTION { get { if (!_LONG_DESCRIPTIONReady) { _LONG_DESCRIPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LONG_DESCRIPTION"); _LONG_DESCRIPTIONReady = true; } return _LONG_DESCRIPTIONContent; } }
        private static Java.Lang.String _LONG_DESCRIPTIONContent = default;
        private static bool _LONG_DESCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#MNEMONIC_KEY"/>
        /// </summary>
        public static Java.Lang.String MNEMONIC_KEY { get { if (!_MNEMONIC_KEYReady) { _MNEMONIC_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MNEMONIC_KEY"); _MNEMONIC_KEYReady = true; } return _MNEMONIC_KEYContent; } }
        private static Java.Lang.String _MNEMONIC_KEYContent = default;
        private static bool _MNEMONIC_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#NAME"/>
        /// </summary>
        public static Java.Lang.String NAME { get { if (!_NAMEReady) { _NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NAME"); _NAMEReady = true; } return _NAMEContent; } }
        private static Java.Lang.String _NAMEContent = default;
        private static bool _NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SELECTED_KEY"/>
        /// </summary>
        public static Java.Lang.String SELECTED_KEY { get { if (!_SELECTED_KEYReady) { _SELECTED_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SELECTED_KEY"); _SELECTED_KEYReady = true; } return _SELECTED_KEYContent; } }
        private static Java.Lang.String _SELECTED_KEYContent = default;
        private static bool _SELECTED_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SHORT_DESCRIPTION"/>
        /// </summary>
        public static Java.Lang.String SHORT_DESCRIPTION { get { if (!_SHORT_DESCRIPTIONReady) { _SHORT_DESCRIPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHORT_DESCRIPTION"); _SHORT_DESCRIPTIONReady = true; } return _SHORT_DESCRIPTIONContent; } }
        private static Java.Lang.String _SHORT_DESCRIPTIONContent = default;
        private static bool _SHORT_DESCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SMALL_ICON"/>
        /// </summary>
        public static Java.Lang.String SMALL_ICON { get { if (!_SMALL_ICONReady) { _SMALL_ICONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SMALL_ICON"); _SMALL_ICONReady = true; } return _SMALL_ICONContent; } }
        private static Java.Lang.String _SMALL_ICONContent = default;
        private static bool _SMALL_ICONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="Action"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("isEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(IsEnabledEventHandler));
            AddEventHandler("getValue", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetValueEventHandler));
            AddEventHandler("actionPerformed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ActionPerformedEventHandler));
            AddEventHandler("addPropertyChangeListener", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AddPropertyChangeListenerEventHandler));
            AddEventHandler("putValue", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PutValueEventHandler));
            AddEventHandler("removePropertyChangeListener", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(RemovePropertyChangeListenerEventHandler));
            AddEventHandler("setEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(SetEnabledEventHandler));
            AddEventHandler("accept", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AcceptEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnIsEnabled { get; set; } = null;

        bool hasOverrideIsEnabled = true;
        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideIsEnabled = true;
            var methodToExecute = (OnIsEnabled != null) ? OnIsEnabled : IsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideIsEnabled, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled()
        {
            hasOverrideIsEnabled = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetValue"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String, object> OnGetValue { get; set; } = null;

        bool hasOverrideGetValue = true;
        void GetValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetValue = true;
            var methodToExecute = (OnGetValue != null) ? OnGetValue : GetValue;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetValue, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object GetValue(Java.Lang.String arg0)
        {
            hasOverrideGetValue = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnActionPerformed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.ActionEvent> OnActionPerformed { get; set; } = null;

        bool hasOverrideActionPerformed = true;
        void ActionPerformedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideActionPerformed = true;
            var methodToExecute = (OnActionPerformed != null) ? OnActionPerformed : ActionPerformed;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.ActionEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideActionPerformed;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        public virtual void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
        {
            hasOverrideActionPerformed = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAddPropertyChangeListener"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.PropertyChangeListener> OnAddPropertyChangeListener { get; set; } = null;

        bool hasOverrideAddPropertyChangeListener = true;
        void AddPropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAddPropertyChangeListener = true;
            var methodToExecute = (OnAddPropertyChangeListener != null) ? OnAddPropertyChangeListener : AddPropertyChangeListener;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Beans.PropertyChangeListener>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAddPropertyChangeListener;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            hasOverrideAddPropertyChangeListener = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPutValue"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, object> OnPutValue { get; set; } = null;

        bool hasOverridePutValue = true;
        void PutValueEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePutValue = true;
            var methodToExecute = (OnPutValue != null) ? OnPutValue : PutValue;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<object>(1));
            data.EventData.TypedEventData.HasOverride = hasOverridePutValue;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void PutValue(Java.Lang.String arg0, object arg1)
        {
            hasOverridePutValue = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRemovePropertyChangeListener"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Beans.PropertyChangeListener> OnRemovePropertyChangeListener { get; set; } = null;

        bool hasOverrideRemovePropertyChangeListener = true;
        void RemovePropertyChangeListenerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideRemovePropertyChangeListener = true;
            var methodToExecute = (OnRemovePropertyChangeListener != null) ? OnRemovePropertyChangeListener : RemovePropertyChangeListener;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Beans.PropertyChangeListener>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideRemovePropertyChangeListener;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public virtual void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            hasOverrideRemovePropertyChangeListener = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<bool> OnSetEnabled { get; set; } = null;

        bool hasOverrideSetEnabled = true;
        void SetEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideSetEnabled = true;
            var methodToExecute = (OnSetEnabled != null) ? OnSetEnabled : SetEnabled;
            methodToExecute.Invoke(data.EventData.GetAt<bool>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideSetEnabled;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public virtual void SetEnabled(bool arg0)
        {
            hasOverrideSetEnabled = false;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public bool AcceptDefault(object arg0)
        {
            return IExecuteWithSignature<bool>("acceptDefault", "(Ljava/lang/Object;)Z", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, bool> OnAccept { get; set; } = null;

        bool hasOverrideAccept = true;
        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAccept = true;
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<object>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAccept, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AcceptDefault"/>; override the method to implement a different behavior</remarks>
        public virtual bool Accept(object arg0)
        {
            hasOverrideAccept = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ActionDirect implementation
    public partial class ActionDirect : Javax.Swing.IAction
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public override object GetValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionListener.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        public override void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
        {
            IExecute("actionPerformed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public override void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public override void PutValue(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("putValue", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public override void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public override void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Accept(object arg0)
        {
            return IExecuteWithSignature<bool>("accept", "(Ljava/lang/Object;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}