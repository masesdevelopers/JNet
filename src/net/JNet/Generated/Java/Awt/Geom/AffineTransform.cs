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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region AffineTransform
    public partial class AffineTransform
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#%3Cinit%3E(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public AffineTransform(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#%3Cinit%3E(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public AffineTransform(double[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#%3Cinit%3E(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public AffineTransform(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#%3Cinit%3E(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public AffineTransform(float[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#%3Cinit%3E(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public AffineTransform(Java.Awt.Geom.AffineTransform arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.AffineTransform"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.AffineTransform t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.AffineTransform"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.Geom.AffineTransform t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_FLIP"/>
        /// </summary>
        public static int TYPE_FLIP { get { if (!_TYPE_FLIPReady) { _TYPE_FLIPContent = SGetField<int>(LocalBridgeClazz, "TYPE_FLIP"); _TYPE_FLIPReady = true; } return _TYPE_FLIPContent; } }
        private static int _TYPE_FLIPContent = default;
        private static bool _TYPE_FLIPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_GENERAL_ROTATION"/>
        /// </summary>
        public static int TYPE_GENERAL_ROTATION { get { if (!_TYPE_GENERAL_ROTATIONReady) { _TYPE_GENERAL_ROTATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERAL_ROTATION"); _TYPE_GENERAL_ROTATIONReady = true; } return _TYPE_GENERAL_ROTATIONContent; } }
        private static int _TYPE_GENERAL_ROTATIONContent = default;
        private static bool _TYPE_GENERAL_ROTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_GENERAL_SCALE"/>
        /// </summary>
        public static int TYPE_GENERAL_SCALE { get { if (!_TYPE_GENERAL_SCALEReady) { _TYPE_GENERAL_SCALEContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERAL_SCALE"); _TYPE_GENERAL_SCALEReady = true; } return _TYPE_GENERAL_SCALEContent; } }
        private static int _TYPE_GENERAL_SCALEContent = default;
        private static bool _TYPE_GENERAL_SCALEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_GENERAL_TRANSFORM"/>
        /// </summary>
        public static int TYPE_GENERAL_TRANSFORM { get { if (!_TYPE_GENERAL_TRANSFORMReady) { _TYPE_GENERAL_TRANSFORMContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERAL_TRANSFORM"); _TYPE_GENERAL_TRANSFORMReady = true; } return _TYPE_GENERAL_TRANSFORMContent; } }
        private static int _TYPE_GENERAL_TRANSFORMContent = default;
        private static bool _TYPE_GENERAL_TRANSFORMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_IDENTITY"/>
        /// </summary>
        public static int TYPE_IDENTITY { get { if (!_TYPE_IDENTITYReady) { _TYPE_IDENTITYContent = SGetField<int>(LocalBridgeClazz, "TYPE_IDENTITY"); _TYPE_IDENTITYReady = true; } return _TYPE_IDENTITYContent; } }
        private static int _TYPE_IDENTITYContent = default;
        private static bool _TYPE_IDENTITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_MASK_ROTATION"/>
        /// </summary>
        public static int TYPE_MASK_ROTATION { get { if (!_TYPE_MASK_ROTATIONReady) { _TYPE_MASK_ROTATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_MASK_ROTATION"); _TYPE_MASK_ROTATIONReady = true; } return _TYPE_MASK_ROTATIONContent; } }
        private static int _TYPE_MASK_ROTATIONContent = default;
        private static bool _TYPE_MASK_ROTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_MASK_SCALE"/>
        /// </summary>
        public static int TYPE_MASK_SCALE { get { if (!_TYPE_MASK_SCALEReady) { _TYPE_MASK_SCALEContent = SGetField<int>(LocalBridgeClazz, "TYPE_MASK_SCALE"); _TYPE_MASK_SCALEReady = true; } return _TYPE_MASK_SCALEContent; } }
        private static int _TYPE_MASK_SCALEContent = default;
        private static bool _TYPE_MASK_SCALEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_QUADRANT_ROTATION"/>
        /// </summary>
        public static int TYPE_QUADRANT_ROTATION { get { if (!_TYPE_QUADRANT_ROTATIONReady) { _TYPE_QUADRANT_ROTATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_QUADRANT_ROTATION"); _TYPE_QUADRANT_ROTATIONReady = true; } return _TYPE_QUADRANT_ROTATIONContent; } }
        private static int _TYPE_QUADRANT_ROTATIONContent = default;
        private static bool _TYPE_QUADRANT_ROTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_TRANSLATION"/>
        /// </summary>
        public static int TYPE_TRANSLATION { get { if (!_TYPE_TRANSLATIONReady) { _TYPE_TRANSLATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_TRANSLATION"); _TYPE_TRANSLATIONReady = true; } return _TYPE_TRANSLATIONContent; } }
        private static int _TYPE_TRANSLATIONContent = default;
        private static bool _TYPE_TRANSLATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#TYPE_UNIFORM_SCALE"/>
        /// </summary>
        public static int TYPE_UNIFORM_SCALE { get { if (!_TYPE_UNIFORM_SCALEReady) { _TYPE_UNIFORM_SCALEContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNIFORM_SCALE"); _TYPE_UNIFORM_SCALEReady = true; } return _TYPE_UNIFORM_SCALEContent; } }
        private static int _TYPE_UNIFORM_SCALEContent = default;
        private static bool _TYPE_UNIFORM_SCALEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getQuadrantRotateInstance(int,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetQuadrantRotateInstance(int arg0, double arg1, double arg2)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getQuadrantRotateInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getQuadrantRotateInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetQuadrantRotateInstance(int arg0)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getQuadrantRotateInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getRotateInstance(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetRotateInstance(double arg0, double arg1, double arg2, double arg3)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getRotateInstance", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getRotateInstance(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetRotateInstance(double arg0, double arg1, double arg2)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getRotateInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getRotateInstance(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetRotateInstance(double arg0, double arg1)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getRotateInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getRotateInstance(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetRotateInstance(double arg0)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getRotateInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getScaleInstance(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetScaleInstance(double arg0, double arg1)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getScaleInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getShearInstance(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetShearInstance(double arg0, double arg1)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getShearInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getTranslateInstance(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public static Java.Awt.Geom.AffineTransform GetTranslateInstance(double arg0, double arg1)
        {
            return SExecute<Java.Awt.Geom.AffineTransform>(LocalBridgeClazz, "getTranslateInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getDeterminant()"/> 
        /// </summary>
        public double Determinant
        {
            get { return IExecute<double>("getDeterminant"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getScaleX()"/> 
        /// </summary>
        public double ScaleX
        {
            get { return IExecute<double>("getScaleX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getScaleY()"/> 
        /// </summary>
        public double ScaleY
        {
            get { return IExecute<double>("getScaleY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getShearX()"/> 
        /// </summary>
        public double ShearX
        {
            get { return IExecute<double>("getShearX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getShearY()"/> 
        /// </summary>
        public double ShearY
        {
            get { return IExecute<double>("getShearY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getTranslateX()"/> 
        /// </summary>
        public double TranslateX
        {
            get { return IExecute<double>("getTranslateX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getTranslateY()"/> 
        /// </summary>
        public double TranslateY
        {
            get { return IExecute<double>("getTranslateY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#isIdentity()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIdentity()
        {
            return IExecute<bool>("isIdentity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#createInverse()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        /// <exception cref="Java.Awt.Geom.NoninvertibleTransformException"/>
        public Java.Awt.Geom.AffineTransform CreateInverse()
        {
            return IExecute<Java.Awt.Geom.AffineTransform>("createInverse");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#deltaTransform(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D DeltaTransform(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("deltaTransform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#inverseTransform(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        /// <exception cref="Java.Awt.Geom.NoninvertibleTransformException"/>
        public Java.Awt.Geom.Point2D InverseTransform(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("inverseTransform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D Transform(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("transform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#createTransformedShape(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape CreateTransformedShape(Java.Awt.Shape arg0)
        {
            return IExecute<Java.Awt.Shape>("createTransformedShape", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#concatenate(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void Concatenate(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecute("concatenate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#deltaTransform(double[],int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void DeltaTransform(double[] arg0, int arg1, double[] arg2, int arg3, int arg4)
        {
            IExecute("deltaTransform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#getMatrix(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void GetMatrix(double[] arg0)
        {
            IExecute("getMatrix", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#inverseTransform(double[],int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <exception cref="Java.Awt.Geom.NoninvertibleTransformException"/>
        public void InverseTransform(double[] arg0, int arg1, double[] arg2, int arg3, int arg4)
        {
            IExecute("inverseTransform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#invert()"/>
        /// </summary>

        /// <exception cref="Java.Awt.Geom.NoninvertibleTransformException"/>
        public void Invert()
        {
            IExecute("invert");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#preConcatenate(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void PreConcatenate(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecute("preConcatenate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#quadrantRotate(int,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void QuadrantRotate(int arg0, double arg1, double arg2)
        {
            IExecute("quadrantRotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#quadrantRotate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void QuadrantRotate(int arg0)
        {
            IExecute("quadrantRotate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#rotate(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void Rotate(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("rotate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#rotate(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void Rotate(double arg0, double arg1, double arg2)
        {
            IExecute("rotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#rotate(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Rotate(double arg0, double arg1)
        {
            IExecute("rotate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#rotate(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Rotate(double arg0)
        {
            IExecute("rotate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#scale(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Scale(double arg0, double arg1)
        {
            IExecute("scale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToIdentity()"/>
        /// </summary>
        public void SetToIdentity()
        {
            IExecute("setToIdentity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToQuadrantRotation(int,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void SetToQuadrantRotation(int arg0, double arg1, double arg2)
        {
            IExecute("setToQuadrantRotation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToQuadrantRotation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetToQuadrantRotation(int arg0)
        {
            IExecute("setToQuadrantRotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToRotation(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetToRotation(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setToRotation", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToRotation(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void SetToRotation(double arg0, double arg1, double arg2)
        {
            IExecute("setToRotation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToRotation(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void SetToRotation(double arg0, double arg1)
        {
            IExecute("setToRotation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToRotation(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetToRotation(double arg0)
        {
            IExecute("setToRotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToScale(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void SetToScale(double arg0, double arg1)
        {
            IExecute("setToScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToShear(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void SetToShear(double arg0, double arg1)
        {
            IExecute("setToShear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setToTranslation(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void SetToTranslation(double arg0, double arg1)
        {
            IExecute("setToTranslation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setTransform(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public void SetTransform(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            IExecute("setTransform", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#setTransform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void SetTransform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecute("setTransform", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#shear(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Shear(double arg0, double arg1)
        {
            IExecute("shear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(double[],int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void Transform(double[] arg0, int arg1, double[] arg2, int arg3, int arg4)
        {
            IExecute("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(double[],int,float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void Transform(double[] arg0, int arg1, float[] arg2, int arg3, int arg4)
        {
            IExecute("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(float[],int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void Transform(float[] arg0, int arg1, double[] arg2, int arg3, int arg4)
        {
            IExecute("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(float[],int,float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void Transform(float[] arg0, int arg1, float[] arg2, int arg3, int arg4)
        {
            IExecute("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#transform(java.awt.geom.Point2D[],int,java.awt.geom.Point2D[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void Transform(Java.Awt.Geom.Point2D[] arg0, int arg1, Java.Awt.Geom.Point2D[] arg2, int arg3, int arg4)
        {
            IExecute("transform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/AffineTransform.html#translate(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Translate(double arg0, double arg1)
        {
            IExecute("translate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}