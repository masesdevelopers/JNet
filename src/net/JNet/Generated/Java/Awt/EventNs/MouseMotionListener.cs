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
    #region MouseMotionListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html"/>
    /// </summary>
    public partial class MouseMotionListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MouseMotionListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.MouseMotionListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region MouseMotionListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="MouseMotionListener"/> or its generic type if there is one
    /// </summary>
    public partial class MouseMotionListenerDirect : MouseMotionListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.MouseMotionListener";
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

    #region IMouseMotionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.MouseMotionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html"/>
    /// </summary>
    public partial interface IMouseMotionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseDragged(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseMoved(Java.Awt.EventNs.MouseEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseMotionListener implementation
    public partial class MouseMotionListener : Java.Awt.EventNs.IMouseMotionListener
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
        /// Handlers initializer for <see cref="MouseMotionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseDragged", new global::System.EventHandler<CLRListenerEventArgs<CLREventDataMETHOD_STUB_LISTENER_FIRST_PARAMETER_PLACEHOLDER>>(MouseDraggedEventHandler));
            AddEventHandler("mouseMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventDataMETHOD_STUB_LISTENER_FIRST_PARAMETER_PLACEHOLDER>>(MouseMovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseDragged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseDragged { get; set; } = null;

        bool hasOverrideMouseDragged = true;
        void MouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnMouseDragged != null) ? OnMouseDragged : MouseDragged;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.MouseEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideMouseDragged;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            hasOverrideMouseDragged = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseMoved { get; set; } = null;

        bool hasOverrideMouseMoved = true;
        void MouseMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnMouseMoved != null) ? OnMouseMoved : MouseMoved;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.EventNs.MouseEvent>(0));
            data.TypedEventData.HasOverride = hasOverrideMouseMoved;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            hasOverrideMouseMoved = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseMotionListenerDirect implementation
    public partial class MouseMotionListenerDirect : Java.Awt.EventNs.IMouseMotionListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseDragged", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecuteWithSignature("mouseMoved", "(Ljava/awt/event/MouseEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}