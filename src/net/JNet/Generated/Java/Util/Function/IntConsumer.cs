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

namespace Java.Util.Function
{
    #region IntConsumer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html"/>
    /// </summary>
    public partial class IntConsumer : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IntConsumer() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.function.IntConsumer";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IntConsumerDirect declaration
    /// <summary>
    /// Direct override of <see cref="IntConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class IntConsumerDirect : IntConsumer
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.IntConsumer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region IIntConsumer
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.IntConsumer implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html"/>
    /// </summary>
    public partial interface IIntConsumer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void Accept(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntConsumer implementation
    public partial class IntConsumer : Java.Util.Function.IIntConsumer
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
        /// Handlers initializer for <see cref="IntConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(AcceptEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntConsumer>>>(AndThenEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void Accept(int arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntConsumer AndThenDefault(Java.Util.Function.IntConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntConsumer>("andThenDefault", "(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntConsumer, Java.Util.Function.IntConsumer> OnAndThen { get; set; } = null;

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntConsumer>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0)
        {
            return AndThenDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntConsumerDirect implementation
    public partial class IntConsumerDirect : Java.Util.Function.IIntConsumer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void Accept(int arg0)
        {
            IExecuteWithSignature("accept", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        public override Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntConsumerDirect, Java.Util.Function.IntConsumer>("andThen", "(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}