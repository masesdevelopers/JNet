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

namespace Javax.Imageio.Spi
{
    #region ServiceRegistry declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html"/>
    /// </summary>
    public partial class ServiceRegistry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ServiceRegistry>
    {
        const string _bridgeClassName = "javax.imageio.spi.ServiceRegistry";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ServiceRegistry() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ServiceRegistry(params object[] args) : base(args) { }

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
        #region Filter declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.Filter.html"/>
        /// </summary>
        public partial class Filter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Filter>
        {
            const string _bridgeClassName = "javax.imageio.spi.ServiceRegistry$Filter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Filter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Filter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Filter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Filter(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ServiceRegistry implementation
    public partial class ServiceRegistry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#%3Cinit%3E(java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        public ServiceRegistry(Java.Util.Iterator<Java.Lang.Class> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#lookupProviders(java.lang.Class,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<T> LookupProviders<T>(Java.Lang.Class arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Util.Iterator<T>>(LocalBridgeClazz, "lookupProviders", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#lookupProviders(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<T> LookupProviders<T>(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.Iterator<T>>(LocalBridgeClazz, "lookupProviders", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#getCategories()"/> 
        /// </summary>
        public Java.Util.Iterator<Java.Lang.Class> Categories
        {
            get { return IExecute<Java.Util.Iterator<Java.Lang.Class>>("getCategories"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#deregisterServiceProvider(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool DeregisterServiceProvider<T>(T arg0, Java.Lang.Class arg1)
        {
            return IExecute<bool>("deregisterServiceProvider", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#registerServiceProvider(java.lang.Object,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterServiceProvider<T>(T arg0, Java.Lang.Class arg1)
        {
            return IExecute<bool>("registerServiceProvider", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#setOrdering(java.lang.Class,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool SetOrdering<T>(Java.Lang.Class arg0, T arg1, T arg2)
        {
            return IExecute<bool>("setOrdering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#unsetOrdering(java.lang.Class,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool UnsetOrdering<T>(Java.Lang.Class arg0, T arg1, T arg2)
        {
            return IExecute<bool>("unsetOrdering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#getServiceProviders(java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> GetServiceProviders<T>(Java.Lang.Class arg0, bool arg1)
        {
            return IExecute<Java.Util.Iterator<T>>("getServiceProviders", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#getServiceProviders(java.lang.Class,javax.imageio.spi.ServiceRegistry.Filter,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Spi.ServiceRegistry.Filter"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> GetServiceProviders<T>(Java.Lang.Class arg0, Javax.Imageio.Spi.ServiceRegistry.Filter arg1, bool arg2)
        {
            return IExecute<Java.Util.Iterator<T>>("getServiceProviders", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#getServiceProviderByClass(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetServiceProviderByClass<T>(Java.Lang.Class arg0)
        {
            return IExecute<T>("getServiceProviderByClass", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#deregisterAll()"/>
        /// </summary>
        public void DeregisterAll()
        {
            IExecute("deregisterAll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#deregisterAll(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public void DeregisterAll(Java.Lang.Class arg0)
        {
            IExecute("deregisterAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#deregisterServiceProvider(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void DeregisterServiceProvider(object arg0)
        {
            IExecute("deregisterServiceProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#registerServiceProvider(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RegisterServiceProvider(object arg0)
        {
            IExecute("registerServiceProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.html#registerServiceProviders(java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        public void RegisterServiceProviders(Java.Util.Iterator<object> arg0)
        {
            IExecute("registerServiceProviders", arg0);
        }

        #endregion

        #region Nested classes
        #region Filter implementation
        public partial class Filter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ServiceRegistry.Filter.html#filter(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool FilterMethod(object arg0)
            {
                return IExecuteWithSignature<bool>("filter", "(Ljava/lang/Object;)Z", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}