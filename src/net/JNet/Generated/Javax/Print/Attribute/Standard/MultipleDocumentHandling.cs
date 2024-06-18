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

namespace Javax.Print.Attribute.Standard
{
    #region MultipleDocumentHandling
    public partial class MultipleDocumentHandling
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.MultipleDocumentHandling"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.MultipleDocumentHandling t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.MultipleDocumentHandling"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.MultipleDocumentHandling t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#SEPARATE_DOCUMENTS_COLLATED_COPIES"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MultipleDocumentHandling SEPARATE_DOCUMENTS_COLLATED_COPIES { get { if (!_SEPARATE_DOCUMENTS_COLLATED_COPIESReady) { _SEPARATE_DOCUMENTS_COLLATED_COPIESContent = SGetField<Javax.Print.Attribute.Standard.MultipleDocumentHandling>(LocalBridgeClazz, "SEPARATE_DOCUMENTS_COLLATED_COPIES"); _SEPARATE_DOCUMENTS_COLLATED_COPIESReady = true; } return _SEPARATE_DOCUMENTS_COLLATED_COPIESContent; } }
        private static Javax.Print.Attribute.Standard.MultipleDocumentHandling _SEPARATE_DOCUMENTS_COLLATED_COPIESContent = default;
        private static bool _SEPARATE_DOCUMENTS_COLLATED_COPIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MultipleDocumentHandling SEPARATE_DOCUMENTS_UNCOLLATED_COPIES { get { if (!_SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady) { _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent = SGetField<Javax.Print.Attribute.Standard.MultipleDocumentHandling>(LocalBridgeClazz, "SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"); _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady = true; } return _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent; } }
        private static Javax.Print.Attribute.Standard.MultipleDocumentHandling _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent = default;
        private static bool _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#SINGLE_DOCUMENT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MultipleDocumentHandling SINGLE_DOCUMENT { get { if (!_SINGLE_DOCUMENTReady) { _SINGLE_DOCUMENTContent = SGetField<Javax.Print.Attribute.Standard.MultipleDocumentHandling>(LocalBridgeClazz, "SINGLE_DOCUMENT"); _SINGLE_DOCUMENTReady = true; } return _SINGLE_DOCUMENTContent; } }
        private static Javax.Print.Attribute.Standard.MultipleDocumentHandling _SINGLE_DOCUMENTContent = default;
        private static bool _SINGLE_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#SINGLE_DOCUMENT_NEW_SHEET"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.MultipleDocumentHandling SINGLE_DOCUMENT_NEW_SHEET { get { if (!_SINGLE_DOCUMENT_NEW_SHEETReady) { _SINGLE_DOCUMENT_NEW_SHEETContent = SGetField<Javax.Print.Attribute.Standard.MultipleDocumentHandling>(LocalBridgeClazz, "SINGLE_DOCUMENT_NEW_SHEET"); _SINGLE_DOCUMENT_NEW_SHEETReady = true; } return _SINGLE_DOCUMENT_NEW_SHEETContent; } }
        private static Javax.Print.Attribute.Standard.MultipleDocumentHandling _SINGLE_DOCUMENT_NEW_SHEETContent = default;
        private static bool _SINGLE_DOCUMENT_NEW_SHEETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/MultipleDocumentHandling.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}