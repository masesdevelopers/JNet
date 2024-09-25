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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region BasicFileAttributes declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html"/>
    /// </summary>
    public partial class BasicFileAttributes : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BasicFileAttributes>
    {
        const string _bridgeClassName = "java.nio.file.attribute.BasicFileAttributes";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BasicFileAttributes class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BasicFileAttributes() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BasicFileAttributes class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BasicFileAttributes(params object[] args) : base(args) { }

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

    #region IBasicFileAttributes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBasicFileAttributes
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsDirectory();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isOther()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsOther();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isRegularFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsRegularFile();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isSymbolicLink()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSymbolicLink();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#fileKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        object FileKey();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#creationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        Java.Nio.File.Attribute.FileTime CreationTime();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastAccessTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        Java.Nio.File.Attribute.FileTime LastAccessTime();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastModifiedTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        Java.Nio.File.Attribute.FileTime LastModifiedTime();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        long Size();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BasicFileAttributes implementation
    public partial class BasicFileAttributes : Java.Nio.File.Attribute.IBasicFileAttributes
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecute<bool>("isDirectory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isOther()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOther()
        {
            return IExecute<bool>("isOther");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isRegularFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegularFile()
        {
            return IExecute<bool>("isRegularFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#isSymbolicLink()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSymbolicLink()
        {
            return IExecute<bool>("isSymbolicLink");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#fileKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FileKey()
        {
            return IExecute("fileKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#creationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime CreationTime()
        {
            return IExecute<Java.Nio.File.Attribute.FileTime>("creationTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastAccessTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime LastAccessTime()
        {
            return IExecute<Java.Nio.File.Attribute.FileTime>("lastAccessTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastModifiedTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime LastModifiedTime()
        {
            return IExecute<Java.Nio.File.Attribute.FileTime>("lastModifiedTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/BasicFileAttributes.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecute<long>("size");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}