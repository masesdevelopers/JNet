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

namespace Javax.Swing.Event
{
    #region ListDataEvent
    public partial class ListDataEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#%3Cinit%3E(java.lang.Object,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ListDataEvent(object arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#CONTENTS_CHANGED"/>
        /// </summary>
        public static int CONTENTS_CHANGED { get { if (!_CONTENTS_CHANGEDReady) { _CONTENTS_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "CONTENTS_CHANGED"); _CONTENTS_CHANGEDReady = true; } return _CONTENTS_CHANGEDContent; } }
        private static int _CONTENTS_CHANGEDContent = default;
        private static bool _CONTENTS_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#INTERVAL_ADDED"/>
        /// </summary>
        public static int INTERVAL_ADDED { get { if (!_INTERVAL_ADDEDReady) { _INTERVAL_ADDEDContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_ADDED"); _INTERVAL_ADDEDReady = true; } return _INTERVAL_ADDEDContent; } }
        private static int _INTERVAL_ADDEDContent = default;
        private static bool _INTERVAL_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#INTERVAL_REMOVED"/>
        /// </summary>
        public static int INTERVAL_REMOVED { get { if (!_INTERVAL_REMOVEDReady) { _INTERVAL_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_REMOVED"); _INTERVAL_REMOVEDReady = true; } return _INTERVAL_REMOVEDContent; } }
        private static int _INTERVAL_REMOVEDContent = default;
        private static bool _INTERVAL_REMOVEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#getIndex0()"/> 
        /// </summary>
        public int Index0
        {
            get { return IExecuteWithSignature<int>("getIndex0", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#getIndex1()"/> 
        /// </summary>
        public int Index1
        {
            get { return IExecuteWithSignature<int>("getIndex1", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ListDataEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}