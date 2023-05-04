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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im.Spi
{
    #region InputMethod
    public partial class InputMethod
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getControlObject()"/> 
        /// </summary>
        public object ControlObject
        {
            get { return IExecute("getControlObject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#isCompositionEnabled()"/> 
        /// </summary>
        public bool IsCompositionEnabled
        {
            get { return IExecute<bool>("isCompositionEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetLocale(Java.Util.Locale arg0)
        {
            return IExecute<bool>("setLocale", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#activate()"/>
        /// </summary>
        public void Activate()
        {
            IExecute("activate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#deactivate(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Deactivate(bool arg0)
        {
            IExecute("deactivate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        public void DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            IExecute("dispatchEvent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#endComposition()"/>
        /// </summary>
        public void EndComposition()
        {
            IExecute("endComposition");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#hideWindows()"/>
        /// </summary>
        public void HideWindows()
        {
            IExecute("hideWindows");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#notifyClientWindowChange(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void NotifyClientWindowChange(Java.Awt.Rectangle arg0)
        {
            IExecute("notifyClientWindowChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#reconvert()"/>
        /// </summary>
        public void Reconvert()
        {
            IExecute("reconvert");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#removeNotify()"/>
        /// </summary>
        public void RemoveNotify()
        {
            IExecute("removeNotify");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCharacterSubsets(java.lang.Character.Subset[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Character.Subset"/></param>
        public void SetCharacterSubsets(Java.Lang.Character.Subset[] arg0)
        {
            IExecute("setCharacterSubsets", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setCompositionEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCompositionEnabled(bool arg0)
        {
            IExecute("setCompositionEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethod.html#setInputMethodContext(java.awt.im.spi.InputMethodContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.Spi.InputMethodContext"/></param>
        public void SetInputMethodContext(Java.Awt.Im.Spi.InputMethodContext arg0)
        {
            IExecute("setInputMethodContext", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}