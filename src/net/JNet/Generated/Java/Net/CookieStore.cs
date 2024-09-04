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

namespace Java.Net
{
    #region CookieStore declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookieStore.html"/>
    /// </summary>
    public partial class CookieStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CookieStore>
    {
        const string _bridgeClassName = "java.net.CookieStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CookieStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookieStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CookieStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookieStore(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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

        // TODO: complete the class

    }
    #endregion

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

    #region CookieStore implementation
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