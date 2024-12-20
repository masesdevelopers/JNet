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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Metadata
{
    #region IIOMetadata declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html"/>
    /// </summary>
    public partial class IIOMetadata : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IIOMetadata>
    {
        const string _bridgeClassName = "javax.imageio.metadata.IIOMetadata";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IIOMetadata class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IIOMetadata() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IIOMetadata class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IIOMetadata(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IIOMetadata implementation
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
            IExecuteWithSignature("mergeTree", "(Ljava/lang/String;Lorg/w3c/dom/Node;)V", arg0, arg1);
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
            IExecuteWithSignature("setFromTree", "(Ljava/lang/String;Lorg/w3c/dom/Node;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}