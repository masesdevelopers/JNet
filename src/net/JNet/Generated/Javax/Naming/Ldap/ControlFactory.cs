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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Ldap
{
    #region ControlFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ControlFactory.html"/>
    /// </summary>
    public partial class ControlFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ControlFactory>
    {
        const string _bridgeClassName = "javax.naming.ldap.ControlFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ControlFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ControlFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ControlFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ControlFactory(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ControlFactory implementation
    public partial class ControlFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ControlFactory.html#getControlInstance(javax.naming.ldap.Control,javax.naming.Context,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg2"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.Control"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Ldap.Control GetControlInstance(Javax.Naming.Ldap.Control arg0, Javax.Naming.Context arg1, Java.Util.Hashtable<object, object> arg2)
        {
            return SExecute<Javax.Naming.Ldap.Control>(LocalBridgeClazz, "getControlInstance", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/ControlFactory.html#getControlInstance(javax.naming.ldap.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.Control"/></param>
        /// <returns><see cref="Javax.Naming.Ldap.Control"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Ldap.Control GetControlInstance(Javax.Naming.Ldap.Control arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Ldap.Control>("getControlInstance", "(Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/Control;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}