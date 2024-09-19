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

namespace Javax.Sql.Rowset
{
    #region JdbcRowSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html"/>
    /// </summary>
    public partial class JdbcRowSet : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JdbcRowSet>
    {
        const string _bridgeClassName = "javax.sql.rowset.JdbcRowSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JdbcRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JdbcRowSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JdbcRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JdbcRowSet(params object[] args) : base(args) { }

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

    #region IJdbcRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJdbcRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getAutoCommit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#setAutoCommit(boolean)"/>
        /// </summary>
        bool AutoCommit { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        Javax.Sql.Rowset.RowSetWarning RowSetWarnings { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        bool ShowDeleted { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#commit()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Commit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Rollback();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void Rollback(Java.Sql.Savepoint arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JdbcRowSet implementation
    public partial class JdbcRowSet : Javax.Sql.Rowset.IJdbcRowSet
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
            get { return IExecuteWithSignature<bool>("getAutoCommit", "()Z"); } set { IExecuteWithSignature("setAutoCommit", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        public Javax.Sql.Rowset.RowSetWarning RowSetWarnings
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getRowSetWarnings", "()Ljavax/sql/rowset/RowSetWarning;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Sql.Rowset.RowSetWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        public bool ShowDeleted
        {
            get { return IExecuteWithSignature<bool>("getShowDeleted", "()Z"); } set { IExecuteWithSignature("setShowDeleted", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#commit()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Commit()
        {
            IExecuteWithSignature("commit", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback()
        {
            IExecuteWithSignature("rollback", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JdbcRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback(Java.Sql.Savepoint arg0)
        {
            IExecuteWithSignature("rollback", "(Ljava/sql/Savepoint;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}