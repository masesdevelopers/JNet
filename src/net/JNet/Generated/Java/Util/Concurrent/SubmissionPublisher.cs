/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region SubmissionPublisher
    public partial class SubmissionPublisher
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1, Java.Util.Function.BiConsumer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Util.Concurrent.SubmissionPublisher t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getClosedException()"/> 
        /// </summary>
        public Java.Lang.Throwable ClosedException
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getClosedException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#estimateMaximumLag()"/> 
        /// </summary>
        public int EstimateMaximumLag
        {
            get { return IExecute<int>("estimateMaximumLag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#estimateMinimumDemand()"/> 
        /// </summary>
        public long EstimateMinimumDemand
        {
            get { return IExecute<long>("estimateMinimumDemand"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getExecutor()"/> 
        /// </summary>
        public Java.Util.Concurrent.Executor Executor
        {
            get { return IExecute<Java.Util.Concurrent.Executor>("getExecutor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#hasSubscribers()"/> 
        /// </summary>
        public bool HasSubscribers
        {
            get { return IExecute<bool>("hasSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#isClosed()"/> 
        /// </summary>
        public bool IsClosed
        {
            get { return IExecute<bool>("isClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getMaxBufferCapacity()"/> 
        /// </summary>
        public int MaxBufferCapacity
        {
            get { return IExecute<int>("getMaxBufferCapacity"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getNumberOfSubscribers()"/> 
        /// </summary>
        public int NumberOfSubscribers
        {
            get { return IExecute<int>("getNumberOfSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getSubscribers()"/> 
        /// </summary>
        public Java.Util.List Subscribers
        {
            get { return IExecute<Java.Util.List>("getSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#isSubscribed(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubscribed(Java.Util.Concurrent.Flow.Subscriber arg0)
        {
            return IExecute<bool>("isSubscribed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="int"/></returns>
        public int Offer(object arg0, Java.Util.Function.BiPredicate arg1)
        {
            return IExecute<int>("offer", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="int"/></returns>
        public int Offer(object arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, Java.Util.Function.BiPredicate arg3)
        {
            return IExecute<int>("offer", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#submit(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Submit(object arg0)
        {
            return IExecute<int>("submit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#consume(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture Consume(Java.Util.Function.Consumer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("consume", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#closeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CloseExceptionally(Java.Lang.Throwable arg0)
        {
            IExecute("closeExceptionally", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        public void Subscribe(Java.Util.Concurrent.Flow.Subscriber arg0)
        {
            IExecute("subscribe", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SubmissionPublisher<T>
    public partial class SubmissionPublisher<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1, Java.Util.Function.BiConsumer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher{T}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Util.Concurrent.SubmissionPublisher<T> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher{T}"/> to <see cref="Java.Util.Concurrent.SubmissionPublisher"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.SubmissionPublisher(Java.Util.Concurrent.SubmissionPublisher<T> t) => t.Cast<Java.Util.Concurrent.SubmissionPublisher>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getClosedException()"/> 
        /// </summary>
        public Java.Lang.Throwable ClosedException
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getClosedException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#estimateMaximumLag()"/> 
        /// </summary>
        public int EstimateMaximumLag
        {
            get { return IExecute<int>("estimateMaximumLag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#estimateMinimumDemand()"/> 
        /// </summary>
        public long EstimateMinimumDemand
        {
            get { return IExecute<long>("estimateMinimumDemand"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getExecutor()"/> 
        /// </summary>
        public Java.Util.Concurrent.Executor Executor
        {
            get { return IExecute<Java.Util.Concurrent.Executor>("getExecutor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#hasSubscribers()"/> 
        /// </summary>
        public bool HasSubscribers
        {
            get { return IExecute<bool>("hasSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#isClosed()"/> 
        /// </summary>
        public bool IsClosed
        {
            get { return IExecute<bool>("isClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getMaxBufferCapacity()"/> 
        /// </summary>
        public int MaxBufferCapacity
        {
            get { return IExecute<int>("getMaxBufferCapacity"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getNumberOfSubscribers()"/> 
        /// </summary>
        public int NumberOfSubscribers
        {
            get { return IExecute<int>("getNumberOfSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#getSubscribers()"/> 
        /// </summary>
        public Java.Util.List Subscribers
        {
            get { return IExecute<Java.Util.List>("getSubscribers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#isSubscribed(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubscribed<Arg0objectSuperT>(Java.Util.Concurrent.Flow.Subscriber<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<bool>("isSubscribed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg1objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int Offer<Arg1objectSuperT>(T arg0, Java.Util.Function.BiPredicate<Java.Util.Concurrent.Flow.Subscriber<Arg1objectSuperT>, Arg1objectSuperT> arg1) where Arg1objectSuperT: T
        {
            return IExecute<int>("offer", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg3objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int Offer<Arg3objectSuperT>(T arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, Java.Util.Function.BiPredicate<Java.Util.Concurrent.Flow.Subscriber<Arg3objectSuperT>, Arg3objectSuperT> arg3) where Arg3objectSuperT: T
        {
            return IExecute<int>("offer", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#submit(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int Submit(T arg0)
        {
            return IExecute<int>("submit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#consume(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.Void> Consume<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Lang.Void>>("consume", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#closeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CloseExceptionally(Java.Lang.Throwable arg0)
        {
            IExecute("closeExceptionally", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/SubmissionPublisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void Subscribe<Arg0objectSuperT>(Java.Util.Concurrent.Flow.Subscriber<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            IExecute("subscribe", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}