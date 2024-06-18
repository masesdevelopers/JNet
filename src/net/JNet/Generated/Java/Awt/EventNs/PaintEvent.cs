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

namespace Java.Awt.EventNs
{
    #region PaintEvent
    public partial class PaintEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Rectangle"/></param>
        public PaintEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Rectangle arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT"/>
        /// </summary>
        public static int PAINT { get { if (!_PAINTReady) { _PAINTContent = SGetField<int>(LocalBridgeClazz, "PAINT"); _PAINTReady = true; } return _PAINTContent; } }
        private static int _PAINTContent = default;
        private static bool _PAINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT_FIRST"/>
        /// </summary>
        public static int PAINT_FIRST { get { if (!_PAINT_FIRSTReady) { _PAINT_FIRSTContent = SGetField<int>(LocalBridgeClazz, "PAINT_FIRST"); _PAINT_FIRSTReady = true; } return _PAINT_FIRSTContent; } }
        private static int _PAINT_FIRSTContent = default;
        private static bool _PAINT_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT_LAST"/>
        /// </summary>
        public static int PAINT_LAST { get { if (!_PAINT_LASTReady) { _PAINT_LASTContent = SGetField<int>(LocalBridgeClazz, "PAINT_LAST"); _PAINT_LASTReady = true; } return _PAINT_LASTContent; } }
        private static int _PAINT_LASTContent = default;
        private static bool _PAINT_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#UPDATE"/>
        /// </summary>
        public static int UPDATE { get { if (!_UPDATEReady) { _UPDATEContent = SGetField<int>(LocalBridgeClazz, "UPDATE"); _UPDATEReady = true; } return _UPDATEContent; } }
        private static int _UPDATEContent = default;
        private static bool _UPDATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#getUpdateRect()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#setUpdateRect(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle UpdateRect
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getUpdateRect", "()Ljava/awt/Rectangle;"); } set { IExecuteWithSignature("setUpdateRect", "(Ljava/awt/Rectangle;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}