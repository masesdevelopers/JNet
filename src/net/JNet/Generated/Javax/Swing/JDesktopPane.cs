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

namespace Javax.Swing
{
    #region JDesktopPane definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html"/>
    /// </summary>
    public partial class JDesktopPane : Javax.Swing.JLayeredPane
    {
        const string _bridgeClassName = "javax.swing.JDesktopPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JDesktopPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JDesktopPane(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region JDesktopPane
    public partial class JDesktopPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#LIVE_DRAG_MODE"/>
        /// </summary>
        public static int LIVE_DRAG_MODE { get { if (!_LIVE_DRAG_MODEReady) { _LIVE_DRAG_MODEContent = SGetField<int>(LocalBridgeClazz, "LIVE_DRAG_MODE"); _LIVE_DRAG_MODEReady = true; } return _LIVE_DRAG_MODEContent; } }
        private static int _LIVE_DRAG_MODEContent = default;
        private static bool _LIVE_DRAG_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#OUTLINE_DRAG_MODE"/>
        /// </summary>
        public static int OUTLINE_DRAG_MODE { get { if (!_OUTLINE_DRAG_MODEReady) { _OUTLINE_DRAG_MODEContent = SGetField<int>(LocalBridgeClazz, "OUTLINE_DRAG_MODE"); _OUTLINE_DRAG_MODEReady = true; } return _OUTLINE_DRAG_MODEContent; } }
        private static int _OUTLINE_DRAG_MODEContent = default;
        private static bool _OUTLINE_DRAG_MODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getAllFrames()"/> 
        /// </summary>
        public Javax.Swing.JInternalFrame[] AllFrames
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.JInternalFrame>("getAllFrames", "()[Ljavax/swing/JInternalFrame;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getDesktopManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setDesktopManager(javax.swing.DesktopManager)"/>
        /// </summary>
        public Javax.Swing.DesktopManager DesktopManager
        {
            get { return IExecuteWithSignature<Javax.Swing.DesktopManager>("getDesktopManager", "()Ljavax/swing/DesktopManager;"); } set { IExecuteWithSignature("setDesktopManager", "(Ljavax/swing/DesktopManager;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getDragMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setDragMode(int)"/>
        /// </summary>
        public int DragMode
        {
            get { return IExecuteWithSignature<int>("getDragMode", "()I"); } set { IExecuteWithSignature("setDragMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getSelectedFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setSelectedFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        public Javax.Swing.JInternalFrame SelectedFrame
        {
            get { return IExecuteWithSignature<Javax.Swing.JInternalFrame>("getSelectedFrame", "()Ljavax/swing/JInternalFrame;"); } set { IExecuteWithSignature("setSelectedFrame", "(Ljavax/swing/JInternalFrame;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#selectFrame(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.JInternalFrame"/></returns>
        public Javax.Swing.JInternalFrame SelectFrame(bool arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JInternalFrame>("selectFrame", "(Z)Ljavax/swing/JInternalFrame;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#getAllFramesInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JInternalFrame"/></returns>
        public Javax.Swing.JInternalFrame[] GetAllFramesInLayer(int arg0)
        {
            return IExecuteWithSignatureArray<Javax.Swing.JInternalFrame>("getAllFramesInLayer", "(I)[Ljavax/swing/JInternalFrame;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDesktopPane.html#setUI(javax.swing.plaf.DesktopPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.DesktopPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.DesktopPaneUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/DesktopPaneUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}