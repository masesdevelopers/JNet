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

namespace Java.Lang.Ref
{
    #region ReferenceQueue declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html"/>
    /// </summary>
    public partial class ReferenceQueue : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReferenceQueue>
    {
        const string _bridgeClassName = "java.lang.ref.ReferenceQueue";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReferenceQueue() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReferenceQueue(params object[] args) : base(args) { }

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

    #region ReferenceQueue<T> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class ReferenceQueue<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReferenceQueue<T>>
    {
        const string _bridgeClassName = "java.lang.ref.ReferenceQueue";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReferenceQueue() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReferenceQueue(params object[] args) : base(args) { }

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

    #region ReferenceQueue implementation
    public partial class ReferenceQueue
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#poll()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        public Java.Lang.Ref.Reference Poll()
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference>("poll", "()Ljava/lang/ref/Reference;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#remove()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Lang.Ref.Reference Remove()
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference>("remove", "()Ljava/lang/ref/Reference;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#remove(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Lang.Ref.Reference Remove(long arg0)
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference>("remove", "(J)Ljava/lang/ref/Reference;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ReferenceQueue<T> implementation
    public partial class ReferenceQueue<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Ref.ReferenceQueue{T}"/> to <see cref="Java.Lang.Ref.ReferenceQueue"/>
        /// </summary>
        public static implicit operator Java.Lang.Ref.ReferenceQueue(Java.Lang.Ref.ReferenceQueue<T> t) => t.Cast<Java.Lang.Ref.ReferenceQueue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#poll()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        public Java.Lang.Ref.Reference<ReturnExtendsT> Poll<ReturnExtendsT>() where ReturnExtendsT : T
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference<ReturnExtendsT>>("poll", "()Ljava/lang/ref/Reference;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#remove()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Lang.Ref.Reference<ReturnExtendsT> Remove<ReturnExtendsT>() where ReturnExtendsT : T
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference<ReturnExtendsT>>("remove", "()Ljava/lang/ref/Reference;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/ReferenceQueue.html#remove(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <typeparam name="ReturnExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Lang.Ref.Reference"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Lang.Ref.Reference<ReturnExtendsT> Remove<ReturnExtendsT>(long arg0) where ReturnExtendsT : T
        {
            return IExecuteWithSignature<Java.Lang.Ref.Reference<ReturnExtendsT>>("remove", "(J)Ljava/lang/ref/Reference;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}