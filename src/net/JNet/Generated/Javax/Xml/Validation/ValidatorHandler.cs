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

namespace Javax.Xml.Validation
{
    #region ValidatorHandler
    public partial class ValidatorHandler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getContentHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ContentHandler ContentHandler
        {
            get { return IExecute<Org.Xml.Sax.ContentHandler>("getContentHandler"); } set { IExecute("setContentHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getErrorHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecute<Org.Xml.Sax.ErrorHandler>("getErrorHandler"); } set { IExecute("setErrorHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getResourceResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSResourceResolver ResourceResolver
        {
            get { return IExecute<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver"); } set { IExecute("setResourceResolver", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getTypeInfoProvider()"/> 
        /// </summary>
        public Javax.Xml.Validation.TypeInfoProvider TypeInfoProvider
        {
            get { return IExecute<Javax.Xml.Validation.TypeInfoProvider>("getTypeInfoProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(string arg0)
        {
            return IExecute<bool>("getFeature", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(string arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/validation/ValidatorHandler.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(string arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}