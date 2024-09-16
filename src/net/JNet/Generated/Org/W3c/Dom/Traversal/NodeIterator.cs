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

namespace Org.W3c.Dom.Traversal
{
    #region NodeIterator declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html"/>
    /// </summary>
    public partial class NodeIterator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NodeIterator>
    {
        const string _bridgeClassName = "org.w3c.dom.traversal.NodeIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("NodeIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public NodeIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("NodeIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public NodeIterator(params object[] args) : base(args) { }

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

    #region INodeIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INodeIterator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getExpandEntityReferences()"/> 
        /// </summary>
        bool ExpandEntityReferences { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getFilter()"/> 
        /// </summary>
        Org.W3c.Dom.Traversal.NodeFilter Filter { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getRoot()"/> 
        /// </summary>
        Org.W3c.Dom.Node Root { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getWhatToShow()"/> 
        /// </summary>
        int WhatToShow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#nextNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node NextNode();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#previousNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node PreviousNode();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#detach()"/>
        /// </summary>
        void Detach();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NodeIterator implementation
    public partial class NodeIterator : Org.W3c.Dom.Traversal.INodeIterator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getExpandEntityReferences()"/> 
        /// </summary>
        public bool ExpandEntityReferences
        {
            get { return IExecuteWithSignature<bool>("getExpandEntityReferences", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getFilter()"/> 
        /// </summary>
        public Org.W3c.Dom.Traversal.NodeFilter Filter
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Traversal.NodeFilter>("getFilter", "()Lorg/w3c/dom/traversal/NodeFilter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getRoot()"/> 
        /// </summary>
        public Org.W3c.Dom.Node Root
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getRoot", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#getWhatToShow()"/> 
        /// </summary>
        public int WhatToShow
        {
            get { return IExecuteWithSignature<int>("getWhatToShow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#nextNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node NextNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("nextNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#previousNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node PreviousNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("previousNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/NodeIterator.html#detach()"/>
        /// </summary>
        public void Detach()
        {
            IExecuteWithSignature("detach", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}