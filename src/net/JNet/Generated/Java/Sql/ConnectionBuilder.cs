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
    #region ConnectionBuilder declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html"/>
    /// </summary>
    public partial class ConnectionBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectionBuilder>
    {
        const string _bridgeClassName = "java.sql.ConnectionBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConnectionBuilder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConnectionBuilder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionBuilder(params object[] args) : base(args) { }

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

    #region IConnectionBuilder
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConnectionBuilder
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Sql.Connection Build();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        Java.Sql.ConnectionBuilder Password(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        Java.Sql.ConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        Java.Sql.ConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        Java.Sql.ConnectionBuilder User(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionBuilder implementation
    public partial class ConnectionBuilder : Java.Sql.IConnectionBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection Build()
        {
            return IExecuteWithSignature<Java.Sql.Connection>("build", "()Ljava/sql/Connection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder Password(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Sql.ConnectionBuilder>("password", "(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Java.Sql.ConnectionBuilder>("shardingKey", "(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Java.Sql.ConnectionBuilder>("superShardingKey", "(Ljava/sql/ShardingKey;)Ljava/sql/ConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ConnectionBuilder"/></returns>
        public Java.Sql.ConnectionBuilder User(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Sql.ConnectionBuilder>("user", "(Ljava/lang/String;)Ljava/sql/ConnectionBuilder;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}