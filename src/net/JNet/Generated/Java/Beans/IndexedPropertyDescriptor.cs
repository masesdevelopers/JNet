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

namespace Java.Beans
{
    #region IndexedPropertyDescriptor definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html"/>
    /// </summary>
    public partial class IndexedPropertyDescriptor : Java.Beans.PropertyDescriptor
    {
        const string _bridgeClassName = "java.beans.IndexedPropertyDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IndexedPropertyDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IndexedPropertyDescriptor(params object[] args) : base(args) { }

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

    #region IndexedPropertyDescriptor
    public partial class IndexedPropertyDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, Java.Lang.String arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(Java.Lang.String arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(Java.Lang.String arg0, Java.Lang.Reflect.Method arg1, Java.Lang.Reflect.Method arg2, Java.Lang.Reflect.Method arg3, Java.Lang.Reflect.Method arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedPropertyType()"/> 
        /// </summary>
        public Java.Lang.Class IndexedPropertyType
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getIndexedPropertyType", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedReadMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#setIndexedReadMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method IndexedReadMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getIndexedReadMethod", "()Ljava/lang/reflect/Method;"); } set { IExecuteWithSignature("setIndexedReadMethod", "(Ljava/lang/reflect/Method;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedWriteMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#setIndexedWriteMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method IndexedWriteMethod
        {
            get { return IExecuteWithSignature<Java.Lang.Reflect.Method>("getIndexedWriteMethod", "()Ljava/lang/reflect/Method;"); } set { IExecuteWithSignature("setIndexedWriteMethod", "(Ljava/lang/reflect/Method;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}