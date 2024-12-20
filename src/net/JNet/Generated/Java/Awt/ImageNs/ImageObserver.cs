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

namespace Java.Awt.ImageNs
{
    #region ImageObserver declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html"/>
    /// </summary>
    public partial class ImageObserver : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageObserver>
    {
        const string _bridgeClassName = "java.awt.image.ImageObserver";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageObserver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageObserver() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageObserver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageObserver(params object[] args) : base(args) { }

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

    #region IImageObserver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IImageObserver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#imageUpdate(java.awt.Image,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ImageUpdate(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageObserver implementation
    public partial class ImageObserver : Java.Awt.ImageNs.IImageObserver
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#ABORT"/>
        /// </summary>
        public static int ABORT { get { if (!_ABORTReady) { _ABORTContent = SGetField<int>(LocalBridgeClazz, "ABORT"); _ABORTReady = true; } return _ABORTContent; } }
        private static int _ABORTContent = default;
        private static bool _ABORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#ALLBITS"/>
        /// </summary>
        public static int ALLBITS { get { if (!_ALLBITSReady) { _ALLBITSContent = SGetField<int>(LocalBridgeClazz, "ALLBITS"); _ALLBITSReady = true; } return _ALLBITSContent; } }
        private static int _ALLBITSContent = default;
        private static bool _ALLBITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#FRAMEBITS"/>
        /// </summary>
        public static int FRAMEBITS { get { if (!_FRAMEBITSReady) { _FRAMEBITSContent = SGetField<int>(LocalBridgeClazz, "FRAMEBITS"); _FRAMEBITSReady = true; } return _FRAMEBITSContent; } }
        private static int _FRAMEBITSContent = default;
        private static bool _FRAMEBITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#HEIGHT"/>
        /// </summary>
        public static int HEIGHT { get { if (!_HEIGHTReady) { _HEIGHTContent = SGetField<int>(LocalBridgeClazz, "HEIGHT"); _HEIGHTReady = true; } return _HEIGHTContent; } }
        private static int _HEIGHTContent = default;
        private static bool _HEIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#PROPERTIES"/>
        /// </summary>
        public static int PROPERTIES { get { if (!_PROPERTIESReady) { _PROPERTIESContent = SGetField<int>(LocalBridgeClazz, "PROPERTIES"); _PROPERTIESReady = true; } return _PROPERTIESContent; } }
        private static int _PROPERTIESContent = default;
        private static bool _PROPERTIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#SOMEBITS"/>
        /// </summary>
        public static int SOMEBITS { get { if (!_SOMEBITSReady) { _SOMEBITSContent = SGetField<int>(LocalBridgeClazz, "SOMEBITS"); _SOMEBITSReady = true; } return _SOMEBITSContent; } }
        private static int _SOMEBITSContent = default;
        private static bool _SOMEBITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#WIDTH"/>
        /// </summary>
        public static int WIDTH { get { if (!_WIDTHReady) { _WIDTHContent = SGetField<int>(LocalBridgeClazz, "WIDTH"); _WIDTHReady = true; } return _WIDTHContent; } }
        private static int _WIDTHContent = default;
        private static bool _WIDTHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageObserver.html#imageUpdate(java.awt.Image,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ImageUpdate(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecuteWithSignature<bool>("imageUpdate", "(Ljava/awt/Image;IIIII)Z", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}