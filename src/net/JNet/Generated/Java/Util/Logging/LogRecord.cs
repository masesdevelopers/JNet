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

namespace Java.Util.Logging
{
    #region LogRecord declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html"/>
    /// </summary>
    public partial class LogRecord : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.logging.LogRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LogRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LogRecord(params object[] args) : base(args) { }

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

    #region LogRecord implementation
    public partial class LogRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#%3Cinit%3E(java.util.logging.Level,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public LogRecord(Java.Util.Logging.Level arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getInstant()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setInstant(java.time.Instant)"/>
        /// </summary>
        public Java.Time.Instant Instant
        {
            get { return IExecute<Java.Time.Instant>("getInstant"); } set { IExecute("setInstant", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getLevel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setLevel(java.util.logging.Level)"/>
        /// </summary>
        public Java.Util.Logging.Level Level
        {
            get { return IExecute<Java.Util.Logging.Level>("getLevel"); } set { IExecute("setLevel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getLoggerName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setLoggerName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LoggerName
        {
            get { return IExecute<Java.Lang.String>("getLoggerName"); } set { IExecute("setLoggerName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getMessage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setMessage(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Message
        {
            get { return IExecute<Java.Lang.String>("getMessage"); } set { IExecute("setMessage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getMillis()"/> 
        /// </summary>
        public long Millis
        {
            get { return IExecute<long>("getMillis"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setParameters(java.lang.Object[])"/>
        /// </summary>
        public object[] Parameters
        {
            get { return IExecuteArray<object>("getParameters"); } set { IExecute("setParameters", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getResourceBundle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setResourceBundle(java.util.ResourceBundle)"/>
        /// </summary>
        public Java.Util.ResourceBundle ResourceBundle
        {
            get { return IExecute<Java.Util.ResourceBundle>("getResourceBundle"); } set { IExecute("setResourceBundle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getResourceBundleName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setResourceBundleName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ResourceBundleName
        {
            get { return IExecute<Java.Lang.String>("getResourceBundleName"); } set { IExecute("setResourceBundleName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getSequenceNumber()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setSequenceNumber(long)"/>
        /// </summary>
        public long SequenceNumber
        {
            get { return IExecute<long>("getSequenceNumber"); } set { IExecute("setSequenceNumber", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getSourceClassName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setSourceClassName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SourceClassName
        {
            get { return IExecute<Java.Lang.String>("getSourceClassName"); } set { IExecute("setSourceClassName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getSourceMethodName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setSourceMethodName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SourceMethodName
        {
            get { return IExecute<Java.Lang.String>("getSourceMethodName"); } set { IExecute("setSourceMethodName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getThreadID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setThreadID(int)"/>
        /// </summary>
        public int ThreadID
        {
            get { return IExecute<int>("getThreadID"); } set { IExecute("setThreadID", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#getThrown()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogRecord.html#setThrown(java.lang.Throwable)"/>
        /// </summary>
        public Java.Lang.Throwable Thrown
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getThrown"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); } set { IExecute("setThrown", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}