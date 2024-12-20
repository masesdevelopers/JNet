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

namespace Javax.Sql.Rowset
{
    #region RowSetFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html"/>
    /// </summary>
    public partial class RowSetFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RowSetFactory>
    {
        const string _bridgeClassName = "javax.sql.rowset.RowSetFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RowSetFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSetFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RowSetFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSetFactory(params object[] args) : base(args) { }

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

    #region IRowSetFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet CreateCachedRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createFilteredRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.FilteredRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.FilteredRowSet CreateFilteredRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJdbcRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JdbcRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.JdbcRowSet CreateJdbcRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJoinRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JoinRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.JoinRowSet CreateJoinRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createWebRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.WebRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.WebRowSet CreateWebRowSet();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetFactory implementation
    public partial class RowSetFactory : Javax.Sql.Rowset.IRowSetFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCachedRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("createCachedRowSet", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createFilteredRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.FilteredRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.FilteredRowSet CreateFilteredRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.FilteredRowSet>("createFilteredRowSet", "()Ljavax/sql/rowset/FilteredRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJdbcRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JdbcRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.JdbcRowSet CreateJdbcRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.JdbcRowSet>("createJdbcRowSet", "()Ljavax/sql/rowset/JdbcRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJoinRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.JoinRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.JoinRowSet CreateJoinRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.JoinRowSet>("createJoinRowSet", "()Ljavax/sql/rowset/JoinRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createWebRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.WebRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.WebRowSet CreateWebRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.WebRowSet>("createWebRowSet", "()Ljavax/sql/rowset/WebRowSet;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}