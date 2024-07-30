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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IDocumentType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocumentType : Org.W3c.Dom.INode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getEntities()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Entities { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getInternalSubset()"/> 
        /// </summary>
        Java.Lang.String InternalSubset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getNotations()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Notations { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getPublicId()"/> 
        /// </summary>
        Java.Lang.String PublicId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getSystemId()"/> 
        /// </summary>
        Java.Lang.String SystemId { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentType
    public partial class DocumentType : Org.W3c.Dom.IDocumentType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getEntities()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Entities
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.NamedNodeMap>("getEntities", "()Lorg/w3c/dom/NamedNodeMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getInternalSubset()"/> 
        /// </summary>
        public Java.Lang.String InternalSubset
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInternalSubset", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getNotations()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Notations
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.NamedNodeMap>("getNotations", "()Lorg/w3c/dom/NamedNodeMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getPublicId()"/> 
        /// </summary>
        public Java.Lang.String PublicId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPublicId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/DocumentType.html#getSystemId()"/> 
        /// </summary>
        public Java.Lang.String SystemId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}