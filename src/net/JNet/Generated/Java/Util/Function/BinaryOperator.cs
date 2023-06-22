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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BinaryOperator
    public partial class BinaryOperator
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
        /// Handlers initializer for <see cref="BinaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyEventHandler)); OnApply = Apply;
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>>>(AndThenEventHandler)); OnAndThen = AndThen;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        public System.Func<object, object, object> OnApply { get; set; }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            if (OnApply != null)
            {
                var executionResult = OnApply.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Apply(object arg0, object arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        public System.Func<Java.Util.Function.Function, Java.Util.Function.BiFunction> OnAndThen { get; set; }

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function>> data)
        {
            if (OnAndThen != null)
            {
                var executionResult = OnAndThen.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public virtual Java.Util.Function.BiFunction AndThen(Java.Util.Function.Function arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBinaryOperator<T>
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.BinaryOperator implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html"/>
    /// </summary>
    public partial interface IBinaryOperator<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Apply<R, U>(T arg0, U arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BinaryOperator<T>
    public partial class BinaryOperator<T> : Java.Util.Function.IBinaryOperator<T>
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
        /// Handlers initializer for <see cref="BinaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(Apply<R, U>EventHandler)); OnApply<R, U> = Apply<R, U>;
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>>>>(AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler)); OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> = AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        public System.Func<T, U, R> OnApply<R, U> { get; set; }

        void Apply<R, U>EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            if (OnApply<R, U> != null)
            {
                var executionResult = OnApply<R, U>.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#apply(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public virtual R Apply<R, U>(T arg0, U arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        public System.Func<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>, Java.Util.Function.BiFunction<T, U, V>> OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> { get; set; }

        void AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV>>> data)
        {
            if (OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV> != null)
            {
                var executionResult = OnAndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiFunction.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="Arg0ExtendsV"></typeparam>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public virtual Java.Util.Function.BiFunction<T, U, V> AndThen<U, V, Arg0objectSuperR, R, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}