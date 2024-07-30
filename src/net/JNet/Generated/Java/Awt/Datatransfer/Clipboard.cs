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

namespace Java.Awt.Datatransfer
{
    #region Clipboard
    public partial class Clipboard
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Clipboard(Java.Lang.String arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getAvailableDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] AvailableDataFlavors
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Datatransfer.DataFlavor>("getAvailableDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getFlavorListeners()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.FlavorListener[] FlavorListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Datatransfer.FlavorListener>("getFlavorListeners", "()[Ljava/awt/datatransfer/FlavorListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#isDataFlavorAvailable(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataFlavorAvailable(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<bool>("isDataFlavorAvailable", "(Ljava/awt/datatransfer/DataFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getData(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Awt.Datatransfer.UnsupportedFlavorException"/>
        /// <exception cref="Java.Io.IOException"/>
        public object GetData(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature("getData", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getContents(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.Transferable"/></returns>
        public Java.Awt.Datatransfer.Transferable GetContents(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Datatransfer.Transferable>("getContents", "(Ljava/lang/Object;)Ljava/awt/datatransfer/Transferable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#addFlavorListener(java.awt.datatransfer.FlavorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.FlavorListener"/></param>
        public void AddFlavorListener(Java.Awt.Datatransfer.FlavorListener arg0)
        {
            IExecuteWithSignature("addFlavorListener", "(Ljava/awt/datatransfer/FlavorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#removeFlavorListener(java.awt.datatransfer.FlavorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.FlavorListener"/></param>
        public void RemoveFlavorListener(Java.Awt.Datatransfer.FlavorListener arg0)
        {
            IExecuteWithSignature("removeFlavorListener", "(Ljava/awt/datatransfer/FlavorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#setContents(java.awt.datatransfer.Transferable,java.awt.datatransfer.ClipboardOwner)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.ClipboardOwner"/></param>
        public void SetContents(Java.Awt.Datatransfer.Transferable arg0, Java.Awt.Datatransfer.ClipboardOwner arg1)
        {
            IExecute("setContents", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}