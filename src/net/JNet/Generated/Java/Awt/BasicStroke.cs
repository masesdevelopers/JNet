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

namespace Java.Awt
{
    #region BasicStroke declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html"/>
    /// </summary>
    public partial class BasicStroke : Java.Awt.Stroke
    {
        const string _bridgeClassName = "java.awt.BasicStroke";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicStroke() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicStroke(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region BasicStroke implementation
    public partial class BasicStroke
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int,float,float[],float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public BasicStroke(float arg0, int arg1, int arg2, float arg3, float[] arg4, float arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public BasicStroke(float arg0, int arg1, int arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BasicStroke(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public BasicStroke(float arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_BUTT"/>
        /// </summary>
        public static int CAP_BUTT { get { if (!_CAP_BUTTReady) { _CAP_BUTTContent = SGetField<int>(LocalBridgeClazz, "CAP_BUTT"); _CAP_BUTTReady = true; } return _CAP_BUTTContent; } }
        private static int _CAP_BUTTContent = default;
        private static bool _CAP_BUTTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_ROUND"/>
        /// </summary>
        public static int CAP_ROUND { get { if (!_CAP_ROUNDReady) { _CAP_ROUNDContent = SGetField<int>(LocalBridgeClazz, "CAP_ROUND"); _CAP_ROUNDReady = true; } return _CAP_ROUNDContent; } }
        private static int _CAP_ROUNDContent = default;
        private static bool _CAP_ROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_SQUARE"/>
        /// </summary>
        public static int CAP_SQUARE { get { if (!_CAP_SQUAREReady) { _CAP_SQUAREContent = SGetField<int>(LocalBridgeClazz, "CAP_SQUARE"); _CAP_SQUAREReady = true; } return _CAP_SQUAREContent; } }
        private static int _CAP_SQUAREContent = default;
        private static bool _CAP_SQUAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_BEVEL"/>
        /// </summary>
        public static int JOIN_BEVEL { get { if (!_JOIN_BEVELReady) { _JOIN_BEVELContent = SGetField<int>(LocalBridgeClazz, "JOIN_BEVEL"); _JOIN_BEVELReady = true; } return _JOIN_BEVELContent; } }
        private static int _JOIN_BEVELContent = default;
        private static bool _JOIN_BEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_MITER"/>
        /// </summary>
        public static int JOIN_MITER { get { if (!_JOIN_MITERReady) { _JOIN_MITERContent = SGetField<int>(LocalBridgeClazz, "JOIN_MITER"); _JOIN_MITERReady = true; } return _JOIN_MITERContent; } }
        private static int _JOIN_MITERContent = default;
        private static bool _JOIN_MITERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_ROUND"/>
        /// </summary>
        public static int JOIN_ROUND { get { if (!_JOIN_ROUNDReady) { _JOIN_ROUNDContent = SGetField<int>(LocalBridgeClazz, "JOIN_ROUND"); _JOIN_ROUNDReady = true; } return _JOIN_ROUNDContent; } }
        private static int _JOIN_ROUNDContent = default;
        private static bool _JOIN_ROUNDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getDashArray()"/> 
        /// </summary>
        public float[] DashArray
        {
            get { return IExecuteWithSignatureArray<float>("getDashArray", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getDashPhase()"/> 
        /// </summary>
        public float DashPhase
        {
            get { return IExecuteWithSignature<float>("getDashPhase", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getEndCap()"/> 
        /// </summary>
        public int EndCap
        {
            get { return IExecuteWithSignature<int>("getEndCap", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getLineJoin()"/> 
        /// </summary>
        public int LineJoin
        {
            get { return IExecuteWithSignature<int>("getLineJoin", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getLineWidth()"/> 
        /// </summary>
        public float LineWidth
        {
            get { return IExecuteWithSignature<float>("getLineWidth", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getMiterLimit()"/> 
        /// </summary>
        public float MiterLimit
        {
            get { return IExecuteWithSignature<float>("getMiterLimit", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#createStrokedShape(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape CreateStrokedShape(Java.Awt.Shape arg0)
        {
            return IExecuteWithSignature<Java.Awt.Shape>("createStrokedShape", "(Ljava/awt/Shape;)Ljava/awt/Shape;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}