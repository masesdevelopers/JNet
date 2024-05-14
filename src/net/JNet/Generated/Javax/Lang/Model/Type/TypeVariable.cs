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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Type
{
    #region ITypeVariable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeVariable : Javax.Lang.Model.Type.IReferenceType
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#getLowerBound()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror LowerBound { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#getUpperBound()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror UpperBound { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#asElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.Element.Element"/></returns>
        Javax.Lang.Model.Element.Element AsElement();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeVariable
    public partial class TypeVariable : Javax.Lang.Model.Type.ITypeVariable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#getLowerBound()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror LowerBound
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getLowerBound", "()Ljavax/lang/model/type/TypeMirror;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#getUpperBound()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror UpperBound
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getUpperBound", "()Ljavax/lang/model/type/TypeMirror;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeVariable.html#asElement()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.Element.Element"/></returns>
        public Javax.Lang.Model.Element.Element AsElement()
        {
            return IExecuteWithSignature<Javax.Lang.Model.Element.Element>("asElement", "()Ljavax/lang/model/element/Element;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}