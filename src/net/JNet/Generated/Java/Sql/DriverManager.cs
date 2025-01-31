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

namespace Java.Sql
{
    #region DriverManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html"/>
    /// </summary>
    public partial class DriverManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DriverManager>
    {
        const string _bridgeClassName = "java.sql.DriverManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DriverManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DriverManager(params object[] args) : base(args) { }

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

    #region DriverManager implementation
    public partial class DriverManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLoginTimeout(int)"/>
        /// </summary>
        public static int LoginTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getLoginTimeout", "()I"); } set { SExecuteWithSignature(LocalBridgeClazz, "setLoginTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public static Java.Io.PrintWriter LogWriter
        {
            get { return SExecuteWithSignature<Java.Io.PrintWriter>(LocalBridgeClazz, "getLogWriter", "()Ljava/io/PrintWriter;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setLogWriter", "(Ljava/io/PrintWriter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecuteWithSignature<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Util.Properties arg1)
        {
            return SExecuteWithSignature<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getDriver(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Driver"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Driver GetDriver(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.Driver>(LocalBridgeClazz, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getDrivers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Sql.Driver> GetDrivers()
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Sql.Driver>>(LocalBridgeClazz, "getDrivers", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#drivers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<Java.Sql.Driver> Drivers()
        {
            return SExecuteWithSignature<Java.Util.Stream.Stream<Java.Sql.Driver>>(LocalBridgeClazz, "drivers", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#deregisterDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void DeregisterDriver(Java.Sql.Driver arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "deregisterDriver", "(Ljava/sql/Driver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#println(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Println(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "println", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver,java.sql.DriverAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <param name="arg1"><see cref="Java.Sql.DriverAction"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void RegisterDriver(Java.Sql.Driver arg0, Java.Sql.DriverAction arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerDriver", "(Ljava/sql/Driver;Ljava/sql/DriverAction;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void RegisterDriver(Java.Sql.Driver arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerDriver", "(Ljava/sql/Driver;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}