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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultDesktopManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html"/>
    /// </summary>
    public partial class DefaultDesktopManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DefaultDesktopManager>
    {
        const string _bridgeClassName = "javax.swing.DefaultDesktopManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultDesktopManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultDesktopManager(params object[] args) : base(args) { }

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

    #region DefaultDesktopManager implementation
    public partial class DefaultDesktopManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultDesktopManager"/> to <see cref="Javax.Swing.DesktopManager"/>
        /// </summary>
        public static implicit operator Javax.Swing.DesktopManager(Javax.Swing.DefaultDesktopManager t) => t.Cast<Javax.Swing.DesktopManager>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultDesktopManager"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultDesktopManager t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#activateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void ActivateFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("activateFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#beginDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void BeginDraggingFrame(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("beginDraggingFrame", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#beginResizingFrame(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void BeginResizingFrame(Javax.Swing.JComponent arg0, int arg1)
        {
            IExecuteWithSignature("beginResizingFrame", "(Ljavax/swing/JComponent;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#closeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void CloseFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("closeFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#deactivateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void DeactivateFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("deactivateFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#deiconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void DeiconifyFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("deiconifyFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#dragFrame(javax.swing.JComponent,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void DragFrame(Javax.Swing.JComponent arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("dragFrame", "(Ljavax/swing/JComponent;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#endDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void EndDraggingFrame(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("endDraggingFrame", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#endResizingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void EndResizingFrame(Javax.Swing.JComponent arg0)
        {
            IExecuteWithSignature("endResizingFrame", "(Ljavax/swing/JComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#iconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void IconifyFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("iconifyFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#maximizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void MaximizeFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("maximizeFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#minimizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void MinimizeFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("minimizeFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#openFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void OpenFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecuteWithSignature("openFrame", "(Ljavax/swing/JInternalFrame;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#resizeFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void ResizeFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("resizeFrame", "(Ljavax/swing/JComponent;IIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultDesktopManager.html#setBoundsForFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetBoundsForFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("setBoundsForFrame", "(Ljavax/swing/JComponent;IIII)V", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}