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

namespace Java.Awt.EventNs
{
    #region FocusListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html"/>
    /// </summary>
    public partial class FocusListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FocusListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.FocusListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region FocusListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="FocusListener"/> or its generic type if there is one
    /// </summary>
    public partial class FocusListenerDirect : FocusListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.FocusListener";
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

    #region IFocusListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.FocusListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html"/>
    /// </summary>
    public partial interface IFocusListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        void FocusGained(Java.Awt.EventNs.FocusEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        void FocusLost(Java.Awt.EventNs.FocusEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FocusListener implementation
    public partial class FocusListener : Java.Awt.EventNs.IFocusListener
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
        /// Handlers initializer for <see cref="FocusListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("focusGained", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(FocusGainedEventHandler));
            AddEventHandler("focusLost", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(FocusLostEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusGained"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.FocusEvent> OnFocusGained { get; set; } = null;

        bool hasOverrideFocusGained = true;
        void FocusGainedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnFocusGained != null) ? OnFocusGained : FocusGained;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.FocusEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideFocusGained;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            hasOverrideFocusGained = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusLost"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.FocusEvent> OnFocusLost { get; set; } = null;

        bool hasOverrideFocusLost = true;
        void FocusLostEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnFocusLost != null) ? OnFocusLost : FocusLost;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.FocusEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideFocusLost;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            hasOverrideFocusLost = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FocusListenerDirect implementation
    public partial class FocusListenerDirect : Java.Awt.EventNs.IFocusListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public override void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusGained", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusListener.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public override void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            IExecuteWithSignature("focusLost", "(Ljava/awt/event/FocusEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}