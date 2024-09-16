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

namespace Javax.Security.Auth.Callback
{
    #region ChoiceCallback declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html"/>
    /// </summary>
    public partial class ChoiceCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ChoiceCallback>
    {
        const string _bridgeClassName = "javax.security.auth.callback.ChoiceCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ChoiceCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ChoiceCallback(params object[] args) : base(args) { }

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

    #region ChoiceCallback implementation
    public partial class ChoiceCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#%3Cinit%3E(java.lang.String,java.lang.String[],int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public ChoiceCallback(Java.Lang.String arg0, Java.Lang.String[] arg1, int arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ChoiceCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.ChoiceCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ChoiceCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.ChoiceCallback t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getChoices()"/> 
        /// </summary>
        public Java.Lang.String[] Choices
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getChoices", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getDefaultChoice()"/> 
        /// </summary>
        public int DefaultChoice
        {
            get { return IExecuteWithSignature<int>("getDefaultChoice", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getPrompt()"/> 
        /// </summary>
        public Java.Lang.String Prompt
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrompt", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#getSelectedIndexes()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#setSelectedIndexes(int[])"/>
        /// </summary>
        public int[] SelectedIndexes
        {
            get { return IExecuteWithSignatureArray<int>("getSelectedIndexes", "()[I"); } set { IExecuteWithSignature("setSelectedIndexes", "([I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#allowMultipleSelections()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AllowMultipleSelections()
        {
            return IExecuteWithSignature<bool>("allowMultipleSelections", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ChoiceCallback.html#setSelectedIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSelectedIndex(int arg0)
        {
            IExecuteWithSignature("setSelectedIndex", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}