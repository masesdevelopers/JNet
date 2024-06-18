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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
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

    #region DoubleUnaryOperator
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
            AddEventHandler("applyAsDouble", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsDoubleEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.DoubleUnaryOperator>>>(AndThenEventHandler));
            AddEventHandler("compose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.DoubleUnaryOperator>>>(ComposeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsDouble"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<double, double> OnApplyAsDouble { get; set; } = null;

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var methodToExecute = (OnApplyAsDouble != null) ? OnApplyAsDouble : ApplyAsDouble;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public virtual double ApplyAsDouble(double arg0)
        {
            return default;
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

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.DoubleUnaryOperator>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return AndThenDefault(arg0);
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

        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.DoubleUnaryOperator>> data)
        {
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return ComposeDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DoubleUnaryOperatorDirect
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