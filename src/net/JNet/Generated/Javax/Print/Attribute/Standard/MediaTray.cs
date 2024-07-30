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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region MediaTray
    public partial class MediaTray
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.MediaTray"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.MediaTray t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#BOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#ENVELOPE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray ENVELOPE { get { if (!_ENVELOPEReady) { _ENVELOPEContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "ENVELOPE"); _ENVELOPEReady = true; } return _ENVELOPEContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _ENVELOPEContent = default;
        private static bool _ENVELOPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#LARGE_CAPACITY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray LARGE_CAPACITY { get { if (!_LARGE_CAPACITYReady) { _LARGE_CAPACITYContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "LARGE_CAPACITY"); _LARGE_CAPACITYReady = true; } return _LARGE_CAPACITYContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _LARGE_CAPACITYContent = default;
        private static bool _LARGE_CAPACITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#MAIN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray MAIN { get { if (!_MAINReady) { _MAINContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "MAIN"); _MAINReady = true; } return _MAINContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _MAINContent = default;
        private static bool _MAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#MANUAL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray MANUAL { get { if (!_MANUALReady) { _MANUALContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "MANUAL"); _MANUALReady = true; } return _MANUALContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _MANUALContent = default;
        private static bool _MANUALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#MIDDLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray MIDDLE { get { if (!_MIDDLEReady) { _MIDDLEContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "MIDDLE"); _MIDDLEReady = true; } return _MIDDLEContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _MIDDLEContent = default;
        private static bool _MIDDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#SIDE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray SIDE { get { if (!_SIDEReady) { _SIDEContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "SIDE"); _SIDEReady = true; } return _SIDEContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _SIDEContent = default;
        private static bool _SIDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MediaTray.html#TOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MediaTray TOP { get { if (!_TOPReady) { _TOPContent = SGetField<Javax.Print.Attribute.Standard.MediaTray>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static Javax.Print.Attribute.Standard.MediaTray _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 

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
}