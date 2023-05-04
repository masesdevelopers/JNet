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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Instrument
{
    #region Instrumentation
    public partial class Instrumentation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#getAllLoadedClasses()"/> 
        /// </summary>
        public Java.Lang.Class[] AllLoadedClasses
        {
            get { return IExecuteArray<Java.Lang.Class>("getAllLoadedClasses"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#isNativeMethodPrefixSupported()"/> 
        /// </summary>
        public bool IsNativeMethodPrefixSupported
        {
            get { return IExecute<bool>("isNativeMethodPrefixSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#isRedefineClassesSupported()"/> 
        /// </summary>
        public bool IsRedefineClassesSupported
        {
            get { return IExecute<bool>("isRedefineClassesSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#isRetransformClassesSupported()"/> 
        /// </summary>
        public bool IsRetransformClassesSupported
        {
            get { return IExecute<bool>("isRetransformClassesSupported"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#isModifiableClass(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsModifiableClass(Java.Lang.Class arg0)
        {
            return IExecute<bool>("isModifiableClass", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#isModifiableModule(java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsModifiableModule(Java.Lang.Module arg0)
        {
            return IExecute<bool>("isModifiableModule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#removeTransformer(java.lang.instrument.ClassFileTransformer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Instrument.ClassFileTransformer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveTransformer(Java.Lang.Instrument.ClassFileTransformer arg0)
        {
            return IExecute<bool>("removeTransformer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#getInitiatedClasses(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class[] GetInitiatedClasses(Java.Lang.ClassLoader arg0)
        {
            return IExecuteArray<Java.Lang.Class>("getInitiatedClasses", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#getObjectSize(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetObjectSize(object arg0)
        {
            return IExecute<long>("getObjectSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#addTransformer(java.lang.instrument.ClassFileTransformer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Instrument.ClassFileTransformer"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void AddTransformer(Java.Lang.Instrument.ClassFileTransformer arg0, bool arg1)
        {
            IExecute("addTransformer", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#addTransformer(java.lang.instrument.ClassFileTransformer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Instrument.ClassFileTransformer"/></param>
        public void AddTransformer(Java.Lang.Instrument.ClassFileTransformer arg0)
        {
            IExecute("addTransformer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#appendToBootstrapClassLoaderSearch(java.util.jar.JarFile)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.JarFile"/></param>
        public void AppendToBootstrapClassLoaderSearch(Java.Util.Jar.JarFile arg0)
        {
            IExecute("appendToBootstrapClassLoaderSearch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#appendToSystemClassLoaderSearch(java.util.jar.JarFile)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.JarFile"/></param>
        public void AppendToSystemClassLoaderSearch(Java.Util.Jar.JarFile arg0)
        {
            IExecute("appendToSystemClassLoaderSearch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#redefineClasses(java.lang.instrument.ClassDefinition[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Instrument.ClassDefinition"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.Instrument.UnmodifiableClassException"/>
        public void RedefineClasses(params Java.Lang.Instrument.ClassDefinition[] arg0)
        {
            if (arg0.Length == 0) IExecute("redefineClasses"); else IExecute("redefineClasses", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#redefineModule(java.lang.Module,java.util.Set,java.util.Map,java.util.Map,java.util.Set,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg4Extendsobject"></typeparam>
        /// <typeparam name="Arg5Extendsobject"></typeparam>
        public void RedefineModule<Arg4Extendsobject, Arg5Extendsobject>(Java.Lang.Module arg0, Java.Util.Set<Java.Lang.Module> arg1, Java.Util.Map<string, Java.Util.Set<Java.Lang.Module>> arg2, Java.Util.Map<string, Java.Util.Set<Java.Lang.Module>> arg3, Java.Util.Set<Java.Lang.Class> arg4, Java.Util.Map<Java.Lang.Class, Java.Util.List<Java.Lang.Class>> arg5)
        {
            IExecute("redefineModule", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#retransformClasses(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <exception cref="Java.Lang.Instrument.UnmodifiableClassException"/>
        public void RetransformClasses<Arg0Extendsobject>(params Java.Lang.Class[] arg0)
        {
            if (arg0.Length == 0) IExecute("retransformClasses"); else IExecute("retransformClasses", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.instrument/java/lang/instrument/Instrumentation.html#setNativeMethodPrefix(java.lang.instrument.ClassFileTransformer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Instrument.ClassFileTransformer"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void SetNativeMethodPrefix(Java.Lang.Instrument.ClassFileTransformer arg0, string arg1)
        {
            IExecute("setNativeMethodPrefix", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}