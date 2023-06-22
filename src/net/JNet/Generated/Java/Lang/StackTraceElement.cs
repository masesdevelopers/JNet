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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region StackTraceElement
    public partial class StackTraceElement
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public StackTraceElement(string arg0, string arg1, string arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public StackTraceElement(string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getClassLoaderName()"/> 
        /// </summary>
        public string ClassLoaderName
        {
            get { return IExecute<string>("getClassLoaderName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getClassName()"/> 
        /// </summary>
        public string ClassName
        {
            get { return IExecute<string>("getClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getFileName()"/> 
        /// </summary>
        public string FileName
        {
            get { return IExecute<string>("getFileName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getLineNumber()"/> 
        /// </summary>
        public int LineNumber
        {
            get { return IExecute<int>("getLineNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getMethodName()"/> 
        /// </summary>
        public string MethodName
        {
            get { return IExecute<string>("getMethodName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getModuleName()"/> 
        /// </summary>
        public string ModuleName
        {
            get { return IExecute<string>("getModuleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#getModuleVersion()"/> 
        /// </summary>
        public string ModuleVersion
        {
            get { return IExecute<string>("getModuleVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackTraceElement.html#isNativeMethod()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNativeMethod()
        {
            return IExecute<bool>("isNativeMethod");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}