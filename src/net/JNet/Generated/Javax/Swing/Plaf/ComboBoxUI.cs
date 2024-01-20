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

namespace Javax.Swing.Plaf
{
    #region ComboBoxUI
    public partial class ComboBoxUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ComboBoxUI.html#isFocusTraversable(javax.swing.JComboBox)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocusTraversable(Javax.Swing.JComboBox<object> arg0)
        {
            return IExecute<bool>("isFocusTraversable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ComboBoxUI.html#isPopupVisible(javax.swing.JComboBox)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPopupVisible(Javax.Swing.JComboBox<object> arg0)
        {
            return IExecute<bool>("isPopupVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ComboBoxUI.html#setPopupVisible(javax.swing.JComboBox,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetPopupVisible(Javax.Swing.JComboBox<object> arg0, bool arg1)
        {
            IExecute("setPopupVisible", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}