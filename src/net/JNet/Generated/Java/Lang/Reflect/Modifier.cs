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

namespace Java.Lang.Reflect
{
    #region Modifier
    public partial class Modifier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#ABSTRACT"/>
        /// </summary>
        public static int ABSTRACT { get { if (!_ABSTRACTReady) { _ABSTRACTContent = SGetField<int>(LocalBridgeClazz, "ABSTRACT"); _ABSTRACTReady = true; } return _ABSTRACTContent; } }
        private static int _ABSTRACTContent = default;
        private static bool _ABSTRACTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#FINAL"/>
        /// </summary>
        public static int FINAL { get { if (!_FINALReady) { _FINALContent = SGetField<int>(LocalBridgeClazz, "FINAL"); _FINALReady = true; } return _FINALContent; } }
        private static int _FINALContent = default;
        private static bool _FINALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#INTERFACE"/>
        /// </summary>
        public static int INTERFACE { get { if (!_INTERFACEReady) { _INTERFACEContent = SGetField<int>(LocalBridgeClazz, "INTERFACE"); _INTERFACEReady = true; } return _INTERFACEContent; } }
        private static int _INTERFACEContent = default;
        private static bool _INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#NATIVE"/>
        /// </summary>
        public static int NATIVE { get { if (!_NATIVEReady) { _NATIVEContent = SGetField<int>(LocalBridgeClazz, "NATIVE"); _NATIVEReady = true; } return _NATIVEContent; } }
        private static int _NATIVEContent = default;
        private static bool _NATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PRIVATE"/>
        /// </summary>
        public static int PRIVATE { get { if (!_PRIVATEReady) { _PRIVATEContent = SGetField<int>(LocalBridgeClazz, "PRIVATE"); _PRIVATEReady = true; } return _PRIVATEContent; } }
        private static int _PRIVATEContent = default;
        private static bool _PRIVATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PROTECTED"/>
        /// </summary>
        public static int PROTECTED { get { if (!_PROTECTEDReady) { _PROTECTEDContent = SGetField<int>(LocalBridgeClazz, "PROTECTED"); _PROTECTEDReady = true; } return _PROTECTEDContent; } }
        private static int _PROTECTEDContent = default;
        private static bool _PROTECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PUBLIC"/>
        /// </summary>
        public static int PUBLIC { get { if (!_PUBLICReady) { _PUBLICContent = SGetField<int>(LocalBridgeClazz, "PUBLIC"); _PUBLICReady = true; } return _PUBLICContent; } }
        private static int _PUBLICContent = default;
        private static bool _PUBLICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STATIC"/>
        /// </summary>
        public static int STATIC { get { if (!_STATICReady) { _STATICContent = SGetField<int>(LocalBridgeClazz, "STATIC"); _STATICReady = true; } return _STATICContent; } }
        private static int _STATICContent = default;
        private static bool _STATICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STRICT"/>
        /// </summary>
        public static int STRICT { get { if (!_STRICTReady) { _STRICTContent = SGetField<int>(LocalBridgeClazz, "STRICT"); _STRICTReady = true; } return _STRICTContent; } }
        private static int _STRICTContent = default;
        private static bool _STRICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#SYNCHRONIZED"/>
        /// </summary>
        public static int SYNCHRONIZED { get { if (!_SYNCHRONIZEDReady) { _SYNCHRONIZEDContent = SGetField<int>(LocalBridgeClazz, "SYNCHRONIZED"); _SYNCHRONIZEDReady = true; } return _SYNCHRONIZEDContent; } }
        private static int _SYNCHRONIZEDContent = default;
        private static bool _SYNCHRONIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#TRANSIENT"/>
        /// </summary>
        public static int TRANSIENT { get { if (!_TRANSIENTReady) { _TRANSIENTContent = SGetField<int>(LocalBridgeClazz, "TRANSIENT"); _TRANSIENTReady = true; } return _TRANSIENTContent; } }
        private static int _TRANSIENTContent = default;
        private static bool _TRANSIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#VOLATILE"/>
        /// </summary>
        public static int VOLATILE { get { if (!_VOLATILEReady) { _VOLATILEContent = SGetField<int>(LocalBridgeClazz, "VOLATILE"); _VOLATILEReady = true; } return _VOLATILEContent; } }
        private static int _VOLATILEContent = default;
        private static bool _VOLATILEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isAbstract(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAbstract(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isAbstract", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isFinal(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinal(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isFinal", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isInterface(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInterface(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isInterface", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isNative(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNative(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNative", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPrivate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPrivate(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isPrivate", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isProtected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsProtected(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isProtected", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPublic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPublic(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isPublic", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStatic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStatic(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isStatic", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStrict(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStrict(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isStrict", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isSynchronized(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSynchronized(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSynchronized", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isTransient(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTransient(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTransient", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isVolatile(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVolatile(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isVolatile", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#classModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int ClassModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "classModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#constructorModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int ConstructorModifiers()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "constructorModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#fieldModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int FieldModifiers()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "fieldModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#interfaceModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int InterfaceModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "interfaceModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#methodModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int MethodModifiers()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "methodModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#parameterModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int ParameterModifiers()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "parameterModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(I)Ljava/lang/String;", arg0);
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