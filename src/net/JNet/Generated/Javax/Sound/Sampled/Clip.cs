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

namespace Javax.Sound.Sampled
{
    #region Clip declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html"/>
    /// </summary>
    public partial class Clip : Javax.Sound.Sampled.DataLine
    {
        const string _bridgeClassName = "javax.sound.sampled.Clip";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Clip class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clip() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Clip class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clip(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region IClip
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClip : Javax.Sound.Sampled.IDataLine
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getFrameLength()"/> 
        /// </summary>
        int FrameLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getMicrosecondLength()"/> 
        /// </summary>
        long MicrosecondLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#loop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void Loop(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioFormat,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        void Open(Javax.Sound.Sampled.AudioFormat arg0, byte[] arg1, int arg2, int arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        /// <exception cref="Java.Io.IOException"/>
        void Open(Javax.Sound.Sampled.AudioInputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setFramePosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void SetFramePosition(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setLoopPoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void SetLoopPoints(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setMicrosecondPosition(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        void SetMicrosecondPosition(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Clip implementation
    public partial class Clip : Javax.Sound.Sampled.IClip
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#LOOP_CONTINUOUSLY"/>
        /// </summary>
        public static int LOOP_CONTINUOUSLY { get { if (!_LOOP_CONTINUOUSLYReady) { _LOOP_CONTINUOUSLYContent = SGetField<int>(LocalBridgeClazz, "LOOP_CONTINUOUSLY"); _LOOP_CONTINUOUSLYReady = true; } return _LOOP_CONTINUOUSLYContent; } }
        private static int _LOOP_CONTINUOUSLYContent = default;
        private static bool _LOOP_CONTINUOUSLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getFrameLength()"/> 
        /// </summary>
        public int FrameLength
        {
            get { return IExecuteWithSignature<int>("getFrameLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#getMicrosecondLength()"/> 
        /// </summary>
        public long MicrosecondLength
        {
            get { return IExecuteWithSignature<long>("getMicrosecondLength", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#loop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Loop(int arg0)
        {
            IExecuteWithSignature("loop", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioFormat,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public void Open(Javax.Sound.Sampled.AudioFormat arg0, byte[] arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("open", "(Ljavax/sound/sampled/AudioFormat;[BII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#open(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Open(Javax.Sound.Sampled.AudioInputStream arg0)
        {
            IExecuteWithSignature("open", "(Ljavax/sound/sampled/AudioInputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setFramePosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFramePosition(int arg0)
        {
            IExecuteWithSignature("setFramePosition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setLoopPoints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLoopPoints(int arg0, int arg1)
        {
            IExecuteWithSignature("setLoopPoints", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Clip.html#setMicrosecondPosition(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMicrosecondPosition(long arg0)
        {
            IExecuteWithSignature("setMicrosecondPosition", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}