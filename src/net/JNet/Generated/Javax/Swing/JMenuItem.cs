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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JMenuItem
    public partial class JMenuItem
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JMenuItem(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#%3Cinit%3E(java.lang.String,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        public JMenuItem(Java.Lang.String arg0, Javax.Swing.Icon arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public JMenuItem(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#%3Cinit%3E(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        public JMenuItem(Javax.Swing.Action arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#%3Cinit%3E(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public JMenuItem(Javax.Swing.Icon arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JMenuItem"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JMenuItem t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JMenuItem"/> to <see cref="Javax.Swing.MenuElement"/>
        /// </summary>
        public static implicit operator Javax.Swing.MenuElement(Javax.Swing.JMenuItem t) => t.Cast<Javax.Swing.MenuElement>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#getAccelerator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#setAccelerator(javax.swing.KeyStroke)"/>
        /// </summary>
        public Javax.Swing.KeyStroke Accelerator
        {
            get { return IExecuteWithSignature<Javax.Swing.KeyStroke>("getAccelerator", "()Ljavax/swing/KeyStroke;"); } set { IExecuteWithSignature("setAccelerator", "(Ljavax/swing/KeyStroke;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getComponent", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#getMenuDragMouseListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.MenuDragMouseListener[] MenuDragMouseListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.MenuDragMouseListener>("getMenuDragMouseListeners", "()[Ljavax/swing/event/MenuDragMouseListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#getMenuKeyListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.MenuKeyListener[] MenuKeyListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.MenuKeyListener>("getMenuKeyListeners", "()[Ljavax/swing/event/MenuKeyListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#getSubElements()"/> 
        /// </summary>
        public Javax.Swing.MenuElement[] SubElements
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.MenuElement>("getSubElements", "()[Ljavax/swing/MenuElement;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#isArmed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArmed()
        {
            return IExecuteWithSignature<bool>("isArmed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#addMenuDragMouseListener(javax.swing.event.MenuDragMouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseListener"/></param>
        public void AddMenuDragMouseListener(Javax.Swing.Event.MenuDragMouseListener arg0)
        {
            IExecuteWithSignature("addMenuDragMouseListener", "(Ljavax/swing/event/MenuDragMouseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#addMenuKeyListener(javax.swing.event.MenuKeyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyListener"/></param>
        public void AddMenuKeyListener(Javax.Swing.Event.MenuKeyListener arg0)
        {
            IExecuteWithSignature("addMenuKeyListener", "(Ljavax/swing/event/MenuKeyListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#menuSelectionChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void MenuSelectionChanged(bool arg0)
        {
            IExecuteWithSignature("menuSelectionChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#processKeyEvent(java.awt.event.KeyEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processKeyEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#processMenuDragMouseEvent(javax.swing.event.MenuDragMouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseEvent"/></param>
        public void ProcessMenuDragMouseEvent(Javax.Swing.Event.MenuDragMouseEvent arg0)
        {
            IExecuteWithSignature("processMenuDragMouseEvent", "(Ljavax/swing/event/MenuDragMouseEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#processMenuKeyEvent(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        public void ProcessMenuKeyEvent(Javax.Swing.Event.MenuKeyEvent arg0)
        {
            IExecuteWithSignature("processMenuKeyEvent", "(Ljavax/swing/event/MenuKeyEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#processMouseEvent(java.awt.event.MouseEvent,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public void ProcessMouseEvent(Java.Awt.EventNs.MouseEvent arg0, Javax.Swing.MenuElement[] arg1, Javax.Swing.MenuSelectionManager arg2)
        {
            IExecute("processMouseEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#removeMenuDragMouseListener(javax.swing.event.MenuDragMouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuDragMouseListener"/></param>
        public void RemoveMenuDragMouseListener(Javax.Swing.Event.MenuDragMouseListener arg0)
        {
            IExecuteWithSignature("removeMenuDragMouseListener", "(Ljavax/swing/event/MenuDragMouseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#removeMenuKeyListener(javax.swing.event.MenuKeyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyListener"/></param>
        public void RemoveMenuKeyListener(Javax.Swing.Event.MenuKeyListener arg0)
        {
            IExecuteWithSignature("removeMenuKeyListener", "(Ljavax/swing/event/MenuKeyListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#setArmed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetArmed(bool arg0)
        {
            IExecuteWithSignature("setArmed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenuItem.html#setUI(javax.swing.plaf.MenuItemUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.MenuItemUI"/></param>
        public void SetUI(Javax.Swing.Plaf.MenuItemUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/MenuItemUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}