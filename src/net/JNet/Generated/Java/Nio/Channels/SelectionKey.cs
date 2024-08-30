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

namespace Java.Nio.Channels
{
    #region SelectionKey declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html"/>
    /// </summary>
    public partial class SelectionKey : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SelectionKey>
    {
        const string _bridgeClassName = "java.nio.channels.SelectionKey";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SelectionKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectionKey() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SelectionKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SelectionKey(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SelectionKey implementation
    public partial class SelectionKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_ACCEPT"/>
        /// </summary>
        public static int OP_ACCEPT { get { if (!_OP_ACCEPTReady) { _OP_ACCEPTContent = SGetField<int>(LocalBridgeClazz, "OP_ACCEPT"); _OP_ACCEPTReady = true; } return _OP_ACCEPTContent; } }
        private static int _OP_ACCEPTContent = default;
        private static bool _OP_ACCEPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_CONNECT"/>
        /// </summary>
        public static int OP_CONNECT { get { if (!_OP_CONNECTReady) { _OP_CONNECTContent = SGetField<int>(LocalBridgeClazz, "OP_CONNECT"); _OP_CONNECTReady = true; } return _OP_CONNECTContent; } }
        private static int _OP_CONNECTContent = default;
        private static bool _OP_CONNECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_READ"/>
        /// </summary>
        public static int OP_READ { get { if (!_OP_READReady) { _OP_READContent = SGetField<int>(LocalBridgeClazz, "OP_READ"); _OP_READReady = true; } return _OP_READContent; } }
        private static int _OP_READContent = default;
        private static bool _OP_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#OP_WRITE"/>
        /// </summary>
        public static int OP_WRITE { get { if (!_OP_WRITEReady) { _OP_WRITEContent = SGetField<int>(LocalBridgeClazz, "OP_WRITE"); _OP_WRITEReady = true; } return _OP_WRITEContent; } }
        private static int _OP_WRITEContent = default;
        private static bool _OP_WRITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int InterestOps()
        {
            return IExecuteWithSignature<int>("interestOps", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#readyOps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ReadyOps()
        {
            return IExecuteWithSignature<int>("readyOps", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#channel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SelectableChannel"/></returns>
        public Java.Nio.Channels.SelectableChannel Channel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SelectableChannel>("channel", "()Ljava/nio/channels/SelectableChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOps(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.SelectionKey"/></returns>
        public Java.Nio.Channels.SelectionKey InterestOps(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.SelectionKey>("interestOps", "(I)Ljava/nio/channels/SelectionKey;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#selector()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Selector"/></returns>
        public Java.Nio.Channels.Selector Selector()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Selector>("selector", "()Ljava/nio/channels/Selector;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isAcceptable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAcceptable()
        {
            return IExecuteWithSignature<bool>("isAcceptable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isConnectable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnectable()
        {
            return IExecuteWithSignature<bool>("isConnectable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isReadable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadable()
        {
            return IExecuteWithSignature<bool>("isReadable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#isWritable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecuteWithSignature<bool>("isWritable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#attach(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Attach(object arg0)
        {
            return IExecuteWithSignature("attach", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#attachment()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Attachment()
        {
            return IExecuteWithSignature("attachment", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOpsAnd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int InterestOpsAnd(int arg0)
        {
            return IExecuteWithSignature<int>("interestOpsAnd", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SelectionKey.html#interestOpsOr(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int InterestOpsOr(int arg0)
        {
            return IExecuteWithSignature<int>("interestOpsOr", "(I)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}