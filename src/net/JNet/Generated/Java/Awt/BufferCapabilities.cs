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

namespace Java.Awt
{
    #region BufferCapabilities
    public partial class BufferCapabilities
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#%3Cinit%3E(java.awt.ImageCapabilities,java.awt.ImageCapabilities,java.awt.BufferCapabilities.FlipContents)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageCapabilities"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageCapabilities"/></param>
        /// <param name="arg2"><see cref="Java.Awt.BufferCapabilities.FlipContents"/></param>
        public BufferCapabilities(Java.Awt.ImageCapabilities arg0, Java.Awt.ImageCapabilities arg1, Java.Awt.BufferCapabilities.FlipContents arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#getBackBufferCapabilities()"/> 
        /// </summary>
        public Java.Awt.ImageCapabilities BackBufferCapabilities
        {
            get { return IExecuteWithSignature<Java.Awt.ImageCapabilities>("getBackBufferCapabilities", "()Ljava/awt/ImageCapabilities;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#getFrontBufferCapabilities()"/> 
        /// </summary>
        public Java.Awt.ImageCapabilities FrontBufferCapabilities
        {
            get { return IExecuteWithSignature<Java.Awt.ImageCapabilities>("getFrontBufferCapabilities", "()Ljava/awt/ImageCapabilities;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#getFlipContents()"/> 
        /// </summary>
        public Java.Awt.BufferCapabilities.FlipContents GetFlipContents
        {
            get { return IExecuteWithSignature<Java.Awt.BufferCapabilities.FlipContents>("getFlipContents", "()Ljava/awt/BufferCapabilities$FlipContents;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#isFullScreenRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullScreenRequired()
        {
            return IExecuteWithSignature<bool>("isFullScreenRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#isMultiBufferAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultiBufferAvailable()
        {
            return IExecuteWithSignature<bool>("isMultiBufferAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.html#isPageFlipping()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPageFlipping()
        {
            return IExecuteWithSignature<bool>("isPageFlipping", "()Z");
        }

        #endregion

        #region Nested classes
        #region FlipContents
        public partial class FlipContents
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.FlipContents.html#BACKGROUND"/>
            /// </summary>
            public static Java.Awt.BufferCapabilities.FlipContents BACKGROUND { get { if (!_BACKGROUNDReady) { _BACKGROUNDContent = SGetField<Java.Awt.BufferCapabilities.FlipContents>(LocalBridgeClazz, "BACKGROUND"); _BACKGROUNDReady = true; } return _BACKGROUNDContent; } }
            private static Java.Awt.BufferCapabilities.FlipContents _BACKGROUNDContent = default;
            private static bool _BACKGROUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.FlipContents.html#COPIED"/>
            /// </summary>
            public static Java.Awt.BufferCapabilities.FlipContents COPIED { get { if (!_COPIEDReady) { _COPIEDContent = SGetField<Java.Awt.BufferCapabilities.FlipContents>(LocalBridgeClazz, "COPIED"); _COPIEDReady = true; } return _COPIEDContent; } }
            private static Java.Awt.BufferCapabilities.FlipContents _COPIEDContent = default;
            private static bool _COPIEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.FlipContents.html#PRIOR"/>
            /// </summary>
            public static Java.Awt.BufferCapabilities.FlipContents PRIOR { get { if (!_PRIORReady) { _PRIORContent = SGetField<Java.Awt.BufferCapabilities.FlipContents>(LocalBridgeClazz, "PRIOR"); _PRIORReady = true; } return _PRIORContent; } }
            private static Java.Awt.BufferCapabilities.FlipContents _PRIORContent = default;
            private static bool _PRIORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BufferCapabilities.FlipContents.html#UNDEFINED"/>
            /// </summary>
            public static Java.Awt.BufferCapabilities.FlipContents UNDEFINED { get { if (!_UNDEFINEDReady) { _UNDEFINEDContent = SGetField<Java.Awt.BufferCapabilities.FlipContents>(LocalBridgeClazz, "UNDEFINED"); _UNDEFINEDReady = true; } return _UNDEFINEDContent; } }
            private static Java.Awt.BufferCapabilities.FlipContents _UNDEFINEDContent = default;
            private static bool _UNDEFINEDReady = false; // this is used because in case of generics 

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}