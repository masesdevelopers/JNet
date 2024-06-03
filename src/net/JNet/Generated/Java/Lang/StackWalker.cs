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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region StackWalker
    public partial class StackWalker
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance()"/> 
        /// </summary>
        public static Java.Lang.StackWalker Instance
        {
            get { return SExecuteWithSignature<Java.Lang.StackWalker>(LocalBridgeClazz, "getInstance", "()Ljava/lang/StackWalker;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.lang.StackWalker.Option)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StackWalker.Option"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Lang.StackWalker.Option arg0)
        {
            return SExecuteWithSignature<Java.Lang.StackWalker>(LocalBridgeClazz, "getInstance", "(Ljava/lang/StackWalker$Option;)Ljava/lang/StackWalker;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.util.Set,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Util.Set<Java.Lang.StackWalker.Option> arg0, int arg1)
        {
            return SExecute<Java.Lang.StackWalker>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Util.Set<Java.Lang.StackWalker.Option> arg0)
        {
            return SExecuteWithSignature<Java.Lang.StackWalker>(LocalBridgeClazz, "getInstance", "(Ljava/util/Set;)Ljava/lang/StackWalker;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getCallerClass()"/> 
        /// </summary>
        public Java.Lang.Class CallerClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCallerClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#walk(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_"><see cref="Java.Util.Stream.Stream{Java.Lang.StackWalker.StackFrame}"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Walk<T, Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_, Arg0ExtendsT> arg0) where Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_ : Java.Util.Stream.Stream<Java.Lang.StackWalker.StackFrame> where Arg0ExtendsT : T
        {
            return IExecuteWithSignature<T>("walk", "(Ljava/util/function/Function;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperJava_Lang_StackWalker_StackFrame"><see cref="Java.Lang.StackWalker.StackFrame"/></typeparam>
        public void ForEach<Arg0objectSuperJava_Lang_StackWalker_StackFrame>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_StackWalker_StackFrame> arg0) where Arg0objectSuperJava_Lang_StackWalker_StackFrame : Java.Lang.StackWalker.StackFrame
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Option
        public partial class Option
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#RETAIN_CLASS_REFERENCE"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option RETAIN_CLASS_REFERENCE { get { if (!_RETAIN_CLASS_REFERENCEReady) { _RETAIN_CLASS_REFERENCEContent = SGetField<Java.Lang.StackWalker.Option>(LocalBridgeClazz, "RETAIN_CLASS_REFERENCE"); _RETAIN_CLASS_REFERENCEReady = true; } return _RETAIN_CLASS_REFERENCEContent; } }
            private static Java.Lang.StackWalker.Option _RETAIN_CLASS_REFERENCEContent = default;
            private static bool _RETAIN_CLASS_REFERENCEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#SHOW_HIDDEN_FRAMES"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option SHOW_HIDDEN_FRAMES { get { if (!_SHOW_HIDDEN_FRAMESReady) { _SHOW_HIDDEN_FRAMESContent = SGetField<Java.Lang.StackWalker.Option>(LocalBridgeClazz, "SHOW_HIDDEN_FRAMES"); _SHOW_HIDDEN_FRAMESReady = true; } return _SHOW_HIDDEN_FRAMESContent; } }
            private static Java.Lang.StackWalker.Option _SHOW_HIDDEN_FRAMESContent = default;
            private static bool _SHOW_HIDDEN_FRAMESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#SHOW_REFLECT_FRAMES"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option SHOW_REFLECT_FRAMES { get { if (!_SHOW_REFLECT_FRAMESReady) { _SHOW_REFLECT_FRAMESContent = SGetField<Java.Lang.StackWalker.Option>(LocalBridgeClazz, "SHOW_REFLECT_FRAMES"); _SHOW_REFLECT_FRAMESReady = true; } return _SHOW_REFLECT_FRAMESContent; } }
            private static Java.Lang.StackWalker.Option _SHOW_REFLECT_FRAMESContent = default;
            private static bool _SHOW_REFLECT_FRAMESReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.StackWalker.Option"/></returns>
            public static Java.Lang.StackWalker.Option ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Lang.StackWalker.Option>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/StackWalker$Option;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.StackWalker.Option"/></returns>
            public static Java.Lang.StackWalker.Option[] Values()
            {
                return SExecuteWithSignatureArray<Java.Lang.StackWalker.Option>(LocalBridgeClazz, "values", "()[Ljava/lang/StackWalker$Option;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StackFrame
        public partial class StackFrame
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getByteCodeIndex()"/> 
            /// </summary>
            public int ByteCodeIndex
            {
                get { return IExecuteWithSignature<int>("getByteCodeIndex", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getClassName()"/> 
            /// </summary>
            public Java.Lang.String ClassName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getDeclaringClass()"/> 
            /// </summary>
            public Java.Lang.Class DeclaringClass
            {
                get { return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getDescriptor()"/> 
            /// </summary>
            public Java.Lang.String Descriptor
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getDescriptor", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getFileName()"/> 
            /// </summary>
            public Java.Lang.String FileName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getFileName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getLineNumber()"/> 
            /// </summary>
            public int LineNumber
            {
                get { return IExecuteWithSignature<int>("getLineNumber", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getMethodName()"/> 
            /// </summary>
            public Java.Lang.String MethodName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getMethodName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getMethodType()"/> 
            /// </summary>
            public Java.Lang.Invoke.MethodType MethodType
            {
                get { return IExecuteWithSignature<Java.Lang.Invoke.MethodType>("getMethodType", "()Ljava/lang/invoke/MethodType;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#isNativeMethod()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsNativeMethod()
            {
                return IExecuteWithSignature<bool>("isNativeMethod", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#toStackTraceElement()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.StackTraceElement"/></returns>
            public Java.Lang.StackTraceElement ToStackTraceElement()
            {
                return IExecuteWithSignature<Java.Lang.StackTraceElement>("toStackTraceElement", "()Ljava/lang/StackTraceElement;");
            }

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