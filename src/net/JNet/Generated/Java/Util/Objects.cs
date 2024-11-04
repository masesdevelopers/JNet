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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Objects declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html"/>
    /// </summary>
    public partial class Objects : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Objects>
    {
        const string _bridgeClassName = "java.util.Objects";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Objects() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Objects(params object[] args) : base(args) { }

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

    #region Objects implementation
    public partial class Objects
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#compare(java.lang.Object,java.lang.Object,java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <param name="arg2"><see cref="Java.Util.Comparator"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg2objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public static int Compare<T, Arg2objectSuperT>(T arg0, T arg1, Java.Util.Comparator<Arg2objectSuperT> arg2) where Arg2objectSuperT : T
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "compare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#requireNonNull(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T RequireNonNull<T>(T arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#requireNonNull(java.lang.Object,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T RequireNonNull<T>(T arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "requireNonNull", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#requireNonNull(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T RequireNonNull<T>(T arg0)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "requireNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#requireNonNullElse(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T RequireNonNullElse<T>(T arg0, T arg1)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "requireNonNullElse", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#requireNonNullElseGet(java.lang.Object,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg1ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public static T RequireNonNullElseGet<T, Arg1ExtendsT>(T arg0, Java.Util.Function.Supplier<Arg1ExtendsT> arg1) where Arg1ExtendsT : T
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "requireNonNullElseGet", "(Ljava/lang/Object;Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#deepEquals(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DeepEquals(object arg0, object arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "deepEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#equals(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Equals(object arg0, object arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#isNull(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNull(object arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNull", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#nonNull(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool NonNull(object arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "nonNull", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#checkFromIndexSize(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CheckFromIndexSize(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "checkFromIndexSize", "(III)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#checkFromToIndex(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CheckFromToIndex(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "checkFromToIndex", "(III)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#checkIndex(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CheckIndex(int arg0, int arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "checkIndex", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#hash(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Hash(params object[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<int>(LocalBridgeClazz, "hash", "([Ljava/lang/Object;)I"); else return SExecuteWithSignature<int>(LocalBridgeClazz, "hash", "([Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#hashCode(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(object arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#toString(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(object arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Objects.html#toString(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(object arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}