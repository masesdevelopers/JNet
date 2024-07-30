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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming
{
    #region NamingEnumeration
    public partial class NamingEnumeration
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#hasMore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public bool HasMore()
        {
            return IExecuteWithSignature<bool>("hasMore", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#next()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Next()
        {
            return IExecuteWithSignature("next", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region INamingEnumeration<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INamingEnumeration<T> : Java.Util.IEnumeration<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#hasMore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        bool HasMore();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#next()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        T Next();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamingEnumeration<T>
    public partial class NamingEnumeration<T> : Javax.Naming.INamingEnumeration<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.NamingEnumeration{T}"/> to <see cref="Javax.Naming.NamingEnumeration"/>
        /// </summary>
        public static implicit operator Javax.Naming.NamingEnumeration(Javax.Naming.NamingEnumeration<T> t) => t.Cast<Javax.Naming.NamingEnumeration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#hasMore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public bool HasMore()
        {
            return IExecuteWithSignature<bool>("hasMore", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#next()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public T Next()
        {
            return IExecuteWithSignature<T>("next", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NamingEnumeration.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}