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

namespace Javax.Management.Timer
{
    #region Timer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html"/>
    /// </summary>
    public partial class Timer : Javax.Management.NotificationBroadcasterSupport
    {
        const string _bridgeClassName = "javax.management.timer.Timer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Timer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Timer(params object[] args) : base(args) { }

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

    #region Timer implementation
    public partial class Timer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Timer.Timer"/> to <see cref="Javax.Management.Timer.TimerMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Timer.TimerMBean(Javax.Management.Timer.Timer t) => t.Cast<Javax.Management.Timer.TimerMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Timer.Timer"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Timer.Timer t) => t.Cast<Javax.Management.MBeanRegistration>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#ONE_DAY"/>
        /// </summary>
        public static long ONE_DAY { get { if (!_ONE_DAYReady) { _ONE_DAYContent = SGetField<long>(LocalBridgeClazz, "ONE_DAY"); _ONE_DAYReady = true; } return _ONE_DAYContent; } }
        private static long _ONE_DAYContent = default;
        private static bool _ONE_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#ONE_HOUR"/>
        /// </summary>
        public static long ONE_HOUR { get { if (!_ONE_HOURReady) { _ONE_HOURContent = SGetField<long>(LocalBridgeClazz, "ONE_HOUR"); _ONE_HOURReady = true; } return _ONE_HOURContent; } }
        private static long _ONE_HOURContent = default;
        private static bool _ONE_HOURReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#ONE_MINUTE"/>
        /// </summary>
        public static long ONE_MINUTE { get { if (!_ONE_MINUTEReady) { _ONE_MINUTEContent = SGetField<long>(LocalBridgeClazz, "ONE_MINUTE"); _ONE_MINUTEReady = true; } return _ONE_MINUTEContent; } }
        private static long _ONE_MINUTEContent = default;
        private static bool _ONE_MINUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#ONE_SECOND"/>
        /// </summary>
        public static long ONE_SECOND { get { if (!_ONE_SECONDReady) { _ONE_SECONDContent = SGetField<long>(LocalBridgeClazz, "ONE_SECOND"); _ONE_SECONDReady = true; } return _ONE_SECONDContent; } }
        private static long _ONE_SECONDContent = default;
        private static bool _ONE_SECONDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#ONE_WEEK"/>
        /// </summary>
        public static long ONE_WEEK { get { if (!_ONE_WEEKReady) { _ONE_WEEKContent = SGetField<long>(LocalBridgeClazz, "ONE_WEEK"); _ONE_WEEKReady = true; } return _ONE_WEEKContent; } }
        private static long _ONE_WEEKContent = default;
        private static bool _ONE_WEEKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getAllNotificationIDs()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Lang.Integer> AllNotificationIDs
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Lang.Integer>>("getAllNotificationIDs", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNbNotifications()"/> 
        /// </summary>
        public int NbNotifications
        {
            get { return IExecuteWithSignature<int>("getNbNotifications", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getSendPastNotifications()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#setSendPastNotifications(boolean)"/>
        /// </summary>
        public bool SendPastNotifications
        {
            get { return IExecuteWithSignature<bool>("getSendPastNotifications", "()Z"); } set { IExecuteWithSignature("setSendPastNotifications", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getFixedRate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetFixedRate(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("getFixedRate", "(Ljava/lang/Integer;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5, bool arg6)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Java.Util.Date arg3, long arg4, long arg5)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Java.Util.Date arg3, long arg4)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#addNotification(java.lang.String,java.lang.String,java.lang.Object,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Integer AddNotification(Java.Lang.String arg0, Java.Lang.String arg1, object arg2, Java.Util.Date arg3)
        {
            return IExecute<Java.Lang.Integer>("addNotification", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNbOccurences(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetNbOccurences(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Lang.Long>("getNbOccurences", "(Ljava/lang/Integer;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getPeriod(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetPeriod(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Lang.Long>("getPeriod", "(Ljava/lang/Integer;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNotificationUserData(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetNotificationUserData(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature("getNotificationUserData", "(Ljava/lang/Integer;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNotificationMessage(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNotificationMessage(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNotificationMessage", "(Ljava/lang/Integer;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNotificationType(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNotificationType(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNotificationType", "(Ljava/lang/Integer;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getDate(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetDate(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Java.Util.Date>("getDate", "(Ljava/lang/Integer;)Ljava/util/Date;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#getNotificationIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Vector"/></returns>
        public Java.Util.Vector<Java.Lang.Integer> GetNotificationIDs(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Vector<Java.Lang.Integer>>("getNotificationIDs", "(Ljava/lang/String;)Ljava/util/Vector;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#removeAllNotifications()"/>
        /// </summary>
        public void RemoveAllNotifications()
        {
            IExecuteWithSignature("removeAllNotifications", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#removeNotification(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotification(Java.Lang.Integer arg0)
        {
            IExecuteWithSignature("removeNotification", "(Ljava/lang/Integer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#removeNotifications(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void RemoveNotifications(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeNotifications", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecuteWithSignature("postDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("postRegister", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/timer/Timer.html#preDeregister()"/>
        /// </summary>
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecuteWithSignature("preDeregister", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}