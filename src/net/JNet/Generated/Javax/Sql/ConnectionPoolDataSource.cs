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

namespace Javax.Sql
{
    #region ConnectionPoolDataSource declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html"/>
    /// </summary>
    public partial class ConnectionPoolDataSource : Javax.Sql.CommonDataSource
    {
        const string _bridgeClassName = "javax.sql.ConnectionPoolDataSource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConnectionPoolDataSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionPoolDataSource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConnectionPoolDataSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionPoolDataSource(params object[] args) : base(args) { }

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

    #region IConnectionPoolDataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConnectionPoolDataSource : Javax.Sql.ICommonDataSource
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        int LoginTimeout { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        Java.Io.PrintWriter LogWriter { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection()"/> 
        /// </summary>
        Javax.Sql.PooledConnection PooledConnection { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.PooledConnection GetPooledConnection(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#createPooledConnectionBuilder()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.PooledConnectionBuilder CreatePooledConnectionBuilder();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionPoolDataSource implementation
    public partial class ConnectionPoolDataSource : Javax.Sql.IConnectionPoolDataSource
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        public int LoginTimeout
        {
            get { return IExecuteWithSignature<int>("getLoginTimeout", "()I"); } set { IExecuteWithSignature("setLoginTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public Java.Io.PrintWriter LogWriter
        {
            get { return IExecuteWithSignature<Java.Io.PrintWriter>("getLogWriter", "()Ljava/io/PrintWriter;"); } set { IExecuteWithSignature("setLogWriter", "(Ljava/io/PrintWriter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection()"/> 
        /// </summary>
        public Javax.Sql.PooledConnection PooledConnection
        {
            get { return IExecuteWithSignature<Javax.Sql.PooledConnection>("getPooledConnection", "()Ljavax/sql/PooledConnection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.PooledConnection GetPooledConnection(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Sql.PooledConnection>("getPooledConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/ConnectionPoolDataSource.html#createPooledConnectionBuilder()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.PooledConnectionBuilder CreatePooledConnectionBuilder()
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnectionBuilder>("createPooledConnectionBuilder", "()Ljavax/sql/PooledConnectionBuilder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}