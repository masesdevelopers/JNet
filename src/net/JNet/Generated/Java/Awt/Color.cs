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
    #region Color declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html"/>
    /// </summary>
    public partial class Color : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Color>
    {
        const string _bridgeClassName = "java.awt.Color";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Color() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Color(params object[] args) : base(args) { }

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

    #region Color implementation
    public partial class Color
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public Color(float arg0, float arg1, float arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public Color(float arg0, float arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Color(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Color(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Color(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Color(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(java.awt.color.ColorSpace,float[],float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public Color(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Color"/> to <see cref="Java.Awt.Paint"/>
        /// </summary>
        public static implicit operator Java.Awt.Paint(Java.Awt.Color t) => t.Cast<Java.Awt.Paint>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Color"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.Color t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#black"/>
        /// </summary>
        public static Java.Awt.Color black { get { if (!_blackReady) { _blackContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "black"); _blackReady = true; } return _blackContent; } }
        private static Java.Awt.Color _blackContent = default;
        private static bool _blackReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#BLACK"/>
        /// </summary>
        public static Java.Awt.Color BLACK { get { if (!_BLACKReady) { _BLACKContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "BLACK"); _BLACKReady = true; } return _BLACKContent; } }
        private static Java.Awt.Color _BLACKContent = default;
        private static bool _BLACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#blue"/>
        /// </summary>
        public static Java.Awt.Color blue { get { if (!_blueReady) { _blueContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "blue"); _blueReady = true; } return _blueContent; } }
        private static Java.Awt.Color _blueContent = default;
        private static bool _blueReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#BLUE"/>
        /// </summary>
        public static Java.Awt.Color BLUE { get { if (!_BLUEReady) { _BLUEContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "BLUE"); _BLUEReady = true; } return _BLUEContent; } }
        private static Java.Awt.Color _BLUEContent = default;
        private static bool _BLUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#cyan"/>
        /// </summary>
        public static Java.Awt.Color cyan { get { if (!_cyanReady) { _cyanContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "cyan"); _cyanReady = true; } return _cyanContent; } }
        private static Java.Awt.Color _cyanContent = default;
        private static bool _cyanReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#CYAN"/>
        /// </summary>
        public static Java.Awt.Color CYAN { get { if (!_CYANReady) { _CYANContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "CYAN"); _CYANReady = true; } return _CYANContent; } }
        private static Java.Awt.Color _CYANContent = default;
        private static bool _CYANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#DARK_GRAY"/>
        /// </summary>
        public static Java.Awt.Color DARK_GRAY { get { if (!_DARK_GRAYReady) { _DARK_GRAYContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "DARK_GRAY"); _DARK_GRAYReady = true; } return _DARK_GRAYContent; } }
        private static Java.Awt.Color _DARK_GRAYContent = default;
        private static bool _DARK_GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#darkGray"/>
        /// </summary>
        public static Java.Awt.Color darkGray { get { if (!_darkGrayReady) { _darkGrayContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "darkGray"); _darkGrayReady = true; } return _darkGrayContent; } }
        private static Java.Awt.Color _darkGrayContent = default;
        private static bool _darkGrayReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#gray"/>
        /// </summary>
        public static Java.Awt.Color gray { get { if (!_grayReady) { _grayContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "gray"); _grayReady = true; } return _grayContent; } }
        private static Java.Awt.Color _grayContent = default;
        private static bool _grayReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#GRAY"/>
        /// </summary>
        public static Java.Awt.Color GRAY { get { if (!_GRAYReady) { _GRAYContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "GRAY"); _GRAYReady = true; } return _GRAYContent; } }
        private static Java.Awt.Color _GRAYContent = default;
        private static bool _GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#green"/>
        /// </summary>
        public static Java.Awt.Color green { get { if (!_greenReady) { _greenContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "green"); _greenReady = true; } return _greenContent; } }
        private static Java.Awt.Color _greenContent = default;
        private static bool _greenReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#GREEN"/>
        /// </summary>
        public static Java.Awt.Color GREEN { get { if (!_GREENReady) { _GREENContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "GREEN"); _GREENReady = true; } return _GREENContent; } }
        private static Java.Awt.Color _GREENContent = default;
        private static bool _GREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#LIGHT_GRAY"/>
        /// </summary>
        public static Java.Awt.Color LIGHT_GRAY { get { if (!_LIGHT_GRAYReady) { _LIGHT_GRAYContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "LIGHT_GRAY"); _LIGHT_GRAYReady = true; } return _LIGHT_GRAYContent; } }
        private static Java.Awt.Color _LIGHT_GRAYContent = default;
        private static bool _LIGHT_GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#lightGray"/>
        /// </summary>
        public static Java.Awt.Color lightGray { get { if (!_lightGrayReady) { _lightGrayContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "lightGray"); _lightGrayReady = true; } return _lightGrayContent; } }
        private static Java.Awt.Color _lightGrayContent = default;
        private static bool _lightGrayReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#magenta"/>
        /// </summary>
        public static Java.Awt.Color magenta { get { if (!_magentaReady) { _magentaContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "magenta"); _magentaReady = true; } return _magentaContent; } }
        private static Java.Awt.Color _magentaContent = default;
        private static bool _magentaReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#MAGENTA"/>
        /// </summary>
        public static Java.Awt.Color MAGENTA { get { if (!_MAGENTAReady) { _MAGENTAContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "MAGENTA"); _MAGENTAReady = true; } return _MAGENTAContent; } }
        private static Java.Awt.Color _MAGENTAContent = default;
        private static bool _MAGENTAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#orange"/>
        /// </summary>
        public static Java.Awt.Color orange { get { if (!_orangeReady) { _orangeContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "orange"); _orangeReady = true; } return _orangeContent; } }
        private static Java.Awt.Color _orangeContent = default;
        private static bool _orangeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#ORANGE"/>
        /// </summary>
        public static Java.Awt.Color ORANGE { get { if (!_ORANGEReady) { _ORANGEContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "ORANGE"); _ORANGEReady = true; } return _ORANGEContent; } }
        private static Java.Awt.Color _ORANGEContent = default;
        private static bool _ORANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#pink"/>
        /// </summary>
        public static Java.Awt.Color pink { get { if (!_pinkReady) { _pinkContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "pink"); _pinkReady = true; } return _pinkContent; } }
        private static Java.Awt.Color _pinkContent = default;
        private static bool _pinkReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#PINK"/>
        /// </summary>
        public static Java.Awt.Color PINK { get { if (!_PINKReady) { _PINKContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "PINK"); _PINKReady = true; } return _PINKContent; } }
        private static Java.Awt.Color _PINKContent = default;
        private static bool _PINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#red"/>
        /// </summary>
        public static Java.Awt.Color red { get { if (!_redReady) { _redContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "red"); _redReady = true; } return _redContent; } }
        private static Java.Awt.Color _redContent = default;
        private static bool _redReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#RED"/>
        /// </summary>
        public static Java.Awt.Color RED { get { if (!_REDReady) { _REDContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "RED"); _REDReady = true; } return _REDContent; } }
        private static Java.Awt.Color _REDContent = default;
        private static bool _REDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#white"/>
        /// </summary>
        public static Java.Awt.Color white { get { if (!_whiteReady) { _whiteContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "white"); _whiteReady = true; } return _whiteContent; } }
        private static Java.Awt.Color _whiteContent = default;
        private static bool _whiteReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#WHITE"/>
        /// </summary>
        public static Java.Awt.Color WHITE { get { if (!_WHITEReady) { _WHITEContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "WHITE"); _WHITEReady = true; } return _WHITEContent; } }
        private static Java.Awt.Color _WHITEContent = default;
        private static bool _WHITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#yellow"/>
        /// </summary>
        public static Java.Awt.Color yellow { get { if (!_yellowReady) { _yellowContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "yellow"); _yellowReady = true; } return _yellowContent; } }
        private static Java.Awt.Color _yellowContent = default;
        private static bool _yellowReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#YELLOW"/>
        /// </summary>
        public static Java.Awt.Color YELLOW { get { if (!_YELLOWReady) { _YELLOWContent = SGetField<Java.Awt.Color>(LocalBridgeClazz, "YELLOW"); _YELLOWReady = true; } return _YELLOWContent; } }
        private static Java.Awt.Color _YELLOWContent = default;
        private static bool _YELLOWReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#RGBtoHSB(int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float[] RGBtoHSB(int arg0, int arg1, int arg2, float[] arg3)
        {
            return SExecuteArray<float>(LocalBridgeClazz, "RGBtoHSB", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#HSBtoRGB(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HSBtoRGB(float arg0, float arg1, float arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "HSBtoRGB", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Awt.Color Decode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Awt.Color>(LocalBridgeClazz, "decode", "(Ljava/lang/String;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Awt.Color>(LocalBridgeClazz, "getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(Java.Lang.String arg0, Java.Awt.Color arg1)
        {
            return SExecute<Java.Awt.Color>(LocalBridgeClazz, "getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Awt.Color>(LocalBridgeClazz, "getColor", "(Ljava/lang/String;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getHSBColor(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetHSBColor(float arg0, float arg1, float arg2)
        {
            return SExecute<Java.Awt.Color>(LocalBridgeClazz, "getHSBColor", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getAlpha()"/> 
        /// </summary>
        public int Alpha
        {
            get { return IExecuteWithSignature<int>("getAlpha", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getBlue()"/> 
        /// </summary>
        public int Blue
        {
            get { return IExecuteWithSignature<int>("getBlue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorSpace()"/> 
        /// </summary>
        public Java.Awt.ColorNs.ColorSpace ColorSpace
        {
            get { return IExecuteWithSignature<Java.Awt.ColorNs.ColorSpace>("getColorSpace", "()Ljava/awt/color/ColorSpace;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getGreen()"/> 
        /// </summary>
        public int Green
        {
            get { return IExecuteWithSignature<int>("getGreen", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRed()"/> 
        /// </summary>
        public int Red
        {
            get { return IExecuteWithSignature<int>("getRed", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGB()"/> 
        /// </summary>
        public int RGB
        {
            get { return IExecuteWithSignature<int>("getRGB", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetColorComponents(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("getColorComponents", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorComponents(java.awt.color.ColorSpace,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetColorComponents(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1)
        {
            return IExecuteArray<float>("getColorComponents", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("getComponents", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getComponents(java.awt.color.ColorSpace,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1)
        {
            return IExecuteArray<float>("getComponents", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGBColorComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetRGBColorComponents(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("getRGBColorComponents", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGBComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetRGBComponents(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("getRGBComponents", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#brighter()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color Brighter()
        {
            return IExecuteWithSignature<Java.Awt.Color>("brighter", "()Ljava/awt/Color;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#darker()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color Darker()
        {
            return IExecuteWithSignature<Java.Awt.Color>("darker", "()Ljava/awt/Color;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#createContext(java.awt.image.ColorModel,java.awt.Rectangle,java.awt.geom.Rectangle2D,java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg4"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.PaintContext"/></returns>
        public Java.Awt.PaintContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.Rectangle arg1, Java.Awt.Geom.Rectangle2D arg2, Java.Awt.Geom.AffineTransform arg3, Java.Awt.RenderingHints arg4)
        {
            return IExecute<Java.Awt.PaintContext>("createContext", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}