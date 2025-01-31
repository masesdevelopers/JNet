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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time.Chrono
{
    #region JapaneseDate declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html"/>
    /// </summary>
    public partial class JapaneseDate : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JapaneseDate>
    {
        const string _bridgeClassName = "java.time.chrono.JapaneseDate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JapaneseDate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JapaneseDate(params object[] args) : base(args) { }

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

    #region JapaneseDate implementation
    public partial class JapaneseDate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.JapaneseDate"/> to <see cref="Java.Time.Chrono.ChronoLocalDate"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoLocalDate(Java.Time.Chrono.JapaneseDate t) => t.Cast<Java.Time.Chrono.ChronoLocalDate>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.JapaneseDate"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Chrono.JapaneseDate t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.JapaneseDate"/></returns>
        public static Java.Time.Chrono.JapaneseDate Now()
        {
            return SExecuteWithSignature<Java.Time.Chrono.JapaneseDate>(LocalBridgeClazz, "now", "()Ljava/time/chrono/JapaneseDate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseDate"/></returns>
        public static Java.Time.Chrono.JapaneseDate Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.JapaneseDate>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/chrono/JapaneseDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseDate"/></returns>
        public static Java.Time.Chrono.JapaneseDate Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.JapaneseDate>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/chrono/JapaneseDate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseDate"/></returns>
        public static Java.Time.Chrono.JapaneseDate Of(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Java.Time.Chrono.JapaneseDate>(LocalBridgeClazz, "of", "(III)Ljava/time/chrono/JapaneseDate;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/chrono/JapaneseDate.html#of(java.time.chrono.JapaneseEra,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.JapaneseEra"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.JapaneseDate"/></returns>
        public static Java.Time.Chrono.JapaneseDate Of(Java.Time.Chrono.JapaneseEra arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignature<Java.Time.Chrono.JapaneseDate>(LocalBridgeClazz, "of", "(Ljava/time/chrono/JapaneseEra;III)Ljava/time/chrono/JapaneseDate;", arg0, arg1, arg2, arg3);
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