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

namespace Javax.Tools
{
    #region ForwardingJavaFileManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html"/>
    /// </summary>
    public partial class ForwardingJavaFileManager : Javax.Tools.JavaFileManager
    {
        const string _bridgeClassName = "javax.tools.ForwardingJavaFileManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ForwardingJavaFileManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ForwardingJavaFileManager(params object[] args) : base(args) { }

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

    #region ForwardingJavaFileManager<M> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html"/>
    /// </summary>
    /// <typeparam name="M"><see cref="Javax.Tools.IJavaFileManager"/></typeparam>
    public partial class ForwardingJavaFileManager<M> : Javax.Tools.JavaFileManager where M : Javax.Tools.IJavaFileManager, new()
    {
        const string _bridgeClassName = "javax.tools.ForwardingJavaFileManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ForwardingJavaFileManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ForwardingJavaFileManager(params object[] args) : base(args) { }

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

    #region ForwardingJavaFileManager implementation
    public partial class ForwardingJavaFileManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getServiceLoader(javax.tools.JavaFileManager.Location,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.ServiceLoader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.ServiceLoader GetServiceLoader(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.ServiceLoader>("getServiceLoader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#contains(javax.tools.JavaFileManager.Location,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Contains(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#handleOption(java.lang.String,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HandleOption(Java.Lang.String arg0, Java.Util.Iterator arg1)
        {
            return IExecute<bool>("handleOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#hasLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasLocation(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<bool>("hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#isSupportedOption(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int IsSupportedOption(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("isSupportedOption", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getClassLoader(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        public Java.Lang.ClassLoader GetClassLoader(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#listLocationsForModules(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable ListLocationsForModules(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable>("listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#list(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Set,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable List(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Set arg2, bool arg3)
        {
            return IExecute<Java.Lang.Iterable>("list", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#inferBinaryName(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String InferBinaryName(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Java.Lang.String>("inferBinaryName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#inferModuleName(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String InferModuleName(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getJavaFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getJavaFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ForwardingJavaFileManager<M> implementation
    public partial class ForwardingJavaFileManager<M>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.ForwardingJavaFileManager{M}"/> to <see cref="Javax.Tools.ForwardingJavaFileManager"/>
        /// </summary>
        public static implicit operator Javax.Tools.ForwardingJavaFileManager(Javax.Tools.ForwardingJavaFileManager<M> t) => t.Cast<Javax.Tools.ForwardingJavaFileManager>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getServiceLoader(javax.tools.JavaFileManager.Location,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="S"></typeparam>
        /// <returns><see cref="Java.Util.ServiceLoader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.ServiceLoader<S> GetServiceLoader<S>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.ServiceLoader<S>>("getServiceLoader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#contains(javax.tools.JavaFileManager.Location,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Contains(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#handleOption(java.lang.String,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HandleOption(Java.Lang.String arg0, Java.Util.Iterator<Java.Lang.String> arg1)
        {
            return IExecute<bool>("handleOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#hasLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasLocation(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<bool>("hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#isSupportedOption(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int IsSupportedOption(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("isSupportedOption", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getClassLoader(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        public Java.Lang.ClassLoader GetClassLoader(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#listLocationsForModules(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable<Java.Util.Set<Javax.Tools.JavaFileManager.Location>> ListLocationsForModules(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable<Java.Util.Set<Javax.Tools.JavaFileManager.Location>>>("listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#list(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Set,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Iterable<Javax.Tools.JavaFileObject> List(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Set<Javax.Tools.JavaFileObject.Kind> arg2, bool arg3)
        {
            return IExecute<Java.Lang.Iterable<Javax.Tools.JavaFileObject>>("list", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#inferBinaryName(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String InferBinaryName(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Java.Lang.String>("inferBinaryName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#inferModuleName(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String InferModuleName(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,java.lang.String,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.FileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.FileObject GetFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Lang.String arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.FileObject>("getFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getLocationForModule(javax.tools.JavaFileManager.Location,javax.tools.JavaFileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileManager.Location GetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, Javax.Tools.JavaFileObject arg1)
        {
            return IExecute<Javax.Tools.JavaFileManager.Location>("getLocationForModule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getJavaFileForInput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForInput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#getJavaFileForOutput(javax.tools.JavaFileManager.Location,java.lang.String,javax.tools.JavaFileObject.Kind,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <param name="arg3"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileObject"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Tools.JavaFileObject GetJavaFileForOutput(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Javax.Tools.JavaFileObject.Kind arg2, Javax.Tools.FileObject arg3)
        {
            return IExecute<Javax.Tools.JavaFileObject>("getJavaFileForOutput", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ForwardingJavaFileManager.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}