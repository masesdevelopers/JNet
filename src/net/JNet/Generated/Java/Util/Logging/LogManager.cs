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

namespace Java.Util.Logging
{
    #region LogManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html"/>
    /// </summary>
    public partial class LogManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LogManager>
    {
        const string _bridgeClassName = "java.util.logging.LogManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LogManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LogManager(params object[] args) : base(args) { }

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

    #region LogManager implementation
    public partial class LogManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#LOGGING_MXBEAN_NAME"/>
        /// </summary>
        public static Java.Lang.String LOGGING_MXBEAN_NAME { get { if (!_LOGGING_MXBEAN_NAMEReady) { _LOGGING_MXBEAN_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGGING_MXBEAN_NAME"); _LOGGING_MXBEAN_NAMEReady = true; } return _LOGGING_MXBEAN_NAMEContent; } }
        private static Java.Lang.String _LOGGING_MXBEAN_NAMEContent = default;
        private static bool _LOGGING_MXBEAN_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLogManager()"/> 
        /// </summary>
        public static Java.Util.Logging.LogManager GetLogManager
        {
            get { return SExecuteWithSignature<Java.Util.Logging.LogManager>(LocalBridgeClazz, "getLogManager", "()Ljava/util/logging/LogManager;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLoggerNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<Java.Lang.String> LoggerNames
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getLoggerNames", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#addLogger(java.util.logging.Logger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Logger"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddLogger(Java.Util.Logging.Logger arg0)
        {
            return IExecuteWithSignature<bool>("addLogger", "(Ljava/util/logging/Logger;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public Java.Util.Logging.Logger GetLogger(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.Logger>("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#addConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Logging.LogManager"/></returns>
        public Java.Util.Logging.LogManager AddConfigurationListener(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.LogManager>("addConfigurationListener", "(Ljava/lang/Runnable;)Ljava/util/logging/LogManager;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#checkAccess()"/>
        /// </summary>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void CheckAccess()
        {
            IExecuteWithSignature("checkAccess", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#readConfiguration()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration()
        {
            IExecuteWithSignature("readConfiguration", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#readConfiguration(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("readConfiguration", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#removeConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void RemoveConfigurationListener(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("removeConfigurationListener", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#updateConfiguration(java.io.InputStream,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Io.InputStream arg0, Java.Util.Function.Function<Java.Lang.String, Java.Util.Function.BiFunction<Java.Lang.String, Java.Lang.String, Java.Lang.String>> arg1)
        {
            IExecuteWithSignature("updateConfiguration", "(Ljava/io/InputStream;Ljava/util/function/Function;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#updateConfiguration(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Util.Function.Function<Java.Lang.String, Java.Util.Function.BiFunction<Java.Lang.String, Java.Lang.String, Java.Lang.String>> arg0)
        {
            IExecuteWithSignature("updateConfiguration", "(Ljava/util/function/Function;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}