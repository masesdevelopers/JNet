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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Temporal
{
    #region TemporalAdjusters
    public partial class TemporalAdjusters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#dayOfWeekInMonth(int,java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster DayOfWeekInMonth(int arg0, Java.Time.DayOfWeek arg1)
        {
            return SExecute<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "dayOfWeekInMonth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#firstDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster FirstDayOfMonth()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "firstDayOfMonth", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#firstDayOfNextMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster FirstDayOfNextMonth()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "firstDayOfNextMonth", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#firstDayOfNextYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster FirstDayOfNextYear()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "firstDayOfNextYear", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#firstDayOfYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster FirstDayOfYear()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "firstDayOfYear", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#firstInMonth(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster FirstInMonth(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "firstInMonth", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#lastDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster LastDayOfMonth()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "lastDayOfMonth", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#lastDayOfYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster LastDayOfYear()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "lastDayOfYear", "()Ljava/time/temporal/TemporalAdjuster;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#lastInMonth(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster LastInMonth(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "lastInMonth", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#next(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster Next(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "next", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#nextOrSame(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster NextOrSame(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "nextOrSame", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#ofDateAdjuster(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster OfDateAdjuster(Java.Util.Function.UnaryOperator<Java.Time.LocalDate> arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "ofDateAdjuster", "(Ljava/util/function/UnaryOperator;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#previous(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster Previous(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "previous", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalAdjusters.html#previousOrSame(java.time.DayOfWeek)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAdjuster"/></returns>
        public static Java.Time.Temporal.TemporalAdjuster PreviousOrSame(Java.Time.DayOfWeek arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalAdjuster>(LocalBridgeClazz, "previousOrSame", "(Ljava/time/DayOfWeek;)Ljava/time/temporal/TemporalAdjuster;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}