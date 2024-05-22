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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform.Sax
{
    #region SAXTransformerFactory
    public partial class SAXTransformerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#FEATURE_XMLFILTER"/>
        /// </summary>
        public static Java.Lang.String FEATURE_XMLFILTER { get { if (!_FEATURE_XMLFILTERReady) { _FEATURE_XMLFILTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_XMLFILTER"); _FEATURE_XMLFILTERReady = true; } return _FEATURE_XMLFILTERContent; } }
        private static Java.Lang.String _FEATURE_XMLFILTERContent = default;
        private static bool _FEATURE_XMLFILTERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTemplatesHandler()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TemplatesHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TemplatesHandler NewTemplatesHandler()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TemplatesHandler>("newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newTransformerHandler(javax.xml.transform.Templates)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Templates"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Sax.TransformerHandler"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Sax.TransformerHandler NewTransformerHandler(Javax.Xml.Transform.Templates arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Sax.TransformerHandler>("newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newXMLFilter(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Org.Xml.Sax.XMLFilter"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Org.Xml.Sax.XMLFilter NewXMLFilter(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Org.Xml.Sax.XMLFilter>("newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXTransformerFactory.html#newXMLFilter(javax.xml.transform.Templates)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Templates"/></param>
        /// <returns><see cref="Org.Xml.Sax.XMLFilter"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Org.Xml.Sax.XMLFilter NewXMLFilter(Javax.Xml.Transform.Templates arg0)
        {
            return IExecuteWithSignature<Org.Xml.Sax.XMLFilter>("newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}