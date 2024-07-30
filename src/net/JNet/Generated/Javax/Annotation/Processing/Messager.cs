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

namespace Javax.Annotation.Processing
{
    #region IMessager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMessager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg4"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2, Javax.Lang.Model.Element.AnnotationMirror arg3, Javax.Lang.Model.Element.AnnotationValue arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2, Javax.Lang.Model.Element.AnnotationMirror arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Messager
    public partial class Messager : Javax.Annotation.Processing.IMessager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.AnnotationValue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg4"><see cref="Javax.Lang.Model.Element.AnnotationValue"/></param>
        public void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2, Javax.Lang.Model.Element.AnnotationMirror arg3, Javax.Lang.Model.Element.AnnotationValue arg4)
        {
            IExecute("printMessage", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg3"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        public void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2, Javax.Lang.Model.Element.AnnotationMirror arg3)
        {
            IExecute("printMessage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence,javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.Element"/></param>
        public void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1, Javax.Lang.Model.Element.Element arg2)
        {
            IExecute("printMessage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Messager.html#printMessage(javax.tools.Diagnostic.Kind,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic.Kind"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        public void PrintMessage(Javax.Tools.Diagnostic.Kind arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("printMessage", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}