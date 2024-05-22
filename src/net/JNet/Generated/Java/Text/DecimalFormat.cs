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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region DecimalFormat
    public partial class DecimalFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#%3Cinit%3E(java.lang.String,java.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.DecimalFormatSymbols"/></param>
        public DecimalFormat(Java.Lang.String arg0, Java.Text.DecimalFormatSymbols arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public DecimalFormat(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getDecimalFormatSymbols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setDecimalFormatSymbols(java.text.DecimalFormatSymbols)"/>
        /// </summary>
        public Java.Text.DecimalFormatSymbols DecimalFormatSymbols
        {
            get { return IExecuteWithSignature<Java.Text.DecimalFormatSymbols>("getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;"); } set { IExecuteWithSignature("setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getGroupingSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setGroupingSize(int)"/>
        /// </summary>
        public int GroupingSize
        {
            get { return IExecuteWithSignature<int>("getGroupingSize", "()I"); } set { IExecuteWithSignature("setGroupingSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getMultiplier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setMultiplier(int)"/>
        /// </summary>
        public int Multiplier
        {
            get { return IExecuteWithSignature<int>("getMultiplier", "()I"); } set { IExecuteWithSignature("setMultiplier", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getNegativePrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setNegativePrefix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NegativePrefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNegativePrefix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNegativePrefix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getNegativeSuffix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setNegativeSuffix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NegativeSuffix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNegativeSuffix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNegativeSuffix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getPositivePrefix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setPositivePrefix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String PositivePrefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPositivePrefix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPositivePrefix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#getPositiveSuffix()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setPositiveSuffix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String PositiveSuffix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPositiveSuffix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPositiveSuffix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#isDecimalSeparatorAlwaysShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDecimalSeparatorAlwaysShown()
        {
            return IExecuteWithSignature<bool>("isDecimalSeparatorAlwaysShown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#isParseBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParseBigDecimal()
        {
            return IExecuteWithSignature<bool>("isParseBigDecimal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#toLocalizedPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToLocalizedPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toLocalizedPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#applyLocalizedPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyLocalizedPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyLocalizedPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setDecimalSeparatorAlwaysShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDecimalSeparatorAlwaysShown(bool arg0)
        {
            IExecuteWithSignature("setDecimalSeparatorAlwaysShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/DecimalFormat.html#setParseBigDecimal(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseBigDecimal(bool arg0)
        {
            IExecuteWithSignature("setParseBigDecimal", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}