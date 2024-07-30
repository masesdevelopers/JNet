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

namespace Javax.Lang.Model.Util
{
    #region ElementScanner6
    public partial class ElementScanner6
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(java.lang.Iterable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Scan(Java.Lang.Iterable arg0, object arg1)
        {
            return IExecute("scan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="object"/></returns>
        public object Scan(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecuteWithSignature("scan", "(Ljavax/lang/model/element/Element;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Scan(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecute("scan", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ElementScanner6<R, P>
    public partial class ElementScanner6<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Util.ElementScanner6{R, P}"/> to <see cref="Javax.Lang.Model.Util.ElementScanner6"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Util.ElementScanner6(Javax.Lang.Model.Util.ElementScanner6<R, P> t) => t.Cast<Javax.Lang.Model.Util.ElementScanner6>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(java.lang.Iterable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Scan<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0, P arg1) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return IExecute<R>("scan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Scan(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecuteWithSignature<R>("scan", "(Ljavax/lang/model/element/Element;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementScanner6.html#scan(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Scan(Javax.Lang.Model.Element.Element arg0, P arg1)
        {
            return IExecute<R>("scan", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}