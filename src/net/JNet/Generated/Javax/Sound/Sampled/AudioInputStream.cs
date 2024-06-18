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

namespace Javax.Sound.Sampled
{
    #region AudioInputStream
    public partial class AudioInputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioInputStream.html#%3Cinit%3E(java.io.InputStream,javax.sound.sampled.AudioFormat,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public AudioInputStream(Java.Io.InputStream arg0, Javax.Sound.Sampled.AudioFormat arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioInputStream.html#%3Cinit%3E(javax.sound.sampled.TargetDataLine)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.TargetDataLine"/></param>
        public AudioInputStream(Javax.Sound.Sampled.TargetDataLine arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioInputStream.html#getFormat()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat Format
        {
            get { return IExecuteWithSignature<Javax.Sound.Sampled.AudioFormat>("getFormat", "()Ljavax/sound/sampled/AudioFormat;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioInputStream.html#getFrameLength()"/> 
        /// </summary>
        public long FrameLength
        {
            get { return IExecuteWithSignature<long>("getFrameLength", "()J"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}