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

namespace Javax.Management.Remote
{
    #region JMXConnectorServerMBean declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html"/>
    /// </summary>
    public partial class JMXConnectorServerMBean : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JMXConnectorServerMBean>
    {
        const string _bridgeClassName = "javax.management.remote.JMXConnectorServerMBean";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JMXConnectorServerMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JMXConnectorServerMBean() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JMXConnectorServerMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JMXConnectorServerMBean(params object[] args) : base(args) { }

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

    #region IJMXConnectorServerMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJMXConnectorServerMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAddress()"/> 
        /// </summary>
        Javax.Management.Remote.JMXServiceURL Address { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAttributes()"/> 
        /// </summary>
        Java.Util.Map<Java.Lang.String, object> Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getConnectionIds()"/> 
        /// </summary>
        Java.Lang.String[] ConnectionIds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsActive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#toJMXConnector(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Management.Remote.JMXConnector ToJMXConnector(Java.Util.Map<Java.Lang.String, object> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#setMBeanServerForwarder(javax.management.remote.MBeanServerForwarder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.MBeanServerForwarder"/></param>
        void SetMBeanServerForwarder(Javax.Management.Remote.MBeanServerForwarder arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#start()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#stop()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JMXConnectorServerMBean implementation
    public partial class JMXConnectorServerMBean : Javax.Management.Remote.IJMXConnectorServerMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAddress()"/> 
        /// </summary>
        public Javax.Management.Remote.JMXServiceURL Address
        {
            get { return IExecuteWithSignature<Javax.Management.Remote.JMXServiceURL>("getAddress", "()Ljavax/management/remote/JMXServiceURL;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, object> Attributes
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("getAttributes", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getConnectionIds()"/> 
        /// </summary>
        public Java.Lang.String[] ConnectionIds
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getConnectionIds", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#toJMXConnector(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.JMXConnector ToJMXConnector(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Javax.Management.Remote.JMXConnector>("toJMXConnector", "(Ljava/util/Map;)Ljavax/management/remote/JMXConnector;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#setMBeanServerForwarder(javax.management.remote.MBeanServerForwarder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.MBeanServerForwarder"/></param>
        public void SetMBeanServerForwarder(Javax.Management.Remote.MBeanServerForwarder arg0)
        {
            IExecuteWithSignature("setMBeanServerForwarder", "(Ljavax/management/remote/MBeanServerForwarder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#start()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#stop()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}