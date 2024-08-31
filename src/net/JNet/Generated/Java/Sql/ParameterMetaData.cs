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

namespace Java.Sql
{
    #region ParameterMetaData declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html"/>
    /// </summary>
    public partial class ParameterMetaData : Java.Sql.Wrapper
    {
        const string _bridgeClassName = "java.sql.ParameterMetaData";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ParameterMetaData class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ParameterMetaData() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ParameterMetaData class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ParameterMetaData(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IParameterMetaData
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IParameterMetaData : Java.Sql.IWrapper
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterCount()"/> 
        /// </summary>
        int ParameterCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool IsSigned(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetParameterMode(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetParameterType(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetPrecision(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int GetScale(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        int IsNullable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetParameterClassName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Lang.String GetParameterTypeName(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ParameterMetaData implementation
    public partial class ParameterMetaData : Java.Sql.IParameterMetaData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterModeIn"/>
        /// </summary>
        public static int parameterModeIn { get { if (!_parameterModeInReady) { _parameterModeInContent = SGetField<int>(LocalBridgeClazz, "parameterModeIn"); _parameterModeInReady = true; } return _parameterModeInContent; } }
        private static int _parameterModeInContent = default;
        private static bool _parameterModeInReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterModeInOut"/>
        /// </summary>
        public static int parameterModeInOut { get { if (!_parameterModeInOutReady) { _parameterModeInOutContent = SGetField<int>(LocalBridgeClazz, "parameterModeInOut"); _parameterModeInOutReady = true; } return _parameterModeInOutContent; } }
        private static int _parameterModeInOutContent = default;
        private static bool _parameterModeInOutReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterModeOut"/>
        /// </summary>
        public static int parameterModeOut { get { if (!_parameterModeOutReady) { _parameterModeOutContent = SGetField<int>(LocalBridgeClazz, "parameterModeOut"); _parameterModeOutReady = true; } return _parameterModeOutContent; } }
        private static int _parameterModeOutContent = default;
        private static bool _parameterModeOutReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterModeUnknown"/>
        /// </summary>
        public static int parameterModeUnknown { get { if (!_parameterModeUnknownReady) { _parameterModeUnknownContent = SGetField<int>(LocalBridgeClazz, "parameterModeUnknown"); _parameterModeUnknownReady = true; } return _parameterModeUnknownContent; } }
        private static int _parameterModeUnknownContent = default;
        private static bool _parameterModeUnknownReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterNoNulls"/>
        /// </summary>
        public static int parameterNoNulls { get { if (!_parameterNoNullsReady) { _parameterNoNullsContent = SGetField<int>(LocalBridgeClazz, "parameterNoNulls"); _parameterNoNullsReady = true; } return _parameterNoNullsContent; } }
        private static int _parameterNoNullsContent = default;
        private static bool _parameterNoNullsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterNullable"/>
        /// </summary>
        public static int parameterNullable { get { if (!_parameterNullableReady) { _parameterNullableContent = SGetField<int>(LocalBridgeClazz, "parameterNullable"); _parameterNullableReady = true; } return _parameterNullableContent; } }
        private static int _parameterNullableContent = default;
        private static bool _parameterNullableReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#parameterNullableUnknown"/>
        /// </summary>
        public static int parameterNullableUnknown { get { if (!_parameterNullableUnknownReady) { _parameterNullableUnknownContent = SGetField<int>(LocalBridgeClazz, "parameterNullableUnknown"); _parameterNullableUnknownReady = true; } return _parameterNullableUnknownContent; } }
        private static int _parameterNullableUnknownContent = default;
        private static bool _parameterNullableUnknownReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterCount()"/> 
        /// </summary>
        public int ParameterCount
        {
            get { return IExecuteWithSignature<int>("getParameterCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSigned(int arg0)
        {
            return IExecuteWithSignature<bool>("isSigned", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetParameterMode(int arg0)
        {
            return IExecuteWithSignature<int>("getParameterMode", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetParameterType(int arg0)
        {
            return IExecuteWithSignature<int>("getParameterType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetPrecision(int arg0)
        {
            return IExecuteWithSignature<int>("getPrecision", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetScale(int arg0)
        {
            return IExecuteWithSignature<int>("getScale", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int IsNullable(int arg0)
        {
            return IExecuteWithSignature<int>("isNullable", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetParameterClassName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getParameterClassName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ParameterMetaData.html#getParameterTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetParameterTypeName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getParameterTypeName", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}