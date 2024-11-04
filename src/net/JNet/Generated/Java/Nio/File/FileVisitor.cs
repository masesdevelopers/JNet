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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File
{
    #region FileVisitor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html"/>
    /// </summary>
    public partial class FileVisitor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FileVisitor>
    {
        const string _bridgeClassName = "java.nio.file.FileVisitor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FileVisitor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileVisitor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FileVisitor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileVisitor(params object[] args) : base(args) { }

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

    #region FileVisitor<T> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class FileVisitor<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FileVisitor<T>>
    {
        const string _bridgeClassName = "java.nio.file.FileVisitor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FileVisitor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileVisitor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FileVisitor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileVisitor(params object[] args) : base(args) { }

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

    #region FileVisitor implementation
    public partial class FileVisitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#postVisitDirectory(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PostVisitDirectory(object arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#preVisitDirectory(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PreVisitDirectory(object arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFile(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFile(object arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFileFailed(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFileFailed(object arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IFileVisitor<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFileVisitor<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#postVisitDirectory(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.FileVisitResult PostVisitDirectory(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#preVisitDirectory(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.FileVisitResult PreVisitDirectory(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFile(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.FileVisitResult VisitFile(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFileFailed(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.FileVisitResult VisitFileFailed(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FileVisitor<T> implementation
    public partial class FileVisitor<T> : Java.Nio.File.IFileVisitor<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.FileVisitor{T}"/> to <see cref="Java.Nio.File.FileVisitor"/>
        /// </summary>
        public static implicit operator Java.Nio.File.FileVisitor(Java.Nio.File.FileVisitor<T> t) => t.Cast<Java.Nio.File.FileVisitor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#postVisitDirectory(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PostVisitDirectory(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#preVisitDirectory(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult PreVisitDirectory(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFile(java.lang.Object,java.nio.file.attribute.BasicFileAttributes)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFile(T arg0, Java.Nio.File.Attribute.BasicFileAttributes arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitor.html#visitFileFailed(java.lang.Object,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Io.IOException"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.FileVisitResult VisitFileFailed(T arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecuteWithSignature<Java.Nio.File.FileVisitResult>("visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}