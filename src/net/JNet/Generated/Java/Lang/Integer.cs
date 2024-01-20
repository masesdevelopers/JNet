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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Integer
    public partial class Integer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Integer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Integer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { return SGetField<int>(LocalBridgeClazz, "BYTES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#MAX_VALUE"/>
        /// </summary>
        public static int MAX_VALUE { get { return SGetField<int>(LocalBridgeClazz, "MAX_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#MIN_VALUE"/>
        /// </summary>
        public static int MIN_VALUE { get { return SGetField<int>(LocalBridgeClazz, "MIN_VALUE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { return SGetField<int>(LocalBridgeClazz, "SIZE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { return SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#bitCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int BitCount(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "bitCount", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compare(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CompareUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compareUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#divideUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int DivideUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "divideUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#hashCode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "hashCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#highestOneBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HighestOneBit(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "highestOneBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#lowestOneBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int LowestOneBit(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "lowestOneBit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#max(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Max(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#min(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Min(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#numberOfLeadingZeros(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfLeadingZeros(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "numberOfLeadingZeros", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#numberOfTrailingZeros(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NumberOfTrailingZeros(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "numberOfTrailingZeros", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<int>(LocalBridgeClazz, "parseInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(string arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "parseInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseInt(string arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "parseInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<int>(LocalBridgeClazz, "parseUnsignedInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(string arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "parseUnsignedInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#parseUnsignedInt(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static int ParseUnsignedInt(string arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "parseUnsignedInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#remainderUnsigned(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RemainderUnsigned(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "remainderUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#reverse(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Reverse(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "reverse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#reverseBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ReverseBytes(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "reverseBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#rotateLeft(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RotateLeft(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "rotateLeft", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#rotateRight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RotateRight(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "rotateRight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#signum(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Signum(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "signum", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#sum(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Sum(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer Decode(string arg0)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "decode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(string arg0, int arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(string arg0, Java.Lang.Integer arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#getInteger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer GetInteger(string arg0)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "getInteger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public static Java.Lang.Integer ValueOf(int arg0)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer ValueOf(string arg0, int arg1)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Integer ValueOf(string arg0)
        {
            return SExecute<Java.Lang.Integer>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toBinaryString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToBinaryString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toBinaryString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toHexString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToHexString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toHexString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toOctalString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToOctalString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toOctalString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toString(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(int arg0, int arg1)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedString(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToUnsignedString(int arg0, int arg1)
        {
            return SExecute<string>(LocalBridgeClazz, "toUnsignedString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToUnsignedString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toUnsignedString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#toUnsignedLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ToUnsignedLong(int arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "toUnsignedLong", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareTo(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Integer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Integer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}