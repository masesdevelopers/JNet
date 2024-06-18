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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IPooledConnection
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPooledConnection
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#getConnection()"/> 
        /// </summary>
        Java.Sql.Connection Connection { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#addConnectionEventListener(javax.sql.ConnectionEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEventListener"/></param>
        void AddConnectionEventListener(Javax.Sql.ConnectionEventListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#addStatementEventListener(javax.sql.StatementEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEventListener"/></param>
        void AddStatementEventListener(Javax.Sql.StatementEventListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#removeConnectionEventListener(javax.sql.ConnectionEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEventListener"/></param>
        void RemoveConnectionEventListener(Javax.Sql.ConnectionEventListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#removeStatementEventListener(javax.sql.StatementEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEventListener"/></param>
        void RemoveStatementEventListener(Javax.Sql.StatementEventListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PooledConnection
    public partial class PooledConnection : Javax.Sql.IPooledConnection
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#getConnection()"/> 
        /// </summary>
        public Java.Sql.Connection Connection
        {
            get { return IExecuteWithSignature<Java.Sql.Connection>("getConnection", "()Ljava/sql/Connection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#addConnectionEventListener(javax.sql.ConnectionEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEventListener"/></param>
        public void AddConnectionEventListener(Javax.Sql.ConnectionEventListener arg0)
        {
            IExecuteWithSignature("addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#addStatementEventListener(javax.sql.StatementEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEventListener"/></param>
        public void AddStatementEventListener(Javax.Sql.StatementEventListener arg0)
        {
            IExecuteWithSignature("addStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#removeConnectionEventListener(javax.sql.ConnectionEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEventListener"/></param>
        public void RemoveConnectionEventListener(Javax.Sql.ConnectionEventListener arg0)
        {
            IExecuteWithSignature("removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/PooledConnection.html#removeStatementEventListener(javax.sql.StatementEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEventListener"/></param>
        public void RemoveStatementEventListener(Javax.Sql.StatementEventListener arg0)
        {
            IExecuteWithSignature("removeStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}