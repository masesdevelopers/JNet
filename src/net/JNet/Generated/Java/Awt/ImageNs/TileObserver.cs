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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region ITileObserver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITileObserver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/TileObserver.html#tileUpdate(java.awt.image.WritableRenderedImage,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRenderedImage"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        void TileUpdate(Java.Awt.ImageNs.WritableRenderedImage arg0, int arg1, int arg2, bool arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TileObserver
    public partial class TileObserver : Java.Awt.ImageNs.ITileObserver
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/TileObserver.html#tileUpdate(java.awt.image.WritableRenderedImage,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRenderedImage"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void TileUpdate(Java.Awt.ImageNs.WritableRenderedImage arg0, int arg1, int arg2, bool arg3)
        {
            IExecute("tileUpdate", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}