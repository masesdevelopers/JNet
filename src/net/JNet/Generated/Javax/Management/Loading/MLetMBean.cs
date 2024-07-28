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

namespace Javax.Management.Loading
{
    #region IMLetMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMLetMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getLibraryDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#setLibraryDirectory(java.lang.String)"/>
        /// </summary>
        Java.Lang.String LibraryDirectory { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getURLs()"/> 
        /// </summary>
        Java.Net.URL[] URLs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        Java.Net.URL GetResource(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Util.Enumeration<Java.Net.URL> GetResources(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        Java.Util.Set<object> GetMBeansFromURL(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        Java.Util.Set<object> GetMBeansFromURL(Java.Net.URL arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        void AddURL(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        void AddURL(Java.Net.URL arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MLetMBean
    public partial class MLetMBean : Javax.Management.Loading.IMLetMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getLibraryDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#setLibraryDirectory(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LibraryDirectory
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLibraryDirectory", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLibraryDirectory", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getURLs()"/> 
        /// </summary>
        public Java.Net.URL[] URLs
        {
            get { return IExecuteWithSignatureArray<Java.Net.URL>("getURLs", "()[Ljava/net/URL;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetResource(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Net.URL>("getResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Enumeration<Java.Net.URL> GetResources(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Net.URL>>("getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<object>>("getMBeansFromURL", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<object>>("getMBeansFromURL", "(Ljava/net/URL;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public void AddURL(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addURL", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public void AddURL(Java.Net.URL arg0)
        {
            IExecuteWithSignature("addURL", "(Ljava/net/URL;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}