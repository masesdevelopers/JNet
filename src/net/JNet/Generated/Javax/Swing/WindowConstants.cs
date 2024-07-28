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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region IWindowConstants
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWindowConstants
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowConstants
    public partial class WindowConstants : Javax.Swing.IWindowConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/WindowConstants.html#DISPOSE_ON_CLOSE"/>
        /// </summary>
        public static int DISPOSE_ON_CLOSE { get { if (!_DISPOSE_ON_CLOSEReady) { _DISPOSE_ON_CLOSEContent = SGetField<int>(LocalBridgeClazz, "DISPOSE_ON_CLOSE"); _DISPOSE_ON_CLOSEReady = true; } return _DISPOSE_ON_CLOSEContent; } }
        private static int _DISPOSE_ON_CLOSEContent = default;
        private static bool _DISPOSE_ON_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/WindowConstants.html#DO_NOTHING_ON_CLOSE"/>
        /// </summary>
        public static int DO_NOTHING_ON_CLOSE { get { if (!_DO_NOTHING_ON_CLOSEReady) { _DO_NOTHING_ON_CLOSEContent = SGetField<int>(LocalBridgeClazz, "DO_NOTHING_ON_CLOSE"); _DO_NOTHING_ON_CLOSEReady = true; } return _DO_NOTHING_ON_CLOSEContent; } }
        private static int _DO_NOTHING_ON_CLOSEContent = default;
        private static bool _DO_NOTHING_ON_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/WindowConstants.html#EXIT_ON_CLOSE"/>
        /// </summary>
        public static int EXIT_ON_CLOSE { get { if (!_EXIT_ON_CLOSEReady) { _EXIT_ON_CLOSEContent = SGetField<int>(LocalBridgeClazz, "EXIT_ON_CLOSE"); _EXIT_ON_CLOSEReady = true; } return _EXIT_ON_CLOSEContent; } }
        private static int _EXIT_ON_CLOSEContent = default;
        private static bool _EXIT_ON_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/WindowConstants.html#HIDE_ON_CLOSE"/>
        /// </summary>
        public static int HIDE_ON_CLOSE { get { if (!_HIDE_ON_CLOSEReady) { _HIDE_ON_CLOSEContent = SGetField<int>(LocalBridgeClazz, "HIDE_ON_CLOSE"); _HIDE_ON_CLOSEReady = true; } return _HIDE_ON_CLOSEContent; } }
        private static int _HIDE_ON_CLOSEContent = default;
        private static bool _HIDE_ON_CLOSEReady = false; // this is used because in case of generics 

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
}