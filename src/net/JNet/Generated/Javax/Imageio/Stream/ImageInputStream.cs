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

namespace Javax.Imageio.Stream
{
    #region ImageInputStream declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html"/>
    /// </summary>
    public partial class ImageInputStream : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageInputStream>
    {
        const string _bridgeClassName = "javax.imageio.stream.ImageInputStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageInputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageInputStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageInputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageInputStream(params object[] args) : base(args) { }

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

    #region IImageInputStream
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IImageInputStream
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getBitOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setBitOffset(int)"/>
        /// </summary>
        int BitOffset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getByteOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setByteOrder(java.nio.ByteOrder)"/>
        /// </summary>
        Java.Nio.ByteOrder ByteOrder { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getFlushedPosition()"/> 
        /// </summary>
        long FlushedPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getStreamPosition()"/> 
        /// </summary>
        long StreamPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCached();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCachedFile();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedMemory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCachedMemory();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        bool ReadBoolean();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        byte ReadByte();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        char ReadChar();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        double ReadDouble();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        float ReadFloat();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadBit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadInt();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedByte();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedShort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int SkipBytes(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadLine();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadUTF();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long Length();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadBits(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadLong();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedInt()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadUnsignedInt();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long SkipBytes(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        short ReadShort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void FlushBefore(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#mark()"/>
        /// </summary>
        void Mark();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBytes(javax.imageio.stream.IIOByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.IIOByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadBytes(Javax.Imageio.Stream.IIOByteBuffer arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(char[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(double[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(float[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(int[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(long[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(short[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Reset();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#seek(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Seek(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageInputStream implementation
    public partial class ImageInputStream : Javax.Imageio.Stream.IImageInputStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageInputStream"/> to <see cref="Java.Io.DataInput"/>
        /// </summary>
        public static implicit operator Java.Io.DataInput(Javax.Imageio.Stream.ImageInputStream t) => t.Cast<Java.Io.DataInput>();
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageInputStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Javax.Imageio.Stream.ImageInputStream t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getBitOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setBitOffset(int)"/>
        /// </summary>
        public int BitOffset
        {
            get { return IExecute<int>("getBitOffset"); } set { IExecute("setBitOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getByteOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setByteOrder(java.nio.ByteOrder)"/>
        /// </summary>
        public Java.Nio.ByteOrder ByteOrder
        {
            get { return IExecute<Java.Nio.ByteOrder>("getByteOrder"); } set { IExecute("setByteOrder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getFlushedPosition()"/> 
        /// </summary>
        public long FlushedPosition
        {
            get { return IExecute<long>("getFlushedPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getStreamPosition()"/> 
        /// </summary>
        public long StreamPosition
        {
            get { return IExecute<long>("getStreamPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCached()
        {
            return IExecute<bool>("isCached");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCachedFile()
        {
            return IExecute<bool>("isCachedFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedMemory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCachedMemory()
        {
            return IExecute<bool>("isCachedMemory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecute<bool>("readBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecute<char>("readChar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecute<float>("readFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read()
        {
            return IExecute<int>("read");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0)
        {
            return IExecute<int>("read", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadBit()
        {
            return IExecute<int>("readBit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecute<int>("readUnsignedByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecute<int>("readUnsignedShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecute<int>("skipBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadLine()
        {
            return IExecute<Java.Lang.String>("readLine");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecute<Java.Lang.String>("readUTF");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Length()
        {
            return IExecute<long>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadBits(int arg0)
        {
            return IExecute<long>("readBits", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedInt()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadUnsignedInt()
        {
            return IExecute<long>("readUnsignedInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long SkipBytes(long arg0)
        {
            return IExecute<long>("skipBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void FlushBefore(long arg0)
        {
            IExecute("flushBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#mark()"/>
        /// </summary>
        public void Mark()
        {
            IExecute("mark");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBytes(javax.imageio.stream.IIOByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.IIOByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadBytes(Javax.Imageio.Stream.IIOByteBuffer arg0, int arg1)
        {
            IExecute("readBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecute("readFully", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(char[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(double[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(float[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(int[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(long[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(short[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#seek(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Seek(long arg0)
        {
            IExecute("seek", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}