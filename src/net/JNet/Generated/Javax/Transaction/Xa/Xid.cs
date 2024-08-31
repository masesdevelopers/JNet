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

namespace Javax.Transaction.Xa
{
    #region Xid declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html"/>
    /// </summary>
    public partial class Xid : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Xid>
    {
        const string _bridgeClassName = "javax.transaction.xa.Xid";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Xid class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Xid() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Xid class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Xid(params object[] args) : base(args) { }

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

    #region IXid
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXid
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getBranchQualifier()"/> 
        /// </summary>
        byte[] BranchQualifier { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getFormatId()"/> 
        /// </summary>
        int FormatId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getGlobalTransactionId()"/> 
        /// </summary>
        byte[] GlobalTransactionId { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Xid implementation
    public partial class Xid : Javax.Transaction.Xa.IXid
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXBQUALSIZE"/>
        /// </summary>
        public static int MAXBQUALSIZE { get { if (!_MAXBQUALSIZEReady) { _MAXBQUALSIZEContent = SGetField<int>(LocalBridgeClazz, "MAXBQUALSIZE"); _MAXBQUALSIZEReady = true; } return _MAXBQUALSIZEContent; } }
        private static int _MAXBQUALSIZEContent = default;
        private static bool _MAXBQUALSIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#MAXGTRIDSIZE"/>
        /// </summary>
        public static int MAXGTRIDSIZE { get { if (!_MAXGTRIDSIZEReady) { _MAXGTRIDSIZEContent = SGetField<int>(LocalBridgeClazz, "MAXGTRIDSIZE"); _MAXGTRIDSIZEReady = true; } return _MAXGTRIDSIZEContent; } }
        private static int _MAXGTRIDSIZEContent = default;
        private static bool _MAXGTRIDSIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getBranchQualifier()"/> 
        /// </summary>
        public byte[] BranchQualifier
        {
            get { return IExecuteWithSignatureArray<byte>("getBranchQualifier", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getFormatId()"/> 
        /// </summary>
        public int FormatId
        {
            get { return IExecuteWithSignature<int>("getFormatId", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/Xid.html#getGlobalTransactionId()"/> 
        /// </summary>
        public byte[] GlobalTransactionId
        {
            get { return IExecuteWithSignatureArray<byte>("getGlobalTransactionId", "()[B"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}