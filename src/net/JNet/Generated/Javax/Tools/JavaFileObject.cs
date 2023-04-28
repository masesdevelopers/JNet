/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region JavaFileObject
    public partial class JavaFileObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecute<Javax.Lang.Model.Element.Modifier>("getAccessLevel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind GetKind
        {
            get { return IExecute<Javax.Tools.JavaFileObject.Kind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecute<Javax.Lang.Model.Element.NestingKind>("getNestingKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(string arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecute<bool>("isNameCompatible", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Kind
        public partial class Kind
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#extension"/>
            /// </summary>
            public string extension { get { return Instance.GetField<string>("extension"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#CLASS"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind CLASS { get { return LocalClazz.GetField<Javax.Tools.JavaFileObject.Kind>("CLASS"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#HTML"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind HTML { get { return LocalClazz.GetField<Javax.Tools.JavaFileObject.Kind>("HTML"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#OTHER"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind OTHER { get { return LocalClazz.GetField<Javax.Tools.JavaFileObject.Kind>("OTHER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#SOURCE"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind SOURCE { get { return LocalClazz.GetField<Javax.Tools.JavaFileObject.Kind>("SOURCE"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#values()"/> 
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind[] Values
            {
                get { return SExecuteArray<Javax.Tools.JavaFileObject.Kind>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Tools.JavaFileObject.Kind"/></returns>
            public static Javax.Tools.JavaFileObject.Kind ValueOf(string arg0)
            {
                return SExecute<Javax.Tools.JavaFileObject.Kind>(LocalClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}