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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region Predicate
    public partial class Predicate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        
        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEqual"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, Java.Util.Function.Predicate> OnIsEqual { get; set; } = null;

        void IsEqualEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnIsEqual != null) ? OnIsEqual : IsEqual;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public virtual Java.Util.Function.Predicate IsEqual(object arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNot"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate, Java.Util.Function.Predicate> OnNot { get; set; } = null;

        void NotEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate>> data)
        {
            var methodToExecute = (OnNot != null) ? OnNot : Not;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public virtual Java.Util.Function.Predicate Not(Java.Util.Function.Predicate arg0)
        {
            return default;
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="Predicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(TestEventHandler));
            AddEventHandler("and", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate>>>(AndEventHandler));
            AddEventHandler("negate", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate>>>(OrEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(object arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate AndDefault(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate>("andDefault", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate, Java.Util.Function.Predicate> OnAnd { get; set; } = null;

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate>> data)
        {
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate And(Java.Util.Function.Predicate arg0)
        {
            return AndDefault(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate>("negateDefault", "()Ljava/util/function/Predicate;");
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate> OnNegate { get; set; } = null;

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate Negate()
        {
            return NegateDefault();
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate OrDefault(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate>("orDefault", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate, Java.Util.Function.Predicate> OnOr { get; set; } = null;

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate>> data)
        {
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate Or(Java.Util.Function.Predicate arg0)
        {
            return OrDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IPredicate<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.Predicate implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html"/>
    /// </summary>
    public partial interface IPredicate<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(T arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        Java.Util.Function.Predicate<T> And<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        Java.Util.Function.Predicate<T> Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        Java.Util.Function.Predicate<T> Or<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Predicate<T>
    public partial class Predicate<T> : Java.Util.Function.IPredicate<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        
        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEqual"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<object, Java.Util.Function.Predicate<T>> OnIsEqual { get; set; } = null;

        void IsEqualEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnIsEqual != null) ? OnIsEqual : IsEqual;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public virtual Java.Util.Function.Predicate<T> IsEqual(object arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNot<Arg0objectSuperT>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate<Arg0objectSuperT>, Java.Util.Function.Predicate<T>> OnNot<Arg0objectSuperT> { get; set; } = null;

        void Not<Arg0objectSuperT>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate<Arg0objectSuperT>>> data)
        {
            var methodToExecute = (OnNot<Arg0objectSuperT> != null) ? OnNot<Arg0objectSuperT> : Not<Arg0objectSuperT>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public virtual Java.Util.Function.Predicate<T> Not<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return default;
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="Predicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(TestEventHandler));
            AddEventHandler("and", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate<Arg0objectSuperT>>>>(And<Arg0objectSuperT>EventHandler));
            AddEventHandler("negate", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate<Arg0objectSuperT>>>>(Or<Arg0objectSuperT>EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<T, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(T arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate<T> And<Arg0objectSuperT>Default(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate<T>>("andDefault", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd<Arg0objectSuperT>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate<Arg0objectSuperT>, Java.Util.Function.Predicate<T>> OnAnd<Arg0objectSuperT> { get; set; } = null;

        void And<Arg0objectSuperT>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate<Arg0objectSuperT>>> data)
        {
            var methodToExecute = (OnAnd<Arg0objectSuperT> != null) ? OnAnd<Arg0objectSuperT> : And<Arg0objectSuperT>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="And<Arg0objectSuperT>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate<T> And<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return And<Arg0objectSuperT>Default(arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate<T> NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate<T>>("negateDefault", "()Ljava/util/function/Predicate;");
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate<T>> OnNegate { get; set; } = null;

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate<T> Negate()
        {
            return NegateDefault();
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Predicate<T> Or<Arg0objectSuperT>Default(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate<T>>("orDefault", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr<Arg0objectSuperT>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.Predicate<Arg0objectSuperT>, Java.Util.Function.Predicate<T>> OnOr<Arg0objectSuperT> { get; set; } = null;

        void Or<Arg0objectSuperT>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Predicate<Arg0objectSuperT>>> data)
        {
            var methodToExecute = (OnOr<Arg0objectSuperT> != null) ? OnOr<Arg0objectSuperT> : Or<Arg0objectSuperT>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="Or<Arg0objectSuperT>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Predicate<T> Or<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return Or<Arg0objectSuperT>Default(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}