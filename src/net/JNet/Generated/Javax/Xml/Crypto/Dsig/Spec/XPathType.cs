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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Spec
{
    #region XPathType
    public partial class XPathType
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.html#%3Cinit%3E(java.lang.String,javax.xml.crypto.dsig.spec.XPathType.Filter,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public XPathType(string arg0, Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter arg1, Java.Util.Map<string, string> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.html#%3Cinit%3E(java.lang.String,javax.xml.crypto.dsig.spec.XPathType.Filter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter"/></param>
        public XPathType(string arg0, Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.html#getExpression()"/> 
        /// </summary>
        public string Expression
        {
            get { return IExecute<string>("getExpression"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.html#getFilter()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter GetFilter
        {
            get { return IExecute<Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter>("getFilter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.html#getNamespaceMap()"/> 
        /// </summary>
        public Java.Util.Map<string, string> NamespaceMap
        {
            get { return IExecute<Java.Util.Map<string, string>>("getNamespaceMap"); }
        }

        #endregion

        #region Nested classes
        #region Filter
        public partial class Filter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.Filter.html#INTERSECT"/>
            /// </summary>
            public static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter INTERSECT { get { if (!_INTERSECTReady) { _INTERSECTContent = SGetField<Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter>(LocalBridgeClazz, "INTERSECT"); _INTERSECTReady = true; } return _INTERSECTContent; } }
            private static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter _INTERSECTContent = default;
            private static bool _INTERSECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.Filter.html#SUBTRACT"/>
            /// </summary>
            public static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter SUBTRACT { get { if (!_SUBTRACTReady) { _SUBTRACTContent = SGetField<Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter>(LocalBridgeClazz, "SUBTRACT"); _SUBTRACTReady = true; } return _SUBTRACTContent; } }
            private static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter _SUBTRACTContent = default;
            private static bool _SUBTRACTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/XPathType.Filter.html#UNION"/>
            /// </summary>
            public static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter UNION { get { if (!_UNIONReady) { _UNIONContent = SGetField<Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter>(LocalBridgeClazz, "UNION"); _UNIONReady = true; } return _UNIONContent; } }
            private static Javax.Xml.Crypto.Dsig.Spec.XPathType.Filter _UNIONContent = default;
            private static bool _UNIONReady = false; // this is used because in case of generics 

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