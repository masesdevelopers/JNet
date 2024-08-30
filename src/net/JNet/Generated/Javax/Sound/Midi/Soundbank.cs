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

namespace Javax.Sound.Midi
{
    #region Soundbank declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html"/>
    /// </summary>
    public partial class Soundbank : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Soundbank>
    {
        const string _bridgeClassName = "javax.sound.midi.Soundbank";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Soundbank class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Soundbank() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Soundbank class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Soundbank(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region ISoundbank
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISoundbank
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getDescription()"/> 
        /// </summary>
        Java.Lang.String Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstruments()"/> 
        /// </summary>
        Javax.Sound.Midi.Instrument[] Instruments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getResources()"/> 
        /// </summary>
        Javax.Sound.Midi.SoundbankResource[] Resources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVendor()"/> 
        /// </summary>
        Java.Lang.String Vendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVersion()"/> 
        /// </summary>
        Java.Lang.String Version { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstrument(javax.sound.midi.Patch)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Instrument"/></returns>
        Javax.Sound.Midi.Instrument GetInstrument(Javax.Sound.Midi.Patch arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Soundbank implementation
    public partial class Soundbank : Javax.Sound.Midi.ISoundbank
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstruments()"/> 
        /// </summary>
        public Javax.Sound.Midi.Instrument[] Instruments
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.Instrument>("getInstruments", "()[Ljavax/sound/midi/Instrument;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getResources()"/> 
        /// </summary>
        public Javax.Sound.Midi.SoundbankResource[] Resources
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Midi.SoundbankResource>("getResources", "()[Ljavax/sound/midi/SoundbankResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVendor()"/> 
        /// </summary>
        public Java.Lang.String Vendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstrument(javax.sound.midi.Patch)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Instrument"/></returns>
        public Javax.Sound.Midi.Instrument GetInstrument(Javax.Sound.Midi.Patch arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Midi.Instrument>("getInstrument", "(Ljavax/sound/midi/Patch;)Ljavax/sound/midi/Instrument;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}