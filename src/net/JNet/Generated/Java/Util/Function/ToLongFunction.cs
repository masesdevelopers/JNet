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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region ToLongFunction
    public partial class ToLongFunction
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToLongFunction.html#applyAsLong(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long ApplyAsLong(object arg0)
        {
            return IExecute<long>("applyAsLong", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToLongFunction<T>
    public partial class ToLongFunction<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Function.ToLongFunction{T}"/> to <see cref="Java.Util.Function.ToLongFunction"/>
        /// </summary>
        public static implicit operator Java.Util.Function.ToLongFunction(Java.Util.Function.ToLongFunction<T> t) => t.Cast<Java.Util.Function.ToLongFunction>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ToLongFunction.html#applyAsLong(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long ApplyAsLong(T arg0)
        {
            return IExecute<long>("applyAsLong", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}