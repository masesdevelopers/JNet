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
    #region Generated declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html"/>
    /// </summary>
    public partial class Generated : Java.Lang.Annotation.Annotation
    {
        const string _bridgeClassName = "javax.annotation.processing.Generated";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Generated class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Generated() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Generated class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Generated(params object[] args) : base(args) { }

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

    #region IGenerated
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGenerated : Java.Lang.Annotation.IAnnotation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#comments()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String Comments();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#date()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String Date();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#value()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String[] Value();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Generated implementation
    public partial class Generated : Javax.Annotation.Processing.IGenerated
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#comments()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Comments()
        {
            return IExecuteWithSignature<Java.Lang.String>("comments", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#date()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Date()
        {
            return IExecuteWithSignature<Java.Lang.String>("date", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Generated.html#value()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] Value()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("value", "()[Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}