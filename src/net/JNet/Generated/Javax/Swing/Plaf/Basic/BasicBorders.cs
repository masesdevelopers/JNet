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
    #region BasicBorders
    public partial class BasicBorders
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getButtonBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetButtonBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getButtonBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getMenuBarBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetMenuBarBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getMenuBarBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getRadioButtonBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetRadioButtonBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getRadioButtonBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getSplitPaneBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetSplitPaneBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getSplitPaneBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getSplitPaneDividerBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetSplitPaneDividerBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getSplitPaneDividerBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getToggleButtonBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetToggleButtonBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getToggleButtonBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getInternalFrameBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border InternalFrameBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getInternalFrameBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getProgressBarBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border ProgressBarBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getProgressBarBorder", "()Ljavax/swing/border/Border;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.html#getTextFieldBorder()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border TextFieldBorder
        {
            get { return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getTextFieldBorder", "()Ljavax/swing/border/Border;"); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ButtonBorder
        public partial class ButtonBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.ButtonBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            public ButtonBorder(Java.Awt.Color arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.ButtonBorder"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicBorders.ButtonBorder t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

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

        #region FieldBorder
        public partial class FieldBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.FieldBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            public FieldBorder(Java.Awt.Color arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.FieldBorder"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicBorders.FieldBorder t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

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

        #region MarginBorder
        public partial class MarginBorder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.MarginBorder"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicBorders.MarginBorder t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

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

        #region MenuBarBorder
        public partial class MenuBarBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.MenuBarBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            public MenuBarBorder(Java.Awt.Color arg0, Java.Awt.Color arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.MenuBarBorder"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicBorders.MenuBarBorder t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

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

        #region RadioButtonBorder
        public partial class RadioButtonBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.RadioButtonBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            public RadioButtonBorder(Java.Awt.Color arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3)
                : base(arg0, arg1, arg2, arg3)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RolloverButtonBorder
        public partial class RolloverButtonBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.RolloverButtonBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            public RolloverButtonBorder(Java.Awt.Color arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3)
                : base(arg0, arg1, arg2, arg3)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SplitPaneBorder
        public partial class SplitPaneBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.SplitPaneBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            public SplitPaneBorder(Java.Awt.Color arg0, Java.Awt.Color arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.SplitPaneBorder"/> to <see cref="Javax.Swing.Border.Border"/>
            /// </summary>
            public static implicit operator Javax.Swing.Border.Border(Javax.Swing.Plaf.Basic.BasicBorders.SplitPaneBorder t) => t.Cast<Javax.Swing.Border.Border>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicBorders.SplitPaneBorder"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicBorders.SplitPaneBorder t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.SplitPaneBorder.html#isBorderOpaque()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsBorderOpaque()
            {
                return IExecuteWithSignature<bool>("isBorderOpaque", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.SplitPaneBorder.html#getBorderInsets(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <returns><see cref="Java.Awt.Insets"/></returns>
            public Java.Awt.Insets GetBorderInsets(Java.Awt.Component arg0)
            {
                return IExecuteWithSignature<Java.Awt.Insets>("getBorderInsets", "(Ljava/awt/Component;)Ljava/awt/Insets;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.SplitPaneBorder.html#paintBorder(java.awt.Component,java.awt.Graphics,int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="int"/></param>
            public void PaintBorder(Java.Awt.Component arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
            {
                IExecute("paintBorder", arg0, arg1, arg2, arg3, arg4, arg5);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ToggleButtonBorder
        public partial class ToggleButtonBorder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicBorders.ToggleButtonBorder.html#%3Cinit%3E(java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            public ToggleButtonBorder(Java.Awt.Color arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3)
                : base(arg0, arg1, arg2, arg3)
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