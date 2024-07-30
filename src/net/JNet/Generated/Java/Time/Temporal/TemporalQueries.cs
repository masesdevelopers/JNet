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
    #region TemporalQueries
    public partial class TemporalQueries
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#chronology()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.Chrono.Chronology> Chronology()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.Chrono.Chronology>>(LocalBridgeClazz, "chronology", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#localDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.LocalDate> LocalDate()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.LocalDate>>(LocalBridgeClazz, "localDate", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#localTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.LocalTime> LocalTime()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.LocalTime>>(LocalBridgeClazz, "localTime", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#precision()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.Temporal.TemporalUnit> Precision()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.Temporal.TemporalUnit>>(LocalBridgeClazz, "precision", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#zone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.ZoneId> Zone()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.ZoneId>>(LocalBridgeClazz, "zone", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#zoneId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.ZoneId> ZoneId()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.ZoneId>>(LocalBridgeClazz, "zoneId", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/TemporalQueries.html#offset()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.ZoneOffset> Offset()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.ZoneOffset>>(LocalBridgeClazz, "offset", "()Ljava/time/temporal/TemporalQuery;");
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