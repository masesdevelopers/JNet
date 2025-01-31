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

namespace Java.Beans.Beancontext
{
    #region BeanContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html"/>
    /// </summary>
    public partial class BeanContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BeanContext>
    {
        const string _bridgeClassName = "java.beans.beancontext.BeanContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BeanContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BeanContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BeanContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BeanContext(params object[] args) : base(args) { }

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

    #region IBeanContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResourceAsStream(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0, Java.Beans.Beancontext.BeanContextChild arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#instantiateChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        object InstantiateChild(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResource(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Net.URL GetResource(Java.Lang.String arg0, Java.Beans.Beancontext.BeanContextChild arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#addBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        void AddBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#removeBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        void RemoveBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContext implementation
    public partial class BeanContext : Java.Beans.Beancontext.IBeanContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.Beancontext.BeanContextChild"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextChild(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.Beancontext.BeanContextChild>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Util.Collection"/>
        /// </summary>
        public static implicit operator Java.Util.Collection(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Util.Collection>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.DesignMode"/>
        /// </summary>
        public static implicit operator Java.Beans.DesignMode(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.DesignMode>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.Visibility"/>
        /// </summary>
        public static implicit operator Java.Beans.Visibility(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.Visibility>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#globalHierarchyLock"/>
        /// </summary>
        public static object globalHierarchyLock { get { if (!_globalHierarchyLockReady) { _globalHierarchyLockContent = SGetField(LocalBridgeClazz, "globalHierarchyLock"); _globalHierarchyLockReady = true; } return _globalHierarchyLockContent; } }
        private static object _globalHierarchyLockContent = default;
        private static bool _globalHierarchyLockReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResourceAsStream(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Io.InputStream GetResourceAsStream(Java.Lang.String arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getResourceAsStream", "(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/io/InputStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#instantiateChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object InstantiateChild(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("instantiateChild", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResource(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Net.URL GetResource(Java.Lang.String arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecuteWithSignature<Java.Net.URL>("getResource", "(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/net/URL;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#addBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void AddBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecuteWithSignature("addBeanContextMembershipListener", "(Ljava/beans/beancontext/BeanContextMembershipListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#removeBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void RemoveBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecuteWithSignature("removeBeanContextMembershipListener", "(Ljava/beans/beancontext/BeanContextMembershipListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}