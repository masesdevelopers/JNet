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
    #region OptionalInt declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html"/>
    /// </summary>
    public partial class OptionalInt : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OptionalInt>
    {
        const string _bridgeClassName = "java.util.OptionalInt";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OptionalInt() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OptionalInt(params object[] args) : base(args) { }

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

    #region OptionalInt implementation
    public partial class OptionalInt
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public static Java.Util.OptionalInt Empty()
        {
            return SExecuteWithSignature<Java.Util.OptionalInt>(LocalBridgeClazz, "empty", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public static Java.Util.OptionalInt Of(int arg0)
        {
            return SExecuteWithSignature<Java.Util.OptionalInt>(LocalBridgeClazz, "of", "(I)Ljava/util/OptionalInt;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#getAsInt()"/> 
        /// </summary>
        public int AsInt
        {
            get { return IExecuteWithSignature<int>("getAsInt", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsX"><typeparamref name="X"/></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public int OrElseThrow<Arg0ExtendsX, X>(Java.Util.Function.Supplier<Arg0ExtendsX> arg0) where Arg0ExtendsX : X
        {
            return IExecute<int>("orElseThrow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#orElse(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int OrElse(int arg0)
        {
            return IExecuteWithSignature<int>("orElse", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#orElseGet(java.util.function.IntSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntSupplier"/></param>
        /// <returns><see cref="int"/></returns>
        public int OrElseGet(Java.Util.Function.IntSupplier arg0)
        {
            return IExecuteWithSignature<int>("orElseGet", "(Ljava/util/function/IntSupplier;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#orElseThrow()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int OrElseThrow()
        {
            return IExecuteWithSignature<int>("orElseThrow", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#stream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Stream()
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("stream", "()Ljava/util/stream/IntStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#ifPresent(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        public void IfPresent(Java.Util.Function.IntConsumer arg0)
        {
            IExecuteWithSignature("ifPresent", "(Ljava/util/function/IntConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalInt.html#ifPresentOrElse(java.util.function.IntConsumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.IntConsumer arg0, Java.Lang.Runnable arg1)
        {
            IExecuteWithSignature("ifPresentOrElse", "(Ljava/util/function/IntConsumer;Ljava/lang/Runnable;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}