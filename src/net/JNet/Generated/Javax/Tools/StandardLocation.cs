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
    #region StandardLocation
    public partial class StandardLocation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_MODULE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("ANNOTATION_PROCESSOR_MODULE_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("ANNOTATION_PROCESSOR_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_OUTPUT { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("CLASS_OUTPUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("CLASS_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("MODULE_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_SOURCE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("MODULE_SOURCE_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#NATIVE_HEADER_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation NATIVE_HEADER_OUTPUT { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("NATIVE_HEADER_OUTPUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PATCH_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PATCH_MODULE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("PATCH_MODULE_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PLATFORM_CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PLATFORM_CLASS_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("PLATFORM_CLASS_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_OUTPUT { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("SOURCE_OUTPUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("SOURCE_PATH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SYSTEM_MODULES"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SYSTEM_MODULES { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("SYSTEM_MODULES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#UPGRADE_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation UPGRADE_MODULE_PATH { get { return LocalClazz.GetField<Javax.Tools.StandardLocation>("UPGRADE_MODULE_PATH"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#values()"/> 
        /// </summary>
        public static Javax.Tools.StandardLocation[] Values
        {
            get { return SExecuteArray<Javax.Tools.StandardLocation>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#locationFor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        public static Javax.Tools.JavaFileManager.Location LocationFor(string arg0)
        {
            return SExecute<Javax.Tools.JavaFileManager.Location>(LocalClazz, "locationFor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Tools.StandardLocation"/></returns>
        public static Javax.Tools.StandardLocation ValueOf(string arg0)
        {
            return SExecute<Javax.Tools.StandardLocation>(LocalClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isModuleOrientedLocation()"/> 
        /// </summary>
        public bool IsModuleOrientedLocation
        {
            get { return IExecute<bool>("isModuleOrientedLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isOutputLocation()"/> 
        /// </summary>
        public bool IsOutputLocation
        {
            get { return IExecute<bool>("isOutputLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}