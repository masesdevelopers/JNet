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
    #region MouseInputListener definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MouseInputListener.html"/>
    /// </summary>
    public partial class MouseInputListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MouseInputListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.swing.event.MouseInputListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region MouseInputListenerDirect definition
    /// <summary>
    /// Direct override of <see cref="MouseInputListener"/> or its generic type if there is one
    /// </summary>
    public partial class MouseInputListenerDirect : MouseInputListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.swing.event.MouseInputListener";
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

    #region IMouseInputListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MouseInputListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MouseInputListener.html"/>
    /// </summary>
    public partial interface IMouseInputListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseClicked(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseEntered(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseExited(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MousePressed(Java.Awt.EventNs.MouseEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        void MouseReleased(Java.Awt.EventNs.MouseEvent arg0);
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

    #region MouseInputListener
    public partial class MouseInputListener : Javax.Swing.Event.IMouseInputListener
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
        /// Handlers initializer for <see cref="MouseInputListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("mouseClicked", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseClickedEventHandler));
            AddEventHandler("mouseEntered", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseEnteredEventHandler));
            AddEventHandler("mouseExited", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseExitedEventHandler));
            AddEventHandler("mousePressed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MousePressedEventHandler));
            AddEventHandler("mouseReleased", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseReleasedEventHandler));
            AddEventHandler("mouseDragged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseDraggedEventHandler));
            AddEventHandler("mouseMoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>>>(MouseMovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseClicked"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseClicked { get; set; } = null;

        void MouseClickedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseClicked != null) ? OnMouseClicked : MouseClicked;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseEntered"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseEntered { get; set; } = null;

        void MouseEnteredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseEntered != null) ? OnMouseEntered : MouseEntered;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseExited"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseExited { get; set; } = null;

        void MouseExitedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseExited != null) ? OnMouseExited : MouseExited;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMousePressed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMousePressed { get; set; } = null;

        void MousePressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMousePressed != null) ? OnMousePressed : MousePressed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseReleased { get; set; } = null;

        void MouseReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseReleased != null) ? OnMouseReleased : MouseReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseDragged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseDragged { get; set; } = null;

        void MouseDraggedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseDragged != null) ? OnMouseDragged : MouseDragged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMouseMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.MouseEvent> OnMouseMoved { get; set; } = null;

        void MouseMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.MouseEvent>> data)
        {
            var methodToExecute = (OnMouseMoved != null) ? OnMouseMoved : MouseMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public virtual void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MouseInputListenerDirect
    public partial class MouseInputListenerDirect : Javax.Swing.Event.IMouseInputListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseClicked", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseEntered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseExited", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mousePressed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseReleased", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseDragged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseMotionListener.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public override void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseMoved", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}