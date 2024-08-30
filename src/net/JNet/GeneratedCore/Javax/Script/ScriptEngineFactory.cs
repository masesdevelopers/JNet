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

namespace Javax.Script
{
    #region IScriptEngineFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScriptEngineFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineName()"/> 
        /// </summary>
        Java.Lang.String EngineName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineVersion()"/> 
        /// </summary>
        Java.Lang.String EngineVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getExtensions()"/> 
        /// </summary>
        Java.Util.List<Java.Lang.String> Extensions { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageName()"/> 
        /// </summary>
        Java.Lang.String LanguageName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageVersion()"/> 
        /// </summary>
        Java.Lang.String LanguageVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMimeTypes()"/> 
        /// </summary>
        Java.Util.List<Java.Lang.String> MimeTypes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getNames()"/> 
        /// </summary>
        Java.Util.List<Java.Lang.String> Names { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getScriptEngine()"/> 
        /// </summary>
        Javax.Script.ScriptEngine ScriptEngine { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetParameter(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMethodCallSyntax(java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetMethodCallSyntax(Java.Lang.String arg0, Java.Lang.String arg1, params Java.Lang.String[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getOutputStatement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetOutputStatement(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getProgram(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetProgram(params Java.Lang.String[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScriptEngineFactory
    public partial class ScriptEngineFactory : Javax.Script.IScriptEngineFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineName()"/> 
        /// </summary>
        public Java.Lang.String EngineName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEngineName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getEngineVersion()"/> 
        /// </summary>
        public Java.Lang.String EngineVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEngineVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getExtensions()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> Extensions
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getExtensions", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageName()"/> 
        /// </summary>
        public Java.Lang.String LanguageName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLanguageName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getLanguageVersion()"/> 
        /// </summary>
        public Java.Lang.String LanguageVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLanguageVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMimeTypes()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> MimeTypes
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getMimeTypes", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getNames()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> Names
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getNames", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getScriptEngine()"/> 
        /// </summary>
        public Javax.Script.ScriptEngine ScriptEngine
        {
            get { return IExecuteWithSignature<Javax.Script.ScriptEngine>("getScriptEngine", "()Ljavax/script/ScriptEngine;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getMethodCallSyntax(java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMethodCallSyntax(Java.Lang.String arg0, Java.Lang.String arg1, params Java.Lang.String[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Lang.String>("getMethodCallSyntax", arg0, arg1); else return IExecute<Java.Lang.String>("getMethodCallSyntax", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getOutputStatement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOutputStatement(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getOutputStatement", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html#getProgram(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProgram(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.String>("getProgram", "([Ljava/lang/String;)Ljava/lang/String;"); else return IExecuteWithSignature<Java.Lang.String>("getProgram", "([Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}