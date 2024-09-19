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

namespace Java.Awt.Im
{
    #region InputSubset declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html"/>
    /// </summary>
    public partial class InputSubset : Java.Lang.Character.Subset
    {
        const string _bridgeClassName = "java.awt.im.InputSubset";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InputSubset() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InputSubset(params object[] args) : base(args) { }

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

    #region InputSubset implementation
    public partial class InputSubset
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#FULLWIDTH_DIGITS"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset FULLWIDTH_DIGITS { get { if (!_FULLWIDTH_DIGITSReady) { _FULLWIDTH_DIGITSContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "FULLWIDTH_DIGITS"); _FULLWIDTH_DIGITSReady = true; } return _FULLWIDTH_DIGITSContent; } }
        private static Java.Awt.Im.InputSubset _FULLWIDTH_DIGITSContent = default;
        private static bool _FULLWIDTH_DIGITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#FULLWIDTH_LATIN"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset FULLWIDTH_LATIN { get { if (!_FULLWIDTH_LATINReady) { _FULLWIDTH_LATINContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "FULLWIDTH_LATIN"); _FULLWIDTH_LATINReady = true; } return _FULLWIDTH_LATINContent; } }
        private static Java.Awt.Im.InputSubset _FULLWIDTH_LATINContent = default;
        private static bool _FULLWIDTH_LATINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#HALFWIDTH_KATAKANA"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset HALFWIDTH_KATAKANA { get { if (!_HALFWIDTH_KATAKANAReady) { _HALFWIDTH_KATAKANAContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "HALFWIDTH_KATAKANA"); _HALFWIDTH_KATAKANAReady = true; } return _HALFWIDTH_KATAKANAContent; } }
        private static Java.Awt.Im.InputSubset _HALFWIDTH_KATAKANAContent = default;
        private static bool _HALFWIDTH_KATAKANAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#HANJA"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset HANJA { get { if (!_HANJAReady) { _HANJAContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "HANJA"); _HANJAReady = true; } return _HANJAContent; } }
        private static Java.Awt.Im.InputSubset _HANJAContent = default;
        private static bool _HANJAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#KANJI"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset KANJI { get { if (!_KANJIReady) { _KANJIContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "KANJI"); _KANJIReady = true; } return _KANJIContent; } }
        private static Java.Awt.Im.InputSubset _KANJIContent = default;
        private static bool _KANJIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#LATIN"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset LATIN { get { if (!_LATINReady) { _LATINContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "LATIN"); _LATINReady = true; } return _LATINContent; } }
        private static Java.Awt.Im.InputSubset _LATINContent = default;
        private static bool _LATINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#LATIN_DIGITS"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset LATIN_DIGITS { get { if (!_LATIN_DIGITSReady) { _LATIN_DIGITSContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "LATIN_DIGITS"); _LATIN_DIGITSReady = true; } return _LATIN_DIGITSContent; } }
        private static Java.Awt.Im.InputSubset _LATIN_DIGITSContent = default;
        private static bool _LATIN_DIGITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#SIMPLIFIED_HANZI"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset SIMPLIFIED_HANZI { get { if (!_SIMPLIFIED_HANZIReady) { _SIMPLIFIED_HANZIContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "SIMPLIFIED_HANZI"); _SIMPLIFIED_HANZIReady = true; } return _SIMPLIFIED_HANZIContent; } }
        private static Java.Awt.Im.InputSubset _SIMPLIFIED_HANZIContent = default;
        private static bool _SIMPLIFIED_HANZIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputSubset.html#TRADITIONAL_HANZI"/>
        /// </summary>
        public static Java.Awt.Im.InputSubset TRADITIONAL_HANZI { get { if (!_TRADITIONAL_HANZIReady) { _TRADITIONAL_HANZIContent = SGetField<Java.Awt.Im.InputSubset>(LocalBridgeClazz, "TRADITIONAL_HANZI"); _TRADITIONAL_HANZIReady = true; } return _TRADITIONAL_HANZIContent; } }
        private static Java.Awt.Im.InputSubset _TRADITIONAL_HANZIContent = default;
        private static bool _TRADITIONAL_HANZIReady = false; // this is used because in case of generics 

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