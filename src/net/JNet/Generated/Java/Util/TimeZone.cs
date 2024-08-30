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

namespace Java.Util
{
    #region TimeZone declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html"/>
    /// </summary>
    public partial class TimeZone : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeZone>
    {
        const string _bridgeClassName = "java.util.TimeZone";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TimeZone class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeZone() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TimeZone class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeZone(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TimeZone implementation
    public partial class TimeZone
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TimeZone"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TimeZone t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TimeZone"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TimeZone t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#LONG"/>
        /// </summary>
        public static int LONG { get { if (!_LONGReady) { _LONGContent = SGetField<int>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
        private static int _LONGContent = default;
        private static bool _LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#SHORT"/>
        /// </summary>
        public static int SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<int>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static int _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getAvailableIDs()"/> 
        /// </summary>
        public static Java.Lang.String[] AvailableIDs
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableIDs", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDefault()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setDefault(java.util.TimeZone)"/>
        /// </summary>
        public static Java.Util.TimeZone Default
        {
            get { return SExecuteWithSignature<Java.Util.TimeZone>(LocalBridgeClazz, "getDefault", "()Ljava/util/TimeZone;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Ljava/util/TimeZone;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getTimeZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public static Java.Util.TimeZone GetTimeZone(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", "(Ljava/time/ZoneId;)Ljava/util/TimeZone;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getAvailableIDs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetAvailableIDs(int arg0)
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableIDs", "(I)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getTimeZone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public static Java.Util.TimeZone GetTimeZone(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName()"/> 
        /// </summary>
        public Java.Lang.String DisplayName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDSTSavings()"/> 
        /// </summary>
        public int DSTSavings
        {
            get { return IExecuteWithSignature<int>("getDSTSavings", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setID(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setID", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getRawOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#setRawOffset(int)"/>
        /// </summary>
        public int RawOffset
        {
            get { return IExecuteWithSignature<int>("getRawOffset", "()I"); } set { IExecuteWithSignature("setRawOffset", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#inDaylightTime(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool InDaylightTime(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<bool>("inDaylightTime", "(Ljava/util/Date;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#useDaylightTime()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool UseDaylightTime()
        {
            return IExecuteWithSignature<bool>("useDaylightTime", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getOffset(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecute<int>("getOffset", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#hasSameRules(java.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasSameRules(Java.Util.TimeZone arg0)
        {
            return IExecuteWithSignature<bool>("hasSameRules", "(Ljava/util/TimeZone;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#observesDaylightTime()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ObservesDaylightTime()
        {
            return IExecuteWithSignature<bool>("observesDaylightTime", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(bool arg0, int arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getOffset(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(long arg0)
        {
            return IExecuteWithSignature<int>("getOffset", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#getDisplayName(boolean,int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(bool arg0, int arg1, Java.Util.Locale arg2)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TimeZone.html#toZoneId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId ToZoneId()
        {
            return IExecuteWithSignature<Java.Time.ZoneId>("toZoneId", "()Ljava/time/ZoneId;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}