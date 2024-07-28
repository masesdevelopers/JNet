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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region IAttributeException
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttributeException
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/AttributeException.html#getUnsupportedAttributes()"/> 
        /// </summary>
        Java.Lang.Class[] UnsupportedAttributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/AttributeException.html#getUnsupportedValues()"/> 
        /// </summary>
        Javax.Print.Attribute.Attribute[] UnsupportedValues { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AttributeException
    public partial class AttributeException : Javax.Print.IAttributeException
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/AttributeException.html#getUnsupportedAttributes()"/> 
        /// </summary>
        public Java.Lang.Class[] UnsupportedAttributes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Class>("getUnsupportedAttributes", "()[Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/AttributeException.html#getUnsupportedValues()"/> 
        /// </summary>
        public Javax.Print.Attribute.Attribute[] UnsupportedValues
        {
            get { return IExecuteWithSignatureArray<Javax.Print.Attribute.Attribute>("getUnsupportedValues", "()[Ljavax/print/attribute/Attribute;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}