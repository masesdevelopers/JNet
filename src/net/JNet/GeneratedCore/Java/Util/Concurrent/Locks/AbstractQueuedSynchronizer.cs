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

namespace Java.Util.Concurrent.Locks
{
    #region AbstractQueuedSynchronizer definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html"/>
    /// </summary>
    public partial class AbstractQueuedSynchronizer : Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer
    {
        const string _bridgeClassName = "java.util.concurrent.locks.AbstractQueuedSynchronizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractQueuedSynchronizer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractQueuedSynchronizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractQueuedSynchronizer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractQueuedSynchronizer(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region ConditionObject definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html"/>
        /// </summary>
        public partial class ConditionObject : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConditionObject>
        {
            const string _bridgeClassName = "java.util.concurrent.locks.AbstractQueuedSynchronizer$ConditionObject";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ConditionObject() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ConditionObject(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region AbstractQueuedSynchronizer
    public partial class AbstractQueuedSynchronizer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getExclusiveQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> ExclusiveQueuedThreads
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Thread>>("getExclusiveQueuedThreads", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getFirstQueuedThread()"/> 
        /// </summary>
        public Java.Lang.Thread FirstQueuedThread
        {
            get { return IExecuteWithSignature<Java.Lang.Thread>("getFirstQueuedThread", "()Ljava/lang/Thread;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> QueuedThreads
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Thread>>("getQueuedThreads", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getQueueLength()"/> 
        /// </summary>
        public int QueueLength
        {
            get { return IExecuteWithSignature<int>("getQueueLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getSharedQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> SharedQueuedThreads
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Thread>>("getSharedQueuedThreads", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#hasContended()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasContended()
        {
            return IExecuteWithSignature<bool>("hasContended", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#hasQueuedPredecessors()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedPredecessors()
        {
            return IExecuteWithSignature<bool>("hasQueuedPredecessors", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#hasQueuedThreads()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThreads()
        {
            return IExecuteWithSignature<bool>("hasQueuedThreads", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#hasWaiters(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaiters(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject arg0)
        {
            return IExecuteWithSignature<bool>("hasWaiters", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#isQueued(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsQueued(Java.Lang.Thread arg0)
        {
            return IExecuteWithSignature<bool>("isQueued", "(Ljava/lang/Thread;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#owns(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Owns(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject arg0)
        {
            return IExecuteWithSignature<bool>("owns", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#release(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Release(int arg0)
        {
            return IExecuteWithSignature<bool>("release", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#releaseShared(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReleaseShared(int arg0)
        {
            return IExecuteWithSignature<bool>("releaseShared", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#tryAcquireNanos(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquireNanos(int arg0, long arg1)
        {
            return IExecute<bool>("tryAcquireNanos", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#tryAcquireSharedNanos(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquireSharedNanos(int arg0, long arg1)
        {
            return IExecute<bool>("tryAcquireSharedNanos", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWaitQueueLength(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject arg0)
        {
            return IExecuteWithSignature<int>("getWaitQueueLength", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#getWaitingThreads(java.util.concurrent.locks.AbstractQueuedSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.Thread> GetWaitingThreads(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Thread>>("getWaitingThreads", "(Ljava/util/concurrent/locks/AbstractQueuedSynchronizer$ConditionObject;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#acquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Acquire(int arg0)
        {
            IExecuteWithSignature("acquire", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#acquireInterruptibly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void AcquireInterruptibly(int arg0)
        {
            IExecuteWithSignature("acquireInterruptibly", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#acquireShared(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcquireShared(int arg0)
        {
            IExecuteWithSignature("acquireShared", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html#acquireSharedInterruptibly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void AcquireSharedInterruptibly(int arg0)
        {
            IExecuteWithSignature("acquireSharedInterruptibly", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ConditionObject
        public partial class ConditionObject
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#%3Cinit%3E(java.util.concurrent.locks.AbstractQueuedSynchronizer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer"/></param>
            public ConditionObject(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/> to <see cref="Java.Util.Concurrent.Locks.Condition"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Locks.Condition(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject t) => t.Cast<Java.Util.Concurrent.Locks.Condition>();
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.AbstractQueuedSynchronizer.ConditionObject t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#await(long,java.util.concurrent.TimeUnit)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool Await(long arg0, Java.Util.Concurrent.TimeUnit arg1)
            {
                return IExecute<bool>("await", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#awaitUntil(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool AwaitUntil(Java.Util.Date arg0)
            {
                return IExecuteWithSignature<bool>("awaitUntil", "(Ljava/util/Date;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#awaitNanos(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="long"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public long AwaitNanos(long arg0)
            {
                return IExecuteWithSignature<long>("awaitNanos", "(J)J", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#await()"/>
            /// </summary>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void Await()
            {
                IExecuteWithSignature("await", "()V");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#awaitUninterruptibly()"/>
            /// </summary>
            public void AwaitUninterruptibly()
            {
                IExecuteWithSignature("awaitUninterruptibly", "()V");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#signal()"/>
            /// </summary>
            public void Signal()
            {
                IExecuteWithSignature("signal", "()V");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html#signalAll()"/>
            /// </summary>
            public void SignalAll()
            {
                IExecuteWithSignature("signalAll", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}