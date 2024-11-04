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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region StatementEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html"/>
    /// </summary>
    public partial class StatementEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "javax.sql.StatementEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StatementEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StatementEvent(params object[] args) : base(args) { }

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

    #region StatementEvent implementation
    public partial class StatementEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#%3Cinit%3E(javax.sql.PooledConnection,java.sql.PreparedStatement,java.sql.SQLException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.PooledConnection"/></param>
        /// <param name="arg1"><see cref="Java.Sql.PreparedStatement"/></param>
        /// <param name="arg2"><see cref="Java.Sql.SQLException"/></param>
        public StatementEvent(Javax.Sql.PooledConnection arg0, Java.Sql.PreparedStatement arg1, Java.Sql.SQLException arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#%3Cinit%3E(javax.sql.PooledConnection,java.sql.PreparedStatement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.PooledConnection"/></param>
        /// <param name="arg1"><see cref="Java.Sql.PreparedStatement"/></param>
        public StatementEvent(Javax.Sql.PooledConnection arg0, Java.Sql.PreparedStatement arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#getSQLException()"/> 
        /// </summary>
        public Java.Sql.SQLException SQLException
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getSQLException", "()Ljava/sql/SQLException;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Sql.SQLException>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#getStatement()"/> 
        /// </summary>
        public Java.Sql.PreparedStatement Statement
        {
            get { return IExecuteWithSignature<Java.Sql.PreparedStatement>("getStatement", "()Ljava/sql/PreparedStatement;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}