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

namespace Java.Text
{
    #region AttributedCharacterIterator
    public partial class AttributedCharacterIterator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getAllAttributeKeys()"/> 
        /// </summary>
        public Java.Util.Set<Java.Text.AttributedCharacterIterator.Attribute> AllAttributeKeys
        {
            get { return IExecute<Java.Util.Set<Java.Text.AttributedCharacterIterator.Attribute>>("getAllAttributeKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<Java.Text.AttributedCharacterIterator.Attribute, object> Attributes
        {
            get { return IExecute<Java.Util.Map<Java.Text.AttributedCharacterIterator.Attribute, object>>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunLimit()"/> 
        /// </summary>
        public int RunLimit
        {
            get { return IExecute<int>("getRunLimit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunStart()"/> 
        /// </summary>
        public int RunStart
        {
            get { return IExecute<int>("getRunStart"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunLimit(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecute<int>("getRunLimit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunLimit(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Set<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute: Java.Text.AttributedCharacterIterator.Attribute
        {
            return IExecute<int>("getRunLimit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunStart(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecute<int>("getRunStart", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getRunStart(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Set<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute: Java.Text.AttributedCharacterIterator.Attribute
        {
            return IExecute<int>("getRunStart", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.html#getAttribute(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecute("getAttribute", arg0);
        }

        #endregion

        #region Nested classes
        #region Attribute
        public partial class Attribute
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Text.AttributedCharacterIterator.Attribute"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Text.AttributedCharacterIterator.Attribute t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.Attribute.html#INPUT_METHOD_SEGMENT"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute INPUT_METHOD_SEGMENT { get { return LocalClazz.GetField<Java.Text.AttributedCharacterIterator.Attribute>("INPUT_METHOD_SEGMENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.Attribute.html#LANGUAGE"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute LANGUAGE { get { return LocalClazz.GetField<Java.Text.AttributedCharacterIterator.Attribute>("LANGUAGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedCharacterIterator.Attribute.html#READING"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute READING { get { return LocalClazz.GetField<Java.Text.AttributedCharacterIterator.Attribute>("READING"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}