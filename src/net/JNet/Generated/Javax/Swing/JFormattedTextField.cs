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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JFormattedTextField
    public partial class JFormattedTextField
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public JFormattedTextField(object arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format"/></param>
        public JFormattedTextField(Java.Text.Format arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatter arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatterFactory,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatterFactory"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatterFactory arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatterFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatterFactory"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatterFactory arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#COMMIT"/>
        /// </summary>
        public static int COMMIT { get { return LocalClazz.GetField<int>("COMMIT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#COMMIT_OR_REVERT"/>
        /// </summary>
        public static int COMMIT_OR_REVERT { get { return LocalClazz.GetField<int>("COMMIT_OR_REVERT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#PERSIST"/>
        /// </summary>
        public static int PERSIST { get { return LocalClazz.GetField<int>("PERSIST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#REVERT"/>
        /// </summary>
        public static int REVERT { get { return LocalClazz.GetField<int>("REVERT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFocusLostBehavior()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setFocusLostBehavior(int)"/>
        /// </summary>
        public int FocusLostBehavior
        {
            get { return IExecute<int>("getFocusLostBehavior"); } set { IExecute("setFocusLostBehavior", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFormatter()"/> 
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter Formatter
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getFormatter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFormatterFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setFormatterFactory(javax.swing.JFormattedTextField.AbstractFormatterFactory)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatterFactory FormatterFactory
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatterFactory>("getFormatterFactory"); } set { IExecute("setFormatterFactory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#isEditValid()"/> 
        /// </summary>
        public bool IsEditValid
        {
            get { return IExecute<bool>("isEditValid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecute("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#commitEdit()"/>
        /// </summary>

        /// <exception cref="Java.Text.ParseException"/>
        public void CommitEdit()
        {
            IExecute("commitEdit");
        }

        #endregion

        #region Nested classes
        #region AbstractFormatter
        public partial class AbstractFormatter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Javax.Swing.JFormattedTextField.AbstractFormatter t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#stringToValue(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Text.ParseException"/>
            public object StringToValue(string arg0)
            {
                return IExecute("stringToValue", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#valueToString(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="string"/></returns>
            /// <exception cref="Java.Text.ParseException"/>
            public string ValueToString(object arg0)
            {
                return IExecute<string>("valueToString", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#install(javax.swing.JFormattedTextField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField"/></param>
            public void Install(Javax.Swing.JFormattedTextField arg0)
            {
                IExecute("install", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#uninstall()"/>
            /// </summary>
            public void Uninstall()
            {
                IExecute("uninstall");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractFormatterFactory
        public partial class AbstractFormatterFactory
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatterFactory.html#getFormatter(javax.swing.JFormattedTextField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField"/></param>
            /// <returns><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></returns>
            public Javax.Swing.JFormattedTextField.AbstractFormatter GetFormatter(Javax.Swing.JFormattedTextField arg0)
            {
                return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getFormatter", arg0);
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