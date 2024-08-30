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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicListUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.html"/>
    /// </summary>
    public partial class BasicListUI : Javax.Swing.Plaf.ListUI
    {
        const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicListUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicListUI(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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
        #region FocusHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.FocusHandler.html"/>
        /// </summary>
        public partial class FocusHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FocusHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI$FocusHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FocusHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FocusHandler(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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

        #region ListDataHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html"/>
        /// </summary>
        public partial class ListDataHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListDataHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI$ListDataHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ListDataHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ListDataHandler(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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

        #region ListSelectionHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListSelectionHandler.html"/>
        /// </summary>
        public partial class ListSelectionHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListSelectionHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI$ListSelectionHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ListSelectionHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ListSelectionHandler(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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

        #region MouseInputHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html"/>
        /// </summary>
        public partial class MouseInputHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MouseInputHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI$MouseInputHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MouseInputHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MouseInputHandler(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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

        #region PropertyChangeHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.PropertyChangeHandler.html"/>
        /// </summary>
        public partial class PropertyChangeHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PropertyChangeHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicListUI$PropertyChangeHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PropertyChangeHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PropertyChangeHandler(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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

    
    }
    #endregion

    #region BasicListUI implementation
    public partial class BasicListUI
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

        #endregion

        #region Nested classes
        #region FocusHandler implementation
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.FocusHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicListUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicListUI"/></param>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicListUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicListUI.FocusHandler"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicListUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecuteWithSignature("focusGained", "(Ljava/awt/event/FocusEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecuteWithSignature("focusLost", "(Ljava/awt/event/FocusEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListDataHandler implementation
        public partial class ListDataHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicListUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicListUI"/></param>
            public ListDataHandler(Javax.Swing.Plaf.Basic.BasicListUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicListUI.ListDataHandler"/> to <see cref="Javax.Swing.Event.ListDataListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ListDataListener(Javax.Swing.Plaf.Basic.BasicListUI.ListDataHandler t) => t.Cast<Javax.Swing.Event.ListDataListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("contentsChanged", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("intervalAdded", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("intervalRemoved", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListSelectionHandler implementation
        public partial class ListSelectionHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListSelectionHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicListUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicListUI"/></param>
            public ListSelectionHandler(Javax.Swing.Plaf.Basic.BasicListUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicListUI.ListSelectionHandler"/> to <see cref="Javax.Swing.Event.ListSelectionListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ListSelectionListener(Javax.Swing.Plaf.Basic.BasicListUI.ListSelectionHandler t) => t.Cast<Javax.Swing.Event.ListSelectionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListSelectionHandler.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
            public void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0)
            {
                IExecuteWithSignature("valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MouseInputHandler implementation
        public partial class MouseInputHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicListUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicListUI"/></param>
            public MouseInputHandler(Javax.Swing.Plaf.Basic.BasicListUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicListUI.MouseInputHandler"/> to <see cref="Javax.Swing.Event.MouseInputListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.MouseInputListener(Javax.Swing.Plaf.Basic.BasicListUI.MouseInputHandler t) => t.Cast<Javax.Swing.Event.MouseInputListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseClicked(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseClicked", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseDragged", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseEntered", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseExited", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseMoved", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mousePressed", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecuteWithSignature("mouseReleased", "(Ljava/awt/event/MouseEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler implementation
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.PropertyChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicListUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicListUI"/></param>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicListUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicListUI.PropertyChangeHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicListUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}