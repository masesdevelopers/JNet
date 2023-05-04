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

namespace Java.Beans
{
    #region Encoder
    public partial class Encoder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#getExceptionListener()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#setExceptionListener(java.beans.ExceptionListener)"/>
        /// </summary>
        public Java.Beans.ExceptionListener ExceptionListener
        {
            get { return IExecute<Java.Beans.ExceptionListener>("getExceptionListener"); } set { IExecute("setExceptionListener", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#getPersistenceDelegate(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Beans.PersistenceDelegate"/></returns>
        public Java.Beans.PersistenceDelegate GetPersistenceDelegate(Java.Lang.Class arg0)
        {
            return IExecute<Java.Beans.PersistenceDelegate>("getPersistenceDelegate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#setPersistenceDelegate(java.lang.Class,java.beans.PersistenceDelegate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PersistenceDelegate"/></param>
        public void SetPersistenceDelegate(Java.Lang.Class arg0, Java.Beans.PersistenceDelegate arg1)
        {
            IExecute("setPersistenceDelegate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#writeExpression(java.beans.Expression)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Expression"/></param>
        public void WriteExpression(Java.Beans.Expression arg0)
        {
            IExecute("writeExpression", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#writeStatement(java.beans.Statement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Statement"/></param>
        public void WriteStatement(Java.Beans.Statement arg0)
        {
            IExecute("writeStatement", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}