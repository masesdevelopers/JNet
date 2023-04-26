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

namespace Javax.Print.Attribute.Standard
{
    #region PresentationDirection
    public partial class PresentationDirection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PresentationDirection"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.PresentationDirection t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PresentationDirection"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.PresentationDirection t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOBOTTOM_TOLEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOBOTTOM_TOLEFT { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOBOTTOM_TOLEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOBOTTOM_TORIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOBOTTOM_TORIGHT { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOBOTTOM_TORIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOLEFT_TOBOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOLEFT_TOBOTTOM { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOLEFT_TOBOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOLEFT_TOTOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOLEFT_TOTOP { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOLEFT_TOTOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TORIGHT_TOBOTTOM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TORIGHT_TOBOTTOM { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TORIGHT_TOBOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TORIGHT_TOTOP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TORIGHT_TOTOP { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TORIGHT_TOTOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOTOP_TOLEFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOTOP_TOLEFT { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOTOP_TOLEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#TOTOP_TORIGHT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PresentationDirection TOTOP_TORIGHT { get { return LocalClazz.GetField<Javax.Print.Attribute.Standard.PresentationDirection>("TOTOP_TORIGHT"); } }
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PresentationDirection.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}