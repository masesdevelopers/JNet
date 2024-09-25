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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region CubicCurve2D declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html"/>
    /// </summary>
    public partial class CubicCurve2D : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CubicCurve2D>
    {
        const string _bridgeClassName = "java.awt.geom.CubicCurve2D";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CubicCurve2D class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CubicCurve2D() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CubicCurve2D class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CubicCurve2D(params object[] args) : base(args) { }

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
        #region Double declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html"/>
        /// </summary>
        public partial class Double : Java.Awt.Geom.CubicCurve2D
        {
            const string _bridgeClassName = "java.awt.geom.CubicCurve2D$Double";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Double() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Double(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Float declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html"/>
        /// </summary>
        public partial class Float : Java.Awt.Geom.CubicCurve2D
        {
            const string _bridgeClassName = "java.awt.geom.CubicCurve2D$Float";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Float() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Float(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region CubicCurve2D implementation
    public partial class CubicCurve2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.CubicCurve2D"/> to <see cref="Java.Awt.Shape"/>
        /// </summary>
        public static implicit operator Java.Awt.Shape(Java.Awt.Geom.CubicCurve2D t) => t.Cast<Java.Awt.Shape>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.CubicCurve2D"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.CubicCurve2D t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatness(double,double,double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="double"/></param>
        /// <param name="arg7"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatness(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatness", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatness(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatness(double[] arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatness", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatnessSq(double,double,double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="double"/></param>
        /// <param name="arg7"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatnessSq(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatnessSq", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatnessSq(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatnessSq(double[] arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatnessSq", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#solveCubic(double[],double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SolveCubic(double[] arg0, double[] arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "solveCubic", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#solveCubic(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SolveCubic(double[] arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "solveCubic", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#subdivide(double[],int,double[],int,double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public static void Subdivide(double[] arg0, int arg1, double[] arg2, int arg3, double[] arg4, int arg5)
        {
            SExecute(LocalBridgeClazz, "subdivide", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#subdivide(java.awt.geom.CubicCurve2D,java.awt.geom.CubicCurve2D,java.awt.geom.CubicCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        public static void Subdivide(Java.Awt.Geom.CubicCurve2D arg0, Java.Awt.Geom.CubicCurve2D arg1, Java.Awt.Geom.CubicCurve2D arg2)
        {
            SExecute(LocalBridgeClazz, "subdivide", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlP1()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D CtrlP1
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getCtrlP1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlP2()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D CtrlP2
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getCtrlP2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlX1()"/> 
        /// </summary>
        public double CtrlX1
        {
            get { return IExecute<double>("getCtrlX1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlX2()"/> 
        /// </summary>
        public double CtrlX2
        {
            get { return IExecute<double>("getCtrlX2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlY1()"/> 
        /// </summary>
        public double CtrlY1
        {
            get { return IExecute<double>("getCtrlY1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getCtrlY2()"/> 
        /// </summary>
        public double CtrlY2
        {
            get { return IExecute<double>("getCtrlY2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatness()"/> 
        /// </summary>
        public double Flatness
        {
            get { return IExecute<double>("getFlatness"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getFlatnessSq()"/> 
        /// </summary>
        public double FlatnessSq
        {
            get { return IExecute<double>("getFlatnessSq"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getP1()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D P1
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getP1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getP2()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D P2
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getP2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getX1()"/> 
        /// </summary>
        public double X1
        {
            get { return IExecute<double>("getX1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getX2()"/> 
        /// </summary>
        public double X2
        {
            get { return IExecute<double>("getX2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getY1()"/> 
        /// </summary>
        public double Y1
        {
            get { return IExecute<double>("getY1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getY2()"/> 
        /// </summary>
        public double Y2
        {
            get { return IExecute<double>("getY2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#setCurve(double,double,double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="double"/></param>
        /// <param name="arg7"><see cref="double"/></param>
        public void SetCurve(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
        {
            IExecute("setCurve", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#contains(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#contains(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#contains(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Point2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#contains(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#intersects(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#intersects(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("intersects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getPathIterator(java.awt.geom.AffineTransform,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0, double arg1)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#getPathIterator(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#setCurve(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetCurve(double[] arg0, int arg1)
        {
            IExecute("setCurve", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#setCurve(java.awt.geom.CubicCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        public void SetCurve(Java.Awt.Geom.CubicCurve2D arg0)
        {
            IExecute("setCurve", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#setCurve(java.awt.geom.Point2D,java.awt.geom.Point2D,java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetCurve(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, Java.Awt.Geom.Point2D arg2, Java.Awt.Geom.Point2D arg3)
        {
            IExecute("setCurve", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#setCurve(java.awt.geom.Point2D[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetCurve(Java.Awt.Geom.Point2D[] arg0, int arg1)
        {
            IExecute("setCurve", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.html#subdivide(java.awt.geom.CubicCurve2D,java.awt.geom.CubicCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.CubicCurve2D"/></param>
        public void Subdivide(Java.Awt.Geom.CubicCurve2D arg0, Java.Awt.Geom.CubicCurve2D arg1)
        {
            IExecute("subdivide", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Double implementation
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#%3Cinit%3E(double,double,double,double,double,double,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            /// <param name="arg4"><see cref="double"/></param>
            /// <param name="arg5"><see cref="double"/></param>
            /// <param name="arg6"><see cref="double"/></param>
            /// <param name="arg7"><see cref="double"/></param>
            public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.CubicCurve2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.CubicCurve2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#ctrlx1"/>
            /// </summary>
            public double ctrlx1 { get { return IGetField<double>("ctrlx1"); } set { ISetField("ctrlx1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#ctrlx2"/>
            /// </summary>
            public double ctrlx2 { get { return IGetField<double>("ctrlx2"); } set { ISetField("ctrlx2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#ctrly1"/>
            /// </summary>
            public double ctrly1 { get { return IGetField<double>("ctrly1"); } set { ISetField("ctrly1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#ctrly2"/>
            /// </summary>
            public double ctrly2 { get { return IGetField<double>("ctrly2"); } set { ISetField("ctrly2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#x1"/>
            /// </summary>
            public double x1 { get { return IGetField<double>("x1"); } set { ISetField("x1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#x2"/>
            /// </summary>
            public double x2 { get { return IGetField<double>("x2"); } set { ISetField("x2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#y1"/>
            /// </summary>
            public double y1 { get { return IGetField<double>("y1"); } set { ISetField("y1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Double.html#y2"/>
            /// </summary>
            public double y2 { get { return IGetField<double>("y2"); } set { ISetField("y2", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Float implementation
        public partial class Float
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#%3Cinit%3E(float,float,float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            /// <param name="arg6"><see cref="float"/></param>
            /// <param name="arg7"><see cref="float"/></param>
            public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.CubicCurve2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.CubicCurve2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#ctrlx1"/>
            /// </summary>
            public float ctrlx1 { get { return IGetField<float>("ctrlx1"); } set { ISetField("ctrlx1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#ctrlx2"/>
            /// </summary>
            public float ctrlx2 { get { return IGetField<float>("ctrlx2"); } set { ISetField("ctrlx2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#ctrly1"/>
            /// </summary>
            public float ctrly1 { get { return IGetField<float>("ctrly1"); } set { ISetField("ctrly1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#ctrly2"/>
            /// </summary>
            public float ctrly2 { get { return IGetField<float>("ctrly2"); } set { ISetField("ctrly2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#x1"/>
            /// </summary>
            public float x1 { get { return IGetField<float>("x1"); } set { ISetField("x1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#x2"/>
            /// </summary>
            public float x2 { get { return IGetField<float>("x2"); } set { ISetField("x2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#y1"/>
            /// </summary>
            public float y1 { get { return IGetField<float>("y1"); } set { ISetField("y1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#y2"/>
            /// </summary>
            public float y2 { get { return IGetField<float>("y2"); } set { ISetField("y2", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/CubicCurve2D.Float.html#setCurve(float,float,float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            /// <param name="arg6"><see cref="float"/></param>
            /// <param name="arg7"><see cref="float"/></param>
            public void SetCurve(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
            {
                IExecute("setCurve", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}