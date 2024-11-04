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

namespace Javax.Sound.Sampled.Spi
{
    #region AudioFileReader declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html"/>
    /// </summary>
    public partial class AudioFileReader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AudioFileReader>
    {
        const string _bridgeClassName = "javax.sound.sampled.spi.AudioFileReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AudioFileReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AudioFileReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AudioFileReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AudioFileReader(params object[] args) : base(args) { }

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

    }
    #endregion

    #region AudioFileReader implementation
    public partial class AudioFileReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/io/File;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioFileFormat(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioFileFormat GetAudioFileFormat(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioFileFormat>("getAudioFileFormat", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/io/File;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/io/InputStream;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/AudioFileReader.html#getAudioInputStream(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        /// <exception cref="Javax.Sound.Sampled.UnsupportedAudioFileException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", "(Ljava/net/URL;)Ljavax/sound/sampled/AudioInputStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}