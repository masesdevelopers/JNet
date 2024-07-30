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
    #region ITreeWalker
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITreeWalker
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getCurrentNode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#setCurrentNode(org.w3c.dom.Node)"/>
        /// </summary>
        Org.W3c.Dom.Node CurrentNode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getExpandEntityReferences()"/> 
        /// </summary>
        bool ExpandEntityReferences { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getFilter()"/> 
        /// </summary>
        Org.W3c.Dom.Traversal.NodeFilter Filter { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getRoot()"/> 
        /// </summary>
        Org.W3c.Dom.Node Root { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getWhatToShow()"/> 
        /// </summary>
        int WhatToShow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#firstChild()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node FirstChild();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#lastChild()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node LastChild();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node NextNode();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextSibling()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node NextSibling();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#parentNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node ParentNode();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node PreviousNode();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousSibling()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node PreviousSibling();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeWalker
    public partial class TreeWalker : Org.W3c.Dom.Traversal.ITreeWalker
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getCurrentNode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#setCurrentNode(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node CurrentNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getCurrentNode", "()Lorg/w3c/dom/Node;"); } set { IExecuteWithSignature("setCurrentNode", "(Lorg/w3c/dom/Node;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getExpandEntityReferences()"/> 
        /// </summary>
        public bool ExpandEntityReferences
        {
            get { return IExecuteWithSignature<bool>("getExpandEntityReferences", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getFilter()"/> 
        /// </summary>
        public Org.W3c.Dom.Traversal.NodeFilter Filter
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Traversal.NodeFilter>("getFilter", "()Lorg/w3c/dom/traversal/NodeFilter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getRoot()"/> 
        /// </summary>
        public Org.W3c.Dom.Node Root
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getRoot", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#getWhatToShow()"/> 
        /// </summary>
        public int WhatToShow
        {
            get { return IExecuteWithSignature<int>("getWhatToShow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#firstChild()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node FirstChild()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("firstChild", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#lastChild()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node LastChild()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("lastChild", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node NextNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("nextNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#nextSibling()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node NextSibling()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("nextSibling", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#parentNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node ParentNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("parentNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node PreviousNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("previousNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/traversal/TreeWalker.html#previousSibling()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node PreviousSibling()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("previousSibling", "()Lorg/w3c/dom/Node;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}