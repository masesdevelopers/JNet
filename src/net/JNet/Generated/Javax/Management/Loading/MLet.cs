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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Loading
{
    #region MLet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html"/>
    /// </summary>
    public partial class MLet : Java.Net.URLClassLoader
    {
        const string _bridgeClassName = "javax.management.loading.MLet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MLet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MLet(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MLet implementation
    public partial class MLet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, Java.Net.URLStreamHandlerFactory arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, Java.Net.URLStreamHandlerFactory arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        public MLet(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#%3Cinit%3E(java.net.URL[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public MLet(Java.Net.URL[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Javax.Management.Loading.MLetMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Loading.MLetMBean(Javax.Management.Loading.MLet t) => t.Cast<Javax.Management.Loading.MLetMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Loading.MLet t) => t.Cast<Javax.Management.MBeanRegistration>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Loading.MLet"/> to <see cref="Java.Io.Externalizable"/>
        /// </summary>
        public static implicit operator Java.Io.Externalizable(Javax.Management.Loading.MLet t) => t.Cast<Java.Io.Externalizable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getLibraryDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#setLibraryDirectory(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LibraryDirectory
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLibraryDirectory", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLibraryDirectory", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getMBeansFromURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<object>>("getMBeansFromURL", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#getMBeansFromURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<object>>("getMBeansFromURL", "(Ljava/net/URL;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecuteWithSignature<Javax.Management.ObjectName>("preRegister", "(Ljavax/management/MBeanServer;Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#loadClass(java.lang.String,javax.management.loading.ClassLoaderRepository)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Loading.ClassLoaderRepository"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Lang.Class LoadClass(Java.Lang.String arg0, Javax.Management.Loading.ClassLoaderRepository arg1)
        {
            return IExecuteWithSignature<Java.Lang.Class>("loadClass", "(Ljava/lang/String;Ljavax/management/loading/ClassLoaderRepository;)Ljava/lang/Class;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#addURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public void AddURL(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addURL", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#addURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public void AddURL(Java.Net.URL arg0)
        {
            IExecuteWithSignature("addURL", "(Ljava/net/URL;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecuteWithSignature("postDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("postRegister", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#preDeregister()"/>
        /// </summary>
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecuteWithSignature("preDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#readExternal(java.io.ObjectInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void ReadExternal(Java.Io.ObjectInput arg0)
        {
            IExecuteWithSignature("readExternal", "(Ljava/io/ObjectInput;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLet.html#writeExternal(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void WriteExternal(Java.Io.ObjectOutput arg0)
        {
            IExecuteWithSignature("writeExternal", "(Ljava/io/ObjectOutput;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}