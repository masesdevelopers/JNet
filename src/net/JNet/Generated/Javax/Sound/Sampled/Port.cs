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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region Port
    public partial class Port
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

        #endregion

        #region Nested classes
        #region Info
        public partial class Info
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#%3Cinit%3E(java.lang.Class,java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public Info(Java.Lang.Class arg0, string arg1, bool arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#COMPACT_DISC"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info COMPACT_DISC { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "COMPACT_DISC"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#HEADPHONE"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info HEADPHONE { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "HEADPHONE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#LINE_IN"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info LINE_IN { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "LINE_IN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#LINE_OUT"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info LINE_OUT { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "LINE_OUT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#MICROPHONE"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info MICROPHONE { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "MICROPHONE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#SPEAKER"/>
            /// </summary>
            public static Javax.Sound.Sampled.Port.Info SPEAKER { get { return SGetField<Javax.Sound.Sampled.Port.Info>(LocalBridgeClazz, "SPEAKER"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#isSource()"/> 
            /// </summary>
            public bool IsSource
            {
                get { return IExecute<bool>("isSource"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Port.Info.html#getName()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }

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