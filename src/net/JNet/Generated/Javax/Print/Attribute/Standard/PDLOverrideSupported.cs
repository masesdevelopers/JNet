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
    #region PDLOverrideSupported
    public partial class PDLOverrideSupported
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PDLOverrideSupported"/> to <see cref="Javax.Print.Attribute.PrintServiceAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintServiceAttribute(Javax.Print.Attribute.Standard.PDLOverrideSupported t) => t.Cast<Javax.Print.Attribute.PrintServiceAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PDLOverrideSupported.html#ATTEMPTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PDLOverrideSupported ATTEMPTED { get { if (!_ATTEMPTEDReady) { _ATTEMPTEDContent = SGetField<Javax.Print.Attribute.Standard.PDLOverrideSupported>(LocalBridgeClazz, "ATTEMPTED"); _ATTEMPTEDReady = true; } return _ATTEMPTEDContent; } }
        private static Javax.Print.Attribute.Standard.PDLOverrideSupported _ATTEMPTEDContent = default;
        private static bool _ATTEMPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PDLOverrideSupported.html#NOT_ATTEMPTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PDLOverrideSupported NOT_ATTEMPTED { get { if (!_NOT_ATTEMPTEDReady) { _NOT_ATTEMPTEDContent = SGetField<Javax.Print.Attribute.Standard.PDLOverrideSupported>(LocalBridgeClazz, "NOT_ATTEMPTED"); _NOT_ATTEMPTEDReady = true; } return _NOT_ATTEMPTEDContent; } }
        private static Javax.Print.Attribute.Standard.PDLOverrideSupported _NOT_ATTEMPTEDContent = default;
        private static bool _NOT_ATTEMPTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PDLOverrideSupported.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PDLOverrideSupported.html#getName()"/> 
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