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

namespace Javax.Management.Modelmbean
{
    #region ModelMBean declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html"/>
    /// </summary>
    public partial class ModelMBean : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ModelMBean>
    {
        const string _bridgeClassName = "javax.management.modelmbean.ModelMBean";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ModelMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ModelMBean() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ModelMBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ModelMBean(params object[] args) : base(args) { }

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

    #region IModelMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IModelMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setManagedResource(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.Modelmbean.InvalidTargetObjectTypeException"/>
        void SetManagedResource(object arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setModelMBeanInfo(javax.management.modelmbean.ModelMBeanInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SetModelMBeanInfo(Javax.Management.Modelmbean.ModelMBeanInfo arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModelMBean implementation
    public partial class ModelMBean : Javax.Management.Modelmbean.IModelMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBean"/> to <see cref="Javax.Management.DynamicMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.DynamicMBean(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.DynamicMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBean"/> to <see cref="Javax.Management.PersistentMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.PersistentMBean(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.PersistentMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBean"/> to <see cref="Javax.Management.Modelmbean.ModelMBeanNotificationBroadcaster"/>
        /// </summary>
        public static implicit operator Javax.Management.Modelmbean.ModelMBeanNotificationBroadcaster(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.Modelmbean.ModelMBeanNotificationBroadcaster>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setManagedResource(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.Modelmbean.InvalidTargetObjectTypeException"/>
        public void SetManagedResource(object arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setManagedResource", "(Ljava/lang/Object;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setModelMBeanInfo(javax.management.modelmbean.ModelMBeanInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetModelMBeanInfo(Javax.Management.Modelmbean.ModelMBeanInfo arg0)
        {
            IExecuteWithSignature("setModelMBeanInfo", "(Ljavax/management/modelmbean/ModelMBeanInfo;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}