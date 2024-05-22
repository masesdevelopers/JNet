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

namespace Java.Net
{
    #region HttpCookie
    public partial class HttpCookie
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public HttpCookie(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#domainMatches(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DomainMatches(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "domainMatches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.HttpCookie> Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.HttpCookie>>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getComment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setComment(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Comment
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getCommentURL()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setCommentURL(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CommentURL
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCommentURL", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCommentURL", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getDiscard()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setDiscard(boolean)"/>
        /// </summary>
        public bool Discard
        {
            get { return IExecuteWithSignature<bool>("getDiscard", "()Z"); } set { IExecuteWithSignature("setDiscard", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getDomain()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setDomain(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Domain
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDomain", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDomain", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getMaxAge()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setMaxAge(long)"/>
        /// </summary>
        public long MaxAge
        {
            get { return IExecuteWithSignature<long>("getMaxAge", "()J"); } set { IExecuteWithSignature("setMaxAge", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setPath(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Path
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPath", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getPortlist()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setPortlist(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Portlist
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPortlist", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPortlist", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getSecure()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setSecure(boolean)"/>
        /// </summary>
        public bool Secure
        {
            get { return IExecuteWithSignature<bool>("getSecure", "()Z"); } set { IExecuteWithSignature("setSecure", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setValue(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Value
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getValue", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setValue", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#getVersion()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setVersion(int)"/>
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); } set { IExecuteWithSignature("setVersion", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#hasExpired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasExpired()
        {
            return IExecuteWithSignature<bool>("hasExpired", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#isHttpOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHttpOnly()
        {
            return IExecuteWithSignature<bool>("isHttpOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpCookie.html#setHttpOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHttpOnly(bool arg0)
        {
            IExecuteWithSignature("setHttpOnly", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}