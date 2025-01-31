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
    #region MethodHandleInfo declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html"/>
    /// </summary>
    public partial class MethodHandleInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MethodHandleInfo>
    {
        const string _bridgeClassName = "java.lang.invoke.MethodHandleInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MethodHandleInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MethodHandleInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MethodHandleInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MethodHandleInfo(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IMethodHandleInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMethodHandleInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getDeclaringClass()"/> 
        /// </summary>
        Java.Lang.Class DeclaringClass { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getMethodType()"/> 
        /// </summary>
        Java.Lang.Invoke.MethodType MethodType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getModifiers()"/> 
        /// </summary>
        int Modifiers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getReferenceKind()"/> 
        /// </summary>
        int ReferenceKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#reflectAs(java.lang.Class,java.lang.invoke.MethodHandles.Lookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Reflect.IMember"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        T ReflectAs<T>(Java.Lang.Class arg0, Java.Lang.Invoke.MethodHandles.Lookup arg1) where T : Java.Lang.Reflect.IMember, new();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsVarArgs();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MethodHandleInfo implementation
    public partial class MethodHandleInfo : Java.Lang.Invoke.IMethodHandleInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_getField"/>
        /// </summary>
        public static int REF_getField { get { if (!_REF_getFieldReady) { _REF_getFieldContent = SGetField<int>(LocalBridgeClazz, "REF_getField"); _REF_getFieldReady = true; } return _REF_getFieldContent; } }
        private static int _REF_getFieldContent = default;
        private static bool _REF_getFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_getStatic"/>
        /// </summary>
        public static int REF_getStatic { get { if (!_REF_getStaticReady) { _REF_getStaticContent = SGetField<int>(LocalBridgeClazz, "REF_getStatic"); _REF_getStaticReady = true; } return _REF_getStaticContent; } }
        private static int _REF_getStaticContent = default;
        private static bool _REF_getStaticReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeInterface"/>
        /// </summary>
        public static int REF_invokeInterface { get { if (!_REF_invokeInterfaceReady) { _REF_invokeInterfaceContent = SGetField<int>(LocalBridgeClazz, "REF_invokeInterface"); _REF_invokeInterfaceReady = true; } return _REF_invokeInterfaceContent; } }
        private static int _REF_invokeInterfaceContent = default;
        private static bool _REF_invokeInterfaceReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeSpecial"/>
        /// </summary>
        public static int REF_invokeSpecial { get { if (!_REF_invokeSpecialReady) { _REF_invokeSpecialContent = SGetField<int>(LocalBridgeClazz, "REF_invokeSpecial"); _REF_invokeSpecialReady = true; } return _REF_invokeSpecialContent; } }
        private static int _REF_invokeSpecialContent = default;
        private static bool _REF_invokeSpecialReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeStatic"/>
        /// </summary>
        public static int REF_invokeStatic { get { if (!_REF_invokeStaticReady) { _REF_invokeStaticContent = SGetField<int>(LocalBridgeClazz, "REF_invokeStatic"); _REF_invokeStaticReady = true; } return _REF_invokeStaticContent; } }
        private static int _REF_invokeStaticContent = default;
        private static bool _REF_invokeStaticReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_invokeVirtual"/>
        /// </summary>
        public static int REF_invokeVirtual { get { if (!_REF_invokeVirtualReady) { _REF_invokeVirtualContent = SGetField<int>(LocalBridgeClazz, "REF_invokeVirtual"); _REF_invokeVirtualReady = true; } return _REF_invokeVirtualContent; } }
        private static int _REF_invokeVirtualContent = default;
        private static bool _REF_invokeVirtualReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_newInvokeSpecial"/>
        /// </summary>
        public static int REF_newInvokeSpecial { get { if (!_REF_newInvokeSpecialReady) { _REF_newInvokeSpecialContent = SGetField<int>(LocalBridgeClazz, "REF_newInvokeSpecial"); _REF_newInvokeSpecialReady = true; } return _REF_newInvokeSpecialContent; } }
        private static int _REF_newInvokeSpecialContent = default;
        private static bool _REF_newInvokeSpecialReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_putField"/>
        /// </summary>
        public static int REF_putField { get { if (!_REF_putFieldReady) { _REF_putFieldContent = SGetField<int>(LocalBridgeClazz, "REF_putField"); _REF_putFieldReady = true; } return _REF_putFieldContent; } }
        private static int _REF_putFieldContent = default;
        private static bool _REF_putFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#REF_putStatic"/>
        /// </summary>
        public static int REF_putStatic { get { if (!_REF_putStaticReady) { _REF_putStaticContent = SGetField<int>(LocalBridgeClazz, "REF_putStatic"); _REF_putStaticReady = true; } return _REF_putStaticContent; } }
        private static int _REF_putStaticContent = default;
        private static bool _REF_putStaticReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#referenceKindToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ReferenceKindToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "referenceKindToString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#toString(int,java.lang.Class,java.lang.String,java.lang.invoke.MethodType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Invoke.MethodType"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(int arg0, Java.Lang.Class arg1, Java.Lang.String arg2, Java.Lang.Invoke.MethodType arg3)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(ILjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/String;", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getDeclaringClass()"/> 
        /// </summary>
        public Java.Lang.Class DeclaringClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getMethodType()"/> 
        /// </summary>
        public Java.Lang.Invoke.MethodType MethodType
        {
            get { return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("getMethodType", "()Ljava/lang/invoke/MethodType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecuteWithSignature<int>("getModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#getReferenceKind()"/> 
        /// </summary>
        public int ReferenceKind
        {
            get { return IExecuteWithSignature<int>("getReferenceKind", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#reflectAs(java.lang.Class,java.lang.invoke.MethodHandles.Lookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Reflect.IMember"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T ReflectAs<T>(Java.Lang.Class arg0, Java.Lang.Invoke.MethodHandles.Lookup arg1) where T : Java.Lang.Reflect.IMember, new()
        {
            return IExecute<T>("reflectAs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/invoke/MethodHandleInfo.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecuteWithSignature<bool>("isVarArgs", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}