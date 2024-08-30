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

namespace Java.Security.Cert
{
    #region PolicyNode declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html"/>
    /// </summary>
    public partial class PolicyNode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PolicyNode>
    {
        const string _bridgeClassName = "java.security.cert.PolicyNode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PolicyNode class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PolicyNode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PolicyNode class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PolicyNode(params object[] args) : base(args) { }

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

    #region IPolicyNode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPolicyNode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getChildren()"/> 
        /// </summary>
        Java.Util.Iterator Children { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getDepth()"/> 
        /// </summary>
        int Depth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getExpectedPolicies()"/> 
        /// </summary>
        Java.Util.Set<Java.Lang.String> ExpectedPolicies { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getParent()"/> 
        /// </summary>
        Java.Security.Cert.PolicyNode Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getPolicyQualifiers()"/> 
        /// </summary>
        Java.Util.Set PolicyQualifiers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getValidPolicy()"/> 
        /// </summary>
        Java.Lang.String ValidPolicy { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#isCritical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCritical();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PolicyNode implementation
    public partial class PolicyNode : Java.Security.Cert.IPolicyNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getChildren()"/> 
        /// </summary>
        public Java.Util.Iterator Children
        {
            get { return IExecuteWithSignature<Java.Util.Iterator>("getChildren", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecuteWithSignature<int>("getDepth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getExpectedPolicies()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> ExpectedPolicies
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getExpectedPolicies", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getParent()"/> 
        /// </summary>
        public Java.Security.Cert.PolicyNode Parent
        {
            get { return IExecuteWithSignature<Java.Security.Cert.PolicyNode>("getParent", "()Ljava/security/cert/PolicyNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getPolicyQualifiers()"/> 
        /// </summary>
        public Java.Util.Set PolicyQualifiers
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getPolicyQualifiers", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getValidPolicy()"/> 
        /// </summary>
        public Java.Lang.String ValidPolicy
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getValidPolicy", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#isCritical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCritical()
        {
            return IExecuteWithSignature<bool>("isCritical", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}