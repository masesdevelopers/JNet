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

namespace Java.Time.Chrono
{
    #region Chronology declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html"/>
    /// </summary>
    public partial class Chronology : Java.Lang.Comparable<Java.Time.Chrono.Chronology>
    {
        const string _bridgeClassName = "java.time.chrono.Chronology";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Chronology class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Chronology() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Chronology class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Chronology(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IChronology
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IChronology : Java.Lang.IComparable<Java.Time.Chrono.Chronology>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getCalendarType()"/> 
        /// </summary>
        Java.Lang.String CalendarType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getId()"/> 
        /// </summary>
        Java.Lang.String Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#isLeapYear(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsLeapYear(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#compareTo(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(Java.Time.Chrono.Chronology arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#prolepticYear(java.time.chrono.Era,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int ProlepticYear(Java.Time.Chrono.Era arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate Date(int arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateEpochDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateEpochDay(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateYearDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateYearDay(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#resolveDate(java.util.Map,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate ResolveDate(Java.Util.Map<Java.Time.Temporal.TemporalField, Java.Lang.Long> arg0, Java.Time.Format.ResolverStyle arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#eraOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.Era"/></returns>
        Java.Time.Chrono.Era EraOf(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#range(java.time.temporal.ChronoField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.ChronoField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.ChronoField arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#eras()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        Java.Util.List<Java.Time.Chrono.Era> Eras();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(java.time.chrono.Era,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateNow();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.Clock arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.ZoneId arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateYearDay(java.time.chrono.Era,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        Java.Time.Chrono.ChronoLocalDate DateYearDay(Java.Time.Chrono.Era arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#localDateTime(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        Java.Time.Chrono.ChronoLocalDateTime LocalDateTime(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#period(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        Java.Time.Chrono.ChronoPeriod Period(int arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#zonedDateTime(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        Java.Time.Chrono.ChronoZonedDateTime ZonedDateTime(Java.Time.Instant arg0, Java.Time.ZoneId arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#zonedDateTime(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        Java.Time.Chrono.ChronoZonedDateTime ZonedDateTime(Java.Time.Temporal.TemporalAccessor arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#epochSecond(int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        long EpochSecond(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Java.Time.ZoneOffset arg6);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#epochSecond(java.time.chrono.Era,int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        long EpochSecond(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Time.ZoneOffset arg7);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Chronology implementation
    public partial class Chronology : Java.Time.Chrono.IChronology
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getAvailableChronologies()"/> 
        /// </summary>
        public static Java.Util.Set<Java.Time.Chrono.Chronology> AvailableChronologies
        {
            get { return SExecuteWithSignature<Java.Util.Set<Java.Time.Chrono.Chronology>>(LocalBridgeClazz, "getAvailableChronologies", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/Chronology;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#of(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology Of(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "of", "(Ljava/lang/String;)Ljava/time/chrono/Chronology;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#ofLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology OfLocale(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "ofLocale", "(Ljava/util/Locale;)Ljava/time/chrono/Chronology;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getCalendarType()"/> 
        /// </summary>
        public Java.Lang.String CalendarType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCalendarType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#isLeapYear(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear(long arg0)
        {
            return IExecuteWithSignature<bool>("isLeapYear", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#compareTo(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.Chronology arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/chrono/Chronology;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#prolepticYear(java.time.chrono.Era,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ProlepticYear(Java.Time.Chrono.Era arg0, int arg1)
        {
            return IExecute<int>("prolepticYear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("date", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("date", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateEpochDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateEpochDay(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateEpochDay", "(J)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateYearDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateYearDay(int arg0, int arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("dateYearDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#resolveDate(java.util.Map,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ResolveDate(Java.Util.Map<Java.Time.Temporal.TemporalField, Java.Lang.Long> arg0, Java.Time.Format.ResolverStyle arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("resolveDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#eraOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.Era"/></returns>
        public Java.Time.Chrono.Era EraOf(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.Era>("eraOf", "(I)Ljava/time/chrono/Era;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#range(java.time.temporal.ChronoField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.ChronoField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.ChronoField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/ChronoField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#eras()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Chrono.Era> Eras()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Chrono.Era>>("eras", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#date(java.time.chrono.Era,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("date", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "()Ljava/time/chrono/ChronoLocalDate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.Clock arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "(Ljava/time/Clock;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateNow(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#dateYearDay(java.time.chrono.Era,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateYearDay(Java.Time.Chrono.Era arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("dateYearDay", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#localDateTime(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        public Java.Time.Chrono.ChronoLocalDateTime LocalDateTime(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDateTime>("localDateTime", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#period(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Period(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("period", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#zonedDateTime(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime ZonedDateTime(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoZonedDateTime>("zonedDateTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#zonedDateTime(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime ZonedDateTime(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("zonedDateTime", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#epochSecond(int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long EpochSecond(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Java.Time.ZoneOffset arg6)
        {
            return IExecute<long>("epochSecond", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/Chronology.html#epochSecond(java.time.chrono.Era,int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long EpochSecond(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Time.ZoneOffset arg7)
        {
            return IExecute<long>("epochSecond", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}