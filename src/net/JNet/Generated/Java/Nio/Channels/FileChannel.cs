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

namespace Java.Nio.Channels
{
    #region FileChannel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html"/>
    /// </summary>
    public partial class FileChannel : Java.Nio.Channels.Spi.AbstractInterruptibleChannel
    {
        const string _bridgeClassName = "java.nio.channels.FileChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FileChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FileChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FileChannel(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region MapMode declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.MapMode.html"/>
        /// </summary>
        public partial class MapMode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MapMode>
        {
            const string _bridgeClassName = "java.nio.channels.FileChannel$MapMode";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MapMode() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MapMode(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region FileChannel implementation
    public partial class FileChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.FileChannel"/> to <see cref="Java.Nio.Channels.SeekableByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.SeekableByteChannel(Java.Nio.Channels.FileChannel t) => t.Cast<Java.Nio.Channels.SeekableByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.FileChannel"/> to <see cref="Java.Nio.Channels.GatheringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.GatheringByteChannel(Java.Nio.Channels.FileChannel t) => t.Cast<Java.Nio.Channels.GatheringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.FileChannel"/> to <see cref="Java.Nio.Channels.ScatteringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ScatteringByteChannel(Java.Nio.Channels.FileChannel t) => t.Cast<Java.Nio.Channels.ScatteringByteChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#open(java.nio.file.Path,java.nio.file.OpenOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.OpenOption"/></param>
        /// <returns><see cref="Java.Nio.Channels.FileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.FileChannel Open(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Nio.Channels.FileChannel>(LocalBridgeClazz, "open", arg0); else return SExecute<Java.Nio.Channels.FileChannel>(LocalBridgeClazz, "open", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#open(java.nio.file.Path,java.util.Set,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.FileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.FileChannel Open<Arg1ExtendsJava_Nio_File_OpenOption>(Java.Nio.File.Path arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, params Java.Nio.File.Attribute.FileAttribute<object>[] arg2) where Arg1ExtendsJava_Nio_File_OpenOption : Java.Nio.File.OpenOption
        {
            if (arg2.Length == 0) return SExecute<Java.Nio.Channels.FileChannel>(LocalBridgeClazz, "open", arg0, arg1); else return SExecute<Java.Nio.Channels.FileChannel>(LocalBridgeClazz, "open", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#read(java.nio.ByteBuffer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.ByteBuffer arg0, long arg1)
        {
            return IExecute<int>("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#write(java.nio.ByteBuffer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Nio.ByteBuffer arg0, long arg1)
        {
            return IExecute<int>("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#lock(long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock Lock(long arg0, long arg1, bool arg2)
        {
            return IExecute<Java.Nio.Channels.FileLock>("lock", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#tryLock(long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock TryLock(long arg0, long arg1, bool arg2)
        {
            return IExecute<Java.Nio.Channels.FileLock>("tryLock", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#map(java.nio.channels.FileChannel.MapMode,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.FileChannel.MapMode"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.MappedByteBuffer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.MappedByteBuffer Map(Java.Nio.Channels.FileChannel.MapMode arg0, long arg1, long arg2)
        {
            return IExecute<Java.Nio.MappedByteBuffer>("map", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#position()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Position()
        {
            return IExecuteWithSignature<long>("position", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#transferFrom(java.nio.channels.ReadableByteChannel,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long TransferFrom(Java.Nio.Channels.ReadableByteChannel arg0, long arg1, long arg2)
        {
            return IExecute<long>("transferFrom", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#transferTo(long,long,java.nio.channels.WritableByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.WritableByteChannel"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long TransferTo(long arg0, long arg1, Java.Nio.Channels.WritableByteChannel arg2)
        {
            return IExecute<long>("transferTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#write(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#force(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Force(bool arg0)
        {
            IExecuteWithSignature("force", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#lock()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock Lock()
        {
            return IExecuteWithSignature<Java.Nio.Channels.FileLock>("lock", "()Ljava/nio/channels/FileLock;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#tryLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock TryLock()
        {
            return IExecuteWithSignature<Java.Nio.Channels.FileLock>("tryLock", "()Ljava/nio/channels/FileLock;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("read", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#write(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("write", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#position(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SeekableByteChannel Position(long arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.SeekableByteChannel>("position", "(J)Ljava/nio/channels/SeekableByteChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.html#truncate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.Channels.SeekableByteChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SeekableByteChannel Truncate(long arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.SeekableByteChannel>("truncate", "(J)Ljava/nio/channels/SeekableByteChannel;", arg0);
        }

        #endregion

        #region Nested classes
        #region MapMode implementation
        public partial class MapMode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.MapMode.html#PRIVATE"/>
            /// </summary>
            public static Java.Nio.Channels.FileChannel.MapMode PRIVATE { get { if (!_PRIVATEReady) { _PRIVATEContent = SGetField<Java.Nio.Channels.FileChannel.MapMode>(LocalBridgeClazz, "PRIVATE"); _PRIVATEReady = true; } return _PRIVATEContent; } }
            private static Java.Nio.Channels.FileChannel.MapMode _PRIVATEContent = default;
            private static bool _PRIVATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.MapMode.html#READ_ONLY"/>
            /// </summary>
            public static Java.Nio.Channels.FileChannel.MapMode READ_ONLY { get { if (!_READ_ONLYReady) { _READ_ONLYContent = SGetField<Java.Nio.Channels.FileChannel.MapMode>(LocalBridgeClazz, "READ_ONLY"); _READ_ONLYReady = true; } return _READ_ONLYContent; } }
            private static Java.Nio.Channels.FileChannel.MapMode _READ_ONLYContent = default;
            private static bool _READ_ONLYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/FileChannel.MapMode.html#READ_WRITE"/>
            /// </summary>
            public static Java.Nio.Channels.FileChannel.MapMode READ_WRITE { get { if (!_READ_WRITEReady) { _READ_WRITEContent = SGetField<Java.Nio.Channels.FileChannel.MapMode>(LocalBridgeClazz, "READ_WRITE"); _READ_WRITEReady = true; } return _READ_WRITEContent; } }
            private static Java.Nio.Channels.FileChannel.MapMode _READ_WRITEContent = default;
            private static bool _READ_WRITEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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