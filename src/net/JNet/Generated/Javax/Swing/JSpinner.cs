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

namespace Javax.Swing
{
    #region JSpinner definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html"/>
    /// </summary>
    public partial class JSpinner : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JSpinner";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JSpinner() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JSpinner(params object[] args) : base(args) { }

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
        #region DateEditor definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html"/>
        /// </summary>
        public partial class DateEditor : Javax.Swing.JSpinner.DefaultEditor
        {
            const string _bridgeClassName = "javax.swing.JSpinner$DateEditor";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DateEditor() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DateEditor(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region DefaultEditor definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html"/>
        /// </summary>
        public partial class DefaultEditor : Javax.Swing.JPanel
        {
            const string _bridgeClassName = "javax.swing.JSpinner$DefaultEditor";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DefaultEditor() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DefaultEditor(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region ListEditor definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.ListEditor.html"/>
        /// </summary>
        public partial class ListEditor : Javax.Swing.JSpinner.DefaultEditor
        {
            const string _bridgeClassName = "javax.swing.JSpinner$ListEditor";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ListEditor() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ListEditor(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region NumberEditor definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html"/>
        /// </summary>
        public partial class NumberEditor : Javax.Swing.JSpinner.DefaultEditor
        {
            const string _bridgeClassName = "javax.swing.JSpinner$NumberEditor";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public NumberEditor() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public NumberEditor(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region JSpinner
    public partial class JSpinner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#%3Cinit%3E(javax.swing.SpinnerModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.SpinnerModel"/></param>
        public JSpinner(Javax.Swing.SpinnerModel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSpinner"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JSpinner t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getEditor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setEditor(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent Editor
        {
            get { return IExecuteWithSignature<Javax.Swing.JComponent>("getEditor", "()Ljavax/swing/JComponent;"); } set { IExecuteWithSignature("setEditor", "(Ljavax/swing/JComponent;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setModel(javax.swing.SpinnerModel)"/>
        /// </summary>
        public Javax.Swing.SpinnerModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.SpinnerModel>("getModel", "()Ljavax/swing/SpinnerModel;"); } set { IExecuteWithSignature("setModel", "(Ljavax/swing/SpinnerModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getNextValue()"/> 
        /// </summary>
        public object NextValue
        {
            get { return IExecuteWithSignature("getNextValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getPreviousValue()"/> 
        /// </summary>
        public object PreviousValue
        {
            get { return IExecuteWithSignature("getPreviousValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecuteWithSignature("getValue", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setValue", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#commitEdit()"/>
        /// </summary>
        /// <exception cref="Java.Text.ParseException"/>
        public void CommitEdit()
        {
            IExecuteWithSignature("commitEdit", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setUI(javax.swing.plaf.SpinnerUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.SpinnerUI"/></param>
        public void SetUI(Javax.Swing.Plaf.SpinnerUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/SpinnerUI;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region DateEditor
        public partial class DateEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#%3Cinit%3E(javax.swing.JSpinner,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public DateEditor(Javax.Swing.JSpinner arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public DateEditor(Javax.Swing.JSpinner arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#getFormat()"/> 
            /// </summary>
            public Java.Text.SimpleDateFormat Format
            {
                get { return IExecuteWithSignature<Java.Text.SimpleDateFormat>("getFormat", "()Ljava/text/SimpleDateFormat;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerDateModel Model
            {
                get { return IExecuteWithSignature<Javax.Swing.SpinnerDateModel>("getModel", "()Ljavax/swing/SpinnerDateModel;"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DefaultEditor
        public partial class DefaultEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public DefaultEditor(Javax.Swing.JSpinner arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Javax.Swing.Event.ChangeListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ChangeListener(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Javax.Swing.Event.ChangeListener>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Java.Beans.PropertyChangeListener>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Java.Awt.LayoutManager"/>
            /// </summary>
            public static implicit operator Java.Awt.LayoutManager(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Java.Awt.LayoutManager>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#getSpinner()"/> 
            /// </summary>
            public Javax.Swing.JSpinner Spinner
            {
                get { return IExecuteWithSignature<Javax.Swing.JSpinner>("getSpinner", "()Ljavax/swing/JSpinner;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#getTextField()"/> 
            /// </summary>
            public Javax.Swing.JFormattedTextField TextField
            {
                get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField>("getTextField", "()Ljavax/swing/JFormattedTextField;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#commitEdit()"/>
            /// </summary>
            /// <exception cref="Java.Text.ParseException"/>
            public void CommitEdit()
            {
                IExecuteWithSignature("commitEdit", "()V");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#dismiss(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public void Dismiss(Javax.Swing.JSpinner arg0)
            {
                IExecuteWithSignature("dismiss", "(Ljavax/swing/JSpinner;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#removeLayoutComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#stateChanged(javax.swing.event.ChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
            public void StateChanged(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecuteWithSignature("stateChanged", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListEditor
        public partial class ListEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.ListEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public ListEditor(Javax.Swing.JSpinner arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.ListEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerListModel Model
            {
                get { return IExecuteWithSignature<Javax.Swing.SpinnerListModel>("getModel", "()Ljavax/swing/SpinnerListModel;"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region NumberEditor
        public partial class NumberEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#%3Cinit%3E(javax.swing.JSpinner,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public NumberEditor(Javax.Swing.JSpinner arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public NumberEditor(Javax.Swing.JSpinner arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#getFormat()"/> 
            /// </summary>
            public Java.Text.DecimalFormat Format
            {
                get { return IExecuteWithSignature<Java.Text.DecimalFormat>("getFormat", "()Ljava/text/DecimalFormat;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerNumberModel Model
            {
                get { return IExecuteWithSignature<Javax.Swing.SpinnerNumberModel>("getModel", "()Ljavax/swing/SpinnerNumberModel;"); }
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