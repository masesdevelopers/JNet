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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicOptionPaneUI
    public partial class BasicOptionPaneUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#MinimumHeight"/>
        /// </summary>
        public static int MinimumHeight { get { if (!_MinimumHeightReady) { _MinimumHeightContent = SGetField<int>(LocalBridgeClazz, "MinimumHeight"); _MinimumHeightReady = true; } return _MinimumHeightContent; } }
        private static int _MinimumHeightContent = default;
        private static bool _MinimumHeightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#MinimumWidth"/>
        /// </summary>
        public static int MinimumWidth { get { if (!_MinimumWidthReady) { _MinimumWidthContent = SGetField<int>(LocalBridgeClazz, "MinimumWidth"); _MinimumWidthReady = true; } return _MinimumWidthContent; } }
        private static int _MinimumWidthContent = default;
        private static bool _MinimumWidthReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#getMinimumOptionPaneSize()"/> 
        /// </summary>
        public Java.Awt.Dimension MinimumOptionPaneSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getMinimumOptionPaneSize", "()Ljava/awt/Dimension;"); }
        }

        #endregion

        #region Nested classes
        #region ButtonAreaLayout
        public partial class ButtonAreaLayout
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#%3Cinit%3E(boolean,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public ButtonAreaLayout(bool arg0, int arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getCentersChildren()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setCentersChildren(boolean)"/>
            /// </summary>
            public bool CentersChildren
            {
                get { return IExecuteWithSignature<bool>("getCentersChildren", "()Z"); } set { IExecuteWithSignature("setCentersChildren", "(Z)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getPadding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setPadding(int)"/>
            /// </summary>
            public int Padding
            {
                get { return IExecuteWithSignature<int>("getPadding", "()I"); } set { IExecuteWithSignature("setPadding", "(I)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getSyncAllWidths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setSyncAllWidths(boolean)"/>
            /// </summary>
            public bool SyncAllWidths
            {
                get { return IExecuteWithSignature<bool>("getSyncAllWidths", "()Z"); } set { IExecuteWithSignature("setSyncAllWidths", "(Z)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#removeLayoutComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.PropertyChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicOptionPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicOptionPaneUI"/></param>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicOptionPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicOptionPaneUI.PropertyChangeHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicOptionPaneUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
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