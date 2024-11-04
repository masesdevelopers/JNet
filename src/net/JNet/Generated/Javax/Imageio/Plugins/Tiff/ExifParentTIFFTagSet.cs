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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Tiff
{
    #region ExifParentTIFFTagSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html"/>
    /// </summary>
    public partial class ExifParentTIFFTagSet : Javax.Imageio.Plugins.Tiff.TIFFTagSet
    {
        const string _bridgeClassName = "javax.imageio.plugins.tiff.ExifParentTIFFTagSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ExifParentTIFFTagSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ExifParentTIFFTagSet(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region ExifParentTIFFTagSet implementation
    public partial class ExifParentTIFFTagSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#TAG_EXIF_IFD_POINTER"/>
        /// </summary>
        public static int TAG_EXIF_IFD_POINTER { get { if (!_TAG_EXIF_IFD_POINTERReady) { _TAG_EXIF_IFD_POINTERContent = SGetField<int>(LocalBridgeClazz, "TAG_EXIF_IFD_POINTER"); _TAG_EXIF_IFD_POINTERReady = true; } return _TAG_EXIF_IFD_POINTERContent; } }
        private static int _TAG_EXIF_IFD_POINTERContent = default;
        private static bool _TAG_EXIF_IFD_POINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#TAG_GPS_INFO_IFD_POINTER"/>
        /// </summary>
        public static int TAG_GPS_INFO_IFD_POINTER { get { if (!_TAG_GPS_INFO_IFD_POINTERReady) { _TAG_GPS_INFO_IFD_POINTERContent = SGetField<int>(LocalBridgeClazz, "TAG_GPS_INFO_IFD_POINTER"); _TAG_GPS_INFO_IFD_POINTERReady = true; } return _TAG_GPS_INFO_IFD_POINTERContent; } }
        private static int _TAG_GPS_INFO_IFD_POINTERContent = default;
        private static bool _TAG_GPS_INFO_IFD_POINTERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#getInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Plugins.Tiff.ExifParentTIFFTagSet Instance
        {
            get { return SExecuteWithSignature<Javax.Imageio.Plugins.Tiff.ExifParentTIFFTagSet>(LocalBridgeClazz, "getInstance", "()Ljavax/imageio/plugins/tiff/ExifParentTIFFTagSet;"); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}