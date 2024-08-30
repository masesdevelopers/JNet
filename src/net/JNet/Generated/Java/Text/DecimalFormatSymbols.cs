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

namespace Java.Text
{
    #region DecimalFormatSymbols declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html"/>
    /// </summary>
    public partial class DecimalFormatSymbols : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DecimalFormatSymbols>
    {
        const string _bridgeClassName = "java.text.DecimalFormatSymbols";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DecimalFormatSymbols() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DecimalFormatSymbols(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region DecimalFormatSymbols implementation
    public partial class DecimalFormatSymbols
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DecimalFormatSymbols(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.DecimalFormatSymbols"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.DecimalFormatSymbols t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Text.DecimalFormatSymbols"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Text.DecimalFormatSymbols t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInstance()"/> 
        /// </summary>
        public static Java.Text.DecimalFormatSymbols Instance
        {
            get { return SExecuteWithSignature<Java.Text.DecimalFormatSymbols>(LocalBridgeClazz, "getInstance", "()Ljava/text/DecimalFormatSymbols;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DecimalFormatSymbols"/></returns>
        public static Java.Text.DecimalFormatSymbols GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.DecimalFormatSymbols>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getCurrency()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setCurrency(java.util.Currency)"/>
        /// </summary>
        public Java.Util.Currency Currency
        {
            get { return IExecuteWithSignature<Java.Util.Currency>("getCurrency", "()Ljava/util/Currency;"); } set { IExecuteWithSignature("setCurrency", "(Ljava/util/Currency;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getCurrencySymbol()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setCurrencySymbol(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CurrencySymbol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCurrencySymbol", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCurrencySymbol", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getDecimalSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setDecimalSeparator(char)"/>
        /// </summary>
        public char DecimalSeparator
        {
            get { return IExecuteWithSignature<char>("getDecimalSeparator", "()C"); } set { IExecuteWithSignature("setDecimalSeparator", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getDigit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setDigit(char)"/>
        /// </summary>
        public char Digit
        {
            get { return IExecuteWithSignature<char>("getDigit", "()C"); } set { IExecuteWithSignature("setDigit", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getExponentSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setExponentSeparator(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ExponentSeparator
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getExponentSeparator", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setExponentSeparator", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getGroupingSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setGroupingSeparator(char)"/>
        /// </summary>
        public char GroupingSeparator
        {
            get { return IExecuteWithSignature<char>("getGroupingSeparator", "()C"); } set { IExecuteWithSignature("setGroupingSeparator", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInfinity()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setInfinity(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Infinity
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInfinity", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setInfinity", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getInternationalCurrencySymbol()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setInternationalCurrencySymbol(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String InternationalCurrencySymbol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInternationalCurrencySymbol", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setInternationalCurrencySymbol", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getMinusSign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setMinusSign(char)"/>
        /// </summary>
        public char MinusSign
        {
            get { return IExecuteWithSignature<char>("getMinusSign", "()C"); } set { IExecuteWithSignature("setMinusSign", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getMonetaryDecimalSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setMonetaryDecimalSeparator(char)"/>
        /// </summary>
        public char MonetaryDecimalSeparator
        {
            get { return IExecuteWithSignature<char>("getMonetaryDecimalSeparator", "()C"); } set { IExecuteWithSignature("setMonetaryDecimalSeparator", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getNaN()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setNaN(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NaN
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNaN", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNaN", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPatternSeparator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPatternSeparator(char)"/>
        /// </summary>
        public char PatternSeparator
        {
            get { return IExecuteWithSignature<char>("getPatternSeparator", "()C"); } set { IExecuteWithSignature("setPatternSeparator", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPercent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPercent(char)"/>
        /// </summary>
        public char Percent
        {
            get { return IExecuteWithSignature<char>("getPercent", "()C"); } set { IExecuteWithSignature("setPercent", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getPerMill()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setPerMill(char)"/>
        /// </summary>
        public char PerMill
        {
            get { return IExecuteWithSignature<char>("getPerMill", "()C"); } set { IExecuteWithSignature("setPerMill", "(C)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#getZeroDigit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormatSymbols.html#setZeroDigit(char)"/>
        /// </summary>
        public char ZeroDigit
        {
            get { return IExecuteWithSignature<char>("getZeroDigit", "()C"); } set { IExecuteWithSignature("setZeroDigit", "(C)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}