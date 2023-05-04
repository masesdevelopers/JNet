/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region IntSummaryStatistics
    public partial class IntSummaryStatistics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#%3Cinit%3E(long,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public IntSummaryStatistics(long arg0, int arg1, int arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.IntSummaryStatistics"/> to <see cref="Java.Util.Function.IntConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.IntConsumer(Java.Util.IntSummaryStatistics t) => t.Cast<Java.Util.Function.IntConsumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#getAverage()"/> 
        /// </summary>
        public double Average
        {
            get { return IExecute<double>("getAverage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#getCount()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecute<long>("getCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#getMax()"/> 
        /// </summary>
        public int Max
        {
            get { return IExecute<int>("getMax"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#getMin()"/> 
        /// </summary>
        public int Min
        {
            get { return IExecute<int>("getMin"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#getSum()"/> 
        /// </summary>
        public long Sum
        {
            get { return IExecute<long>("getSum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Accept(int arg0)
        {
            IExecute("accept", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/IntSummaryStatistics.html#combine(java.util.IntSummaryStatistics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.IntSummaryStatistics"/></param>
        public void Combine(Java.Util.IntSummaryStatistics arg0)
        {
            IExecute("combine", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}