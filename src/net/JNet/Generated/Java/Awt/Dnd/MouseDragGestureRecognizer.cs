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

namespace Java.Awt.Dnd
{
    #region MouseDragGestureRecognizer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html"/>
    /// </summary>
    public partial class MouseDragGestureRecognizer : Java.Awt.Dnd.DragGestureRecognizer
    {
        const string _bridgeClassName = "java.awt.dnd.MouseDragGestureRecognizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MouseDragGestureRecognizer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MouseDragGestureRecognizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MouseDragGestureRecognizer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MouseDragGestureRecognizer(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MouseDragGestureRecognizer implementation
    public partial class MouseDragGestureRecognizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Dnd.MouseDragGestureRecognizer"/> to <see cref="Java.Awt.EventNs.MouseListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.MouseListener(Java.Awt.Dnd.MouseDragGestureRecognizer t) => t.Cast<Java.Awt.EventNs.MouseListener>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Dnd.MouseDragGestureRecognizer"/> to <see cref="Java.Awt.EventNs.MouseMotionListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.MouseMotionListener(Java.Awt.Dnd.MouseDragGestureRecognizer t) => t.Cast<Java.Awt.EventNs.MouseMotionListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseClicked", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseDragged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseEntered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseExited", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseMoved", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mousePressed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/MouseDragGestureRecognizer.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
        {
            IExecute("mouseReleased", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}