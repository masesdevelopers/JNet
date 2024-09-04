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

namespace Javax.Swing.Text
{
    #region DefaultFormatterFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html"/>
    /// </summary>
    public partial class DefaultFormatterFactory : Javax.Swing.JFormattedTextField.AbstractFormatterFactory
    {
        const string _bridgeClassName = "javax.swing.text.DefaultFormatterFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultFormatterFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultFormatterFactory(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region DefaultFormatterFactory implementation
    public partial class DefaultFormatterFactory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1, Javax.Swing.JFormattedTextField.AbstractFormatter arg2, Javax.Swing.JFormattedTextField.AbstractFormatter arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1, Javax.Swing.JFormattedTextField.AbstractFormatter arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultFormatterFactory"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.DefaultFormatterFactory t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getDefaultFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setDefaultFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter DefaultFormatter
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getDefaultFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"); } set { IExecuteWithSignature("setDefaultFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getDisplayFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setDisplayFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter DisplayFormatter
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getDisplayFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"); } set { IExecuteWithSignature("setDisplayFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getEditFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setEditFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter EditFormatter
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getEditFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"); } set { IExecuteWithSignature("setEditFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getNullFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setNullFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter NullFormatter
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getNullFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"); } set { IExecuteWithSignature("setNullFormatter", "(Ljavax/swing/JFormattedTextField$AbstractFormatter;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}