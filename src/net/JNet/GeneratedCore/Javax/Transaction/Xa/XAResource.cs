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
    #region XAResource definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html"/>
    /// </summary>
    public partial class XAResource : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XAResource>
    {
        const string _bridgeClassName = "javax.transaction.xa.XAResource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XAResource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XAResource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XAResource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XAResource(params object[] args) : base(args) { }

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

    #region IXAResource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXAResource
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#getTransactionTimeout()"/> 
        /// </summary>
        int TransactionTimeout { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#isSameRM(javax.transaction.xa.XAResource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.XAResource"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        bool IsSameRM(Javax.Transaction.Xa.XAResource arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#setTransactionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        bool SetTransactionTimeout(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#prepare(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        int Prepare(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#recover(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Transaction.Xa.Xid"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        Javax.Transaction.Xa.Xid[] Recover(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#commit(javax.transaction.xa.Xid,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Commit(Javax.Transaction.Xa.Xid arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#end(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void End(Javax.Transaction.Xa.Xid arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#forget(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Forget(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#rollback(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Rollback(Javax.Transaction.Xa.Xid arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#start(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        void Start(Javax.Transaction.Xa.Xid arg0, int arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XAResource
    public partial class XAResource : Javax.Transaction.Xa.IXAResource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMENDRSCAN"/>
        /// </summary>
        public static int TMENDRSCAN { get { if (!_TMENDRSCANReady) { _TMENDRSCANContent = SGetField<int>(LocalBridgeClazz, "TMENDRSCAN"); _TMENDRSCANReady = true; } return _TMENDRSCANContent; } }
        private static int _TMENDRSCANContent = default;
        private static bool _TMENDRSCANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMFAIL"/>
        /// </summary>
        public static int TMFAIL { get { if (!_TMFAILReady) { _TMFAILContent = SGetField<int>(LocalBridgeClazz, "TMFAIL"); _TMFAILReady = true; } return _TMFAILContent; } }
        private static int _TMFAILContent = default;
        private static bool _TMFAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMJOIN"/>
        /// </summary>
        public static int TMJOIN { get { if (!_TMJOINReady) { _TMJOINContent = SGetField<int>(LocalBridgeClazz, "TMJOIN"); _TMJOINReady = true; } return _TMJOINContent; } }
        private static int _TMJOINContent = default;
        private static bool _TMJOINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMNOFLAGS"/>
        /// </summary>
        public static int TMNOFLAGS { get { if (!_TMNOFLAGSReady) { _TMNOFLAGSContent = SGetField<int>(LocalBridgeClazz, "TMNOFLAGS"); _TMNOFLAGSReady = true; } return _TMNOFLAGSContent; } }
        private static int _TMNOFLAGSContent = default;
        private static bool _TMNOFLAGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMONEPHASE"/>
        /// </summary>
        public static int TMONEPHASE { get { if (!_TMONEPHASEReady) { _TMONEPHASEContent = SGetField<int>(LocalBridgeClazz, "TMONEPHASE"); _TMONEPHASEReady = true; } return _TMONEPHASEContent; } }
        private static int _TMONEPHASEContent = default;
        private static bool _TMONEPHASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMRESUME"/>
        /// </summary>
        public static int TMRESUME { get { if (!_TMRESUMEReady) { _TMRESUMEContent = SGetField<int>(LocalBridgeClazz, "TMRESUME"); _TMRESUMEReady = true; } return _TMRESUMEContent; } }
        private static int _TMRESUMEContent = default;
        private static bool _TMRESUMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSTARTRSCAN"/>
        /// </summary>
        public static int TMSTARTRSCAN { get { if (!_TMSTARTRSCANReady) { _TMSTARTRSCANContent = SGetField<int>(LocalBridgeClazz, "TMSTARTRSCAN"); _TMSTARTRSCANReady = true; } return _TMSTARTRSCANContent; } }
        private static int _TMSTARTRSCANContent = default;
        private static bool _TMSTARTRSCANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSUCCESS"/>
        /// </summary>
        public static int TMSUCCESS { get { if (!_TMSUCCESSReady) { _TMSUCCESSContent = SGetField<int>(LocalBridgeClazz, "TMSUCCESS"); _TMSUCCESSReady = true; } return _TMSUCCESSContent; } }
        private static int _TMSUCCESSContent = default;
        private static bool _TMSUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#TMSUSPEND"/>
        /// </summary>
        public static int TMSUSPEND { get { if (!_TMSUSPENDReady) { _TMSUSPENDContent = SGetField<int>(LocalBridgeClazz, "TMSUSPEND"); _TMSUSPENDReady = true; } return _TMSUSPENDContent; } }
        private static int _TMSUSPENDContent = default;
        private static bool _TMSUSPENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#XA_OK"/>
        /// </summary>
        public static int XA_OK { get { if (!_XA_OKReady) { _XA_OKContent = SGetField<int>(LocalBridgeClazz, "XA_OK"); _XA_OKReady = true; } return _XA_OKContent; } }
        private static int _XA_OKContent = default;
        private static bool _XA_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#XA_RDONLY"/>
        /// </summary>
        public static int XA_RDONLY { get { if (!_XA_RDONLYReady) { _XA_RDONLYContent = SGetField<int>(LocalBridgeClazz, "XA_RDONLY"); _XA_RDONLYReady = true; } return _XA_RDONLYContent; } }
        private static int _XA_RDONLYContent = default;
        private static bool _XA_RDONLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#getTransactionTimeout()"/> 
        /// </summary>
        public int TransactionTimeout
        {
            get { return IExecuteWithSignature<int>("getTransactionTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#isSameRM(javax.transaction.xa.XAResource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.XAResource"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public bool IsSameRM(Javax.Transaction.Xa.XAResource arg0)
        {
            return IExecuteWithSignature<bool>("isSameRM", "(Ljavax/transaction/xa/XAResource;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#setTransactionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public bool SetTransactionTimeout(int arg0)
        {
            return IExecuteWithSignature<bool>("setTransactionTimeout", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#prepare(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public int Prepare(Javax.Transaction.Xa.Xid arg0)
        {
            return IExecuteWithSignature<int>("prepare", "(Ljavax/transaction/xa/Xid;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#recover(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Transaction.Xa.Xid"/></returns>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public Javax.Transaction.Xa.Xid[] Recover(int arg0)
        {
            return IExecuteWithSignatureArray<Javax.Transaction.Xa.Xid>("recover", "(I)[Ljavax/transaction/xa/Xid;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#commit(javax.transaction.xa.Xid,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Commit(Javax.Transaction.Xa.Xid arg0, bool arg1)
        {
            IExecute("commit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#end(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void End(Javax.Transaction.Xa.Xid arg0, int arg1)
        {
            IExecute("end", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#forget(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Forget(Javax.Transaction.Xa.Xid arg0)
        {
            IExecuteWithSignature("forget", "(Ljavax/transaction/xa/Xid;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#rollback(javax.transaction.xa.Xid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Rollback(Javax.Transaction.Xa.Xid arg0)
        {
            IExecuteWithSignature("rollback", "(Ljavax/transaction/xa/Xid;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.transaction.xa/javax/transaction/xa/XAResource.html#start(javax.transaction.xa.Xid,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Transaction.Xa.Xid"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Transaction.Xa.XAException"/>
        public void Start(Javax.Transaction.Xa.Xid arg0, int arg1)
        {
            IExecute("start", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}