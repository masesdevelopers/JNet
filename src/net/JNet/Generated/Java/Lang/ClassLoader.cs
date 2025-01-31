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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ClassLoader declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html"/>
    /// </summary>
    public partial class ClassLoader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ClassLoader>
    {
        const string _bridgeClassName = "java.lang.ClassLoader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ClassLoader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClassLoader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ClassLoader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ClassLoader(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ClassLoader implementation
    public partial class ClassLoader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getPlatformClassLoader()"/> 
        /// </summary>
        public static Java.Lang.ClassLoader PlatformClassLoader
        {
            get { return SExecuteWithSignature<Java.Lang.ClassLoader>(LocalBridgeClazz, "getPlatformClassLoader", "()Ljava/lang/ClassLoader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemClassLoader()"/> 
        /// </summary>
        public static Java.Lang.ClassLoader SystemClassLoader
        {
            get { return SExecuteWithSignature<Java.Lang.ClassLoader>(LocalBridgeClazz, "getSystemClassLoader", "()Ljava/lang/ClassLoader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public static Java.Io.InputStream GetSystemResourceAsStream(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Io.InputStream>(LocalBridgeClazz, "getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public static Java.Net.URL GetSystemResource(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Net.URL>(LocalBridgeClazz, "getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Util.Enumeration<Java.Net.URL> GetSystemResources(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Net.URL>>(LocalBridgeClazz, "getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getDefinedPackages()"/> 
        /// </summary>
        public Java.Lang.Package[] DefinedPackages
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Package>("getDefinedPackages", "()[Ljava/lang/Package;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getParent()"/> 
        /// </summary>
        public Java.Lang.ClassLoader Parent
        {
            get { return IExecuteWithSignature<Java.Lang.ClassLoader>("getParent", "()Ljava/lang/ClassLoader;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getUnnamedModule()"/> 
        /// </summary>
        public Java.Lang.Module UnnamedModule
        {
            get { return IExecuteWithSignature<Java.Lang.Module>("getUnnamedModule", "()Ljava/lang/Module;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#isRegisteredAsParallelCapable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegisteredAsParallelCapable()
        {
            return IExecuteWithSignature<bool>("isRegisteredAsParallelCapable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getDefinedPackage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Package"/></returns>
        public Java.Lang.Package GetDefinedPackage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Package>("getDefinedPackage", "(Ljava/lang/String;)Ljava/lang/Package;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#loadClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Lang.Class LoadClass(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Class>("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetResource(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Net.URL>("getResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Enumeration<Java.Net.URL> GetResources(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Net.URL>>("getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#resources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Net.URL> Resources(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Net.URL>>("resources", "(Ljava/lang/String;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#clearAssertionStatus()"/>
        /// </summary>
        public void ClearAssertionStatus()
        {
            IExecuteWithSignature("clearAssertionStatus", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setClassAssertionStatus(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetClassAssertionStatus(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setClassAssertionStatus", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setDefaultAssertionStatus(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDefaultAssertionStatus(bool arg0)
        {
            IExecuteWithSignature("setDefaultAssertionStatus", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setPackageAssertionStatus(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetPackageAssertionStatus(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setPackageAssertionStatus", "(Ljava/lang/String;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}