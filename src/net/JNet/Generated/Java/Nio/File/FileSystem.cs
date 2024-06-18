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
    #region FileSystem
    public partial class FileSystem
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getFileStores()"/> 
        /// </summary>
        public Java.Lang.Iterable<Java.Nio.File.FileStore> FileStores
        {
            get { return IExecuteWithSignature<Java.Lang.Iterable<Java.Nio.File.FileStore>>("getFileStores", "()Ljava/lang/Iterable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getRootDirectories()"/> 
        /// </summary>
        public Java.Lang.Iterable<Java.Nio.File.Path> RootDirectories
        {
            get { return IExecuteWithSignature<Java.Lang.Iterable<Java.Nio.File.Path>>("getRootDirectories", "()Ljava/lang/Iterable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getSeparator()"/> 
        /// </summary>
        public Java.Lang.String Separator
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSeparator", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getUserPrincipalLookupService()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.UserPrincipalLookupService UserPrincipalLookupService
        {
            get { return IExecuteWithSignature<Java.Nio.File.Attribute.UserPrincipalLookupService>("getUserPrincipalLookupService", "()Ljava/nio/file/attribute/UserPrincipalLookupService;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getPath(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path GetPath(Java.Lang.String arg0, params Java.Lang.String[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.Path>("getPath", arg0); else return IExecute<Java.Nio.File.Path>("getPath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#getPathMatcher(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.PathMatcher"/></returns>
        public Java.Nio.File.PathMatcher GetPathMatcher(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.PathMatcher>("getPathMatcher", "(Ljava/lang/String;)Ljava/nio/file/PathMatcher;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Spi.FileSystemProvider"/></returns>
        public Java.Nio.File.Spi.FileSystemProvider Provider()
        {
            return IExecuteWithSignature<Java.Nio.File.Spi.FileSystemProvider>("provider", "()Ljava/nio/file/spi/FileSystemProvider;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#newWatchService()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.WatchService"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchService NewWatchService()
        {
            return IExecuteWithSignature<Java.Nio.File.WatchService>("newWatchService", "()Ljava/nio/file/WatchService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#supportedFileAttributeViews()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> SupportedFileAttributeViews()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("supportedFileAttributeViews", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystem.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}