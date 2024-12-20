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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Stream
{
    #region ImageOutputStream declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html"/>
    /// </summary>
    public partial class ImageOutputStream : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageOutputStream>
    {
        const string _bridgeClassName = "javax.imageio.stream.ImageOutputStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageOutputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageOutputStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageOutputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageOutputStream(params object[] args) : base(args) { }

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

    #region IImageOutputStream
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IImageOutputStream
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void FlushBefore(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Write(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Write(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Write(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteBit(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBits(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteBits(long arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBoolean(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteBoolean(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteByte(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteBytes(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteChar(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChars(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteChars(char[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChars(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteChars(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteDouble(double arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeDoubles(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteDoubles(double[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteFloat(float arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeFloats(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteFloats(float[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteInt(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeInts(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteInts(int[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteLong(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeLongs(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteLongs(long[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteShort(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeShorts(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteShorts(short[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeUTF(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void WriteUTF(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageOutputStream implementation
    public partial class ImageOutputStream : Javax.Imageio.Stream.IImageOutputStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageOutputStream"/> to <see cref="Javax.Imageio.Stream.ImageInputStream"/>
        /// </summary>
        public static implicit operator Javax.Imageio.Stream.ImageInputStream(Javax.Imageio.Stream.ImageOutputStream t) => t.Cast<Javax.Imageio.Stream.ImageInputStream>();
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageOutputStream"/> to <see cref="Java.Io.DataOutput"/>
        /// </summary>
        public static implicit operator Java.Io.DataOutput(Javax.Imageio.Stream.ImageOutputStream t) => t.Cast<Java.Io.DataOutput>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void FlushBefore(long arg0)
        {
            IExecuteWithSignature("flushBefore", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("write", "([BII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecuteWithSignature("write", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(int arg0)
        {
            IExecuteWithSignature("write", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBit(int arg0)
        {
            IExecuteWithSignature("writeBit", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBits(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBits(long arg0, int arg1)
        {
            IExecuteWithSignature("writeBits", "(JI)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBoolean(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBoolean(bool arg0)
        {
            IExecuteWithSignature("writeBoolean", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteByte(int arg0)
        {
            IExecuteWithSignature("writeByte", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBytes(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeBytes", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChar(int arg0)
        {
            IExecuteWithSignature("writeChar", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChars(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChars(char[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeChars", "([CII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeChars(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChars(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeChars", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteDouble(double arg0)
        {
            IExecuteWithSignature("writeDouble", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeDoubles(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteDoubles(double[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeDoubles", "([DII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteFloat(float arg0)
        {
            IExecuteWithSignature("writeFloat", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeFloats(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteFloats(float[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeFloats", "([FII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInt(int arg0)
        {
            IExecuteWithSignature("writeInt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeInts(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInts(int[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeInts", "([III)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteLong(long arg0)
        {
            IExecuteWithSignature("writeLong", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeLongs(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteLongs(long[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeLongs", "([JII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteShort(int arg0)
        {
            IExecuteWithSignature("writeShort", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeShorts(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteShorts(short[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("writeShorts", "([SII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageOutputStream.html#writeUTF(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteUTF(Java.Lang.String arg0)
        {
            IExecuteWithSignature("writeUTF", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}