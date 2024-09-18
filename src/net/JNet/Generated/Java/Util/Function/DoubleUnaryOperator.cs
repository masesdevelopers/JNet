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
    #region DoubleUnaryOperator declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html"/>
    /// </summary>
    public partial class DoubleUnaryOperator : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DoubleUnaryOperator() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.function.DoubleUnaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region DoubleUnaryOperatorDirect declaration
    /// <summary>
    /// Direct override of <see cref="DoubleUnaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleUnaryOperatorDirect : DoubleUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.DoubleUnaryOperator";
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

    #region IDoubleUnaryOperator
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.DoubleUnaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html"/>
    /// </summary>
    public partial interface IDoubleUnaryOperator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        double ApplyAsDouble(double arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleUnaryOperator implementation
    public partial class DoubleUnaryOperator : Java.Util.Function.IDoubleUnaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#identity()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.DoubleUnaryOperator Identity()
        {
            return SExecuteWithSignature<Java.Util.Function.DoubleUnaryOperator>(LocalBridgeClazz, "identity", "()Ljava/util/function/DoubleUnaryOperator;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="DoubleUnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsDouble", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ApplyAsDoubleEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));
            AddEventHandler("compose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComposeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<double, double> OnApplyAsDouble { get; set; } = null;

        bool hasOverrideApplyAsDouble = true;
        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<double>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideApplyAsDouble, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(double arg0)
        {
            hasOverrideApplyAsDouble = false; return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.DoubleUnaryOperator AndThenDefault(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperator>("andThenDefault", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.DoubleUnaryOperator, Java.Util.Function.DoubleUnaryOperator> OnAndThen { get; set; } = null;

        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.DoubleUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            hasOverrideAndThen = false; return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.DoubleUnaryOperator ComposeDefault(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperator>("composeDefault", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.DoubleUnaryOperator, Java.Util.Function.DoubleUnaryOperator> OnCompose { get; set; } = null;

        bool hasOverrideCompose = true;
        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.DoubleUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideCompose, executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            hasOverrideCompose = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleUnaryOperatorDirect implementation
    public partial class DoubleUnaryOperatorDirect : Java.Util.Function.IDoubleUnaryOperator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public override double ApplyAsDouble(double arg0)
        {
            return IExecuteWithSignature<double>("applyAsDouble", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public override Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperatorDirect, Java.Util.Function.DoubleUnaryOperator>("andThen", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public override Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperatorDirect, Java.Util.Function.DoubleUnaryOperator>("compose", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}