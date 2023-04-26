/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
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
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public IIOMetadataFormatImpl(string arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public IIOMetadataFormatImpl(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Metadata.IIOMetadataFormatImpl"/> to <see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/>
        /// </summary>
        public static implicit operator Javax.Imageio.Metadata.IIOMetadataFormat(Javax.Imageio.Metadata.IIOMetadataFormatImpl t) => t.Cast<Javax.Imageio.Metadata.IIOMetadataFormat>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#standardMetadataFormatName"/>
        /// </summary>
        public static string standardMetadataFormatName { get { return LocalClazz.GetField<string>("standardMetadataFormatName"); } }
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getStandardFormatInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Metadata.IIOMetadataFormat StandardFormatInstance
        {
            get { return SExecute<Javax.Imageio.Metadata.IIOMetadataFormat>(LocalClazz, "getStandardFormatInstance"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getRootName()"/> 
        /// </summary>
        public string RootName
        {
            get { return IExecute<string>("getRootName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#canNodeAppear(java.lang.String,javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanNodeAppear(string arg0, Javax.Imageio.ImageTypeSpecifier arg1)
        {
            return IExecute<bool>("canNodeAppear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#isAttributeRequired(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeRequired(string arg0, string arg1)
        {
            return IExecute<bool>("isAttributeRequired", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDataType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeDataType(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeDataType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeListMaxLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMaxLength(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeListMaxLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeListMinLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMinLength(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeListMinLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeValueType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeValueType(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeValueType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getChildPolicy(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetChildPolicy(string arg0)
        {
            return IExecute<int>("getChildPolicy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementMaxChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMaxChildren(string arg0)
        {
            return IExecute<int>("getElementMaxChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementMinChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMinChildren(string arg0)
        {
            return IExecute<int>("getElementMinChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectArrayMaxLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMaxLength(string arg0)
        {
            return IExecute<int>("getObjectArrayMaxLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectArrayMinLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMinLength(string arg0)
        {
            return IExecute<int>("getObjectArrayMinLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectValueType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectValueType(string arg0)
        {
            return IExecute<int>("getObjectValueType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetObjectClass<ReturnExtendsobject>(string arg0)
        {
            return IExecute<Java.Lang.Class>("getObjectClass", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectMaxValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<ReturnExtendsobject> GetObjectMaxValue<ReturnExtendsobject>(string arg0)
        {
            return IExecute<Java.Lang.Comparable<ReturnExtendsobject>>("getObjectMaxValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectMinValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<ReturnExtendsobject> GetObjectMinValue<ReturnExtendsobject>(string arg0)
        {
            return IExecute<Java.Lang.Comparable<ReturnExtendsobject>>("getObjectMinValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectDefaultValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObjectDefaultValue(string arg0)
        {
            return IExecute("getObjectDefaultValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getObjectEnumerations(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetObjectEnumerations(string arg0)
        {
            return IExecuteArray<object>("getObjectEnumerations", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDefaultValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeDefaultValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeDefaultValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeDescription(java.lang.String,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeDescription(string arg0, string arg1, Java.Util.Locale arg2)
        {
            return IExecute<string>("getAttributeDescription", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeMaxValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeMaxValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeMaxValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeMinValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeMinValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeMinValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getElementDescription(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetElementDescription(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getElementDescription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeEnumerations(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetAttributeEnumerations(string arg0, string arg1)
        {
            return IExecuteArray<string>("getAttributeEnumerations", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getAttributeNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetAttributeNames(string arg0)
        {
            return IExecuteArray<string>("getAttributeNames", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormatImpl.html#getChildNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetChildNames(string arg0)
        {
            return IExecuteArray<string>("getChildNames", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}