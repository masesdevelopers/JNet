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

namespace Javax.Sound.Midi.Spi
{
    #region MidiFileReader
    public partial class MidiFileReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getMidiFileFormat(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>("getMidiFileFormat", "(Ljava/io/File;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getMidiFileFormat(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>("getMidiFileFormat", "(Ljava/io/InputStream;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getMidiFileFormat(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiFileFormat"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.MidiFileFormat GetMidiFileFormat(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.MidiFileFormat>("getMidiFileFormat", "(Ljava/net/URL;)Ljavax/sound/midi/MidiFileFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getSequence(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.Sequence GetSequence(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.Sequence>("getSequence", "(Ljava/io/File;)Ljavax/sound/midi/Sequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getSequence(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.Sequence GetSequence(Java.Io.InputStream arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.Sequence>("getSequence", "(Ljava/io/InputStream;)Ljavax/sound/midi/Sequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileReader.html#getSequence(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Sequence"/></returns>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Sound.Midi.Sequence GetSequence(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.Sequence>("getSequence", "(Ljava/net/URL;)Ljavax/sound/midi/Sequence;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}