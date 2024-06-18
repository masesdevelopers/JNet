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

namespace Org.Xml.Sax.Ext
{
    #region ILexicalHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILexicalHandler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#comment(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void Comment(char[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endCDATA()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void EndCDATA();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endDTD()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void EndDTD();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void EndEntity(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startCDATA()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void StartCDATA();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startDTD(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void StartDTD(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        void StartEntity(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LexicalHandler
    public partial class LexicalHandler : Org.Xml.Sax.Ext.ILexicalHandler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#comment(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Comment(char[] arg0, int arg1, int arg2)
        {
            IExecute("comment", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endCDATA()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndCDATA()
        {
            IExecuteWithSignature("endCDATA", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endDTD()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndDTD()
        {
            IExecuteWithSignature("endDTD", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#endEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndEntity(Java.Lang.String arg0)
        {
            IExecuteWithSignature("endEntity", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startCDATA()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartCDATA()
        {
            IExecuteWithSignature("startCDATA", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startDTD(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartDTD(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("startDTD", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/ext/LexicalHandler.html#startEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartEntity(Java.Lang.String arg0)
        {
            IExecuteWithSignature("startEntity", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}