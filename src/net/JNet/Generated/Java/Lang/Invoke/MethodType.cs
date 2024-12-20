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

namespace Java.Lang.Invoke
{
    #region MethodType declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html"/>
    /// </summary>
    public partial class MethodType : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.lang.invoke.MethodType";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MethodType() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MethodType(params object[] args) : base(args) { }

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

    #region MethodType implementation
    public partial class MethodType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#fromMethodDescriptorString(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.TypeNotPresentException"/>
        public static Java.Lang.Invoke.MethodType FromMethodDescriptorString(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "fromMethodDescriptorString", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0, bool arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "genericMethodType", "(IZ)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#genericMethodType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType GenericMethodType(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "genericMethodType", "(I)Ljava/lang/invoke/MethodType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class,java.lang.Class,java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class arg1, params Java.Lang.Class[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1); else return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class,java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Class[] arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Lang.Invoke.MethodType arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0, Java.Util.List<Java.Lang.Class> arg1)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#methodType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public static Java.Lang.Invoke.MethodType MethodTypeMethod(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Lang.Invoke.MethodType>(LocalBridgeClazz, "methodType", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasPrimitives()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPrimitives()
        {
            return IExecuteWithSignature<bool>("hasPrimitives", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#hasWrappers()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasWrappers()
        {
            return IExecuteWithSignature<bool>("hasWrappers", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ParameterCount()
        {
            return IExecuteWithSignature<int>("parameterCount", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#lastParameterType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class LastParameterType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("lastParameterType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ParameterType(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.Class>("parameterType", "(I)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#returnType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ReturnType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("returnType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterArray()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class[] ParameterArray()
        {
            return IExecuteWithSignatureArray<Java.Lang.Class>("parameterArray", "()[Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#appendParameterTypes(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType AppendParameterTypes(params Java.Lang.Class[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("appendParameterTypes", "([Ljava/lang/Class;)Ljava/lang/invoke/MethodType;"); else return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("appendParameterTypes", "([Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#appendParameterTypes(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType AppendParameterTypes(Java.Util.List<Java.Lang.Class> arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("appendParameterTypes", "(Ljava/util/List;)Ljava/lang/invoke/MethodType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#changeParameterType(int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType ChangeParameterType(int arg0, Java.Lang.Class arg1)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("changeParameterType", "(ILjava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#changeReturnType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType ChangeReturnType(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("changeReturnType", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#dropParameterTypes(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType DropParameterTypes(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("dropParameterTypes", "(II)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#erase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Erase()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("erase", "()Ljava/lang/invoke/MethodType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#generic()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Generic()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("generic", "()Ljava/lang/invoke/MethodType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#insertParameterTypes(int,java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType InsertParameterTypes(int arg0, params Java.Lang.Class[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("insertParameterTypes", "(I[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0); else return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("insertParameterTypes", "(I[Ljava/lang/Class;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#insertParameterTypes(int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType InsertParameterTypes(int arg0, Java.Util.List<Java.Lang.Class> arg1)
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("insertParameterTypes", "(ILjava/util/List;)Ljava/lang/invoke/MethodType;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#unwrap()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Unwrap()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("unwrap", "()Ljava/lang/invoke/MethodType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#wrap()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Invoke.MethodType"/></returns>
        public Java.Lang.Invoke.MethodType Wrap()
        {
            return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("wrap", "()Ljava/lang/invoke/MethodType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#toMethodDescriptorString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToMethodDescriptorString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toMethodDescriptorString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodType.html#parameterList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Class> ParameterList()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Class>>("parameterList", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}