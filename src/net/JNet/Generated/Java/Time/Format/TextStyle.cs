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

namespace Java.Time.Format
{
    #region TextStyle
    public partial class TextStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL { get { if (!_FULLReady) { _FULLContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL"); _FULLReady = true; } return _FULLContent; } }
        private static Java.Time.Format.TextStyle _FULLContent = default;
        private static bool _FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#FULL_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle FULL_STANDALONE { get { if (!_FULL_STANDALONEReady) { _FULL_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "FULL_STANDALONE"); _FULL_STANDALONEReady = true; } return _FULL_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _FULL_STANDALONEContent = default;
        private static bool _FULL_STANDALONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW { get { if (!_NARROWReady) { _NARROWContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW"); _NARROWReady = true; } return _NARROWContent; } }
        private static Java.Time.Format.TextStyle _NARROWContent = default;
        private static bool _NARROWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#NARROW_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle NARROW_STANDALONE { get { if (!_NARROW_STANDALONEReady) { _NARROW_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "NARROW_STANDALONE"); _NARROW_STANDALONEReady = true; } return _NARROW_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _NARROW_STANDALONEContent = default;
        private static bool _NARROW_STANDALONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static Java.Time.Format.TextStyle _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#SHORT_STANDALONE"/>
        /// </summary>
        public static Java.Time.Format.TextStyle SHORT_STANDALONE { get { if (!_SHORT_STANDALONEReady) { _SHORT_STANDALONEContent = SGetField<Java.Time.Format.TextStyle>(LocalBridgeClazz, "SHORT_STANDALONE"); _SHORT_STANDALONEReady = true; } return _SHORT_STANDALONEContent; } }
        private static Java.Time.Format.TextStyle _SHORT_STANDALONEContent = default;
        private static bool _SHORT_STANDALONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.TextStyle>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/format/TextStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public static Java.Time.Format.TextStyle[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Format.TextStyle>(LocalBridgeClazz, "values", "()[Ljava/time/format/TextStyle;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#isStandalone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandalone()
        {
            return IExecuteWithSignature<bool>("isStandalone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asNormal()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsNormal()
        {
            return IExecuteWithSignature<Java.Time.Format.TextStyle>("asNormal", "()Ljava/time/format/TextStyle;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/TextStyle.html#asStandalone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.TextStyle"/></returns>
        public Java.Time.Format.TextStyle AsStandalone()
        {
            return IExecuteWithSignature<Java.Time.Format.TextStyle>("asStandalone", "()Ljava/time/format/TextStyle;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}