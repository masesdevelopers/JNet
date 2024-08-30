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
    #region JulianFields definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/JulianFields.html"/>
    /// </summary>
    public partial class JulianFields : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JulianFields>
    {
        const string _bridgeClassName = "java.time.temporal.JulianFields";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JulianFields() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JulianFields(params object[] args) : base(args) { }

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

    #region JulianFields
    public partial class JulianFields
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/JulianFields.html#JULIAN_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.TemporalField JULIAN_DAY { get { if (!_JULIAN_DAYReady) { _JULIAN_DAYContent = SGetField<Java.Time.Temporal.TemporalField>(LocalBridgeClazz, "JULIAN_DAY"); _JULIAN_DAYReady = true; } return _JULIAN_DAYContent; } }
        private static Java.Time.Temporal.TemporalField _JULIAN_DAYContent = default;
        private static bool _JULIAN_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/JulianFields.html#MODIFIED_JULIAN_DAY"/>
        /// </summary>
        public static Java.Time.Temporal.TemporalField MODIFIED_JULIAN_DAY { get { if (!_MODIFIED_JULIAN_DAYReady) { _MODIFIED_JULIAN_DAYContent = SGetField<Java.Time.Temporal.TemporalField>(LocalBridgeClazz, "MODIFIED_JULIAN_DAY"); _MODIFIED_JULIAN_DAYReady = true; } return _MODIFIED_JULIAN_DAYContent; } }
        private static Java.Time.Temporal.TemporalField _MODIFIED_JULIAN_DAYContent = default;
        private static bool _MODIFIED_JULIAN_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/temporal/JulianFields.html#RATA_DIE"/>
        /// </summary>
        public static Java.Time.Temporal.TemporalField RATA_DIE { get { if (!_RATA_DIEReady) { _RATA_DIEContent = SGetField<Java.Time.Temporal.TemporalField>(LocalBridgeClazz, "RATA_DIE"); _RATA_DIEReady = true; } return _RATA_DIEContent; } }
        private static Java.Time.Temporal.TemporalField _RATA_DIEContent = default;
        private static bool _RATA_DIEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}