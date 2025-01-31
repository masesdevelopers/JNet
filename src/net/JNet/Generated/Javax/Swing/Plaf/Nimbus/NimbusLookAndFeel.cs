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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Nimbus
{
    #region NimbusLookAndFeel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusLookAndFeel.html"/>
    /// </summary>
    public partial class NimbusLookAndFeel : Javax.Swing.Plaf.Synth.SynthLookAndFeel
    {
        const string _bridgeClassName = "javax.swing.plaf.nimbus.NimbusLookAndFeel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NimbusLookAndFeel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NimbusLookAndFeel(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region NimbusLookAndFeel implementation
    public partial class NimbusLookAndFeel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusLookAndFeel.html#getDerivedColor(java.lang.String,float,float,float,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetDerivedColor(Java.Lang.String arg0, float arg1, float arg2, float arg3, int arg4, bool arg5)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getDerivedColor", "(Ljava/lang/String;FFFIZ)Ljava/awt/Color;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/nimbus/NimbusLookAndFeel.html#register(javax.swing.plaf.synth.Region,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.Region"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Register(Javax.Swing.Plaf.Synth.Region arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("register", "(Ljavax/swing/plaf/synth/Region;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}