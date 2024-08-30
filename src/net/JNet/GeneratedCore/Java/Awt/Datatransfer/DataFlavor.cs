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
    #region DataFlavor definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html"/>
    /// </summary>
    public partial class DataFlavor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DataFlavor>
    {
        const string _bridgeClassName = "java.awt.datatransfer.DataFlavor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DataFlavor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DataFlavor(params object[] args) : base(args) { }

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

    #region DataFlavor
    public partial class DataFlavor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public DataFlavor(Java.Lang.Class arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public DataFlavor(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public DataFlavor(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public DataFlavor(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.DataFlavor"/> to <see cref="Java.Io.Externalizable"/>
        /// </summary>
        public static implicit operator Java.Io.Externalizable(Java.Awt.Datatransfer.DataFlavor t) => t.Cast<Java.Io.Externalizable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.DataFlavor"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Datatransfer.DataFlavor t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#imageFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor imageFlavor { get { if (!_imageFlavorReady) { _imageFlavorContent = SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "imageFlavor"); _imageFlavorReady = true; } return _imageFlavorContent; } }
        private static Java.Awt.Datatransfer.DataFlavor _imageFlavorContent = default;
        private static bool _imageFlavorReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaFileListFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor javaFileListFlavor { get { if (!_javaFileListFlavorReady) { _javaFileListFlavorContent = SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "javaFileListFlavor"); _javaFileListFlavorReady = true; } return _javaFileListFlavorContent; } }
        private static Java.Awt.Datatransfer.DataFlavor _javaFileListFlavorContent = default;
        private static bool _javaFileListFlavorReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#stringFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor stringFlavor { get { if (!_stringFlavorReady) { _stringFlavorContent = SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "stringFlavor"); _stringFlavorReady = true; } return _stringFlavorContent; } }
        private static Java.Awt.Datatransfer.DataFlavor _stringFlavorContent = default;
        private static bool _stringFlavorReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaJVMLocalObjectMimeType"/>
        /// </summary>
        public static Java.Lang.String javaJVMLocalObjectMimeType { get { if (!_javaJVMLocalObjectMimeTypeReady) { _javaJVMLocalObjectMimeTypeContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "javaJVMLocalObjectMimeType"); _javaJVMLocalObjectMimeTypeReady = true; } return _javaJVMLocalObjectMimeTypeContent; } }
        private static Java.Lang.String _javaJVMLocalObjectMimeTypeContent = default;
        private static bool _javaJVMLocalObjectMimeTypeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaRemoteObjectMimeType"/>
        /// </summary>
        public static Java.Lang.String javaRemoteObjectMimeType { get { if (!_javaRemoteObjectMimeTypeReady) { _javaRemoteObjectMimeTypeContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "javaRemoteObjectMimeType"); _javaRemoteObjectMimeTypeReady = true; } return _javaRemoteObjectMimeTypeContent; } }
        private static Java.Lang.String _javaRemoteObjectMimeTypeContent = default;
        private static bool _javaRemoteObjectMimeTypeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaSerializedObjectMimeType"/>
        /// </summary>
        public static Java.Lang.String javaSerializedObjectMimeType { get { if (!_javaSerializedObjectMimeTypeReady) { _javaSerializedObjectMimeTypeContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "javaSerializedObjectMimeType"); _javaSerializedObjectMimeTypeReady = true; } return _javaSerializedObjectMimeTypeContent; } }
        private static Java.Lang.String _javaSerializedObjectMimeTypeContent = default;
        private static bool _javaSerializedObjectMimeTypeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#allHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor allHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "allHtmlFlavor"); } set { SSetField(LocalBridgeClazz, "allHtmlFlavor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#fragmentHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor fragmentHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "fragmentHtmlFlavor"); } set { SSetField(LocalBridgeClazz, "fragmentHtmlFlavor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#selectionHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor selectionHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "selectionHtmlFlavor"); } set { SSetField(LocalBridgeClazz, "selectionHtmlFlavor", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getTextPlainUnicodeFlavor()"/> 
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor TextPlainUnicodeFlavor
        {
            get { return SExecuteWithSignature<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "getTextPlainUnicodeFlavor", "()Ljava/awt/datatransfer/DataFlavor;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#selectBestTextFlavor(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.DataFlavor"/></returns>
        public static Java.Awt.Datatransfer.DataFlavor SelectBestTextFlavor(Java.Awt.Datatransfer.DataFlavor[] arg0)
        {
            return SExecuteWithSignature<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "selectBestTextFlavor", "([Ljava/awt/datatransfer/DataFlavor;)Ljava/awt/datatransfer/DataFlavor;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getDefaultRepresentationClass()"/> 
        /// </summary>
        public Java.Lang.Class DefaultRepresentationClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getDefaultRepresentationClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getDefaultRepresentationClassAsString()"/> 
        /// </summary>
        public Java.Lang.String DefaultRepresentationClassAsString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDefaultRepresentationClassAsString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getHumanPresentableName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#setHumanPresentableName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String HumanPresentableName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHumanPresentableName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setHumanPresentableName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getMimeType()"/> 
        /// </summary>
        public Java.Lang.String MimeType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMimeType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getPrimaryType()"/> 
        /// </summary>
        public Java.Lang.String PrimaryType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrimaryType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getRepresentationClass()"/> 
        /// </summary>
        public Java.Lang.Class RepresentationClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getRepresentationClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getSubType()"/> 
        /// </summary>
        public Java.Lang.String SubType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSubType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorJavaFileListType()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlavorJavaFileListType()
        {
            return IExecuteWithSignature<bool>("isFlavorJavaFileListType", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorRemoteObjectType()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlavorRemoteObjectType()
        {
            return IExecuteWithSignature<bool>("isFlavorRemoteObjectType", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorSerializedObjectType()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlavorSerializedObjectType()
        {
            return IExecuteWithSignature<bool>("isFlavorSerializedObjectType", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorTextType()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlavorTextType()
        {
            return IExecuteWithSignature<bool>("isFlavorTextType", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeEqual(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMimeTypeEqual(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isMimeTypeEqual", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeSerializedObject()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMimeTypeSerializedObject()
        {
            return IExecuteWithSignature<bool>("isMimeTypeSerializedObject", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassByteBuffer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassByteBuffer()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassByteBuffer", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassCharBuffer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassCharBuffer()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassCharBuffer", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassInputStream()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassInputStream()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassInputStream", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassReader()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassReader()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassReader", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassRemote()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassRemote()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassRemote", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassSerializable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepresentationClassSerializable()
        {
            return IExecuteWithSignature<bool>("isRepresentationClassSerializable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#match(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<bool>("match", "(Ljava/awt/datatransfer/DataFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeEqual(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMimeTypeEqual(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecuteWithSignature<bool>("isMimeTypeEqual", "(Ljava/awt/datatransfer/DataFlavor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getReaderForText(java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Awt.Datatransfer.UnsupportedFlavorException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader GetReaderForText(Java.Awt.Datatransfer.Transferable arg0)
        {
            return IExecuteWithSignature<Java.Io.Reader>("getReaderForText", "(Ljava/awt/datatransfer/Transferable;)Ljava/io/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#readExternal(java.io.ObjectInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public void ReadExternal(Java.Io.ObjectInput arg0)
        {
            IExecuteWithSignature("readExternal", "(Ljava/io/ObjectInput;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#writeExternal(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteExternal(Java.Io.ObjectOutput arg0)
        {
            IExecuteWithSignature("writeExternal", "(Ljava/io/ObjectOutput;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}