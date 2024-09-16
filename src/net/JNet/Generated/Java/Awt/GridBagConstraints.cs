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
    #region GridBagConstraints declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html"/>
    /// </summary>
    public partial class GridBagConstraints : MASES.JCOBridge.C2JBridge.JVMBridgeBase<GridBagConstraints>
    {
        const string _bridgeClassName = "java.awt.GridBagConstraints";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GridBagConstraints() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GridBagConstraints(params object[] args) : base(args) { }

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

    #region GridBagConstraints implementation
    public partial class GridBagConstraints
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#%3Cinit%3E(int,int,int,int,double,double,int,int,java.awt.Insets,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Insets"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public GridBagConstraints(int arg0, int arg1, int arg2, int arg3, double arg4, double arg5, int arg6, int arg7, Java.Awt.Insets arg8, int arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weightx"/>
        /// </summary>
        public double weightx { get { return IGetField<double>("weightx"); } set { ISetField("weightx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weighty"/>
        /// </summary>
        public double weighty { get { return IGetField<double>("weighty"); } set { ISetField("weighty", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#anchor"/>
        /// </summary>
        public int anchor { get { return IGetField<int>("anchor"); } set { ISetField("anchor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#fill"/>
        /// </summary>
        public int fill { get { return IGetField<int>("fill"); } set { ISetField("fill", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridheight"/>
        /// </summary>
        public int gridheight { get { return IGetField<int>("gridheight"); } set { ISetField("gridheight", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridwidth"/>
        /// </summary>
        public int gridwidth { get { return IGetField<int>("gridwidth"); } set { ISetField("gridwidth", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridx"/>
        /// </summary>
        public int gridx { get { return IGetField<int>("gridx"); } set { ISetField("gridx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridy"/>
        /// </summary>
        public int gridy { get { return IGetField<int>("gridy"); } set { ISetField("gridy", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipadx"/>
        /// </summary>
        public int ipadx { get { return IGetField<int>("ipadx"); } set { ISetField("ipadx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipady"/>
        /// </summary>
        public int ipady { get { return IGetField<int>("ipady"); } set { ISetField("ipady", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#insets"/>
        /// </summary>
        public Java.Awt.Insets insets { get { return IGetField<Java.Awt.Insets>("insets"); } set { ISetField("insets", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE"/>
        /// </summary>
        public static int ABOVE_BASELINE { get { if (!_ABOVE_BASELINEReady) { _ABOVE_BASELINEContent = SGetField<int>(LocalBridgeClazz, "ABOVE_BASELINE"); _ABOVE_BASELINEReady = true; } return _ABOVE_BASELINEContent; } }
        private static int _ABOVE_BASELINEContent = default;
        private static bool _ABOVE_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_LEADING"/>
        /// </summary>
        public static int ABOVE_BASELINE_LEADING { get { if (!_ABOVE_BASELINE_LEADINGReady) { _ABOVE_BASELINE_LEADINGContent = SGetField<int>(LocalBridgeClazz, "ABOVE_BASELINE_LEADING"); _ABOVE_BASELINE_LEADINGReady = true; } return _ABOVE_BASELINE_LEADINGContent; } }
        private static int _ABOVE_BASELINE_LEADINGContent = default;
        private static bool _ABOVE_BASELINE_LEADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_TRAILING"/>
        /// </summary>
        public static int ABOVE_BASELINE_TRAILING { get { if (!_ABOVE_BASELINE_TRAILINGReady) { _ABOVE_BASELINE_TRAILINGContent = SGetField<int>(LocalBridgeClazz, "ABOVE_BASELINE_TRAILING"); _ABOVE_BASELINE_TRAILINGReady = true; } return _ABOVE_BASELINE_TRAILINGContent; } }
        private static int _ABOVE_BASELINE_TRAILINGContent = default;
        private static bool _ABOVE_BASELINE_TRAILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE"/>
        /// </summary>
        public static int BASELINE { get { if (!_BASELINEReady) { _BASELINEContent = SGetField<int>(LocalBridgeClazz, "BASELINE"); _BASELINEReady = true; } return _BASELINEContent; } }
        private static int _BASELINEContent = default;
        private static bool _BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_LEADING"/>
        /// </summary>
        public static int BASELINE_LEADING { get { if (!_BASELINE_LEADINGReady) { _BASELINE_LEADINGContent = SGetField<int>(LocalBridgeClazz, "BASELINE_LEADING"); _BASELINE_LEADINGReady = true; } return _BASELINE_LEADINGContent; } }
        private static int _BASELINE_LEADINGContent = default;
        private static bool _BASELINE_LEADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_TRAILING"/>
        /// </summary>
        public static int BASELINE_TRAILING { get { if (!_BASELINE_TRAILINGReady) { _BASELINE_TRAILINGContent = SGetField<int>(LocalBridgeClazz, "BASELINE_TRAILING"); _BASELINE_TRAILINGReady = true; } return _BASELINE_TRAILINGContent; } }
        private static int _BASELINE_TRAILINGContent = default;
        private static bool _BASELINE_TRAILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE"/>
        /// </summary>
        public static int BELOW_BASELINE { get { if (!_BELOW_BASELINEReady) { _BELOW_BASELINEContent = SGetField<int>(LocalBridgeClazz, "BELOW_BASELINE"); _BELOW_BASELINEReady = true; } return _BELOW_BASELINEContent; } }
        private static int _BELOW_BASELINEContent = default;
        private static bool _BELOW_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_LEADING"/>
        /// </summary>
        public static int BELOW_BASELINE_LEADING { get { if (!_BELOW_BASELINE_LEADINGReady) { _BELOW_BASELINE_LEADINGContent = SGetField<int>(LocalBridgeClazz, "BELOW_BASELINE_LEADING"); _BELOW_BASELINE_LEADINGReady = true; } return _BELOW_BASELINE_LEADINGContent; } }
        private static int _BELOW_BASELINE_LEADINGContent = default;
        private static bool _BELOW_BASELINE_LEADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_TRAILING"/>
        /// </summary>
        public static int BELOW_BASELINE_TRAILING { get { if (!_BELOW_BASELINE_TRAILINGReady) { _BELOW_BASELINE_TRAILINGContent = SGetField<int>(LocalBridgeClazz, "BELOW_BASELINE_TRAILING"); _BELOW_BASELINE_TRAILINGReady = true; } return _BELOW_BASELINE_TRAILINGContent; } }
        private static int _BELOW_BASELINE_TRAILINGContent = default;
        private static bool _BELOW_BASELINE_TRAILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BOTH"/>
        /// </summary>
        public static int BOTH { get { if (!_BOTHReady) { _BOTHContent = SGetField<int>(LocalBridgeClazz, "BOTH"); _BOTHReady = true; } return _BOTHContent; } }
        private static int _BOTHContent = default;
        private static bool _BOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<int>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static int _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#EAST"/>
        /// </summary>
        public static int EAST { get { if (!_EASTReady) { _EASTContent = SGetField<int>(LocalBridgeClazz, "EAST"); _EASTReady = true; } return _EASTContent; } }
        private static int _EASTContent = default;
        private static bool _EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_END"/>
        /// </summary>
        public static int FIRST_LINE_END { get { if (!_FIRST_LINE_ENDReady) { _FIRST_LINE_ENDContent = SGetField<int>(LocalBridgeClazz, "FIRST_LINE_END"); _FIRST_LINE_ENDReady = true; } return _FIRST_LINE_ENDContent; } }
        private static int _FIRST_LINE_ENDContent = default;
        private static bool _FIRST_LINE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_START"/>
        /// </summary>
        public static int FIRST_LINE_START { get { if (!_FIRST_LINE_STARTReady) { _FIRST_LINE_STARTContent = SGetField<int>(LocalBridgeClazz, "FIRST_LINE_START"); _FIRST_LINE_STARTReady = true; } return _FIRST_LINE_STARTContent; } }
        private static int _FIRST_LINE_STARTContent = default;
        private static bool _FIRST_LINE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_END"/>
        /// </summary>
        public static int LAST_LINE_END { get { if (!_LAST_LINE_ENDReady) { _LAST_LINE_ENDContent = SGetField<int>(LocalBridgeClazz, "LAST_LINE_END"); _LAST_LINE_ENDReady = true; } return _LAST_LINE_ENDContent; } }
        private static int _LAST_LINE_ENDContent = default;
        private static bool _LAST_LINE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_START"/>
        /// </summary>
        public static int LAST_LINE_START { get { if (!_LAST_LINE_STARTReady) { _LAST_LINE_STARTContent = SGetField<int>(LocalBridgeClazz, "LAST_LINE_START"); _LAST_LINE_STARTReady = true; } return _LAST_LINE_STARTContent; } }
        private static int _LAST_LINE_STARTContent = default;
        private static bool _LAST_LINE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_END"/>
        /// </summary>
        public static int LINE_END { get { if (!_LINE_ENDReady) { _LINE_ENDContent = SGetField<int>(LocalBridgeClazz, "LINE_END"); _LINE_ENDReady = true; } return _LINE_ENDContent; } }
        private static int _LINE_ENDContent = default;
        private static bool _LINE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_START"/>
        /// </summary>
        public static int LINE_START { get { if (!_LINE_STARTReady) { _LINE_STARTContent = SGetField<int>(LocalBridgeClazz, "LINE_START"); _LINE_STARTReady = true; } return _LINE_STARTContent; } }
        private static int _LINE_STARTContent = default;
        private static bool _LINE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NONE"/>
        /// </summary>
        public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static int _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTH"/>
        /// </summary>
        public static int NORTH { get { if (!_NORTHReady) { _NORTHContent = SGetField<int>(LocalBridgeClazz, "NORTH"); _NORTHReady = true; } return _NORTHContent; } }
        private static int _NORTHContent = default;
        private static bool _NORTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHEAST"/>
        /// </summary>
        public static int NORTHEAST { get { if (!_NORTHEASTReady) { _NORTHEASTContent = SGetField<int>(LocalBridgeClazz, "NORTHEAST"); _NORTHEASTReady = true; } return _NORTHEASTContent; } }
        private static int _NORTHEASTContent = default;
        private static bool _NORTHEASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHWEST"/>
        /// </summary>
        public static int NORTHWEST { get { if (!_NORTHWESTReady) { _NORTHWESTContent = SGetField<int>(LocalBridgeClazz, "NORTHWEST"); _NORTHWESTReady = true; } return _NORTHWESTContent; } }
        private static int _NORTHWESTContent = default;
        private static bool _NORTHWESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_END"/>
        /// </summary>
        public static int PAGE_END { get { if (!_PAGE_ENDReady) { _PAGE_ENDContent = SGetField<int>(LocalBridgeClazz, "PAGE_END"); _PAGE_ENDReady = true; } return _PAGE_ENDContent; } }
        private static int _PAGE_ENDContent = default;
        private static bool _PAGE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_START"/>
        /// </summary>
        public static int PAGE_START { get { if (!_PAGE_STARTReady) { _PAGE_STARTContent = SGetField<int>(LocalBridgeClazz, "PAGE_START"); _PAGE_STARTReady = true; } return _PAGE_STARTContent; } }
        private static int _PAGE_STARTContent = default;
        private static bool _PAGE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#RELATIVE"/>
        /// </summary>
        public static int RELATIVE { get { if (!_RELATIVEReady) { _RELATIVEContent = SGetField<int>(LocalBridgeClazz, "RELATIVE"); _RELATIVEReady = true; } return _RELATIVEContent; } }
        private static int _RELATIVEContent = default;
        private static bool _RELATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#REMAINDER"/>
        /// </summary>
        public static int REMAINDER { get { if (!_REMAINDERReady) { _REMAINDERContent = SGetField<int>(LocalBridgeClazz, "REMAINDER"); _REMAINDERReady = true; } return _REMAINDERContent; } }
        private static int _REMAINDERContent = default;
        private static bool _REMAINDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTH"/>
        /// </summary>
        public static int SOUTH { get { if (!_SOUTHReady) { _SOUTHContent = SGetField<int>(LocalBridgeClazz, "SOUTH"); _SOUTHReady = true; } return _SOUTHContent; } }
        private static int _SOUTHContent = default;
        private static bool _SOUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHEAST"/>
        /// </summary>
        public static int SOUTHEAST { get { if (!_SOUTHEASTReady) { _SOUTHEASTContent = SGetField<int>(LocalBridgeClazz, "SOUTHEAST"); _SOUTHEASTReady = true; } return _SOUTHEASTContent; } }
        private static int _SOUTHEASTContent = default;
        private static bool _SOUTHEASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHWEST"/>
        /// </summary>
        public static int SOUTHWEST { get { if (!_SOUTHWESTReady) { _SOUTHWESTContent = SGetField<int>(LocalBridgeClazz, "SOUTHWEST"); _SOUTHWESTReady = true; } return _SOUTHWESTContent; } }
        private static int _SOUTHWESTContent = default;
        private static bool _SOUTHWESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#WEST"/>
        /// </summary>
        public static int WEST { get { if (!_WESTReady) { _WESTContent = SGetField<int>(LocalBridgeClazz, "WEST"); _WESTReady = true; } return _WESTContent; } }
        private static int _WESTContent = default;
        private static bool _WESTReady = false; // this is used because in case of generics 

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
}