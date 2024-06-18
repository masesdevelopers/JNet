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

namespace Javax.Swing.Plaf.Synth
{
    #region SynthContext
    public partial class SynthContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthContext.html#%3Cinit%3E(javax.swing.JComponent,javax.swing.plaf.synth.Region,javax.swing.plaf.synth.SynthStyle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.Region"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Plaf.Synth.SynthStyle"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SynthContext(Javax.Swing.JComponent arg0, Javax.Swing.Plaf.Synth.Region arg1, Javax.Swing.Plaf.Synth.SynthStyle arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthContext.html#getComponent()"/> 
        /// </summary>
        public Javax.Swing.JComponent Component
        {
            get { return IExecuteWithSignature<Javax.Swing.JComponent>("getComponent", "()Ljavax/swing/JComponent;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthContext.html#getComponentState()"/> 
        /// </summary>
        public int ComponentState
        {
            get { return IExecuteWithSignature<int>("getComponentState", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthContext.html#getRegion()"/> 
        /// </summary>
        public Javax.Swing.Plaf.Synth.Region Region
        {
            get { return IExecuteWithSignature<Javax.Swing.Plaf.Synth.Region>("getRegion", "()Ljavax/swing/plaf/synth/Region;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthContext.html#getStyle()"/> 
        /// </summary>
        public Javax.Swing.Plaf.Synth.SynthStyle Style
        {
            get { return IExecuteWithSignature<Javax.Swing.Plaf.Synth.SynthStyle>("getStyle", "()Ljavax/swing/plaf/synth/SynthStyle;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}