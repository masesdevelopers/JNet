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

namespace Javax.Swing
{
    #region SwingConstants declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html"/>
    /// </summary>
    public partial class SwingConstants : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SwingConstants>
    {
        const string _bridgeClassName = "javax.swing.SwingConstants";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SwingConstants class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SwingConstants() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SwingConstants class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SwingConstants(params object[] args) : base(args) { }

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

    #region ISwingConstants
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISwingConstants
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SwingConstants implementation
    public partial class SwingConstants : Javax.Swing.ISwingConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#BOTTOM"/>
        /// </summary>
        public static int BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<int>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static int _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<int>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static int _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#EAST"/>
        /// </summary>
        public static int EAST { get { if (!_EASTReady) { _EASTContent = SGetField<int>(LocalBridgeClazz, "EAST"); _EASTReady = true; } return _EASTContent; } }
        private static int _EASTContent = default;
        private static bool _EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#LEADING"/>
        /// </summary>
        public static int LEADING { get { if (!_LEADINGReady) { _LEADINGContent = SGetField<int>(LocalBridgeClazz, "LEADING"); _LEADINGReady = true; } return _LEADINGContent; } }
        private static int _LEADINGContent = default;
        private static bool _LEADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<int>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static int _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#NEXT"/>
        /// </summary>
        public static int NEXT { get { if (!_NEXTReady) { _NEXTContent = SGetField<int>(LocalBridgeClazz, "NEXT"); _NEXTReady = true; } return _NEXTContent; } }
        private static int _NEXTContent = default;
        private static bool _NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#NORTH"/>
        /// </summary>
        public static int NORTH { get { if (!_NORTHReady) { _NORTHContent = SGetField<int>(LocalBridgeClazz, "NORTH"); _NORTHReady = true; } return _NORTHContent; } }
        private static int _NORTHContent = default;
        private static bool _NORTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#NORTH_EAST"/>
        /// </summary>
        public static int NORTH_EAST { get { if (!_NORTH_EASTReady) { _NORTH_EASTContent = SGetField<int>(LocalBridgeClazz, "NORTH_EAST"); _NORTH_EASTReady = true; } return _NORTH_EASTContent; } }
        private static int _NORTH_EASTContent = default;
        private static bool _NORTH_EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#NORTH_WEST"/>
        /// </summary>
        public static int NORTH_WEST { get { if (!_NORTH_WESTReady) { _NORTH_WESTContent = SGetField<int>(LocalBridgeClazz, "NORTH_WEST"); _NORTH_WESTReady = true; } return _NORTH_WESTContent; } }
        private static int _NORTH_WESTContent = default;
        private static bool _NORTH_WESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#PREVIOUS"/>
        /// </summary>
        public static int PREVIOUS { get { if (!_PREVIOUSReady) { _PREVIOUSContent = SGetField<int>(LocalBridgeClazz, "PREVIOUS"); _PREVIOUSReady = true; } return _PREVIOUSContent; } }
        private static int _PREVIOUSContent = default;
        private static bool _PREVIOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<int>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static int _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#SOUTH"/>
        /// </summary>
        public static int SOUTH { get { if (!_SOUTHReady) { _SOUTHContent = SGetField<int>(LocalBridgeClazz, "SOUTH"); _SOUTHReady = true; } return _SOUTHContent; } }
        private static int _SOUTHContent = default;
        private static bool _SOUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#SOUTH_EAST"/>
        /// </summary>
        public static int SOUTH_EAST { get { if (!_SOUTH_EASTReady) { _SOUTH_EASTContent = SGetField<int>(LocalBridgeClazz, "SOUTH_EAST"); _SOUTH_EASTReady = true; } return _SOUTH_EASTContent; } }
        private static int _SOUTH_EASTContent = default;
        private static bool _SOUTH_EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#SOUTH_WEST"/>
        /// </summary>
        public static int SOUTH_WEST { get { if (!_SOUTH_WESTReady) { _SOUTH_WESTContent = SGetField<int>(LocalBridgeClazz, "SOUTH_WEST"); _SOUTH_WESTReady = true; } return _SOUTH_WESTContent; } }
        private static int _SOUTH_WESTContent = default;
        private static bool _SOUTH_WESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#TOP"/>
        /// </summary>
        public static int TOP { get { if (!_TOPReady) { _TOPContent = SGetField<int>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static int _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#TRAILING"/>
        /// </summary>
        public static int TRAILING { get { if (!_TRAILINGReady) { _TRAILINGContent = SGetField<int>(LocalBridgeClazz, "TRAILING"); _TRAILINGReady = true; } return _TRAILINGContent; } }
        private static int _TRAILINGContent = default;
        private static bool _TRAILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SwingConstants.html#WEST"/>
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