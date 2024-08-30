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

namespace Javax.Sound.Midi.Spi
{
    #region MidiDeviceProvider
    public partial class MidiDeviceProvider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiDeviceProvider.html#getDeviceInfo()"/> 
        /// </summary>
        public Javax.Sound.Midi.MidiDevice.Info[] DeviceInfo
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.MidiDevice.Info>("getDeviceInfo", "()[Ljavax/sound/midi/MidiDevice$Info;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiDeviceProvider.html#getDevice(javax.sound.midi.MidiDevice.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MidiDevice.Info"/></param>
        /// <returns><see cref="Javax.Sound.Midi.MidiDevice"/></returns>
        public Javax.Sound.Midi.MidiDevice GetDevice(Javax.Sound.Midi.MidiDevice.Info arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.MidiDevice>("getDevice", "(Ljavax/sound/midi/MidiDevice$Info;)Ljavax/sound/midi/MidiDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiDeviceProvider.html#isDeviceSupported(javax.sound.midi.MidiDevice.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MidiDevice.Info"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceSupported(Javax.Sound.Midi.MidiDevice.Info arg0)
        {
            return IExecuteWithSignature<bool>("isDeviceSupported", "(Ljavax/sound/midi/MidiDevice$Info;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}