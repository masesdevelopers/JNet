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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im
{
    #region InputContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html"/>
    /// </summary>
    public partial class InputContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InputContext>
    {
        const string _bridgeClassName = "java.awt.im.InputContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InputContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InputContext(params object[] args) : base(args) { }

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

    #region InputContext implementation
    public partial class InputContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#getInstance()"/> 
        /// </summary>
        public static Java.Awt.Im.InputContext Instance
        {
            get { return SExecuteWithSignature<Java.Awt.Im.InputContext>(LocalBridgeClazz, "getInstance", "()Ljava/awt/im/InputContext;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#getInputMethodControlObject()"/> 
        /// </summary>
        public object InputMethodControlObject
        {
            get { return IExecuteWithSignature("getInputMethodControlObject", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#isCompositionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompositionEnabled()
        {
            return IExecuteWithSignature<bool>("isCompositionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#selectInputMethod(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SelectInputMethod(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<bool>("selectInputMethod", "(Ljava/util/Locale;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        public void DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            IExecuteWithSignature("dispatchEvent", "(Ljava/awt/AWTEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#endComposition()"/>
        /// </summary>
        public void EndComposition()
        {
            IExecuteWithSignature("endComposition", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#reconvert()"/>
        /// </summary>
        public void Reconvert()
        {
            IExecuteWithSignature("reconvert", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#removeNotify(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveNotify(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("removeNotify", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#setCharacterSubsets(java.lang.Character.Subset[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Character.Subset"/></param>
        public void SetCharacterSubsets(Java.Lang.Character.Subset[] arg0)
        {
            IExecuteWithSignature("setCharacterSubsets", "([Ljava/lang/Character$Subset;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputContext.html#setCompositionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCompositionEnabled(bool arg0)
        {
            IExecuteWithSignature("setCompositionEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}