/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicListUI
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
        #region FocusHandler
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
                IExecute("focusGained", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusLost", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListDataHandler
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
                IExecute("contentsChanged", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecute("intervalAdded", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.ListDataHandler.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecute("intervalRemoved", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListSelectionHandler
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
                IExecute("valueChanged", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MouseInputHandler
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
                IExecute("mouseClicked", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseDragged", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseEntered", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseExited", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseMoved", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mousePressed", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicListUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)"/>
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

        #region PropertyChangeHandler
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
                IExecute("propertyChange", arg0);
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