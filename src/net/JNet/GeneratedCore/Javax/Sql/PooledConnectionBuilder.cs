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
    #region IPooledConnectionBuilder
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPooledConnectionBuilder
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.PooledConnection Build();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        Javax.Sql.PooledConnectionBuilder Password(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        Javax.Sql.PooledConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        Javax.Sql.PooledConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        Javax.Sql.PooledConnectionBuilder User(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PooledConnectionBuilder
    public partial class PooledConnectionBuilder : Javax.Sql.IPooledConnectionBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.PooledConnection Build()
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnection>("build", "()Ljavax/sql/PooledConnection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        public Javax.Sql.PooledConnectionBuilder Password(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnectionBuilder>("password", "(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        public Javax.Sql.PooledConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnectionBuilder>("shardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        public Javax.Sql.PooledConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnectionBuilder>("superShardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/PooledConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnectionBuilder"/></returns>
        public Javax.Sql.PooledConnectionBuilder User(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Sql.PooledConnectionBuilder>("user", "(Ljava/lang/String;)Ljavax/sql/PooledConnectionBuilder;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}