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

namespace Javax.Xml.Stream.Events
{
    #region IEntityReference
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEntityReference : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/EntityReference.html#getDeclaration()"/> 
        /// </summary>
        Javax.Xml.Stream.Events.EntityDeclaration Declaration { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/EntityReference.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EntityReference
    public partial class EntityReference : Javax.Xml.Stream.Events.IEntityReference
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/EntityReference.html#getDeclaration()"/> 
        /// </summary>
        public Javax.Xml.Stream.Events.EntityDeclaration Declaration
        {
            get { return IExecuteWithSignature<Javax.Xml.Stream.Events.EntityDeclaration>("getDeclaration", "()Ljavax/xml/stream/events/EntityDeclaration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/EntityReference.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}