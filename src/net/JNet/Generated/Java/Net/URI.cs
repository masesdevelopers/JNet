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

namespace Java.Net
{
    #region URI
    public partial class URI
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,int,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(string arg0, string arg1, string arg2, int arg3, string arg4, string arg5, string arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(string arg0, string arg1, string arg2, string arg3, string arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(string arg0, string arg1, string arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(string arg0, string arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Net.URI"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Net.URI t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Net.URI"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Net.URI t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#create(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public static Java.Net.URI Create(string arg0)
        {
            return SExecute<Java.Net.URI>(LocalBridgeClazz, "create", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getAuthority()"/> 
        /// </summary>
        public string Authority
        {
            get { return IExecute<string>("getAuthority"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getFragment()"/> 
        /// </summary>
        public string Fragment
        {
            get { return IExecute<string>("getFragment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getHost()"/> 
        /// </summary>
        public string Host
        {
            get { return IExecute<string>("getHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getPath()"/> 
        /// </summary>
        public string Path
        {
            get { return IExecute<string>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecute<int>("getPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getQuery()"/> 
        /// </summary>
        public string Query
        {
            get { return IExecute<string>("getQuery"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawAuthority()"/> 
        /// </summary>
        public string RawAuthority
        {
            get { return IExecute<string>("getRawAuthority"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawFragment()"/> 
        /// </summary>
        public string RawFragment
        {
            get { return IExecute<string>("getRawFragment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawPath()"/> 
        /// </summary>
        public string RawPath
        {
            get { return IExecute<string>("getRawPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawQuery()"/> 
        /// </summary>
        public string RawQuery
        {
            get { return IExecute<string>("getRawQuery"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawSchemeSpecificPart()"/> 
        /// </summary>
        public string RawSchemeSpecificPart
        {
            get { return IExecute<string>("getRawSchemeSpecificPart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawUserInfo()"/> 
        /// </summary>
        public string RawUserInfo
        {
            get { return IExecute<string>("getRawUserInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getScheme()"/> 
        /// </summary>
        public string Scheme
        {
            get { return IExecute<string>("getScheme"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getSchemeSpecificPart()"/> 
        /// </summary>
        public string SchemeSpecificPart
        {
            get { return IExecute<string>("getSchemeSpecificPart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getUserInfo()"/> 
        /// </summary>
        public string UserInfo
        {
            get { return IExecute<string>("getUserInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#isAbsolute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecute<bool>("isAbsolute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#isOpaque()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOpaque()
        {
            return IExecute<bool>("isOpaque");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#compareTo(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Net.URI arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#toASCIIString()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ToASCIIString()
        {
            return IExecute<string>("toASCIIString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#normalize()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Normalize()
        {
            return IExecute<Java.Net.URI>("normalize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#parseServerAuthority()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public Java.Net.URI ParseServerAuthority()
        {
            return IExecute<Java.Net.URI>("parseServerAuthority");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#relativize(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Relativize(Java.Net.URI arg0)
        {
            return IExecute<Java.Net.URI>("relativize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Resolve(string arg0)
        {
            return IExecute<Java.Net.URI>("resolve", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#resolve(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Resolve(Java.Net.URI arg0)
        {
            return IExecute<Java.Net.URI>("resolve", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#toURL()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public Java.Net.URL ToURL()
        {
            return IExecute<Java.Net.URL>("toURL");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}