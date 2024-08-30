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

namespace Java.Time.Temporal
{
    #region WeekFields declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html"/>
    /// </summary>
    public partial class WeekFields : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.time.temporal.WeekFields";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WeekFields() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WeekFields(params object[] args) : base(args) { }

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

    #region WeekFields implementation
    public partial class WeekFields
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#WEEK_BASED_YEARS"/>
        /// </summary>
        public static Java.Time.Temporal.TemporalUnit WEEK_BASED_YEARS { get { if (!_WEEK_BASED_YEARSReady) { _WEEK_BASED_YEARSContent = SGetField<Java.Time.Temporal.TemporalUnit>(LocalBridgeClazz, "WEEK_BASED_YEARS"); _WEEK_BASED_YEARSReady = true; } return _WEEK_BASED_YEARSContent; } }
        private static Java.Time.Temporal.TemporalUnit _WEEK_BASED_YEARSContent = default;
        private static bool _WEEK_BASED_YEARSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#ISO"/>
        /// </summary>
        public static Java.Time.Temporal.WeekFields ISO { get { if (!_ISOReady) { _ISOContent = SGetField<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "ISO"); _ISOReady = true; } return _ISOContent; } }
        private static Java.Time.Temporal.WeekFields _ISOContent = default;
        private static bool _ISOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#SUNDAY_START"/>
        /// </summary>
        public static Java.Time.Temporal.WeekFields SUNDAY_START { get { if (!_SUNDAY_STARTReady) { _SUNDAY_STARTContent = SGetField<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "SUNDAY_START"); _SUNDAY_STARTReady = true; } return _SUNDAY_STARTContent; } }
        private static Java.Time.Temporal.WeekFields _SUNDAY_STARTContent = default;
        private static bool _SUNDAY_STARTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#of(java.time.DayOfWeek,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.DayOfWeek"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Temporal.WeekFields"/></returns>
        public static Java.Time.Temporal.WeekFields Of(Java.Time.DayOfWeek arg0, int arg1)
        {
            return SExecute<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#of(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Temporal.WeekFields"/></returns>
        public static Java.Time.Temporal.WeekFields Of(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.WeekFields>(LocalBridgeClazz, "of", "(Ljava/util/Locale;)Ljava/time/temporal/WeekFields;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#getFirstDayOfWeek()"/> 
        /// </summary>
        public Java.Time.DayOfWeek FirstDayOfWeek
        {
            get { return IExecuteWithSignature<Java.Time.DayOfWeek>("getFirstDayOfWeek", "()Ljava/time/DayOfWeek;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#getMinimalDaysInFirstWeek()"/> 
        /// </summary>
        public int MinimalDaysInFirstWeek
        {
            get { return IExecuteWithSignature<int>("getMinimalDaysInFirstWeek", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#dayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalField"/></returns>
        public Java.Time.Temporal.TemporalField DayOfWeek()
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalField>("dayOfWeek", "()Ljava/time/temporal/TemporalField;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekBasedYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalField"/></returns>
        public Java.Time.Temporal.TemporalField WeekBasedYear()
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalField>("weekBasedYear", "()Ljava/time/temporal/TemporalField;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalField"/></returns>
        public Java.Time.Temporal.TemporalField WeekOfMonth()
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalField>("weekOfMonth", "()Ljava/time/temporal/TemporalField;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfWeekBasedYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalField"/></returns>
        public Java.Time.Temporal.TemporalField WeekOfWeekBasedYear()
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalField>("weekOfWeekBasedYear", "()Ljava/time/temporal/TemporalField;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/WeekFields.html#weekOfYear()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalField"/></returns>
        public Java.Time.Temporal.TemporalField WeekOfYear()
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalField>("weekOfYear", "()Ljava/time/temporal/TemporalField;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}