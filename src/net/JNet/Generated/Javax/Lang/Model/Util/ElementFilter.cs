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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Util
{
    #region ElementFilter
    public partial class ElementFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#constructorsIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ExecutableElement> ConstructorsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ExecutableElement>>(LocalBridgeClazz, "constructorsIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#methodsIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ExecutableElement> MethodsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ExecutableElement>>(LocalBridgeClazz, "methodsIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#modulesIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement> ModulesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement>>(LocalBridgeClazz, "modulesIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#exportsIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement.ExportsDirective> ExportsIn<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive> arg0) where Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive : Javax.Lang.Model.Element.ModuleElement.Directive
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement.ExportsDirective>>(LocalBridgeClazz, "exportsIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#opensIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement.OpensDirective> OpensIn<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive> arg0) where Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive : Javax.Lang.Model.Element.ModuleElement.Directive
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement.OpensDirective>>(LocalBridgeClazz, "opensIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#providesIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement.ProvidesDirective> ProvidesIn<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive> arg0) where Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive : Javax.Lang.Model.Element.ModuleElement.Directive
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement.ProvidesDirective>>(LocalBridgeClazz, "providesIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#requiresIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement.RequiresDirective> RequiresIn<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive> arg0) where Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive : Javax.Lang.Model.Element.ModuleElement.Directive
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement.RequiresDirective>>(LocalBridgeClazz, "requiresIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#usesIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.ModuleElement.UsesDirective> UsesIn<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive> arg0) where Arg0ExtendsJavax_Lang_Model_Element_ModuleElement_Directive : Javax.Lang.Model.Element.ModuleElement.Directive
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.ModuleElement.UsesDirective>>(LocalBridgeClazz, "usesIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#packagesIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.PackageElement> PackagesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.PackageElement>>(LocalBridgeClazz, "packagesIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#typesIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.TypeElement> TypesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.TypeElement>>(LocalBridgeClazz, "typesIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#fieldsIn(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Javax.Lang.Model.Element.VariableElement> FieldsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Iterable<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.List<Javax.Lang.Model.Element.VariableElement>>(LocalBridgeClazz, "fieldsIn", "(Ljava/lang/Iterable;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#constructorsIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.ExecutableElement> ConstructorsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.ExecutableElement>>(LocalBridgeClazz, "constructorsIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#methodsIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.ExecutableElement> MethodsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.ExecutableElement>>(LocalBridgeClazz, "methodsIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#modulesIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.ModuleElement> ModulesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.ModuleElement>>(LocalBridgeClazz, "modulesIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#packagesIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.PackageElement> PackagesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.PackageElement>>(LocalBridgeClazz, "packagesIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#typesIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.TypeElement> TypesIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.TypeElement>>(LocalBridgeClazz, "typesIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#fieldsIn(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Javax.Lang.Model.Element.VariableElement> FieldsIn<Arg0ExtendsJavax_Lang_Model_Element_Element>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_Element> arg0) where Arg0ExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return SExecuteWithSignature<Java.Util.Set<Javax.Lang.Model.Element.VariableElement>>(LocalBridgeClazz, "fieldsIn", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}