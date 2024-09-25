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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DesktopManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html"/>
    /// </summary>
    public partial class DesktopManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DesktopManager>
    {
        const string _bridgeClassName = "javax.swing.DesktopManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DesktopManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DesktopManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DesktopManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DesktopManager(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IDesktopManager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDesktopManager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#activateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void ActivateFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#beginDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        void BeginDraggingFrame(Javax.Swing.JComponent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#beginResizingFrame(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void BeginResizingFrame(Javax.Swing.JComponent arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#closeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void CloseFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#deactivateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void DeactivateFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#deiconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void DeiconifyFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#dragFrame(javax.swing.JComponent,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        void DragFrame(Javax.Swing.JComponent arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#endDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        void EndDraggingFrame(Javax.Swing.JComponent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#endResizingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        void EndResizingFrame(Javax.Swing.JComponent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#iconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void IconifyFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#maximizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void MaximizeFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#minimizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void MinimizeFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#openFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        void OpenFrame(Javax.Swing.JInternalFrame arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#resizeFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        void ResizeFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#setBoundsForFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        void SetBoundsForFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DesktopManager implementation
    public partial class DesktopManager : Javax.Swing.IDesktopManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#activateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void ActivateFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("activateFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#beginDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void BeginDraggingFrame(Javax.Swing.JComponent arg0)
        {
            IExecute("beginDraggingFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#beginResizingFrame(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void BeginResizingFrame(Javax.Swing.JComponent arg0, int arg1)
        {
            IExecute("beginResizingFrame", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#closeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void CloseFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("closeFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#deactivateFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void DeactivateFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("deactivateFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#deiconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void DeiconifyFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("deiconifyFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#dragFrame(javax.swing.JComponent,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void DragFrame(Javax.Swing.JComponent arg0, int arg1, int arg2)
        {
            IExecute("dragFrame", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#endDraggingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void EndDraggingFrame(Javax.Swing.JComponent arg0)
        {
            IExecute("endDraggingFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#endResizingFrame(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        public void EndResizingFrame(Javax.Swing.JComponent arg0)
        {
            IExecute("endResizingFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#iconifyFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void IconifyFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("iconifyFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#maximizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void MaximizeFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("maximizeFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#minimizeFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void MinimizeFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("minimizeFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#openFrame(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public void OpenFrame(Javax.Swing.JInternalFrame arg0)
        {
            IExecute("openFrame", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#resizeFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void ResizeFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("resizeFrame", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DesktopManager.html#setBoundsForFrame(javax.swing.JComponent,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetBoundsForFrame(Javax.Swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("setBoundsForFrame", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}