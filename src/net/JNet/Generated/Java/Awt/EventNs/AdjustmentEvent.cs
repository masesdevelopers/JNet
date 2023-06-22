/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region AdjustmentEvent
    public partial class AdjustmentEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#%3Cinit%3E(java.awt.Adjustable,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Adjustable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public AdjustmentEvent(Java.Awt.Adjustable arg0, int arg1, int arg2, int arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#%3Cinit%3E(java.awt.Adjustable,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Adjustable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AdjustmentEvent(Java.Awt.Adjustable arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_FIRST"/>
        /// </summary>
        public static int ADJUSTMENT_FIRST { get { return SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_FIRST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_LAST"/>
        /// </summary>
        public static int ADJUSTMENT_LAST { get { return SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_LAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_VALUE_CHANGED"/>
        /// </summary>
        public static int ADJUSTMENT_VALUE_CHANGED { get { return SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_VALUE_CHANGED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#BLOCK_DECREMENT"/>
        /// </summary>
        public static int BLOCK_DECREMENT { get { return SGetField<int>(LocalBridgeClazz, "BLOCK_DECREMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#BLOCK_INCREMENT"/>
        /// </summary>
        public static int BLOCK_INCREMENT { get { return SGetField<int>(LocalBridgeClazz, "BLOCK_INCREMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#TRACK"/>
        /// </summary>
        public static int TRACK { get { return SGetField<int>(LocalBridgeClazz, "TRACK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#UNIT_DECREMENT"/>
        /// </summary>
        public static int UNIT_DECREMENT { get { return SGetField<int>(LocalBridgeClazz, "UNIT_DECREMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#UNIT_INCREMENT"/>
        /// </summary>
        public static int UNIT_INCREMENT { get { return SGetField<int>(LocalBridgeClazz, "UNIT_INCREMENT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getAdjustable()"/> 
        /// </summary>
        public Java.Awt.Adjustable Adjustable
        {
            get { return IExecute<Java.Awt.Adjustable>("getAdjustable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getAdjustmentType()"/> 
        /// </summary>
        public int AdjustmentType
        {
            get { return IExecute<int>("getAdjustmentType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getValueIsAdjusting()"/> 
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}