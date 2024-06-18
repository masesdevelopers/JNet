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

namespace Java.Awt.ImageNs
{
    #region PackedColorModel
    public partial class PackedColorModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PackedColorModel.html#%3Cinit%3E(java.awt.color.ColorSpace,int,int,int,int,int,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public PackedColorModel(Java.Awt.ColorNs.ColorSpace arg0, int arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, int arg7, int arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PackedColorModel.html#%3Cinit%3E(java.awt.color.ColorSpace,int,int[],int,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public PackedColorModel(Java.Awt.ColorNs.ColorSpace arg0, int arg1, int[] arg2, int arg3, bool arg4, int arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PackedColorModel.html#getMasks()"/> 
        /// </summary>
        public int[] Masks
        {
            get { return IExecuteWithSignatureArray<int>("getMasks", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PackedColorModel.html#getMask(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMask(int arg0)
        {
            return IExecuteWithSignature<int>("getMask", "(I)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}