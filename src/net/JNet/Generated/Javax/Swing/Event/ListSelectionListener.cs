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
    #region ListSelectionListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html"/>
    /// </summary>
    public partial class ListSelectionListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListSelectionListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.ListSelectionListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ListSelectionListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ListSelectionListener"/> or its generic type if there is one
    /// </summary>
    public partial class ListSelectionListenerDirect : ListSelectionListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.ListSelectionListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IListSelectionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.ListSelectionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html"/>
    /// </summary>
    public partial interface IListSelectionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListSelectionListener implementation
    public partial class ListSelectionListener : Javax.Swing.Event.IListSelectionListener
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
        /// Handlers initializer for <see cref="ListSelectionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("valueChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListSelectionEvent>>>(ValueChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnValueChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Swing.Event.ListSelectionEvent> OnValueChanged { get; set; } = null;

        void ValueChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListSelectionEvent>> data)
        {
            var methodToExecute = (OnValueChanged != null) ? OnValueChanged : ValueChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public virtual void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListSelectionListenerDirect implementation
    public partial class ListSelectionListenerDirect : Javax.Swing.Event.IListSelectionListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListSelectionListener.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public override void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            IExecuteWithSignature("valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}