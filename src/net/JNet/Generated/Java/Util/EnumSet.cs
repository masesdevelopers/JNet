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

namespace Java.Util
{
    #region EnumSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html"/>
    /// </summary>
    public partial class EnumSet : Java.Util.AbstractSet
    {
        const string _bridgeClassName = "java.util.EnumSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EnumSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EnumSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EnumSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EnumSet(params object[] args) : base(args) { }

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

    #region EnumSet<E> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html"/>
    /// </summary>
    /// <typeparam name="E"><see cref="Java.Lang.Enum{E}"/></typeparam>
    public partial class EnumSet<E> : Java.Util.AbstractSet<E> where E : Java.Lang.Enum<E>
    {
        const string _bridgeClassName = "java.util.EnumSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EnumSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EnumSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EnumSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EnumSet(params object[] args) : base(args) { }

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

    #region EnumSet implementation
    public partial class EnumSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.EnumSet t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.EnumSet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#allOf(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet AllOf(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "allOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#complementOf(java.util.EnumSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumSet"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet ComplementOf(Java.Util.EnumSet arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "complementOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#copyOf(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet CopyOf(Java.Util.Collection arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#copyOf(java.util.EnumSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumSet"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet CopyOf(Java.Util.EnumSet arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#noneOf(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet NoneOf(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "noneOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0, Java.Lang.Enum arg1, Java.Lang.Enum arg2, Java.Lang.Enum arg3, Java.Lang.Enum arg4)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0, Java.Lang.Enum arg1, Java.Lang.Enum arg2, Java.Lang.Enum arg3)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0, Java.Lang.Enum arg1, Java.Lang.Enum arg2)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0, params Java.Lang.Enum[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0); else return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0, Java.Lang.Enum arg1)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Of(Java.Lang.Enum arg0)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#range(java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Enum"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet Range(Java.Lang.Enum arg0, Java.Lang.Enum arg1)
        {
            return SExecute<Java.Util.EnumSet>(LocalBridgeClazz, "range", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public Java.Util.EnumSet Clone()
        {
            return IExecuteWithSignature<Java.Util.EnumSet>("clone", "()Ljava/util/EnumSet;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EnumSet<E> implementation
    public partial class EnumSet<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumSet{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.EnumSet<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumSet{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.EnumSet<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumSet{E}"/> to <see cref="Java.Util.EnumSet"/>
        /// </summary>
        public static implicit operator Java.Util.EnumSet(Java.Util.EnumSet<E> t) => t.Cast<Java.Util.EnumSet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#allOf(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> AllOf(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "allOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#complementOf(java.util.EnumSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumSet"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> ComplementOf(Java.Util.EnumSet<E> arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "complementOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#copyOf(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> CopyOf(Java.Util.Collection<E> arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#copyOf(java.util.EnumSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumSet"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> CopyOf(Java.Util.EnumSet<E> arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#noneOf(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> NoneOf(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "noneOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0, E arg1, E arg2, E arg3)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0, E arg1, E arg2)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0, params E[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0); else return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0, E arg1)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#of(java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Of(E arg0)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#range(java.lang.Enum,java.lang.Enum)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public static Java.Util.EnumSet<E> Range(E arg0, E arg1)
        {
            return SExecute<Java.Util.EnumSet<E>>(LocalBridgeClazz, "range", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/EnumSet.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EnumSet"/></returns>
        public Java.Util.EnumSet<E> Clone()
        {
            return IExecuteWithSignature<Java.Util.EnumSet<E>>("clone", "()Ljava/util/EnumSet;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}