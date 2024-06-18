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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File
{
    #region FileVisitor
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
            return IExecute<Java.Nio.File.FileVisitResult>("postVisitDirectory", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("preVisitDirectory", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("visitFile", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("visitFileFailed", arg0, arg1);
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

    #region FileVisitor<T>
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
            return IExecute<Java.Nio.File.FileVisitResult>("postVisitDirectory", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("preVisitDirectory", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("visitFile", arg0, arg1);
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
            return IExecute<Java.Nio.File.FileVisitResult>("visitFileFailed", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}