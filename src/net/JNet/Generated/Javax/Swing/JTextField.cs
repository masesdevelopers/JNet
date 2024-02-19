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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JTextField
    public partial class JTextField
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JTextField(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JTextField(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public JTextField(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#%3Cinit%3E(javax.swing.text.Document,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JTextField(Javax.Swing.Text.Document arg0, Java.Lang.String arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JTextField"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.JTextField t) => t.Cast<Javax.Swing.SwingConstants>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#notifyAction"/>
        /// </summary>
        public static Java.Lang.String notifyAction { get { if (!_notifyActionReady) { _notifyActionContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "notifyAction"); _notifyActionReady = true; } return _notifyActionContent; } }
        private static Java.Lang.String _notifyActionContent = default;
        private static bool _notifyActionReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#setAction(javax.swing.Action)"/>
        /// </summary>
        public Javax.Swing.Action Action
        {
            get { return IExecute<Javax.Swing.Action>("getAction"); } set { IExecute("setAction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#setColumns(int)"/>
        /// </summary>
        public int Columns
        {
            get { return IExecute<int>("getColumns"); } set { IExecute("setColumns", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getHorizontalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#setHorizontalAlignment(int)"/>
        /// </summary>
        public int HorizontalAlignment
        {
            get { return IExecute<int>("getHorizontalAlignment"); } set { IExecute("setHorizontalAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getHorizontalVisibility()"/> 
        /// </summary>
        public Javax.Swing.BoundedRangeModel HorizontalVisibility
        {
            get { return IExecute<Javax.Swing.BoundedRangeModel>("getHorizontalVisibility"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#getScrollOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#setScrollOffset(int)"/>
        /// </summary>
        public int ScrollOffset
        {
            get { return IExecute<int>("getScrollOffset"); } set { IExecute("setScrollOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#postActionEvent()"/>
        /// </summary>
        public void PostActionEvent()
        {
            IExecute("postActionEvent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextField.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetActionCommand(Java.Lang.String arg0)
        {
            IExecute("setActionCommand", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}