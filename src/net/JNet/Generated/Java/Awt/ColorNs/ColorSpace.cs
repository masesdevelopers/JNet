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

namespace Java.Awt.ColorNs
{
    #region ColorSpace declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html"/>
    /// </summary>
    public partial class ColorSpace : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.awt.color.ColorSpace";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ColorSpace class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ColorSpace() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ColorSpace class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ColorSpace(params object[] args) : base(args) { }

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

    #region ColorSpace implementation
    public partial class ColorSpace
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#CS_CIEXYZ"/>
        /// </summary>
        public static int CS_CIEXYZ { get { if (!_CS_CIEXYZReady) { _CS_CIEXYZContent = SGetField<int>(LocalBridgeClazz, "CS_CIEXYZ"); _CS_CIEXYZReady = true; } return _CS_CIEXYZContent; } }
        private static int _CS_CIEXYZContent = default;
        private static bool _CS_CIEXYZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#CS_GRAY"/>
        /// </summary>
        public static int CS_GRAY { get { if (!_CS_GRAYReady) { _CS_GRAYContent = SGetField<int>(LocalBridgeClazz, "CS_GRAY"); _CS_GRAYReady = true; } return _CS_GRAYContent; } }
        private static int _CS_GRAYContent = default;
        private static bool _CS_GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#CS_LINEAR_RGB"/>
        /// </summary>
        public static int CS_LINEAR_RGB { get { if (!_CS_LINEAR_RGBReady) { _CS_LINEAR_RGBContent = SGetField<int>(LocalBridgeClazz, "CS_LINEAR_RGB"); _CS_LINEAR_RGBReady = true; } return _CS_LINEAR_RGBContent; } }
        private static int _CS_LINEAR_RGBContent = default;
        private static bool _CS_LINEAR_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#CS_PYCC"/>
        /// </summary>
        public static int CS_PYCC { get { if (!_CS_PYCCReady) { _CS_PYCCContent = SGetField<int>(LocalBridgeClazz, "CS_PYCC"); _CS_PYCCReady = true; } return _CS_PYCCContent; } }
        private static int _CS_PYCCContent = default;
        private static bool _CS_PYCCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#CS_sRGB"/>
        /// </summary>
        public static int CS_sRGB { get { if (!_CS_sRGBReady) { _CS_sRGBContent = SGetField<int>(LocalBridgeClazz, "CS_sRGB"); _CS_sRGBReady = true; } return _CS_sRGBContent; } }
        private static int _CS_sRGBContent = default;
        private static bool _CS_sRGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_2CLR"/>
        /// </summary>
        public static int TYPE_2CLR { get { if (!_TYPE_2CLRReady) { _TYPE_2CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_2CLR"); _TYPE_2CLRReady = true; } return _TYPE_2CLRContent; } }
        private static int _TYPE_2CLRContent = default;
        private static bool _TYPE_2CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_3CLR"/>
        /// </summary>
        public static int TYPE_3CLR { get { if (!_TYPE_3CLRReady) { _TYPE_3CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_3CLR"); _TYPE_3CLRReady = true; } return _TYPE_3CLRContent; } }
        private static int _TYPE_3CLRContent = default;
        private static bool _TYPE_3CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_4CLR"/>
        /// </summary>
        public static int TYPE_4CLR { get { if (!_TYPE_4CLRReady) { _TYPE_4CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_4CLR"); _TYPE_4CLRReady = true; } return _TYPE_4CLRContent; } }
        private static int _TYPE_4CLRContent = default;
        private static bool _TYPE_4CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_5CLR"/>
        /// </summary>
        public static int TYPE_5CLR { get { if (!_TYPE_5CLRReady) { _TYPE_5CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_5CLR"); _TYPE_5CLRReady = true; } return _TYPE_5CLRContent; } }
        private static int _TYPE_5CLRContent = default;
        private static bool _TYPE_5CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_6CLR"/>
        /// </summary>
        public static int TYPE_6CLR { get { if (!_TYPE_6CLRReady) { _TYPE_6CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_6CLR"); _TYPE_6CLRReady = true; } return _TYPE_6CLRContent; } }
        private static int _TYPE_6CLRContent = default;
        private static bool _TYPE_6CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_7CLR"/>
        /// </summary>
        public static int TYPE_7CLR { get { if (!_TYPE_7CLRReady) { _TYPE_7CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_7CLR"); _TYPE_7CLRReady = true; } return _TYPE_7CLRContent; } }
        private static int _TYPE_7CLRContent = default;
        private static bool _TYPE_7CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_8CLR"/>
        /// </summary>
        public static int TYPE_8CLR { get { if (!_TYPE_8CLRReady) { _TYPE_8CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_8CLR"); _TYPE_8CLRReady = true; } return _TYPE_8CLRContent; } }
        private static int _TYPE_8CLRContent = default;
        private static bool _TYPE_8CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_9CLR"/>
        /// </summary>
        public static int TYPE_9CLR { get { if (!_TYPE_9CLRReady) { _TYPE_9CLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_9CLR"); _TYPE_9CLRReady = true; } return _TYPE_9CLRContent; } }
        private static int _TYPE_9CLRContent = default;
        private static bool _TYPE_9CLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_ACLR"/>
        /// </summary>
        public static int TYPE_ACLR { get { if (!_TYPE_ACLRReady) { _TYPE_ACLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_ACLR"); _TYPE_ACLRReady = true; } return _TYPE_ACLRContent; } }
        private static int _TYPE_ACLRContent = default;
        private static bool _TYPE_ACLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_BCLR"/>
        /// </summary>
        public static int TYPE_BCLR { get { if (!_TYPE_BCLRReady) { _TYPE_BCLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_BCLR"); _TYPE_BCLRReady = true; } return _TYPE_BCLRContent; } }
        private static int _TYPE_BCLRContent = default;
        private static bool _TYPE_BCLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_CCLR"/>
        /// </summary>
        public static int TYPE_CCLR { get { if (!_TYPE_CCLRReady) { _TYPE_CCLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_CCLR"); _TYPE_CCLRReady = true; } return _TYPE_CCLRContent; } }
        private static int _TYPE_CCLRContent = default;
        private static bool _TYPE_CCLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_CMY"/>
        /// </summary>
        public static int TYPE_CMY { get { if (!_TYPE_CMYReady) { _TYPE_CMYContent = SGetField<int>(LocalBridgeClazz, "TYPE_CMY"); _TYPE_CMYReady = true; } return _TYPE_CMYContent; } }
        private static int _TYPE_CMYContent = default;
        private static bool _TYPE_CMYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_CMYK"/>
        /// </summary>
        public static int TYPE_CMYK { get { if (!_TYPE_CMYKReady) { _TYPE_CMYKContent = SGetField<int>(LocalBridgeClazz, "TYPE_CMYK"); _TYPE_CMYKReady = true; } return _TYPE_CMYKContent; } }
        private static int _TYPE_CMYKContent = default;
        private static bool _TYPE_CMYKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_DCLR"/>
        /// </summary>
        public static int TYPE_DCLR { get { if (!_TYPE_DCLRReady) { _TYPE_DCLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_DCLR"); _TYPE_DCLRReady = true; } return _TYPE_DCLRContent; } }
        private static int _TYPE_DCLRContent = default;
        private static bool _TYPE_DCLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_ECLR"/>
        /// </summary>
        public static int TYPE_ECLR { get { if (!_TYPE_ECLRReady) { _TYPE_ECLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_ECLR"); _TYPE_ECLRReady = true; } return _TYPE_ECLRContent; } }
        private static int _TYPE_ECLRContent = default;
        private static bool _TYPE_ECLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_FCLR"/>
        /// </summary>
        public static int TYPE_FCLR { get { if (!_TYPE_FCLRReady) { _TYPE_FCLRContent = SGetField<int>(LocalBridgeClazz, "TYPE_FCLR"); _TYPE_FCLRReady = true; } return _TYPE_FCLRContent; } }
        private static int _TYPE_FCLRContent = default;
        private static bool _TYPE_FCLRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_GRAY"/>
        /// </summary>
        public static int TYPE_GRAY { get { if (!_TYPE_GRAYReady) { _TYPE_GRAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_GRAY"); _TYPE_GRAYReady = true; } return _TYPE_GRAYContent; } }
        private static int _TYPE_GRAYContent = default;
        private static bool _TYPE_GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_HLS"/>
        /// </summary>
        public static int TYPE_HLS { get { if (!_TYPE_HLSReady) { _TYPE_HLSContent = SGetField<int>(LocalBridgeClazz, "TYPE_HLS"); _TYPE_HLSReady = true; } return _TYPE_HLSContent; } }
        private static int _TYPE_HLSContent = default;
        private static bool _TYPE_HLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_HSV"/>
        /// </summary>
        public static int TYPE_HSV { get { if (!_TYPE_HSVReady) { _TYPE_HSVContent = SGetField<int>(LocalBridgeClazz, "TYPE_HSV"); _TYPE_HSVReady = true; } return _TYPE_HSVContent; } }
        private static int _TYPE_HSVContent = default;
        private static bool _TYPE_HSVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_Lab"/>
        /// </summary>
        public static int TYPE_Lab { get { if (!_TYPE_LabReady) { _TYPE_LabContent = SGetField<int>(LocalBridgeClazz, "TYPE_Lab"); _TYPE_LabReady = true; } return _TYPE_LabContent; } }
        private static int _TYPE_LabContent = default;
        private static bool _TYPE_LabReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_Luv"/>
        /// </summary>
        public static int TYPE_Luv { get { if (!_TYPE_LuvReady) { _TYPE_LuvContent = SGetField<int>(LocalBridgeClazz, "TYPE_Luv"); _TYPE_LuvReady = true; } return _TYPE_LuvContent; } }
        private static int _TYPE_LuvContent = default;
        private static bool _TYPE_LuvReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_RGB"/>
        /// </summary>
        public static int TYPE_RGB { get { if (!_TYPE_RGBReady) { _TYPE_RGBContent = SGetField<int>(LocalBridgeClazz, "TYPE_RGB"); _TYPE_RGBReady = true; } return _TYPE_RGBContent; } }
        private static int _TYPE_RGBContent = default;
        private static bool _TYPE_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_XYZ"/>
        /// </summary>
        public static int TYPE_XYZ { get { if (!_TYPE_XYZReady) { _TYPE_XYZContent = SGetField<int>(LocalBridgeClazz, "TYPE_XYZ"); _TYPE_XYZReady = true; } return _TYPE_XYZContent; } }
        private static int _TYPE_XYZContent = default;
        private static bool _TYPE_XYZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_YCbCr"/>
        /// </summary>
        public static int TYPE_YCbCr { get { if (!_TYPE_YCbCrReady) { _TYPE_YCbCrContent = SGetField<int>(LocalBridgeClazz, "TYPE_YCbCr"); _TYPE_YCbCrReady = true; } return _TYPE_YCbCrContent; } }
        private static int _TYPE_YCbCrContent = default;
        private static bool _TYPE_YCbCrReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#TYPE_Yxy"/>
        /// </summary>
        public static int TYPE_Yxy { get { if (!_TYPE_YxyReady) { _TYPE_YxyContent = SGetField<int>(LocalBridgeClazz, "TYPE_Yxy"); _TYPE_YxyReady = true; } return _TYPE_YxyContent; } }
        private static int _TYPE_YxyContent = default;
        private static bool _TYPE_YxyReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ColorNs.ColorSpace"/></returns>
        public static Java.Awt.ColorNs.ColorSpace GetInstance(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.ColorNs.ColorSpace>(LocalBridgeClazz, "getInstance", "(I)Ljava/awt/color/ColorSpace;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getNumComponents()"/> 
        /// </summary>
        public int NumComponents
        {
            get { return IExecuteWithSignature<int>("getNumComponents", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#fromCIEXYZ(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] FromCIEXYZ(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("fromCIEXYZ", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#fromRGB(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] FromRGB(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("fromRGB", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#toCIEXYZ(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] ToCIEXYZ(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("toCIEXYZ", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#toRGB(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] ToRGB(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("toRGB", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#isCS_sRGB()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCS_sRGB()
        {
            return IExecuteWithSignature<bool>("isCS_sRGB", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getMaxValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetMaxValue(int arg0)
        {
            return IExecuteWithSignature<float>("getMaxValue", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getMinValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetMinValue(int arg0)
        {
            return IExecuteWithSignature<float>("getMinValue", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ColorSpace.html#getName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}