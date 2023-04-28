/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset
{
    #region JdbcRowSet
    public partial class JdbcRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.JdbcRowSet"/> to <see cref="Javax.Sql.RowSet"/>
        /// </summary>
        public static implicit operator Javax.Sql.RowSet(Javax.Sql.Rowset.JdbcRowSet t) => t.Cast<Javax.Sql.RowSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.JdbcRowSet"/> to <see cref="Javax.Sql.Rowset.Joinable"/>
        /// </summary>
        public static implicit operator Javax.Sql.Rowset.Joinable(Javax.Sql.Rowset.JdbcRowSet t) => t.Cast<Javax.Sql.Rowset.Joinable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getAutoCommit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#setAutoCommit(boolean)"/>
        /// </summary>
        public bool AutoCommit
        {
            get { return IExecute<bool>("getAutoCommit"); } set { IExecute("setAutoCommit", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        public Javax.Sql.Rowset.RowSetWarning RowSetWarnings
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getRowSetWarnings"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Sql.Rowset.RowSetWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        public bool ShowDeleted
        {
            get { return IExecute<bool>("getShowDeleted"); } set { IExecute("setShowDeleted", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#commit()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void Commit()
        {
            IExecute("commit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback()
        {
            IExecute("rollback");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback(Java.Sql.Savepoint arg0)
        {
            IExecute("rollback", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}