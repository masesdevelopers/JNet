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

namespace Javax.Annotation.Processing
{
    #region IProcessingEnvironment
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProcessingEnvironment
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getElementUtils()"/> 
        /// </summary>
        Javax.Lang.Model.Util.Elements ElementUtils { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getFiler()"/> 
        /// </summary>
        Javax.Annotation.Processing.Filer Filer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getLocale()"/> 
        /// </summary>
        Java.Util.Locale Locale { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getMessager()"/> 
        /// </summary>
        Javax.Annotation.Processing.Messager Messager { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getOptions()"/> 
        /// </summary>
        Java.Util.Map<Java.Lang.String, Java.Lang.String> Options { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getSourceVersion()"/> 
        /// </summary>
        Javax.Lang.Model.SourceVersion SourceVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getTypeUtils()"/> 
        /// </summary>
        Javax.Lang.Model.Util.Types TypeUtils { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessingEnvironment
    public partial class ProcessingEnvironment : Javax.Annotation.Processing.IProcessingEnvironment
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getElementUtils()"/> 
        /// </summary>
        public Javax.Lang.Model.Util.Elements ElementUtils
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Util.Elements>("getElementUtils", "()Ljavax/lang/model/util/Elements;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getFiler()"/> 
        /// </summary>
        public Javax.Annotation.Processing.Filer Filer
        {
            get { return IExecuteWithSignature<Javax.Annotation.Processing.Filer>("getFiler", "()Ljavax/annotation/processing/Filer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getMessager()"/> 
        /// </summary>
        public Javax.Annotation.Processing.Messager Messager
        {
            get { return IExecuteWithSignature<Javax.Annotation.Processing.Messager>("getMessager", "()Ljavax/annotation/processing/Messager;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getOptions()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Options
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("getOptions", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getSourceVersion()"/> 
        /// </summary>
        public Javax.Lang.Model.SourceVersion SourceVersion
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.SourceVersion>("getSourceVersion", "()Ljavax/lang/model/SourceVersion;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/ProcessingEnvironment.html#getTypeUtils()"/> 
        /// </summary>
        public Javax.Lang.Model.Util.Types TypeUtils
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Util.Types>("getTypeUtils", "()Ljavax/lang/model/util/Types;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}