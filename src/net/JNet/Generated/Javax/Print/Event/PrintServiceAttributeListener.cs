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

namespace Javax.Print.Event
{
    #region PrintServiceAttributeListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html"/>
    /// </summary>
    public partial class PrintServiceAttributeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintServiceAttributeListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.print.event.PrintServiceAttributeListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region PrintServiceAttributeListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="PrintServiceAttributeListener"/> or its generic type if there is one
    /// </summary>
    public partial class PrintServiceAttributeListenerDirect : PrintServiceAttributeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.print.event.PrintServiceAttributeListener";
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

    #region IPrintServiceAttributeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintServiceAttributeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html"/>
    /// </summary>
    public partial interface IPrintServiceAttributeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeEvent"/></param>
        void AttributeUpdate(Javax.Print.Event.PrintServiceAttributeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintServiceAttributeListener implementation
    public partial class PrintServiceAttributeListener : Javax.Print.Event.IPrintServiceAttributeListener
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
        /// Handlers initializer for <see cref="PrintServiceAttributeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("attributeUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintServiceAttributeEvent>>>(AttributeUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAttributeUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintServiceAttributeEvent> OnAttributeUpdate { get; set; } = null;

        void AttributeUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintServiceAttributeEvent>> data)
        {
            var methodToExecute = (OnAttributeUpdate != null) ? OnAttributeUpdate : AttributeUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeEvent"/></param>
        public virtual void AttributeUpdate(Javax.Print.Event.PrintServiceAttributeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintServiceAttributeListenerDirect implementation
    public partial class PrintServiceAttributeListenerDirect : Javax.Print.Event.IPrintServiceAttributeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeEvent"/></param>
        public override void AttributeUpdate(Javax.Print.Event.PrintServiceAttributeEvent arg0)
        {
            IExecuteWithSignature("attributeUpdate", "(Ljavax/print/event/PrintServiceAttributeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}