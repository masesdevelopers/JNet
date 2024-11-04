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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Annotation.Processing
{
    #region RoundEnvironment declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html"/>
    /// </summary>
    public partial class RoundEnvironment : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RoundEnvironment>
    {
        const string _bridgeClassName = "javax.annotation.processing.RoundEnvironment";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RoundEnvironment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RoundEnvironment() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RoundEnvironment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RoundEnvironment(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IRoundEnvironment
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRoundEnvironment
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getRootElements()"/> 
        /// </summary>
        Java.Util.Set RootElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#errorRaised()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool ErrorRaised();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#processingOver()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool ProcessingOver();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Class arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Javax.Lang.Model.Element.TypeElement arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element, Arg0ExtendsJava_Lang_Annotation_Annotation>(Java.Util.Set<Java.Lang.Class> arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element where Arg0ExtendsJava_Lang_Annotation_Annotation : Java.Lang.Annotation.Annotation;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(javax.lang.model.element.TypeElement[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element>(params Javax.Lang.Model.Element.TypeElement[] arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RoundEnvironment implementation
    public partial class RoundEnvironment : Javax.Annotation.Processing.IRoundEnvironment
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getRootElements()"/> 
        /// </summary>
        public Java.Util.Set RootElements
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getRootElements", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#errorRaised()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ErrorRaised()
        {
            return IExecuteWithSignature<bool>("errorRaised", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#processingOver()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ProcessingOver()
        {
            return IExecuteWithSignature<bool>("processingOver", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Class arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWith", "(Ljava/lang/Class;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Javax.Lang.Model.Element.TypeElement arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWith", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element, Arg0ExtendsJava_Lang_Annotation_Annotation>(Java.Util.Set<Java.Lang.Class> arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element where Arg0ExtendsJava_Lang_Annotation_Annotation : Java.Lang.Annotation.Annotation
        {
            return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(javax.lang.model.element.TypeElement[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element>(params Javax.Lang.Model.Element.TypeElement[] arg0) where ReturnExtendsJavax_Lang_Model_Element_Element : Javax.Lang.Model.Element.Element
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", "([Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;"); else return IExecuteWithSignature<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", "([Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}