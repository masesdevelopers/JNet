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
    #region DecimalStyle
    public partial class DecimalStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#STANDARD"/>
        /// </summary>
        public static Java.Time.Format.DecimalStyle STANDARD { get { if (!_STANDARDReady) { _STANDARDContent = SGetField<Java.Time.Format.DecimalStyle>(LocalBridgeClazz, "STANDARD"); _STANDARDReady = true; } return _STANDARDContent; } }
        private static Java.Time.Format.DecimalStyle _STANDARDContent = default;
        private static bool _STANDARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Set<Java.Util.Locale> AvailableLocales
        {
            get { return SExecuteWithSignature<Java.Util.Set<Java.Util.Locale>>(LocalBridgeClazz, "getAvailableLocales", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#of(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public static Java.Time.Format.DecimalStyle Of(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.DecimalStyle>(LocalBridgeClazz, "of", "(Ljava/util/Locale;)Ljava/time/format/DecimalStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#ofDefaultLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public static Java.Time.Format.DecimalStyle OfDefaultLocale()
        {
            return SExecuteWithSignature<Java.Time.Format.DecimalStyle>(LocalBridgeClazz, "ofDefaultLocale", "()Ljava/time/format/DecimalStyle;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#getDecimalSeparator()"/> 
        /// </summary>
        public char DecimalSeparator
        {
            get { return IExecuteWithSignature<char>("getDecimalSeparator", "()C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#getNegativeSign()"/> 
        /// </summary>
        public char NegativeSign
        {
            get { return IExecuteWithSignature<char>("getNegativeSign", "()C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#getPositiveSign()"/> 
        /// </summary>
        public char PositiveSign
        {
            get { return IExecuteWithSignature<char>("getPositiveSign", "()C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#getZeroDigit()"/> 
        /// </summary>
        public char ZeroDigit
        {
            get { return IExecuteWithSignature<char>("getZeroDigit", "()C"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#withDecimalSeparator(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public Java.Time.Format.DecimalStyle WithDecimalSeparator(char arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DecimalStyle>("withDecimalSeparator", "(C)Ljava/time/format/DecimalStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#withNegativeSign(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public Java.Time.Format.DecimalStyle WithNegativeSign(char arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DecimalStyle>("withNegativeSign", "(C)Ljava/time/format/DecimalStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#withPositiveSign(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public Java.Time.Format.DecimalStyle WithPositiveSign(char arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DecimalStyle>("withPositiveSign", "(C)Ljava/time/format/DecimalStyle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/format/DecimalStyle.html#withZeroDigit(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public Java.Time.Format.DecimalStyle WithZeroDigit(char arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DecimalStyle>("withZeroDigit", "(C)Ljava/time/format/DecimalStyle;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}