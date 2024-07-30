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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Catalog
{
    #region CatalogFeatures
    public partial class CatalogFeatures
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#defaults()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures"/></returns>
        public static Javax.Xml.Catalog.CatalogFeatures Defaults()
        {
            return SExecuteWithSignature<Javax.Xml.Catalog.CatalogFeatures>(LocalBridgeClazz, "defaults", "()Ljavax/xml/catalog/CatalogFeatures;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#builder()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Builder"/></returns>
        public static Javax.Xml.Catalog.CatalogFeatures.Builder BuilderMethod()
        {
            return SExecuteWithSignature<Javax.Xml.Catalog.CatalogFeatures.Builder>(LocalBridgeClazz, "builder", "()Ljavax/xml/catalog/CatalogFeatures$Builder;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.html#get(javax.xml.catalog.CatalogFeatures.Feature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Get(Javax.Xml.Catalog.CatalogFeatures.Feature arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("get", "(Ljavax/xml/catalog/CatalogFeatures$Feature;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures"/></returns>
            public Javax.Xml.Catalog.CatalogFeatures Build()
            {
                return IExecuteWithSignature<Javax.Xml.Catalog.CatalogFeatures>("build", "()Ljavax/xml/catalog/CatalogFeatures;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Builder.html#with(javax.xml.catalog.CatalogFeatures.Feature,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Builder"/></returns>
            public Javax.Xml.Catalog.CatalogFeatures.Builder With(Javax.Xml.Catalog.CatalogFeatures.Feature arg0, Java.Lang.String arg1)
            {
                return IExecute<Javax.Xml.Catalog.CatalogFeatures.Builder>("with", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Feature
        public partial class Feature
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#DEFER"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature DEFER { get { if (!_DEFERReady) { _DEFERContent = SGetField<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "DEFER"); _DEFERReady = true; } return _DEFERContent; } }
            private static Javax.Xml.Catalog.CatalogFeatures.Feature _DEFERContent = default;
            private static bool _DEFERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#FILES"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature FILES { get { if (!_FILESReady) { _FILESContent = SGetField<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "FILES"); _FILESReady = true; } return _FILESContent; } }
            private static Javax.Xml.Catalog.CatalogFeatures.Feature _FILESContent = default;
            private static bool _FILESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#PREFER"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature PREFER { get { if (!_PREFERReady) { _PREFERContent = SGetField<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "PREFER"); _PREFERReady = true; } return _PREFERContent; } }
            private static Javax.Xml.Catalog.CatalogFeatures.Feature _PREFERContent = default;
            private static bool _PREFERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#RESOLVE"/>
            /// </summary>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature RESOLVE { get { if (!_RESOLVEReady) { _RESOLVEContent = SGetField<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "RESOLVE"); _RESOLVEReady = true; } return _RESOLVEContent; } }
            private static Javax.Xml.Catalog.CatalogFeatures.Feature _RESOLVEContent = default;
            private static bool _RESOLVEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></returns>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/xml/catalog/CatalogFeatures$Feature;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Xml.Catalog.CatalogFeatures.Feature"/></returns>
            public static Javax.Xml.Catalog.CatalogFeatures.Feature[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Xml.Catalog.CatalogFeatures.Feature>(LocalBridgeClazz, "values", "()[Ljavax/xml/catalog/CatalogFeatures$Feature;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#getPropertyName()"/> 
            /// </summary>
            public Java.Lang.String PropertyName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getPropertyName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogFeatures.Feature.html#defaultValue()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String DefaultValue()
            {
                return IExecuteWithSignature<Java.Lang.String>("defaultValue", "()Ljava/lang/String;");
            }

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