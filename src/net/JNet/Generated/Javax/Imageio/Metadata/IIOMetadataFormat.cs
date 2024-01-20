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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Metadata
{
    #region IIIOMetadataFormat
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IIIOMetadataFormat
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getRootName()"/> 
        /// </summary>
        string RootName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#canNodeAppear(java.lang.String,javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        bool CanNodeAppear(string arg0, Javax.Imageio.ImageTypeSpecifier arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#isAttributeRequired(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsAttributeRequired(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDataType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAttributeDataType(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeListMaxLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAttributeListMaxLength(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeListMinLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAttributeListMinLength(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeValueType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetAttributeValueType(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getChildPolicy(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetChildPolicy(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementMaxChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetElementMaxChildren(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementMinChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetElementMinChildren(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectArrayMaxLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetObjectArrayMaxLength(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectArrayMinLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetObjectArrayMinLength(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectValueType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int GetObjectValueType(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        Java.Lang.Class GetObjectClass(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectMaxValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        Java.Lang.Comparable<object> GetObjectMaxValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectMinValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        Java.Lang.Comparable<object> GetObjectMinValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectDefaultValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetObjectDefaultValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectEnumerations(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object[] GetObjectEnumerations(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDefaultValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeDefaultValue(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDescription(java.lang.String,java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeDescription(string arg0, string arg1, Java.Util.Locale arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeMaxValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeMaxValue(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeMinValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAttributeMinValue(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementDescription(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        string GetElementDescription(string arg0, Java.Util.Locale arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeEnumerations(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string[] GetAttributeEnumerations(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string[] GetAttributeNames(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getChildNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        string[] GetChildNames(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOMetadataFormat
    public partial class IIOMetadataFormat : Javax.Imageio.Metadata.IIIOMetadataFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_ALL"/>
        /// </summary>
        public static int CHILD_POLICY_ALL { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_ALL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_CHOICE"/>
        /// </summary>
        public static int CHILD_POLICY_CHOICE { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_CHOICE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_EMPTY"/>
        /// </summary>
        public static int CHILD_POLICY_EMPTY { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_EMPTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_MAX"/>
        /// </summary>
        public static int CHILD_POLICY_MAX { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_MAX"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_REPEAT"/>
        /// </summary>
        public static int CHILD_POLICY_REPEAT { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_REPEAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_SEQUENCE"/>
        /// </summary>
        public static int CHILD_POLICY_SEQUENCE { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_SEQUENCE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#CHILD_POLICY_SOME"/>
        /// </summary>
        public static int CHILD_POLICY_SOME { get { return SGetField<int>(LocalBridgeClazz, "CHILD_POLICY_SOME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#DATATYPE_BOOLEAN"/>
        /// </summary>
        public static int DATATYPE_BOOLEAN { get { return SGetField<int>(LocalBridgeClazz, "DATATYPE_BOOLEAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#DATATYPE_DOUBLE"/>
        /// </summary>
        public static int DATATYPE_DOUBLE { get { return SGetField<int>(LocalBridgeClazz, "DATATYPE_DOUBLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#DATATYPE_FLOAT"/>
        /// </summary>
        public static int DATATYPE_FLOAT { get { return SGetField<int>(LocalBridgeClazz, "DATATYPE_FLOAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#DATATYPE_INTEGER"/>
        /// </summary>
        public static int DATATYPE_INTEGER { get { return SGetField<int>(LocalBridgeClazz, "DATATYPE_INTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#DATATYPE_STRING"/>
        /// </summary>
        public static int DATATYPE_STRING { get { return SGetField<int>(LocalBridgeClazz, "DATATYPE_STRING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_ARBITRARY"/>
        /// </summary>
        public static int VALUE_ARBITRARY { get { return SGetField<int>(LocalBridgeClazz, "VALUE_ARBITRARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_ENUMERATION"/>
        /// </summary>
        public static int VALUE_ENUMERATION { get { return SGetField<int>(LocalBridgeClazz, "VALUE_ENUMERATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_LIST"/>
        /// </summary>
        public static int VALUE_LIST { get { return SGetField<int>(LocalBridgeClazz, "VALUE_LIST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_NONE"/>
        /// </summary>
        public static int VALUE_NONE { get { return SGetField<int>(LocalBridgeClazz, "VALUE_NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE"/>
        /// </summary>
        public static int VALUE_RANGE { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE_MAX_INCLUSIVE"/>
        /// </summary>
        public static int VALUE_RANGE_MAX_INCLUSIVE { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE_MAX_INCLUSIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE_MAX_INCLUSIVE_MASK"/>
        /// </summary>
        public static int VALUE_RANGE_MAX_INCLUSIVE_MASK { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE_MAX_INCLUSIVE_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE_MIN_INCLUSIVE"/>
        /// </summary>
        public static int VALUE_RANGE_MIN_INCLUSIVE { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE_MIN_INCLUSIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE_MIN_INCLUSIVE_MASK"/>
        /// </summary>
        public static int VALUE_RANGE_MIN_INCLUSIVE_MASK { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE_MIN_INCLUSIVE_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#VALUE_RANGE_MIN_MAX_INCLUSIVE"/>
        /// </summary>
        public static int VALUE_RANGE_MIN_MAX_INCLUSIVE { get { return SGetField<int>(LocalBridgeClazz, "VALUE_RANGE_MIN_MAX_INCLUSIVE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getRootName()"/> 
        /// </summary>
        public string RootName
        {
            get { return IExecute<string>("getRootName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#canNodeAppear(java.lang.String,javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanNodeAppear(string arg0, Javax.Imageio.ImageTypeSpecifier arg1)
        {
            return IExecute<bool>("canNodeAppear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#isAttributeRequired(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeRequired(string arg0, string arg1)
        {
            return IExecute<bool>("isAttributeRequired", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDataType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeDataType(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeDataType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeListMaxLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMaxLength(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeListMaxLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeListMinLength(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeListMinLength(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeListMinLength", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeValueType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributeValueType(string arg0, string arg1)
        {
            return IExecute<int>("getAttributeValueType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getChildPolicy(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetChildPolicy(string arg0)
        {
            return IExecute<int>("getChildPolicy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementMaxChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMaxChildren(string arg0)
        {
            return IExecute<int>("getElementMaxChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementMinChildren(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetElementMinChildren(string arg0)
        {
            return IExecute<int>("getElementMinChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectArrayMaxLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMaxLength(string arg0)
        {
            return IExecute<int>("getObjectArrayMaxLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectArrayMinLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectArrayMinLength(string arg0)
        {
            return IExecute<int>("getObjectArrayMinLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectValueType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetObjectValueType(string arg0)
        {
            return IExecute<int>("getObjectValueType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetObjectClass(string arg0)
        {
            return IExecute<Java.Lang.Class>("getObjectClass", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectMaxValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<object> GetObjectMaxValue(string arg0)
        {
            return IExecute<Java.Lang.Comparable<object>>("getObjectMaxValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectMinValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Comparable"/></returns>
        public Java.Lang.Comparable<object> GetObjectMinValue(string arg0)
        {
            return IExecute<Java.Lang.Comparable<object>>("getObjectMinValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectDefaultValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObjectDefaultValue(string arg0)
        {
            return IExecute("getObjectDefaultValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getObjectEnumerations(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetObjectEnumerations(string arg0)
        {
            return IExecuteArray<object>("getObjectEnumerations", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDefaultValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeDefaultValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeDefaultValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeDescription(java.lang.String,java.lang.String,java.util.Locale)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeMaxValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeMaxValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeMaxValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeMinValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAttributeMinValue(string arg0, string arg1)
        {
            return IExecute<string>("getAttributeMinValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getElementDescription(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetElementDescription(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getElementDescription", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeEnumerations(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetAttributeEnumerations(string arg0, string arg1)
        {
            return IExecuteArray<string>("getAttributeEnumerations", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getAttributeNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetAttributeNames(string arg0)
        {
            return IExecuteArray<string>("getAttributeNames", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataFormat.html#getChildNames(java.lang.String)"/>
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