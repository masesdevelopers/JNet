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

namespace Java.Awt.Im.Spi
{
    #region InputMethodDescriptor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html"/>
    /// </summary>
    public partial class InputMethodDescriptor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InputMethodDescriptor>
    {
        const string _bridgeClassName = "java.awt.im.spi.InputMethodDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputMethodDescriptor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethodDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputMethodDescriptor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethodDescriptor(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IInputMethodDescriptor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethodDescriptor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getAvailableLocales()"/> 
        /// </summary>
        Java.Util.Locale[] AvailableLocales { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#hasDynamicLocaleList()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasDynamicLocaleList();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#createInputMethod()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Im.Spi.InputMethod"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        Java.Awt.Im.Spi.InputMethod CreateInputMethod();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodIcon(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        Java.Awt.Image GetInputMethodIcon(Java.Util.Locale arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodDisplayName(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetInputMethodDisplayName(Java.Util.Locale arg0, Java.Util.Locale arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodDescriptor implementation
    public partial class InputMethodDescriptor : Java.Awt.Im.Spi.IInputMethodDescriptor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteWithSignatureArray<Java.Util.Locale>("getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#hasDynamicLocaleList()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDynamicLocaleList()
        {
            return IExecuteWithSignature<bool>("hasDynamicLocaleList", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#createInputMethod()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Im.Spi.InputMethod"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Java.Awt.Im.Spi.InputMethod CreateInputMethod()
        {
            return IExecuteWithSignature<Java.Awt.Im.Spi.InputMethod>("createInputMethod", "()Ljava/awt/im/spi/InputMethod;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodIcon(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetInputMethodIcon(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getInputMethodIcon", "(Ljava/util/Locale;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodDisplayName(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInputMethodDisplayName(Java.Util.Locale arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getInputMethodDisplayName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}