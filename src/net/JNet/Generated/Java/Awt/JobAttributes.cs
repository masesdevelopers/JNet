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

namespace Java.Awt
{
    #region JobAttributes
    public partial class JobAttributes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#%3Cinit%3E(int,java.awt.JobAttributes.DefaultSelectionType,java.awt.JobAttributes.DestinationType,java.awt.JobAttributes.DialogType,java.lang.String,int,int,java.awt.JobAttributes.MultipleDocumentHandlingType,int[][],java.lang.String,java.awt.JobAttributes.SidesType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.JobAttributes.DefaultSelectionType"/></param>
        /// <param name="arg2"><see cref="Java.Awt.JobAttributes.DestinationType"/></param>
        /// <param name="arg3"><see cref="Java.Awt.JobAttributes.DialogType"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Awt.JobAttributes.MultipleDocumentHandlingType"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="string"/></param>
        /// <param name="arg10"><see cref="Java.Awt.JobAttributes.SidesType"/></param>
        public JobAttributes(int arg0, Java.Awt.JobAttributes.DefaultSelectionType arg1, Java.Awt.JobAttributes.DestinationType arg2, Java.Awt.JobAttributes.DialogType arg3, string arg4, int arg5, int arg6, Java.Awt.JobAttributes.MultipleDocumentHandlingType arg7, int[][] arg8, string arg9, Java.Awt.JobAttributes.SidesType arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#%3Cinit%3E(java.awt.JobAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.JobAttributes"/></param>
        public JobAttributes(Java.Awt.JobAttributes arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.JobAttributes"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.JobAttributes t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getCopies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setCopies(int)"/>
        /// </summary>
        public int Copies
        {
            get { return IExecute<int>("getCopies"); } set { IExecute("setCopies", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDefaultSelection()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDefaultSelection(java.awt.JobAttributes.DefaultSelectionType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DefaultSelectionType DefaultSelection
        {
            get { return IExecute<Java.Awt.JobAttributes.DefaultSelectionType>("getDefaultSelection"); } set { IExecute("setDefaultSelection", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDestination()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDestination(java.awt.JobAttributes.DestinationType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DestinationType Destination
        {
            get { return IExecute<Java.Awt.JobAttributes.DestinationType>("getDestination"); } set { IExecute("setDestination", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDialog()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDialog(java.awt.JobAttributes.DialogType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DialogType Dialog
        {
            get { return IExecute<Java.Awt.JobAttributes.DialogType>("getDialog"); } set { IExecute("setDialog", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getFileName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setFileName(java.lang.String)"/>
        /// </summary>
        public string FileName
        {
            get { return IExecute<string>("getFileName"); } set { IExecute("setFileName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getFromPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setFromPage(int)"/>
        /// </summary>
        public int FromPage
        {
            get { return IExecute<int>("getFromPage"); } set { IExecute("setFromPage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMaxPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMaxPage(int)"/>
        /// </summary>
        public int MaxPage
        {
            get { return IExecute<int>("getMaxPage"); } set { IExecute("setMaxPage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMinPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMinPage(int)"/>
        /// </summary>
        public int MinPage
        {
            get { return IExecute<int>("getMinPage"); } set { IExecute("setMinPage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMultipleDocumentHandling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMultipleDocumentHandling(java.awt.JobAttributes.MultipleDocumentHandlingType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.MultipleDocumentHandlingType MultipleDocumentHandling
        {
            get { return IExecute<Java.Awt.JobAttributes.MultipleDocumentHandlingType>("getMultipleDocumentHandling"); } set { IExecute("setMultipleDocumentHandling", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getPageRanges()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setPageRanges(int[][])"/>
        /// </summary>
        public int[] PageRanges
        {
            get { return IExecuteArray<int>("getPageRanges"); } set { IExecute("setPageRanges", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getPrinter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setPrinter(java.lang.String)"/>
        /// </summary>
        public string Printer
        {
            get { return IExecute<string>("getPrinter"); } set { IExecute("setPrinter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getSides()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setSides(java.awt.JobAttributes.SidesType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.SidesType Sides
        {
            get { return IExecute<Java.Awt.JobAttributes.SidesType>("getSides"); } set { IExecute("setSides", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getToPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setToPage(int)"/>
        /// </summary>
        public int ToPage
        {
            get { return IExecute<int>("getToPage"); } set { IExecute("setToPage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#set(java.awt.JobAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.JobAttributes"/></param>
        public void Set(Java.Awt.JobAttributes arg0)
        {
            IExecute("set", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setCopiesToDefault()"/>
        /// </summary>
        public void SetCopiesToDefault()
        {
            IExecute("setCopiesToDefault");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMultipleDocumentHandlingToDefault()"/>
        /// </summary>
        public void SetMultipleDocumentHandlingToDefault()
        {
            IExecute("setMultipleDocumentHandlingToDefault");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setSidesToDefault()"/>
        /// </summary>
        public void SetSidesToDefault()
        {
            IExecute("setSidesToDefault");
        }
        
        #endregion

        #region Nested classes
        #region DefaultSelectionType
        public partial class DefaultSelectionType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#ALL"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType ALL { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DefaultSelectionType>("ALL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#RANGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType RANGE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DefaultSelectionType>("RANGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#SELECTION"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType SELECTION { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DefaultSelectionType>("SELECTION"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DestinationType
        public partial class DestinationType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DestinationType.html#FILE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DestinationType FILE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DestinationType>("FILE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DestinationType.html#PRINTER"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DestinationType PRINTER { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DestinationType>("PRINTER"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DialogType
        public partial class DialogType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#COMMON"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType COMMON { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DialogType>("COMMON"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#NATIVE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType NATIVE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DialogType>("NATIVE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#NONE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType NONE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.DialogType>("NONE"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MultipleDocumentHandlingType
        public partial class MultipleDocumentHandlingType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.MultipleDocumentHandlingType.html#SEPARATE_DOCUMENTS_COLLATED_COPIES"/>
            /// </summary>
            public static Java.Awt.JobAttributes.MultipleDocumentHandlingType SEPARATE_DOCUMENTS_COLLATED_COPIES { get { return LocalClazz.GetField<Java.Awt.JobAttributes.MultipleDocumentHandlingType>("SEPARATE_DOCUMENTS_COLLATED_COPIES"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.MultipleDocumentHandlingType.html#SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"/>
            /// </summary>
            public static Java.Awt.JobAttributes.MultipleDocumentHandlingType SEPARATE_DOCUMENTS_UNCOLLATED_COPIES { get { return LocalClazz.GetField<Java.Awt.JobAttributes.MultipleDocumentHandlingType>("SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SidesType
        public partial class SidesType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#ONE_SIDED"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType ONE_SIDED { get { return LocalClazz.GetField<Java.Awt.JobAttributes.SidesType>("ONE_SIDED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#TWO_SIDED_LONG_EDGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType TWO_SIDED_LONG_EDGE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.SidesType>("TWO_SIDED_LONG_EDGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#TWO_SIDED_SHORT_EDGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType TWO_SIDED_SHORT_EDGE { get { return LocalClazz.GetField<Java.Awt.JobAttributes.SidesType>("TWO_SIDED_SHORT_EDGE"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}