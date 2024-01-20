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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model
{
    #region SourceVersion
    public partial class SourceVersion
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_0"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_0 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_0"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_1"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_1 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_10"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_10 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_10"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_11"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_11 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_11"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_2"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_2 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_2"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_3"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_3 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_3"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_4"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_4 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_4"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_5"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_5 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_5"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_6"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_6 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_6"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_7"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_7 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_7"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_8"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_8 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_8"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#RELEASE_9"/>
        /// </summary>
        public static Javax.Lang.Model.SourceVersion RELEASE_9 { get { return SGetField<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "RELEASE_9"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#isIdentifier(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsIdentifier(Java.Lang.CharSequence arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isIdentifier", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#isKeyword(java.lang.CharSequence,javax.lang.model.SourceVersion)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.SourceVersion"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsKeyword(Java.Lang.CharSequence arg0, Javax.Lang.Model.SourceVersion arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isKeyword", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#isKeyword(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsKeyword(Java.Lang.CharSequence arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isKeyword", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#isName(java.lang.CharSequence,javax.lang.model.SourceVersion)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.SourceVersion"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsName(Java.Lang.CharSequence arg0, Javax.Lang.Model.SourceVersion arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#isName(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsName(Java.Lang.CharSequence arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#latest()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.SourceVersion"/></returns>
        public static Javax.Lang.Model.SourceVersion Latest()
        {
            return SExecute<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "latest");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#latestSupported()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.SourceVersion"/></returns>
        public static Javax.Lang.Model.SourceVersion LatestSupported()
        {
            return SExecute<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "latestSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Lang.Model.SourceVersion"/></returns>
        public static Javax.Lang.Model.SourceVersion ValueOf(string arg0)
        {
            return SExecute<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html#values()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.SourceVersion"/></returns>
        public static Javax.Lang.Model.SourceVersion[] Values()
        {
            return SExecuteArray<Javax.Lang.Model.SourceVersion>(LocalBridgeClazz, "values");
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