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

namespace Javax.Sound.Sampled
{
    #region AudioSystem declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html"/>
    /// </summary>
    public partial class AudioSystem : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AudioSystem>
    {
        const string _bridgeClassName = "javax.sound.sampled.AudioSystem";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AudioSystem() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AudioSystem(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AudioSystem implementation
    public partial class AudioSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#NOT_SPECIFIED"/>
        /// </summary>
        public static int NOT_SPECIFIED { get { if (!_NOT_SPECIFIEDReady) { _NOT_SPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "NOT_SPECIFIED"); _NOT_SPECIFIEDReady = true; } return _NOT_SPECIFIEDContent; } }
        private static int _NOT_SPECIFIEDContent = default;
        private static bool _NOT_SPECIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioFileTypes()"/> 
        /// </summary>
        public static Javax.Sound.Sampled.AudioFileFormat.Type[] AudioFileTypes
        {
            get { return SExecuteArray<Javax.Sound.Sampled.AudioFileFormat.Type>(LocalBridgeClazz, "getAudioFileTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getClip()"/> 
        /// </summary>
        public static Javax.Sound.Sampled.Clip Clip
        {
            get { return SExecute<Javax.Sound.Sampled.Clip>(LocalBridgeClazz, "getClip"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getMixerInfo()"/> 
        /// </summary>
        public static Javax.Sound.Sampled.Mixer.Info[] MixerInfo
        {
            get { return SExecuteArray<Javax.Sound.Sampled.Mixer.Info>(LocalBridgeClazz, "getMixerInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#isConversionSupported(javax.sound.sampled.AudioFormat,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsConversionSupported(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isConversionSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#isConversionSupported(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsConversionSupported(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isConversionSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#isFileTypeSupported(javax.sound.sampled.AudioFileFormat.Type,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFileTypeSupported(Javax.Sound.Sampled.AudioFileFormat.Type arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isFileTypeSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#isFileTypeSupported(javax.sound.sampled.AudioFileFormat.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFileTypeSupported(Javax.Sound.Sampled.AudioFileFormat.Type arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isFileTypeSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#isLineSupported(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLineSupported(Javax.Sound.Sampled.Line.Info arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isLineSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#write(javax.sound.sampled.AudioInputStream,javax.sound.sampled.AudioFileFormat.Type,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static int Write(Javax.Sound.Sampled.AudioInputStream arg0, Javax.Sound.Sampled.AudioFileFormat.Type arg1, Java.Io.File arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#write(javax.sound.sampled.AudioInputStream,javax.sound.sampled.AudioFileFormat.Type,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static int Write(Javax.Sound.Sampled.AudioInputStream arg0, Javax.Sound.Sampled.AudioFileFormat.Type arg1, Java.Io.OutputStream arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioFileFormat(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.File arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioFileFormat>(LocalBridgeClazz, "getAudioFileFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioFileFormat(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.InputStream arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioFileFormat>(LocalBridgeClazz, "getAudioFileFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioFileFormat(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Net.URL arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioFileFormat>(LocalBridgeClazz, "getAudioFileFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioFileTypes(javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat.Type"/></returns>
        public static Javax.Sound.Sampled.AudioFileFormat.Type[] GetAudioFileTypes(Javax.Sound.Sampled.AudioInputStream arg0)
        {
            return SExecuteArray<Javax.Sound.Sampled.AudioFileFormat.Type>(LocalBridgeClazz, "getAudioFileTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetFormats(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFormat"/></returns>
        public static Javax.Sound.Sampled.AudioFormat[] GetTargetFormats(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return SExecuteArray<Javax.Sound.Sampled.AudioFormat>(LocalBridgeClazz, "getTargetFormats", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetEncodings(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></returns>
        public static Javax.Sound.Sampled.AudioFormat.Encoding[] GetTargetEncodings(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return SExecuteArray<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "getTargetEncodings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetEncodings(javax.sound.sampled.AudioFormat.Encoding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></returns>
        public static Javax.Sound.Sampled.AudioFormat.Encoding[] GetTargetEncodings(Javax.Sound.Sampled.AudioFormat.Encoding arg0)
        {
            return SExecuteArray<Javax.Sound.Sampled.AudioFormat.Encoding>(LocalBridgeClazz, "getTargetEncodings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioInputStream(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.File arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioInputStream>(LocalBridgeClazz, "getAudioInputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioInputStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.InputStream arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioInputStream>(LocalBridgeClazz, "getAudioInputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioInputStream(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Net.URL arg0)
        {
            return SExecute<Javax.Sound.Sampled.AudioInputStream>(LocalBridgeClazz, "getAudioInputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioInputStream(javax.sound.sampled.AudioFormat,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        public static Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return SExecute<Javax.Sound.Sampled.AudioInputStream>(LocalBridgeClazz, "getAudioInputStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getAudioInputStream(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        public static Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return SExecute<Javax.Sound.Sampled.AudioInputStream>(LocalBridgeClazz, "getAudioInputStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getClip(javax.sound.sampled.Mixer.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Mixer.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Clip"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.Clip GetClip(Javax.Sound.Sampled.Mixer.Info arg0)
        {
            return SExecute<Javax.Sound.Sampled.Clip>(LocalBridgeClazz, "getClip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getLine(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.Line GetLine(Javax.Sound.Sampled.Line.Info arg0)
        {
            return SExecute<Javax.Sound.Sampled.Line>(LocalBridgeClazz, "getLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getSourceLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        public static Javax.Sound.Sampled.Line.Info[] GetSourceLineInfo(Javax.Sound.Sampled.Line.Info arg0)
        {
            return SExecuteArray<Javax.Sound.Sampled.Line.Info>(LocalBridgeClazz, "getSourceLineInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        public static Javax.Sound.Sampled.Line.Info[] GetTargetLineInfo(Javax.Sound.Sampled.Line.Info arg0)
        {
            return SExecuteArray<Javax.Sound.Sampled.Line.Info>(LocalBridgeClazz, "getTargetLineInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getMixer(javax.sound.sampled.Mixer.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Mixer.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Mixer"/></returns>
        public static Javax.Sound.Sampled.Mixer GetMixer(Javax.Sound.Sampled.Mixer.Info arg0)
        {
            return SExecute<Javax.Sound.Sampled.Mixer>(LocalBridgeClazz, "getMixer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getSourceDataLine(javax.sound.sampled.AudioFormat,javax.sound.sampled.Mixer.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.Mixer.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.SourceDataLine"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.SourceDataLine GetSourceDataLine(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.Mixer.Info arg1)
        {
            return SExecute<Javax.Sound.Sampled.SourceDataLine>(LocalBridgeClazz, "getSourceDataLine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getSourceDataLine(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.SourceDataLine"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.SourceDataLine GetSourceDataLine(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return SExecute<Javax.Sound.Sampled.SourceDataLine>(LocalBridgeClazz, "getSourceDataLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetDataLine(javax.sound.sampled.AudioFormat,javax.sound.sampled.Mixer.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.Mixer.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.TargetDataLine"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.TargetDataLine GetTargetDataLine(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.Mixer.Info arg1)
        {
            return SExecute<Javax.Sound.Sampled.TargetDataLine>(LocalBridgeClazz, "getTargetDataLine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioSystem.html#getTargetDataLine(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.TargetDataLine"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public static Javax.Sound.Sampled.TargetDataLine GetTargetDataLine(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return SExecute<Javax.Sound.Sampled.TargetDataLine>(LocalBridgeClazz, "getTargetDataLine", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}