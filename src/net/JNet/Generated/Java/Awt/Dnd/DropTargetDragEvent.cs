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

namespace Java.Awt.Dnd
{
    #region DropTargetDragEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html"/>
    /// </summary>
    public partial class DropTargetDragEvent : Java.Awt.Dnd.DropTargetEvent
    {
        const string _bridgeClassName = "java.awt.dnd.DropTargetDragEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DropTargetDragEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DropTargetDragEvent(params object[] args) : base(args) { }

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

    #region DropTargetDragEvent implementation
    public partial class DropTargetDragEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#%3Cinit%3E(java.awt.dnd.DropTargetContext,java.awt.Point,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DropTargetDragEvent(Java.Awt.Dnd.DropTargetContext arg0, Java.Awt.Point arg1, int arg2, int arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getCurrentDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] CurrentDataFlavors
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Datatransfer.DataFlavor>("getCurrentDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getCurrentDataFlavorsAsList()"/> 
        /// </summary>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> CurrentDataFlavorsAsList
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getCurrentDataFlavorsAsList", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getDropAction()"/> 
        /// </summary>
        public int DropAction
        {
            get { return IExecuteWithSignature<int>("getDropAction", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getLocation()"/> 
        /// </summary>
        public Java.Awt.Point Location
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getLocation", "()Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getSourceActions()"/> 
        /// </summary>
        public int SourceActions
        {
            get { return IExecuteWithSignature<int>("getSourceActions", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#getTransferable()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.Transferable>("getTransferable", "()Ljava/awt/datatransfer/Transferable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#isDataFlavorSupported(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataFlavorSupported(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<bool>("isDataFlavorSupported", "(Ljava/awt/datatransfer/DataFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#acceptDrag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrag(int arg0)
        {
            IExecuteWithSignature("acceptDrag", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetDragEvent.html#rejectDrag()"/>
        /// </summary>
        public void RejectDrag()
        {
            IExecuteWithSignature("rejectDrag", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}