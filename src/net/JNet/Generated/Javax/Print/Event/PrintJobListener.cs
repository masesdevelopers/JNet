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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Event
{
    #region PrintJobListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html"/>
    /// </summary>
    public partial class PrintJobListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintJobListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.print.event.PrintJobListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region PrintJobListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="PrintJobListener"/> or its generic type if there is one
    /// </summary>
    public partial class PrintJobListenerDirect : PrintJobListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.print.event.PrintJobListener";
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

    #region IPrintJobListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintJobListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html"/>
    /// </summary>
    public partial interface IPrintJobListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobRequiresAttention(Javax.Print.Event.PrintJobEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobListener implementation
    public partial class PrintJobListener : Javax.Print.Event.IPrintJobListener
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
        /// Handlers initializer for <see cref="PrintJobListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("printDataTransferCompleted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintDataTransferCompletedEventHandler));
            AddEventHandler("printJobCanceled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintJobCanceledEventHandler));
            AddEventHandler("printJobCompleted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintJobCompletedEventHandler));
            AddEventHandler("printJobFailed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintJobFailedEventHandler));
            AddEventHandler("printJobNoMoreEvents", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintJobNoMoreEventsEventHandler));
            AddEventHandler("printJobRequiresAttention", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(PrintJobRequiresAttentionEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintDataTransferCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintDataTransferCompleted { get; set; } = null;

        bool hasOverridePrintDataTransferCompleted = true;
        void PrintDataTransferCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintDataTransferCompleted = true;
            var methodToExecute = (OnPrintDataTransferCompleted != null) ? OnPrintDataTransferCompleted : PrintDataTransferCompleted;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintDataTransferCompleted;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintDataTransferCompleted = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCanceled { get; set; } = null;

        bool hasOverridePrintJobCanceled = true;
        void PrintJobCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintJobCanceled = true;
            var methodToExecute = (OnPrintJobCanceled != null) ? OnPrintJobCanceled : PrintJobCanceled;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintJobCanceled;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintJobCanceled = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCompleted { get; set; } = null;

        bool hasOverridePrintJobCompleted = true;
        void PrintJobCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintJobCompleted = true;
            var methodToExecute = (OnPrintJobCompleted != null) ? OnPrintJobCompleted : PrintJobCompleted;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintJobCompleted;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintJobCompleted = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobFailed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobFailed { get; set; } = null;

        bool hasOverridePrintJobFailed = true;
        void PrintJobFailedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintJobFailed = true;
            var methodToExecute = (OnPrintJobFailed != null) ? OnPrintJobFailed : PrintJobFailed;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintJobFailed;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintJobFailed = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobNoMoreEvents"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobNoMoreEvents { get; set; } = null;

        bool hasOverridePrintJobNoMoreEvents = true;
        void PrintJobNoMoreEventsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintJobNoMoreEvents = true;
            var methodToExecute = (OnPrintJobNoMoreEvents != null) ? OnPrintJobNoMoreEvents : PrintJobNoMoreEvents;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintJobNoMoreEvents;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintJobNoMoreEvents = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobRequiresAttention"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobRequiresAttention { get; set; } = null;

        bool hasOverridePrintJobRequiresAttention = true;
        void PrintJobRequiresAttentionEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverridePrintJobRequiresAttention = true;
            var methodToExecute = (OnPrintJobRequiresAttention != null) ? OnPrintJobRequiresAttention : PrintJobRequiresAttention;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Print.Event.PrintJobEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverridePrintJobRequiresAttention;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobRequiresAttention(Javax.Print.Event.PrintJobEvent arg0)
        {
            hasOverridePrintJobRequiresAttention = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobListenerDirect implementation
    public partial class PrintJobListenerDirect : Javax.Print.Event.IPrintJobListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printDataTransferCompleted", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printJobCanceled", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printJobCompleted", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printJobFailed", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printJobNoMoreEvents", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public override void PrintJobRequiresAttention(Javax.Print.Event.PrintJobEvent arg0)
        {
            IExecuteWithSignature("printJobRequiresAttention", "(Ljavax/print/event/PrintJobEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}