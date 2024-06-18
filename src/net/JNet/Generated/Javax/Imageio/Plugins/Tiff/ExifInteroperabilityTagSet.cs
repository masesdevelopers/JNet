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

namespace Javax.Imageio.Plugins.Tiff
{
    #region ExifInteroperabilityTagSet
    public partial class ExifInteroperabilityTagSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#TAG_INTEROPERABILITY_INDEX"/>
        /// </summary>
        public static int TAG_INTEROPERABILITY_INDEX { get { if (!_TAG_INTEROPERABILITY_INDEXReady) { _TAG_INTEROPERABILITY_INDEXContent = SGetField<int>(LocalBridgeClazz, "TAG_INTEROPERABILITY_INDEX"); _TAG_INTEROPERABILITY_INDEXReady = true; } return _TAG_INTEROPERABILITY_INDEXContent; } }
        private static int _TAG_INTEROPERABILITY_INDEXContent = default;
        private static bool _TAG_INTEROPERABILITY_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#INTEROPERABILITY_INDEX_R98"/>
        /// </summary>
        public static Java.Lang.String INTEROPERABILITY_INDEX_R98 { get { if (!_INTEROPERABILITY_INDEX_R98Ready) { _INTEROPERABILITY_INDEX_R98Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTEROPERABILITY_INDEX_R98"); _INTEROPERABILITY_INDEX_R98Ready = true; } return _INTEROPERABILITY_INDEX_R98Content; } }
        private static Java.Lang.String _INTEROPERABILITY_INDEX_R98Content = default;
        private static bool _INTEROPERABILITY_INDEX_R98Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#INTEROPERABILITY_INDEX_THM"/>
        /// </summary>
        public static Java.Lang.String INTEROPERABILITY_INDEX_THM { get { if (!_INTEROPERABILITY_INDEX_THMReady) { _INTEROPERABILITY_INDEX_THMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTEROPERABILITY_INDEX_THM"); _INTEROPERABILITY_INDEX_THMReady = true; } return _INTEROPERABILITY_INDEX_THMContent; } }
        private static Java.Lang.String _INTEROPERABILITY_INDEX_THMContent = default;
        private static bool _INTEROPERABILITY_INDEX_THMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#getInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Plugins.Tiff.ExifInteroperabilityTagSet Instance
        {
            get { return SExecuteWithSignature<Javax.Imageio.Plugins.Tiff.ExifInteroperabilityTagSet>(LocalBridgeClazz, "getInstance", "()Ljavax/imageio/plugins/tiff/ExifInteroperabilityTagSet;"); }
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