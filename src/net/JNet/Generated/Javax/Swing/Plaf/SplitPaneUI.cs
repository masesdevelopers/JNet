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

namespace Javax.Swing.Plaf
{
    #region SplitPaneUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html"/>
    /// </summary>
    public partial class SplitPaneUI : Javax.Swing.Plaf.ComponentUI
    {
        const string _bridgeClassName = "javax.swing.plaf.SplitPaneUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SplitPaneUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SplitPaneUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SplitPaneUI class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SplitPaneUI(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SplitPaneUI implementation
    public partial class SplitPaneUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getMaximumDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getMaximumDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getMinimumDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMinimumDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getMinimumDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#finishedPaintingChildren(javax.swing.JSplitPane,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        public void FinishedPaintingChildren(Javax.Swing.JSplitPane arg0, Java.Awt.Graphics arg1)
        {
            IExecuteWithSignature("finishedPaintingChildren", "(Ljavax/swing/JSplitPane;Ljava/awt/Graphics;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#resetToPreferredSizes(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        public void ResetToPreferredSizes(Javax.Swing.JSplitPane arg0)
        {
            IExecuteWithSignature("resetToPreferredSizes", "(Ljavax/swing/JSplitPane;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#setDividerLocation(javax.swing.JSplitPane,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDividerLocation(Javax.Swing.JSplitPane arg0, int arg1)
        {
            IExecuteWithSignature("setDividerLocation", "(Ljavax/swing/JSplitPane;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}