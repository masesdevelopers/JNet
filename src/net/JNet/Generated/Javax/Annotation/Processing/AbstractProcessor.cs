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

namespace Javax.Annotation.Processing
{
    #region AbstractProcessor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html"/>
    /// </summary>
    public partial class AbstractProcessor : Javax.Annotation.Processing.Processor
    {
        const string _bridgeClassName = "javax.annotation.processing.AbstractProcessor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractProcessor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractProcessor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractProcessor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractProcessor(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region AbstractProcessor implementation
    public partial class AbstractProcessor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#getSupportedAnnotationTypes()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SupportedAnnotationTypes
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSupportedAnnotationTypes", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#getSupportedOptions()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SupportedOptions
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSupportedOptions", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#getSupportedSourceVersion()"/> 
        /// </summary>
        public Javax.Lang.Model.SourceVersion SupportedSourceVersion
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.SourceVersion>("getSupportedSourceVersion", "()Ljavax/lang/model/SourceVersion;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#process(java.util.Set,javax.annotation.processing.RoundEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Javax.Annotation.Processing.RoundEnvironment"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Lang_Model_Element_TypeElement"><see cref="Javax.Lang.Model.Element.TypeElement"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool Process<Arg0ExtendsJavax_Lang_Model_Element_TypeElement>(Java.Util.Set<Arg0ExtendsJavax_Lang_Model_Element_TypeElement> arg0, Javax.Annotation.Processing.RoundEnvironment arg1) where Arg0ExtendsJavax_Lang_Model_Element_TypeElement : Javax.Lang.Model.Element.TypeElement
        {
            return IExecute<bool>("process", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#getCompletions(javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.ExecutableElement,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Annotation_Processing_Completion"><see cref="Javax.Annotation.Processing.Completion"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Annotation_Processing_Completion> GetCompletions<ReturnExtendsJavax_Annotation_Processing_Completion>(Javax.Lang.Model.Element.Element arg0, Javax.Lang.Model.Element.AnnotationMirror arg1, Javax.Lang.Model.Element.ExecutableElement arg2, Java.Lang.String arg3) where ReturnExtendsJavax_Annotation_Processing_Completion : Javax.Annotation.Processing.Completion
        {
            return IExecute<Java.Lang.Iterable<ReturnExtendsJavax_Annotation_Processing_Completion>>("getCompletions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/AbstractProcessor.html#init(javax.annotation.processing.ProcessingEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Annotation.Processing.ProcessingEnvironment"/></param>
        public void Init(Javax.Annotation.Processing.ProcessingEnvironment arg0)
        {
            IExecuteWithSignature("init", "(Ljavax/annotation/processing/ProcessingEnvironment;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}