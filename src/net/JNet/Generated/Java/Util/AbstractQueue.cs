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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region AbstractQueue
    public partial class AbstractQueue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractQueue"/> to <see cref="Java.Util.Queue"/>
        /// </summary>
        public static implicit operator Java.Util.Queue(Java.Util.AbstractQueue t) => t.Cast<Java.Util.Queue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractQueue.html#element()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecute("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractQueue.html#remove()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractQueue<E>
    public partial class AbstractQueue<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractQueue{E}"/> to <see cref="Java.Util.Queue{E}"/>
        /// </summary>
        public static implicit operator Java.Util.Queue<E>(Java.Util.AbstractQueue<E> t) => t.Cast<Java.Util.Queue<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractQueue{E}"/> to <see cref="Java.Util.AbstractQueue"/>
        /// </summary>
        public static implicit operator Java.Util.AbstractQueue(Java.Util.AbstractQueue<E> t) => t.Cast<Java.Util.AbstractQueue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractQueue.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecute<E>("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractQueue.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecute<E>("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}