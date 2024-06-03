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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ILongPredicate
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.LongPredicate implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html"/>
    /// </summary>
    public partial interface ILongPredicate
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongPredicate
    public partial class LongPredicate : Java.Util.Function.ILongPredicate
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
        /// Handlers initializer for <see cref="LongPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.LongPredicate>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.LongPredicate>>>(OrEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<long, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(long arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongPredicate AndDefault(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicate>("andDefault", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongPredicate, Java.Util.Function.LongPredicate> OnAnd { get; set; } = null;

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.LongPredicate>> data)
        {
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0)
        {
            return AndDefault(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongPredicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicate>("negateDefault", "()Ljava/util/function/LongPredicate;");
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongPredicate> OnNegate { get; set; } = null;

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongPredicate Negate()
        {
            return NegateDefault();
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongPredicate OrDefault(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicate>("orDefault", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongPredicate, Java.Util.Function.LongPredicate> OnOr { get; set; } = null;

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.LongPredicate>> data)
        {
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0)
        {
            return OrDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongPredicateDirect
    public partial class LongPredicateDirect : Java.Util.Function.ILongPredicate
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(long arg0)
        {
            return IExecuteWithSignature<bool>("test", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public override Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("and", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public override Java.Util.Function.LongPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("negate", "()Ljava/util/function/LongPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public override Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("or", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}