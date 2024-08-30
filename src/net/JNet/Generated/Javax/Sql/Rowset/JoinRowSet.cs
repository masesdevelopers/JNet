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

namespace Javax.Sql.Rowset
{
    #region JoinRowSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html"/>
    /// </summary>
    public partial class JoinRowSet : Javax.Sql.Rowset.WebRowSet
    {
        const string _bridgeClassName = "javax.sql.rowset.JoinRowSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JoinRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JoinRowSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JoinRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JoinRowSet(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IJoinRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJoinRowSet : Javax.Sql.Rowset.IWebRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getJoinType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#setJoinType(int)"/>
        /// </summary>
        int JoinType { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSetNames()"/> 
        /// </summary>
        Java.Lang.String[] RowSetNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSets()"/> 
        /// </summary>
        Java.Util.Collection<object> RowSets { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getWhereClause()"/> 
        /// </summary>
        Java.Lang.String WhereClause { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsCrossJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool SupportsCrossJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsFullJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool SupportsFullJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsInnerJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool SupportsInnerJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsLeftOuterJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool SupportsLeftOuterJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsRightOuterJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool SupportsRightOuterJoin();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#toCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet ToCachedRowSet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.rowset.Joinable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.Rowset.Joinable"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.Rowset.Joinable arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet[] arg0, int[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void AddRowSet(Javax.Sql.RowSet[] arg0, Java.Lang.String[] arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JoinRowSet implementation
    public partial class JoinRowSet : Javax.Sql.Rowset.IJoinRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#CROSS_JOIN"/>
        /// </summary>
        public static int CROSS_JOIN { get { if (!_CROSS_JOINReady) { _CROSS_JOINContent = SGetField<int>(LocalBridgeClazz, "CROSS_JOIN"); _CROSS_JOINReady = true; } return _CROSS_JOINContent; } }
        private static int _CROSS_JOINContent = default;
        private static bool _CROSS_JOINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#FULL_JOIN"/>
        /// </summary>
        public static int FULL_JOIN { get { if (!_FULL_JOINReady) { _FULL_JOINContent = SGetField<int>(LocalBridgeClazz, "FULL_JOIN"); _FULL_JOINReady = true; } return _FULL_JOINContent; } }
        private static int _FULL_JOINContent = default;
        private static bool _FULL_JOINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#INNER_JOIN"/>
        /// </summary>
        public static int INNER_JOIN { get { if (!_INNER_JOINReady) { _INNER_JOINContent = SGetField<int>(LocalBridgeClazz, "INNER_JOIN"); _INNER_JOINReady = true; } return _INNER_JOINContent; } }
        private static int _INNER_JOINContent = default;
        private static bool _INNER_JOINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#LEFT_OUTER_JOIN"/>
        /// </summary>
        public static int LEFT_OUTER_JOIN { get { if (!_LEFT_OUTER_JOINReady) { _LEFT_OUTER_JOINContent = SGetField<int>(LocalBridgeClazz, "LEFT_OUTER_JOIN"); _LEFT_OUTER_JOINReady = true; } return _LEFT_OUTER_JOINContent; } }
        private static int _LEFT_OUTER_JOINContent = default;
        private static bool _LEFT_OUTER_JOINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#RIGHT_OUTER_JOIN"/>
        /// </summary>
        public static int RIGHT_OUTER_JOIN { get { if (!_RIGHT_OUTER_JOINReady) { _RIGHT_OUTER_JOINContent = SGetField<int>(LocalBridgeClazz, "RIGHT_OUTER_JOIN"); _RIGHT_OUTER_JOINReady = true; } return _RIGHT_OUTER_JOINContent; } }
        private static int _RIGHT_OUTER_JOINContent = default;
        private static bool _RIGHT_OUTER_JOINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getJoinType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#setJoinType(int)"/>
        /// </summary>
        public int JoinType
        {
            get { return IExecuteWithSignature<int>("getJoinType", "()I"); } set { IExecuteWithSignature("setJoinType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSetNames()"/> 
        /// </summary>
        public Java.Lang.String[] RowSetNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getRowSetNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getRowSets()"/> 
        /// </summary>
        public Java.Util.Collection<object> RowSets
        {
            get { return IExecuteWithSignature<Java.Util.Collection<object>>("getRowSets", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#getWhereClause()"/> 
        /// </summary>
        public Java.Lang.String WhereClause
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getWhereClause", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsCrossJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsCrossJoin()
        {
            return IExecuteWithSignature<bool>("supportsCrossJoin", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsFullJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsFullJoin()
        {
            return IExecuteWithSignature<bool>("supportsFullJoin", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsInnerJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsInnerJoin()
        {
            return IExecuteWithSignature<bool>("supportsInnerJoin", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsLeftOuterJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsLeftOuterJoin()
        {
            return IExecuteWithSignature<bool>("supportsLeftOuterJoin", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#supportsRightOuterJoin()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsRightOuterJoin()
        {
            return IExecuteWithSignature<bool>("supportsRightOuterJoin", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#toCachedRowSet()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet ToCachedRowSet()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("toCachedRowSet", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet arg0, int arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet arg0, Java.Lang.String arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.rowset.Joinable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.Rowset.Joinable"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.Rowset.Joinable arg0)
        {
            IExecuteWithSignature("addRowSet", "(Ljavax/sql/rowset/Joinable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet[] arg0, int[] arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/JoinRowSet.html#addRowSet(javax.sql.RowSet[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddRowSet(Javax.Sql.RowSet[] arg0, Java.Lang.String[] arg1)
        {
            IExecute("addRowSet", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}