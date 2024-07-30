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

namespace Javax.Lang.Model.Type
{
    #region ITypeMirror
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeMirror : Javax.Lang.Model.IAnnotatedConstruct
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#getKind()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeKind Kind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#accept(javax.lang.model.type.TypeVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        R Accept<R, P>(Javax.Lang.Model.Type.TypeVisitor<R, P> arg0, P arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeMirror
    public partial class TypeMirror : Javax.Lang.Model.Type.ITypeMirror
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#getKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeKind Kind
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeKind>("getKind", "()Ljavax/lang/model/type/TypeKind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#accept(javax.lang.model.type.TypeVisitor,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVisitor"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="R"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Accept<R, P>(Javax.Lang.Model.Type.TypeVisitor<R, P> arg0, P arg1)
        {
            return IExecute<R>("accept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}