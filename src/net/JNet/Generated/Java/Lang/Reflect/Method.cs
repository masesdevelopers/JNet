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

namespace Java.Lang.Reflect
{
    #region Method declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html"/>
    /// </summary>
    public partial class Method : Java.Lang.Reflect.Executable
    {
        const string _bridgeClassName = "java.lang.reflect.Method";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Method() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Method(params object[] args) : base(args) { }

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

    #region Method implementation
    public partial class Method
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#getDefaultValue()"/> 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecuteWithSignature("getDefaultValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#getGenericReturnType()"/> 
        /// </summary>
        public Java.Lang.Reflect.Type GenericReturnType
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Type>("getGenericReturnType", "()Ljava/lang/reflect/Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#getReturnType()"/> 
        /// </summary>
        public Java.Lang.Class ReturnType
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getReturnType", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#isBridge()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBridge()
        {
            return IExecuteWithSignature<bool>("isBridge", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#isDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefault()
        {
            return IExecuteWithSignature<bool>("isDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Method.html#invoke(java.lang.Object,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.Reflect.InvocationTargetException"/>
        public object Invoke(object arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature("invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", arg0); else return IExecuteWithSignature("invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}