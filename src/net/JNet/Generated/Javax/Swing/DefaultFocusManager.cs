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
    #region DefaultFocusManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html"/>
    /// </summary>
    public partial class DefaultFocusManager : Javax.Swing.FocusManager
    {
        const string _bridgeClassName = "javax.swing.DefaultFocusManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultFocusManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultFocusManager(params object[] args) : base(args) { }

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

    #region DefaultFocusManager implementation
    public partial class DefaultFocusManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#compareTabOrder(java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareTabOrder(Java.Awt.Component arg0, Java.Awt.Component arg1)
        {
            return IExecute<bool>("compareTabOrder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getComponentAfter(java.awt.Container,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentAfter(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getComponentBefore(java.awt.Container,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentBefore(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentBefore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getFirstComponent(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetFirstComponent(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getFirstComponent", "(Ljava/awt/Container;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getLastComponent(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetLastComponent(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getLastComponent", "(Ljava/awt/Container;)Ljava/awt/Component;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}