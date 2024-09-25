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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Chrono
{
    #region JapaneseEra declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html"/>
    /// </summary>
    public partial class JapaneseEra : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JapaneseEra>
    {
        const string _bridgeClassName = "java.time.chrono.JapaneseEra";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JapaneseEra() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JapaneseEra(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region JapaneseEra implementation
    public partial class JapaneseEra
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.JapaneseEra"/> to <see cref="Java.Time.Chrono.Era"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.Era(Java.Time.Chrono.JapaneseEra t) => t.Cast<Java.Time.Chrono.Era>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.JapaneseEra"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Chrono.JapaneseEra t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#HEISEI"/>
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra HEISEI { get { if (!_HEISEIReady) { _HEISEIContent = SGetField<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "HEISEI"); _HEISEIReady = true; } return _HEISEIContent; } }
        private static Java.Time.Chrono.JapaneseEra _HEISEIContent = default;
        private static bool _HEISEIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#MEIJI"/>
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra MEIJI { get { if (!_MEIJIReady) { _MEIJIContent = SGetField<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "MEIJI"); _MEIJIReady = true; } return _MEIJIContent; } }
        private static Java.Time.Chrono.JapaneseEra _MEIJIContent = default;
        private static bool _MEIJIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#SHOWA"/>
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra SHOWA { get { if (!_SHOWAReady) { _SHOWAContent = SGetField<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "SHOWA"); _SHOWAReady = true; } return _SHOWAContent; } }
        private static Java.Time.Chrono.JapaneseEra _SHOWAContent = default;
        private static bool _SHOWAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#TAISHO"/>
        /// </summary>
        public static Java.Time.Chrono.JapaneseEra TAISHO { get { if (!_TAISHOReady) { _TAISHOContent = SGetField<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "TAISHO"); _TAISHOReady = true; } return _TAISHOContent; } }
        private static Java.Time.Chrono.JapaneseEra _TAISHOContent = default;
        private static bool _TAISHOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseEra"/></returns>
        public static Java.Time.Chrono.JapaneseEra Of(int arg0)
        {
            return SExecute<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseEra"/></returns>
        public static Java.Time.Chrono.JapaneseEra ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.JapaneseEra"/></returns>
        public static Java.Time.Chrono.JapaneseEra[] Values()
        {
            return SExecuteArray<Java.Time.Chrono.JapaneseEra>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseEra.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecute<Java.Time.Temporal.ValueRange>("range", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}