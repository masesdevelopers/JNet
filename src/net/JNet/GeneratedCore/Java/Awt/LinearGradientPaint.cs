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

namespace Java.Awt
{
    #region LinearGradientPaint definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html"/>
    /// </summary>
    public partial class LinearGradientPaint : Java.Awt.MultipleGradientPaint
    {
        const string _bridgeClassName = "java.awt.LinearGradientPaint";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LinearGradientPaint() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LinearGradientPaint(params object[] args) : base(args) { }

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

    #region LinearGradientPaint
    public partial class LinearGradientPaint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#%3Cinit%3E(float,float,float,float,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg6"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public LinearGradientPaint(float arg0, float arg1, float arg2, float arg3, float[] arg4, Java.Awt.Color[] arg5, Java.Awt.MultipleGradientPaint.CycleMethod arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#%3Cinit%3E(float,float,float,float,float[],java.awt.Color[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        public LinearGradientPaint(float arg0, float arg1, float arg2, float arg3, float[] arg4, Java.Awt.Color[] arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,java.awt.geom.Point2D,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod,java.awt.MultipleGradientPaint.ColorSpaceType,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        /// <param name="arg5"><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public LinearGradientPaint(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, float[] arg2, Java.Awt.Color[] arg3, Java.Awt.MultipleGradientPaint.CycleMethod arg4, Java.Awt.MultipleGradientPaint.ColorSpaceType arg5, Java.Awt.Geom.AffineTransform arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,java.awt.geom.Point2D,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public LinearGradientPaint(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, float[] arg2, Java.Awt.Color[] arg3, Java.Awt.MultipleGradientPaint.CycleMethod arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,java.awt.geom.Point2D,float[],java.awt.Color[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        public LinearGradientPaint(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, float[] arg2, Java.Awt.Color[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#getEndPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D EndPoint
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getEndPoint", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/LinearGradientPaint.html#getStartPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D StartPoint
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getStartPoint", "()Ljava/awt/geom/Point2D;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}