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

namespace Java.Awt.Dnd.Peer
{
    #region DropTargetContextPeer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html"/>
    /// </summary>
    public partial class DropTargetContextPeer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DropTargetContextPeer>
    {
        const string _bridgeClassName = "java.awt.dnd.peer.DropTargetContextPeer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DropTargetContextPeer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DropTargetContextPeer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DropTargetContextPeer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DropTargetContextPeer(params object[] args) : base(args) { }

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

    #region IDropTargetContextPeer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDropTargetContextPeer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getDropTarget()"/> 
        /// </summary>
        Java.Awt.Dnd.DropTarget DropTarget { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTargetActions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#setTargetActions(int)"/>
        /// </summary>
        int TargetActions { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferable()"/> 
        /// </summary>
        Java.Awt.Datatransfer.Transferable Transferable { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferDataFlavors()"/> 
        /// </summary>
        Java.Awt.Datatransfer.DataFlavor[] TransferDataFlavors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#isTransferableJVMLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsTransferableJVMLocal();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void AcceptDrag(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void AcceptDrop(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#dropComplete(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void DropComplete(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrag()"/>
        /// </summary>
        void RejectDrag();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrop()"/>
        /// </summary>
        void RejectDrop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DropTargetContextPeer implementation
    public partial class DropTargetContextPeer : Java.Awt.Dnd.Peer.IDropTargetContextPeer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getDropTarget()"/> 
        /// </summary>
        public Java.Awt.Dnd.DropTarget DropTarget
        {
            get { return IExecuteWithSignature<Java.Awt.Dnd.DropTarget>("getDropTarget", "()Ljava/awt/dnd/DropTarget;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTargetActions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#setTargetActions(int)"/>
        /// </summary>
        public int TargetActions
        {
            get { return IExecuteWithSignature<int>("getTargetActions", "()I"); } set { IExecuteWithSignature("setTargetActions", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferable()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.Transferable>("getTransferable", "()Ljava/awt/datatransfer/Transferable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] TransferDataFlavors
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Datatransfer.DataFlavor>("getTransferDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#isTransferableJVMLocal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTransferableJVMLocal()
        {
            return IExecuteWithSignature<bool>("isTransferableJVMLocal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrag(int arg0)
        {
            IExecuteWithSignature("acceptDrag", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrop(int arg0)
        {
            IExecuteWithSignature("acceptDrop", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#dropComplete(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void DropComplete(bool arg0)
        {
            IExecuteWithSignature("dropComplete", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrag()"/>
        /// </summary>
        public void RejectDrag()
        {
            IExecuteWithSignature("rejectDrag", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrop()"/>
        /// </summary>
        public void RejectDrop()
        {
            IExecuteWithSignature("rejectDrop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}