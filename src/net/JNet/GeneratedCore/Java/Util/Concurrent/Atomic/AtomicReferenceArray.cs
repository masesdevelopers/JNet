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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicReferenceArray definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html"/>
    /// </summary>
    public partial class AtomicReferenceArray : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.concurrent.atomic.AtomicReferenceArray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AtomicReferenceArray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AtomicReferenceArray(params object[] args) : base(args) { }

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

    #region AtomicReferenceArray<E> definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html"/>
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public partial class AtomicReferenceArray<E> : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.concurrent.atomic.AtomicReferenceArray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AtomicReferenceArray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AtomicReferenceArray(params object[] args) : base(args) { }

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

    #region AtomicReferenceArray
    public partial class AtomicReferenceArray
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public AtomicReferenceArray(int arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndSet(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(int arg0, object arg1, object arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetAcquire(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(int arg0, object arg1, object arg2)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetPlain(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(int arg0, object arg1, object arg2)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetRelease(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(int arg0, object arg1, object arg2)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetVolatile(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(int arg0, object arg1, object arg2)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#accumulateAndGet(int,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object AccumulateAndGet(int arg0, object arg1, Java.Util.Function.BinaryOperator arg2)
        {
            return IExecute("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchange(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchange(int arg0, object arg1, object arg2)
        {
            return IExecute("compareAndExchange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchangeAcquire(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeAcquire(int arg0, object arg1, object arg2)
        {
            return IExecute("compareAndExchangeAcquire", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchangeRelease(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CompareAndExchangeRelease(int arg0, object arg1, object arg2)
        {
            return IExecute("compareAndExchangeRelease", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int arg0)
        {
            return IExecuteWithSignature("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAcquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAcquire(int arg0)
        {
            return IExecuteWithSignature("getAcquire", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndAccumulate(int,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAccumulate(int arg0, object arg1, Java.Util.Function.BinaryOperator arg2)
        {
            return IExecute("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndSet(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSet(int arg0, object arg1)
        {
            return IExecute("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndUpdate(int,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndUpdate(int arg0, Java.Util.Function.UnaryOperator arg1)
        {
            return IExecute("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getOpaque(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOpaque(int arg0)
        {
            return IExecuteWithSignature("getOpaque", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getPlain(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetPlain(int arg0)
        {
            return IExecuteWithSignature("getPlain", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#updateAndGet(int,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object UpdateAndGet(int arg0, Java.Util.Function.UnaryOperator arg1)
        {
            return IExecute("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#lazySet(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void LazySet(int arg0, object arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Set(int arg0, object arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setOpaque(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetOpaque(int arg0, object arg1)
        {
            IExecute("setOpaque", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setPlain(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetPlain(int arg0, object arg1)
        {
            IExecute("setPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setRelease(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetRelease(int arg0, object arg1)
        {
            IExecute("setRelease", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicReferenceArray<E>
    public partial class AtomicReferenceArray<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#%3Cinit%3E(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public AtomicReferenceArray(E[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public AtomicReferenceArray(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicReferenceArray{E}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicReferenceArray"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicReferenceArray(Java.Util.Concurrent.Atomic.AtomicReferenceArray<E> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicReferenceArray>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndSet(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(int arg0, E arg1, E arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetAcquire(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(int arg0, E arg1, E arg2)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetPlain(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(int arg0, E arg1, E arg2)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetRelease(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(int arg0, E arg1, E arg2)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#weakCompareAndSetVolatile(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(int arg0, E arg1, E arg2)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#accumulateAndGet(int,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E AccumulateAndGet(int arg0, E arg1, Java.Util.Function.BinaryOperator<E> arg2)
        {
            return IExecute<E>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchange(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E CompareAndExchange(int arg0, E arg1, E arg2)
        {
            return IExecute<E>("compareAndExchange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchangeAcquire(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E CompareAndExchangeAcquire(int arg0, E arg1, E arg2)
        {
            return IExecute<E>("compareAndExchangeAcquire", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#compareAndExchangeRelease(int,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E CompareAndExchangeRelease(int arg0, E arg1, E arg2)
        {
            return IExecute<E>("compareAndExchangeRelease", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(int arg0)
        {
            return IExecuteWithSignature<E>("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAcquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetAcquire(int arg0)
        {
            return IExecuteWithSignature<E>("getAcquire", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndAccumulate(int,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetAndAccumulate(int arg0, E arg1, Java.Util.Function.BinaryOperator<E> arg2)
        {
            return IExecute<E>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndSet(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetAndSet(int arg0, E arg1)
        {
            return IExecute<E>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getAndUpdate(int,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetAndUpdate(int arg0, Java.Util.Function.UnaryOperator<E> arg1)
        {
            return IExecute<E>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getOpaque(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetOpaque(int arg0)
        {
            return IExecuteWithSignature<E>("getOpaque", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#getPlain(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E GetPlain(int arg0)
        {
            return IExecuteWithSignature<E>("getPlain", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#updateAndGet(int,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E UpdateAndGet(int arg0, Java.Util.Function.UnaryOperator<E> arg1)
        {
            return IExecute<E>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#lazySet(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void LazySet(int arg0, E arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Set(int arg0, E arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setOpaque(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void SetOpaque(int arg0, E arg1)
        {
            IExecute("setOpaque", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setPlain(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void SetPlain(int arg0, E arg1)
        {
            IExecute("setPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceArray.html#setRelease(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void SetRelease(int arg0, E arg1)
        {
            IExecute("setRelease", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}