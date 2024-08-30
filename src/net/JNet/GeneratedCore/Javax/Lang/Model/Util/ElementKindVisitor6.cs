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

namespace Javax.Lang.Model.Util
{
    #region ElementKindVisitor6 definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html"/>
    /// </summary>
    public partial class ElementKindVisitor6 : Javax.Lang.Model.Util.SimpleElementVisitor6
    {
        const string _bridgeClassName = "javax.lang.model.util.ElementKindVisitor6";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ElementKindVisitor6() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ElementKindVisitor6(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ElementKindVisitor6<R, P> definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html"/>
    /// </summary>
    /// <typeparam name="R"></typeparam>
    /// <typeparam name="P"></typeparam>
    public partial class ElementKindVisitor6<R, P> : Javax.Lang.Model.Util.SimpleElementVisitor6<R, P>
    {
        const string _bridgeClassName = "javax.lang.model.util.ElementKindVisitor6";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ElementKindVisitor6() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ElementKindVisitor6(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region ElementKindVisitor6
    public partial class ElementKindVisitor6
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsConstructor(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutableAsConstructor(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutableAsConstructor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsInstanceInit(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutableAsInstanceInit(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutableAsInstanceInit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsMethod(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutableAsMethod(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutableAsMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsStaticInit(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutableAsStaticInit(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutableAsStaticInit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsAnnotationType(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeAsAnnotationType(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitTypeAsAnnotationType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsClass(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeAsClass(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitTypeAsClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsEnum(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeAsEnum(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitTypeAsEnum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsInterface(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeAsInterface(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitTypeAsInterface", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsEnumConstant(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsEnumConstant(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsEnumConstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsExceptionParameter(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsExceptionParameter(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsExceptionParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsField(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsField(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsLocalVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsLocalVariable(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsLocalVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsParameter(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsParameter(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsResourceVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariableAsResourceVariable(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariableAsResourceVariable", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ElementKindVisitor6<R, P>
    public partial class ElementKindVisitor6<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Util.ElementKindVisitor6{R, P}"/> to <see cref="Javax.Lang.Model.Util.ElementKindVisitor6"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Util.ElementKindVisitor6(Javax.Lang.Model.Util.ElementKindVisitor6<R, P> t) => t.Cast<Javax.Lang.Model.Util.ElementKindVisitor6>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsConstructor(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutableAsConstructor(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1)
        {
            return IExecute<R>("visitExecutableAsConstructor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsInstanceInit(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutableAsInstanceInit(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1)
        {
            return IExecute<R>("visitExecutableAsInstanceInit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsMethod(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutableAsMethod(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1)
        {
            return IExecute<R>("visitExecutableAsMethod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitExecutableAsStaticInit(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutableAsStaticInit(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1)
        {
            return IExecute<R>("visitExecutableAsStaticInit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsAnnotationType(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeAsAnnotationType(Javax.Lang.Model.Element.TypeElement arg0, P arg1)
        {
            return IExecute<R>("visitTypeAsAnnotationType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsClass(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeAsClass(Javax.Lang.Model.Element.TypeElement arg0, P arg1)
        {
            return IExecute<R>("visitTypeAsClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsEnum(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeAsEnum(Javax.Lang.Model.Element.TypeElement arg0, P arg1)
        {
            return IExecute<R>("visitTypeAsEnum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitTypeAsInterface(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeAsInterface(Javax.Lang.Model.Element.TypeElement arg0, P arg1)
        {
            return IExecute<R>("visitTypeAsInterface", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsEnumConstant(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsEnumConstant(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsEnumConstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsExceptionParameter(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsExceptionParameter(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsExceptionParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsField(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsField(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsLocalVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsLocalVariable(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsLocalVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsParameter(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsParameter(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementKindVisitor6.html#visitVariableAsResourceVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariableAsResourceVariable(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariableAsResourceVariable", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}