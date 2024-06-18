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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region GlyphJustificationInfo
    public partial class GlyphJustificationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#%3Cinit%3E(float,boolean,int,float,float,boolean,int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="float"/></param>
        /// <param name="arg8"><see cref="float"/></param>
        public GlyphJustificationInfo(float arg0, bool arg1, int arg2, float arg3, float arg4, bool arg5, int arg6, float arg7, float arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growAbsorb"/>
        /// </summary>
        public bool growAbsorb { get { if (!_growAbsorbReady) { _growAbsorbContent = IGetField<bool>("growAbsorb"); _growAbsorbReady = true; } return _growAbsorbContent; } }
        private bool _growAbsorbContent = default;
        private bool _growAbsorbReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkAbsorb"/>
        /// </summary>
        public bool shrinkAbsorb { get { if (!_shrinkAbsorbReady) { _shrinkAbsorbContent = IGetField<bool>("shrinkAbsorb"); _shrinkAbsorbReady = true; } return _shrinkAbsorbContent; } }
        private bool _shrinkAbsorbContent = default;
        private bool _shrinkAbsorbReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growLeftLimit"/>
        /// </summary>
        public float growLeftLimit { get { if (!_growLeftLimitReady) { _growLeftLimitContent = IGetField<float>("growLeftLimit"); _growLeftLimitReady = true; } return _growLeftLimitContent; } }
        private float _growLeftLimitContent = default;
        private bool _growLeftLimitReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growRightLimit"/>
        /// </summary>
        public float growRightLimit { get { if (!_growRightLimitReady) { _growRightLimitContent = IGetField<float>("growRightLimit"); _growRightLimitReady = true; } return _growRightLimitContent; } }
        private float _growRightLimitContent = default;
        private bool _growRightLimitReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkLeftLimit"/>
        /// </summary>
        public float shrinkLeftLimit { get { if (!_shrinkLeftLimitReady) { _shrinkLeftLimitContent = IGetField<float>("shrinkLeftLimit"); _shrinkLeftLimitReady = true; } return _shrinkLeftLimitContent; } }
        private float _shrinkLeftLimitContent = default;
        private bool _shrinkLeftLimitReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkRightLimit"/>
        /// </summary>
        public float shrinkRightLimit { get { if (!_shrinkRightLimitReady) { _shrinkRightLimitContent = IGetField<float>("shrinkRightLimit"); _shrinkRightLimitReady = true; } return _shrinkRightLimitContent; } }
        private float _shrinkRightLimitContent = default;
        private bool _shrinkRightLimitReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#weight"/>
        /// </summary>
        public float weight { get { if (!_weightReady) { _weightContent = IGetField<float>("weight"); _weightReady = true; } return _weightContent; } }
        private float _weightContent = default;
        private bool _weightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growPriority"/>
        /// </summary>
        public int growPriority { get { if (!_growPriorityReady) { _growPriorityContent = IGetField<int>("growPriority"); _growPriorityReady = true; } return _growPriorityContent; } }
        private int _growPriorityContent = default;
        private bool _growPriorityReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkPriority"/>
        /// </summary>
        public int shrinkPriority { get { if (!_shrinkPriorityReady) { _shrinkPriorityContent = IGetField<int>("shrinkPriority"); _shrinkPriorityReady = true; } return _shrinkPriorityContent; } }
        private int _shrinkPriorityContent = default;
        private bool _shrinkPriorityReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_INTERCHAR"/>
        /// </summary>
        public static int PRIORITY_INTERCHAR { get { if (!_PRIORITY_INTERCHARReady) { _PRIORITY_INTERCHARContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_INTERCHAR"); _PRIORITY_INTERCHARReady = true; } return _PRIORITY_INTERCHARContent; } }
        private static int _PRIORITY_INTERCHARContent = default;
        private static bool _PRIORITY_INTERCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_KASHIDA"/>
        /// </summary>
        public static int PRIORITY_KASHIDA { get { if (!_PRIORITY_KASHIDAReady) { _PRIORITY_KASHIDAContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_KASHIDA"); _PRIORITY_KASHIDAReady = true; } return _PRIORITY_KASHIDAContent; } }
        private static int _PRIORITY_KASHIDAContent = default;
        private static bool _PRIORITY_KASHIDAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_NONE"/>
        /// </summary>
        public static int PRIORITY_NONE { get { if (!_PRIORITY_NONEReady) { _PRIORITY_NONEContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_NONE"); _PRIORITY_NONEReady = true; } return _PRIORITY_NONEContent; } }
        private static int _PRIORITY_NONEContent = default;
        private static bool _PRIORITY_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_WHITESPACE"/>
        /// </summary>
        public static int PRIORITY_WHITESPACE { get { if (!_PRIORITY_WHITESPACEReady) { _PRIORITY_WHITESPACEContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_WHITESPACE"); _PRIORITY_WHITESPACEReady = true; } return _PRIORITY_WHITESPACEContent; } }
        private static int _PRIORITY_WHITESPACEContent = default;
        private static bool _PRIORITY_WHITESPACEReady = false; // this is used because in case of generics 

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