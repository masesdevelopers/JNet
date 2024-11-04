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
    #region XAConnectionBuilder declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html"/>
    /// </summary>
    public partial class XAConnectionBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XAConnectionBuilder>
    {
        const string _bridgeClassName = "javax.sql.XAConnectionBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XAConnectionBuilder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XAConnectionBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XAConnectionBuilder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XAConnectionBuilder(params object[] args) : base(args) { }

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

    #region IXAConnectionBuilder
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXAConnectionBuilder
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.XAConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.XAConnection Build();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        Javax.Sql.XAConnectionBuilder Password(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        Javax.Sql.XAConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        Javax.Sql.XAConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        Javax.Sql.XAConnectionBuilder User(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XAConnectionBuilder implementation
    public partial class XAConnectionBuilder : Javax.Sql.IXAConnectionBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#build()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.XAConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.XAConnection Build()
        {
            return IExecuteWithSignature<Javax.Sql.XAConnection>("build", "()Ljavax/sql/XAConnection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        public Javax.Sql.XAConnectionBuilder Password(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Sql.XAConnectionBuilder>("password", "(Ljava/lang/String;)Ljavax/sql/XAConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#shardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        public Javax.Sql.XAConnectionBuilder ShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Javax.Sql.XAConnectionBuilder>("shardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/XAConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#superShardingKey(java.sql.ShardingKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ShardingKey"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        public Javax.Sql.XAConnectionBuilder SuperShardingKey(Java.Sql.ShardingKey arg0)
        {
            return IExecuteWithSignature<Javax.Sql.XAConnectionBuilder>("superShardingKey", "(Ljava/sql/ShardingKey;)Ljavax/sql/XAConnectionBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XAConnectionBuilder.html#user(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        public Javax.Sql.XAConnectionBuilder User(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Sql.XAConnectionBuilder>("user", "(Ljava/lang/String;)Ljavax/sql/XAConnectionBuilder;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}