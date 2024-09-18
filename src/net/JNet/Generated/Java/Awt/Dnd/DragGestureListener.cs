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

namespace Java.Awt.Dnd
{
    #region DragGestureListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html"/>
    /// </summary>
    public partial class DragGestureListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DragGestureListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.dnd.DragGestureListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region DragGestureListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="DragGestureListener"/> or its generic type if there is one
    /// </summary>
    public partial class DragGestureListenerDirect : DragGestureListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.dnd.DragGestureListener";
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

    #region IDragGestureListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.dnd.DragGestureListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html"/>
    /// </summary>
    public partial interface IDragGestureListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html#dragGestureRecognized(java.awt.dnd.DragGestureEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        void DragGestureRecognized(Java.Awt.Dnd.DragGestureEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DragGestureListener implementation
    public partial class DragGestureListener : Java.Awt.Dnd.IDragGestureListener
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
        /// Handlers initializer for <see cref="DragGestureListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("dragGestureRecognized", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(DragGestureRecognizedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html#dragGestureRecognized(java.awt.dnd.DragGestureEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragGestureRecognized"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.Dnd.DragGestureEvent> OnDragGestureRecognized { get; set; } = null;

        bool hasOverrideDragGestureRecognized = true;
        void DragGestureRecognizedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideDragGestureRecognized = true;
            var methodToExecute = (OnDragGestureRecognized != null) ? OnDragGestureRecognized : DragGestureRecognized;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.Dnd.DragGestureEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideDragGestureRecognized;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html#dragGestureRecognized(java.awt.dnd.DragGestureEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        public virtual void DragGestureRecognized(Java.Awt.Dnd.DragGestureEvent arg0)
        {
            hasOverrideDragGestureRecognized = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DragGestureListenerDirect implementation
    public partial class DragGestureListenerDirect : Java.Awt.Dnd.IDragGestureListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html#dragGestureRecognized(java.awt.dnd.DragGestureEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureEvent"/></param>
        public override void DragGestureRecognized(Java.Awt.Dnd.DragGestureEvent arg0)
        {
            IExecuteWithSignature("dragGestureRecognized", "(Ljava/awt/dnd/DragGestureEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}