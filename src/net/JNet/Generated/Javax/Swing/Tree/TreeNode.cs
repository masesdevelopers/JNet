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

namespace Javax.Swing.Tree
{
    #region TreeNode declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html"/>
    /// </summary>
    public partial class TreeNode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TreeNode>
    {
        const string _bridgeClassName = "javax.swing.tree.TreeNode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TreeNode class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeNode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TreeNode class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TreeNode(params object[] args) : base(args) { }

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

    #region ITreeNode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITreeNode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getAllowsChildren()"/> 
        /// </summary>
        bool AllowsChildren { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildCount()"/> 
        /// </summary>
        int ChildCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getParent()"/> 
        /// </summary>
        Javax.Swing.Tree.TreeNode Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#isLeaf()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsLeaf();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="int"/></returns>
        int GetIndex(Javax.Swing.Tree.TreeNode arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#children()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsJavax_Swing_Tree_TreeNode"><see cref="Javax.Swing.Tree.TreeNode"/></typeparam>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode> Children<ReturnExtendsJavax_Swing_Tree_TreeNode>() where ReturnExtendsJavax_Swing_Tree_TreeNode : Javax.Swing.Tree.TreeNode;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        Javax.Swing.Tree.TreeNode GetChildAt(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeNode implementation
    public partial class TreeNode : Javax.Swing.Tree.ITreeNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getAllowsChildren()"/> 
        /// </summary>
        public bool AllowsChildren
        {
            get { return IExecuteWithSignature<bool>("getAllowsChildren", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildCount()"/> 
        /// </summary>
        public int ChildCount
        {
            get { return IExecuteWithSignature<int>("getChildCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getParent()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode Parent
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getParent", "()Ljavax/swing/tree/TreeNode;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#isLeaf()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeaf()
        {
            return IExecuteWithSignature<bool>("isLeaf", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndex(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecuteWithSignature<int>("getIndex", "(Ljavax/swing/tree/TreeNode;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#children()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsJavax_Swing_Tree_TreeNode"><see cref="Javax.Swing.Tree.TreeNode"/></typeparam>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode> Children<ReturnExtendsJavax_Swing_Tree_TreeNode>() where ReturnExtendsJavax_Swing_Tree_TreeNode : Javax.Swing.Tree.TreeNode
        {
            return IExecuteWithSignature<Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode>>("children", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAt(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Tree.TreeNode>("getChildAt", "(I)Ljavax/swing/tree/TreeNode;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}