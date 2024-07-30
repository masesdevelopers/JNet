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

namespace Javax.Imageio.Metadata
{
    #region IIOMetadata
    public partial class IIOMetadata
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getController()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#setController(javax.imageio.metadata.IIOMetadataController)"/>
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadataController Controller
        {
            get { return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataController>("getController", "()Ljavax/imageio/metadata/IIOMetadataController;"); } set { IExecuteWithSignature("setController", "(Ljavax/imageio/metadata/IIOMetadataController;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getDefaultController()"/> 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadataController DefaultController
        {
            get { return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataController>("getDefaultController", "()Ljavax/imageio/metadata/IIOMetadataController;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getExtraMetadataFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] ExtraMetadataFormatNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getExtraMetadataFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getMetadataFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] MetadataFormatNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getMetadataFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getNativeMetadataFormatName()"/> 
        /// </summary>
        public Java.Lang.String NativeMetadataFormatName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNativeMetadataFormatName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getAsTree(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node GetAsTree(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("getAsTree", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#mergeTree(java.lang.String,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Javax.Imageio.Metadata.IIOInvalidTreeException"/>
        public void MergeTree(Java.Lang.String arg0, Org.W3c.Dom.Node arg1)
        {
            IExecute("mergeTree", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#activateController()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ActivateController()
        {
            return IExecuteWithSignature<bool>("activateController", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#hasController()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasController()
        {
            return IExecuteWithSignature<bool>("hasController", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#isStandardMetadataFormatSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandardMetadataFormatSupported()
        {
            return IExecuteWithSignature<bool>("isStandardMetadataFormatSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetMetadataFormat(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataFormat>("getMetadataFormat", "(Ljava/lang/String;)Ljavax/imageio/metadata/IIOMetadataFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#setFromTree(java.lang.String,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Javax.Imageio.Metadata.IIOInvalidTreeException"/>
        public void SetFromTree(Java.Lang.String arg0, Org.W3c.Dom.Node arg1)
        {
            IExecute("setFromTree", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}