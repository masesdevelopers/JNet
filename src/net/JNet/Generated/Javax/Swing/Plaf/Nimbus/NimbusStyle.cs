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

namespace Javax.Swing.Plaf.Nimbus
{
    #region NimbusStyle
    public partial class NimbusStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#LARGE_SCALE"/>
        /// </summary>
        public static double LARGE_SCALE { get { return SGetField<double>(LocalBridgeClazz, "LARGE_SCALE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#MINI_SCALE"/>
        /// </summary>
        public static double MINI_SCALE { get { return SGetField<double>(LocalBridgeClazz, "MINI_SCALE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#SMALL_SCALE"/>
        /// </summary>
        public static double SMALL_SCALE { get { return SGetField<double>(LocalBridgeClazz, "SMALL_SCALE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#LARGE_KEY"/>
        /// </summary>
        public static string LARGE_KEY { get { return SGetField<string>(LocalBridgeClazz, "LARGE_KEY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#MINI_KEY"/>
        /// </summary>
        public static string MINI_KEY { get { return SGetField<string>(LocalBridgeClazz, "MINI_KEY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#SMALL_KEY"/>
        /// </summary>
        public static string SMALL_KEY { get { return SGetField<string>(LocalBridgeClazz, "SMALL_KEY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#getBackgroundPainter(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Javax.Swing.Painter"/></returns>
        public Javax.Swing.Painter<object> GetBackgroundPainter(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecute<Javax.Swing.Painter<object>>("getBackgroundPainter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#getBorderPainter(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Javax.Swing.Painter"/></returns>
        public Javax.Swing.Painter<object> GetBorderPainter(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecute<Javax.Swing.Painter<object>>("getBorderPainter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusStyle.html#getForegroundPainter(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="Javax.Swing.Painter"/></returns>
        public Javax.Swing.Painter<object> GetForegroundPainter(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecute<Javax.Swing.Painter<object>>("getForegroundPainter", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}