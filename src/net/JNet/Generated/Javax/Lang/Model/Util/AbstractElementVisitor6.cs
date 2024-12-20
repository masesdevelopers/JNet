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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Util
{
    #region AbstractElementVisitor6 declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html"/>
    /// </summary>
    public partial class AbstractElementVisitor6 : Javax.Lang.Model.Element.ElementVisitor
    {
        const string _bridgeClassName = "javax.lang.model.util.AbstractElementVisitor6";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractElementVisitor6 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractElementVisitor6() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractElementVisitor6 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractElementVisitor6(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AbstractElementVisitor6<R, P> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html"/>
    /// </summary>
    /// <typeparam name="R"></typeparam>
    /// <typeparam name="P"></typeparam>
    public partial class AbstractElementVisitor6<R, P> : Javax.Lang.Model.Element.ElementVisitor<R, P>
    {
        const string _bridgeClassName = "javax.lang.model.util.AbstractElementVisitor6";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractElementVisitor6 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractElementVisitor6() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractElementVisitor6 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractElementVisitor6(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region AbstractElementVisitor6 implementation
    public partial class AbstractElementVisitor6
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visit(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecuteWithSignature("visit", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visit(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecuteWithSignature("visit", "(Ljavax/lang/model/element/Element;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visitModule(javax.lang.model.element.ModuleElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitModule(Javax.Lang.Model.Element.ModuleElement arg0, object arg1)
        {
            return IExecuteWithSignature("visitModule", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visitUnknown(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecuteWithSignature("visitUnknown", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractElementVisitor6<R, P> implementation
    public partial class AbstractElementVisitor6<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Util.AbstractElementVisitor6{R, P}"/> to <see cref="Javax.Lang.Model.Util.AbstractElementVisitor6"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Util.AbstractElementVisitor6(Javax.Lang.Model.Util.AbstractElementVisitor6<R, P> t) => t.Cast<Javax.Lang.Model.Util.AbstractElementVisitor6>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visit(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.Element arg0, P arg1)
        {
            return IExecuteWithSignature<R>("visit", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visit(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecuteWithSignature<R>("visit", "(Ljavax/lang/model/element/Element;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visitModule(javax.lang.model.element.ModuleElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitModule(Javax.Lang.Model.Element.ModuleElement arg0, P arg1)
        {
            return IExecuteWithSignature<R>("visitModule", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/AbstractElementVisitor6.html#visitUnknown(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Element.Element arg0, P arg1)
        {
            return IExecuteWithSignature<R>("visitUnknown", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}