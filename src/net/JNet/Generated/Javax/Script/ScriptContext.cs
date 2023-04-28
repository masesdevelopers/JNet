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

namespace Javax.Script
{
    #region ScriptContext
    public partial class ScriptContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#ENGINE_SCOPE"/>
        /// </summary>
        public static int ENGINE_SCOPE { get { return LocalClazz.GetField<int>("ENGINE_SCOPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#GLOBAL_SCOPE"/>
        /// </summary>
        public static int GLOBAL_SCOPE { get { return LocalClazz.GetField<int>("GLOBAL_SCOPE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getErrorWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#setErrorWriter(java.io.Writer)"/>
        /// </summary>
        public Java.Io.Writer ErrorWriter
        {
            get { return IExecute<Java.Io.Writer>("getErrorWriter"); } set { IExecute("setErrorWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getReader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#setReader(java.io.Reader)"/>
        /// </summary>
        public Java.Io.Reader Reader
        {
            get { return IExecute<Java.Io.Reader>("getReader"); } set { IExecute("setReader", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getScopes()"/> 
        /// </summary>
        public Java.Util.List<int?> Scopes
        {
            get { return IExecute<Java.Util.List<int?>>("getScopes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#setWriter(java.io.Writer)"/>
        /// </summary>
        public Java.Io.Writer Writer
        {
            get { return IExecute<Java.Io.Writer>("getWriter"); } set { IExecute("setWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getAttributesScope(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributesScope(string arg0)
        {
            return IExecute<int>("getAttributesScope", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getAttribute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(string arg0, int arg1)
        {
            return IExecute("getAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#removeAttribute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object RemoveAttribute(string arg0, int arg1)
        {
            return IExecute("removeAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#getBindings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings GetBindings(int arg0)
        {
            return IExecute<Javax.Script.Bindings>("getBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#setAttribute(java.lang.String,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetAttribute(string arg0, object arg1, int arg2)
        {
            IExecute("setAttribute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html#setBindings(javax.script.Bindings,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.Bindings"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetBindings(Javax.Script.Bindings arg0, int arg1)
        {
            IExecute("setBindings", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}