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

namespace Javax.Imageio.Metadata
{
    #region IIOMetadataFormatImpl
    public partial class IIOMetadataFormatImpl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public IIOMetadataFormatImpl(Java.Lang.String arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public IIOMetadataFormatImpl(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#standardMetadataFormatName"/>
        /// </summary>
        public static Java.Lang.String standardMetadataFormatName { get { if (!_standardMetadataFormatNameReady) { _standardMetadataFormatNameContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "standardMetadataFormatName"); _standardMetadataFormatNameReady = true; } return _standardMetadataFormatNameContent; } }
        private static Java.Lang.String _standardMetadataFormatNameContent = default;
        private static bool _standardMetadataFormatNameReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getStandardFormatInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Metadata.IIOMetadataFormat StandardFormatInstance
        {
            get { return SExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataFormat>(LocalBridgeClazz, "getStandardFormatInstance", "()Ljavax/imageio/metadata/IIOMetadataFormat;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getRootName()"/> 
        /// </summary>
        public Java.Lang.String RootName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRootName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#canNodeAppear(java.lang.String,javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanNodeAppear(Java.Lang.String arg0, Javax.Imageio.ImageTypeSpecifier arg1)
        {
            return IExecute<bool>("canNodeAppear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#isAttributeRequired(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeRequired(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("isAttributeRequired", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDataType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeDataType(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getAttributeDataType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeListMaxLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMaxLength(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getAttributeListMaxLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeListMinLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMinLength(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getAttributeListMinLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeValueType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeValueType(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getAttributeValueType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getChildPolicy(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetChildPolicy(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getChildPolicy", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementMaxChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMaxChildren(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getElementMaxChildren", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementMinChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMinChildren(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getElementMinChildren", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectArrayMaxLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMaxLength(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getObjectArrayMaxLength", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectArrayMinLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMinLength(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getObjectArrayMinLength", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectValueType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectValueType(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getObjectValueType", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetObjectClass(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Class>("getObjectClass", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectMaxValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<object> GetObjectMaxValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Comparable<object>>("getObjectMaxValue", "(Ljava/lang/String;)Ljava/lang/Comparable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectMinValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<object> GetObjectMinValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Comparable<object>>("getObjectMinValue", "(Ljava/lang/String;)Ljava/lang/Comparable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectDefaultValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObjectDefaultValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getObjectDefaultValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectEnumerations(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetObjectEnumerations(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<object>("getObjectEnumerations", "(Ljava/lang/String;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDefaultValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeDefaultValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getAttributeDefaultValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDescription(java.lang.String,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeDescription(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Locale arg2)
        {
            return IExecute<Java.Lang.String>("getAttributeDescription", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeMaxValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeMaxValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getAttributeMaxValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeMinValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeMinValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getAttributeMinValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementDescription(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetElementDescription(Java.Lang.String arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getElementDescription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeEnumerations(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetAttributeEnumerations(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteArray<Java.Lang.String>("getAttributeEnumerations", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetAttributeNames(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getAttributeNames", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getChildNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetChildNames(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getChildNames", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}