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

namespace Java.Beans.Beancontext
{
    #region BeanContextServices definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html"/>
    /// </summary>
    public partial class BeanContextServices : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BeanContextServices>
    {
        const string _bridgeClassName = "java.beans.beancontext.BeanContextServices";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BeanContextServices class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BeanContextServices() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BeanContextServices class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BeanContextServices(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IBeanContextServices
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanContextServices
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getCurrentServiceClasses()"/> 
        /// </summary>
        Java.Util.Iterator<object> CurrentServiceClasses { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#addService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <returns><see cref="bool"/></returns>
        bool AddService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#hasService(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HasService(Java.Lang.Class arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Class,java.lang.Object,java.beans.beancontext.BeanContextServiceRevokedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedListener"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Util.TooManyListenersException"/>
        object GetService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, Java.Lang.Class arg2, object arg3, Java.Beans.Beancontext.BeanContextServiceRevokedListener arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getCurrentServiceSelectors(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<object> GetCurrentServiceSelectors(Java.Lang.Class arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#addBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        void AddBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#releaseService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        void ReleaseService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, object arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#removeBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        void RemoveBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#revokeService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        void RevokeService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1, bool arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContextServices
    public partial class BeanContextServices : Java.Beans.Beancontext.IBeanContextServices
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextServices"/> to <see cref="Java.Beans.Beancontext.BeanContext"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContext(Java.Beans.Beancontext.BeanContextServices t) => t.Cast<Java.Beans.Beancontext.BeanContext>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextServices"/> to <see cref="Java.Beans.Beancontext.BeanContextServicesListener"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextServicesListener(Java.Beans.Beancontext.BeanContextServices t) => t.Cast<Java.Beans.Beancontext.BeanContextServicesListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getCurrentServiceClasses()"/> 
        /// </summary>
        public Java.Util.Iterator<object> CurrentServiceClasses
        {
            get { return IExecuteWithSignature<Java.Util.Iterator<object>>("getCurrentServiceClasses", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#addService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1)
        {
            return IExecute<bool>("addService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#hasService(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasService(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("hasService", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Class,java.lang.Object,java.beans.beancontext.BeanContextServiceRevokedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedListener"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Util.TooManyListenersException"/>
        public object GetService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, Java.Lang.Class arg2, object arg3, Java.Beans.Beancontext.BeanContextServiceRevokedListener arg4)
        {
            return IExecute("getService", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#getCurrentServiceSelectors(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<object> GetCurrentServiceSelectors(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Util.Iterator<object>>("getCurrentServiceSelectors", "(Ljava/lang/Class;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#addBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        public void AddBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0)
        {
            IExecuteWithSignature("addBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#releaseService(java.beans.beancontext.BeanContextChild,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void ReleaseService(Java.Beans.Beancontext.BeanContextChild arg0, object arg1, object arg2)
        {
            IExecute("releaseService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#removeBeanContextServicesListener(java.beans.beancontext.BeanContextServicesListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServicesListener"/></param>
        public void RemoveBeanContextServicesListener(Java.Beans.Beancontext.BeanContextServicesListener arg0)
        {
            IExecuteWithSignature("removeBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServices.html#revokeService(java.lang.Class,java.beans.beancontext.BeanContextServiceProvider,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextServiceProvider"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void RevokeService(Java.Lang.Class arg0, Java.Beans.Beancontext.BeanContextServiceProvider arg1, bool arg2)
        {
            IExecute("revokeService", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}