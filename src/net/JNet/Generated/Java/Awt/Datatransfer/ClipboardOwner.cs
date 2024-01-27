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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region IClipboardOwner
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClipboardOwner
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/ClipboardOwner.html#lostOwnership(java.awt.datatransfer.Clipboard,java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Clipboard"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        void LostOwnership(Java.Awt.Datatransfer.Clipboard arg0, Java.Awt.Datatransfer.Transferable arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ClipboardOwner
    public partial class ClipboardOwner : Java.Awt.Datatransfer.IClipboardOwner
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/ClipboardOwner.html#lostOwnership(java.awt.datatransfer.Clipboard,java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Clipboard"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        public void LostOwnership(Java.Awt.Datatransfer.Clipboard arg0, Java.Awt.Datatransfer.Transferable arg1)
        {
            IExecute("lostOwnership", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}