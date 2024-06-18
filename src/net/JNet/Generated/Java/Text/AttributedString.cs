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

namespace Java.Text
{
    #region AttributedString
    public partial class AttributedString
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#%3Cinit%3E(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public AttributedString(Java.Lang.String arg0, Java.Util.Map arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public AttributedString(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#%3Cinit%3E(java.text.AttributedCharacterIterator,int,int,java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        public AttributedString(Java.Text.AttributedCharacterIterator arg0, int arg1, int arg2, Java.Text.AttributedCharacterIterator.Attribute[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#%3Cinit%3E(java.text.AttributedCharacterIterator,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AttributedString(Java.Text.AttributedCharacterIterator arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#%3Cinit%3E(java.text.AttributedCharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        public AttributedString(Java.Text.AttributedCharacterIterator arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#getIterator()"/> 
        /// </summary>
        public Java.Text.AttributedCharacterIterator Iterator
        {
            get { return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("getIterator", "()Ljava/text/AttributedCharacterIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#getIterator(java.text.AttributedCharacterIterator.Attribute[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator GetIterator(Java.Text.AttributedCharacterIterator.Attribute[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Text.AttributedCharacterIterator>("getIterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#getIterator(java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator GetIterator(Java.Text.AttributedCharacterIterator.Attribute[] arg0)
        {
            return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#addAttribute(java.text.AttributedCharacterIterator.Attribute,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void AddAttribute(Java.Text.AttributedCharacterIterator.Attribute arg0, object arg1, int arg2, int arg3)
        {
            IExecute("addAttribute", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#addAttribute(java.text.AttributedCharacterIterator.Attribute,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddAttribute(Java.Text.AttributedCharacterIterator.Attribute arg0, object arg1)
        {
            IExecute("addAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/AttributedString.html#addAttributes(java.util.Map,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <typeparam name="Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></typeparam>
        public void AddAttributes<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Map<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute, object> arg0, int arg1, int arg2) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute : Java.Text.AttributedCharacterIterator.Attribute
        {
            IExecute("addAttributes", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}