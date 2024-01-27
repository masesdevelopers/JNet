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

namespace Javax.Accessibility
{
    #region AccessibleStateSet
    public partial class AccessibleStateSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#%3Cinit%3E(javax.accessibility.AccessibleState[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleState"/></param>
        public AccessibleStateSet(Javax.Accessibility.AccessibleState[] arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#add(javax.accessibility.AccessibleState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleState"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Javax.Accessibility.AccessibleState arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#contains(javax.accessibility.AccessibleState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleState"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Javax.Accessibility.AccessibleState arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#remove(javax.accessibility.AccessibleState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleState"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Javax.Accessibility.AccessibleState arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#toArray()"/>
        /// </summary>

        /// <returns><see cref="Javax.Accessibility.AccessibleState"/></returns>
        public Javax.Accessibility.AccessibleState[] ToArray()
        {
            return IExecuteArray<Javax.Accessibility.AccessibleState>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#addAll(javax.accessibility.AccessibleState[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Accessibility.AccessibleState"/></param>
        public void AddAll(Javax.Accessibility.AccessibleState[] arg0)
        {
            IExecute("addAll", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleStateSet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}