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
    #region ChronoUnit definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html"/>
    /// </summary>
    public partial class ChronoUnit : Java.Lang.Enum<Java.Time.Temporal.ChronoUnit>
    {
        const string _bridgeClassName = "java.time.temporal.ChronoUnit";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ChronoUnit() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ChronoUnit(params object[] args) : base(args) { }

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

    #region ChronoUnit
    public partial class ChronoUnit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Temporal.ChronoUnit"/> to <see cref="Java.Time.Temporal.TemporalUnit"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalUnit(Java.Time.Temporal.ChronoUnit t) => t.Cast<Java.Time.Temporal.TemporalUnit>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#CENTURIES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit CENTURIES { get { if (!_CENTURIESReady) { _CENTURIESContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "CENTURIES"); _CENTURIESReady = true; } return _CENTURIESContent; } }
        private static Java.Time.Temporal.ChronoUnit _CENTURIESContent = default;
        private static bool _CENTURIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#DAYS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit DAYS { get { if (!_DAYSReady) { _DAYSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "DAYS"); _DAYSReady = true; } return _DAYSContent; } }
        private static Java.Time.Temporal.ChronoUnit _DAYSContent = default;
        private static bool _DAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#DECADES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit DECADES { get { if (!_DECADESReady) { _DECADESContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "DECADES"); _DECADESReady = true; } return _DECADESContent; } }
        private static Java.Time.Temporal.ChronoUnit _DECADESContent = default;
        private static bool _DECADESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#ERAS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit ERAS { get { if (!_ERASReady) { _ERASContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "ERAS"); _ERASReady = true; } return _ERASContent; } }
        private static Java.Time.Temporal.ChronoUnit _ERASContent = default;
        private static bool _ERASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#FOREVER"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit FOREVER { get { if (!_FOREVERReady) { _FOREVERContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "FOREVER"); _FOREVERReady = true; } return _FOREVERContent; } }
        private static Java.Time.Temporal.ChronoUnit _FOREVERContent = default;
        private static bool _FOREVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#HALF_DAYS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit HALF_DAYS { get { if (!_HALF_DAYSReady) { _HALF_DAYSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "HALF_DAYS"); _HALF_DAYSReady = true; } return _HALF_DAYSContent; } }
        private static Java.Time.Temporal.ChronoUnit _HALF_DAYSContent = default;
        private static bool _HALF_DAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#HOURS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit HOURS { get { if (!_HOURSReady) { _HOURSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "HOURS"); _HOURSReady = true; } return _HOURSContent; } }
        private static Java.Time.Temporal.ChronoUnit _HOURSContent = default;
        private static bool _HOURSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MICROS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MICROS { get { if (!_MICROSReady) { _MICROSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "MICROS"); _MICROSReady = true; } return _MICROSContent; } }
        private static Java.Time.Temporal.ChronoUnit _MICROSContent = default;
        private static bool _MICROSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MILLENNIA"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MILLENNIA { get { if (!_MILLENNIAReady) { _MILLENNIAContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "MILLENNIA"); _MILLENNIAReady = true; } return _MILLENNIAContent; } }
        private static Java.Time.Temporal.ChronoUnit _MILLENNIAContent = default;
        private static bool _MILLENNIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MILLIS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MILLIS { get { if (!_MILLISReady) { _MILLISContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "MILLIS"); _MILLISReady = true; } return _MILLISContent; } }
        private static Java.Time.Temporal.ChronoUnit _MILLISContent = default;
        private static bool _MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MINUTES"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MINUTES { get { if (!_MINUTESReady) { _MINUTESContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "MINUTES"); _MINUTESReady = true; } return _MINUTESContent; } }
        private static Java.Time.Temporal.ChronoUnit _MINUTESContent = default;
        private static bool _MINUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#MONTHS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit MONTHS { get { if (!_MONTHSReady) { _MONTHSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "MONTHS"); _MONTHSReady = true; } return _MONTHSContent; } }
        private static Java.Time.Temporal.ChronoUnit _MONTHSContent = default;
        private static bool _MONTHSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#NANOS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit NANOS { get { if (!_NANOSReady) { _NANOSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "NANOS"); _NANOSReady = true; } return _NANOSContent; } }
        private static Java.Time.Temporal.ChronoUnit _NANOSContent = default;
        private static bool _NANOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#SECONDS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit SECONDS { get { if (!_SECONDSReady) { _SECONDSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "SECONDS"); _SECONDSReady = true; } return _SECONDSContent; } }
        private static Java.Time.Temporal.ChronoUnit _SECONDSContent = default;
        private static bool _SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#WEEKS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit WEEKS { get { if (!_WEEKSReady) { _WEEKSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "WEEKS"); _WEEKSReady = true; } return _WEEKSContent; } }
        private static Java.Time.Temporal.ChronoUnit _WEEKSContent = default;
        private static bool _WEEKSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#YEARS"/>
        /// </summary>
        public static Java.Time.Temporal.ChronoUnit YEARS { get { if (!_YEARSReady) { _YEARSContent = SGetField<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "YEARS"); _YEARSReady = true; } return _YEARSContent; } }
        private static Java.Time.Temporal.ChronoUnit _YEARSContent = default;
        private static bool _YEARSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Temporal.ChronoUnit"/></returns>
        public static Java.Time.Temporal.ChronoUnit ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/temporal/ChronoUnit;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.ChronoUnit"/></returns>
        public static Java.Time.Temporal.ChronoUnit[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Temporal.ChronoUnit>(LocalBridgeClazz, "values", "()[Ljava/time/temporal/ChronoUnit;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#getDuration()"/> 
        /// </summary>
        public Java.Time.Duration Duration
        {
            get { return IExecuteWithSignature<Java.Time.Duration>("getDuration", "()Ljava/time/Duration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#addTo(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AddTo<R>(R arg0, long arg1) where R : Java.Time.Temporal.ITemporal, new()
        {
            return IExecute<R>("addTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isDateBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecuteWithSignature<bool>("isDateBased", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isDurationEstimated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDurationEstimated()
        {
            return IExecuteWithSignature<bool>("isDurationEstimated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isSupportedBy(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<bool>("isSupportedBy", "(Ljava/time/temporal/Temporal;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#isTimeBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecuteWithSignature<bool>("isTimeBased", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/ChronoUnit.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="long"/></returns>
        public long Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return IExecute<long>("between", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}