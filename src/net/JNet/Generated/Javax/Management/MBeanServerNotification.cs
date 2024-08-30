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

namespace Javax.Management
{
    #region MBeanServerNotification declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html"/>
    /// </summary>
    public partial class MBeanServerNotification : Javax.Management.Notification
    {
        const string _bridgeClassName = "javax.management.MBeanServerNotification";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MBeanServerNotification() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MBeanServerNotification(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region MBeanServerNotification implementation
    public partial class MBeanServerNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Javax.Management.ObjectName"/></param>
        public MBeanServerNotification(Java.Lang.String arg0, object arg1, long arg2, Javax.Management.ObjectName arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#REGISTRATION_NOTIFICATION"/>
        /// </summary>
        public static Java.Lang.String REGISTRATION_NOTIFICATION { get { if (!_REGISTRATION_NOTIFICATIONReady) { _REGISTRATION_NOTIFICATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REGISTRATION_NOTIFICATION"); _REGISTRATION_NOTIFICATIONReady = true; } return _REGISTRATION_NOTIFICATIONContent; } }
        private static Java.Lang.String _REGISTRATION_NOTIFICATIONContent = default;
        private static bool _REGISTRATION_NOTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#UNREGISTRATION_NOTIFICATION"/>
        /// </summary>
        public static Java.Lang.String UNREGISTRATION_NOTIFICATION { get { if (!_UNREGISTRATION_NOTIFICATIONReady) { _UNREGISTRATION_NOTIFICATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "UNREGISTRATION_NOTIFICATION"); _UNREGISTRATION_NOTIFICATIONReady = true; } return _UNREGISTRATION_NOTIFICATIONContent; } }
        private static Java.Lang.String _UNREGISTRATION_NOTIFICATIONContent = default;
        private static bool _UNREGISTRATION_NOTIFICATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#getMBeanName()"/> 
        /// </summary>
        public Javax.Management.ObjectName MBeanName
        {
            get { return IExecuteWithSignature<Javax.Management.ObjectName>("getMBeanName", "()Ljavax/management/ObjectName;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}