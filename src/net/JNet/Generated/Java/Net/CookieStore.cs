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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region ICookieStore
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICookieStore
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#getCookies()"/> 
        /// </summary>
        Java.Util.List<Java.Net.HttpCookie> Cookies { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#getURIs()"/> 
        /// </summary>
        Java.Util.List<Java.Net.URI> URIs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#remove(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Remove(Java.Net.URI arg0, Java.Net.HttpCookie arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#removeAll()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool RemoveAll();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#get(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        Java.Util.List<Java.Net.HttpCookie> Get(Java.Net.URI arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#add(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        void Add(Java.Net.URI arg0, Java.Net.HttpCookie arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CookieStore
    public partial class CookieStore : Java.Net.ICookieStore
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#getCookies()"/> 
        /// </summary>
        public Java.Util.List<Java.Net.HttpCookie> Cookies
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Net.HttpCookie>>("getCookies", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#getURIs()"/> 
        /// </summary>
        public Java.Util.List<Java.Net.URI> URIs
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Net.URI>>("getURIs", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#remove(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Java.Net.URI arg0, Java.Net.HttpCookie arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#removeAll()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll()
        {
            return IExecuteWithSignature<bool>("removeAll", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#get(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.HttpCookie> Get(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.HttpCookie>>("get", "(Ljava/net/URI;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html#add(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        public void Add(Java.Net.URI arg0, Java.Net.HttpCookie arg1)
        {
            IExecute("add", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}