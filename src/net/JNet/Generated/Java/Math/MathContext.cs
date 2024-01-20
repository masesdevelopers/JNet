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

namespace Java.Math
{
    #region MathContext
    public partial class MathContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(int,java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.RoundingMode"/></param>
        public MathContext(int arg0, Java.Math.RoundingMode arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public MathContext(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public MathContext(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL128"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL128 { get { return SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL128"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL32"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL32 { get { return SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL32"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#DECIMAL64"/>
        /// </summary>
        public static Java.Math.MathContext DECIMAL64 { get { return SGetField<Java.Math.MathContext>(LocalBridgeClazz, "DECIMAL64"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#UNLIMITED"/>
        /// </summary>
        public static Java.Math.MathContext UNLIMITED { get { return SGetField<Java.Math.MathContext>(LocalBridgeClazz, "UNLIMITED"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#getPrecision()"/> 
        /// </summary>
        public int Precision
        {
            get { return IExecute<int>("getPrecision"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html#getRoundingMode()"/> 
        /// </summary>
        public Java.Math.RoundingMode RoundingMode
        {
            get { return IExecute<Java.Math.RoundingMode>("getRoundingMode"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}