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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Metal
{
    #region MetalLookAndFeel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html"/>
    /// </summary>
    public partial class MetalLookAndFeel : Javax.Swing.Plaf.Basic.BasicLookAndFeel
    {
        const string _bridgeClassName = "javax.swing.plaf.metal.MetalLookAndFeel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MetalLookAndFeel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MetalLookAndFeel(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MetalLookAndFeel implementation
    public partial class MetalLookAndFeel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getAcceleratorForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource AcceleratorForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getAcceleratorForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getAcceleratorSelectedForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource AcceleratorSelectedForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getAcceleratorSelectedForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getBlack()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource Black
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getBlack", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControl()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource Control
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControl", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlDarkShadow()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlDarkShadow
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlDarkShadow", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlDisabled()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlDisabled
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlDisabled", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlHighlight()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlHighlight
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlHighlight", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlInfo()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlInfo
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlInfo", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlShadow()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlShadow
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlShadow", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource ControlTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getControlTextFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource ControlTextFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getControlTextFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getCurrentTheme()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#setCurrentTheme(javax.swing.plaf.metal.MetalTheme)"/>
        /// </summary>
        public static Javax.Swing.Plaf.Metal.MetalTheme CurrentTheme
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.Metal.MetalTheme>(LocalBridgeClazz, "getCurrentTheme", "()Ljavax/swing/plaf/metal/MetalTheme;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setCurrentTheme", "(Ljavax/swing/plaf/metal/MetalTheme;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getDesktopColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource DesktopColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getDesktopColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getFocusColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource FocusColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getFocusColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getHighlightedTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource HighlightedTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getHighlightedTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getInactiveControlTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource InactiveControlTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getInactiveControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getInactiveSystemTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource InactiveSystemTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getInactiveSystemTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource MenuBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getMenuBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuDisabledForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource MenuDisabledForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getMenuDisabledForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource MenuForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getMenuForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuSelectedBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource MenuSelectedBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getMenuSelectedBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuSelectedForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource MenuSelectedForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getMenuSelectedForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getMenuTextFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource MenuTextFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getMenuTextFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getPrimaryControl()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource PrimaryControl
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getPrimaryControl", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getPrimaryControlDarkShadow()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource PrimaryControlDarkShadow
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getPrimaryControlDarkShadow", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getPrimaryControlHighlight()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource PrimaryControlHighlight
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getPrimaryControlHighlight", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getPrimaryControlInfo()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource PrimaryControlInfo
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getPrimaryControlInfo", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getPrimaryControlShadow()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource PrimaryControlShadow
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getPrimaryControlShadow", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getSeparatorBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource SeparatorBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getSeparatorBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getSeparatorForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource SeparatorForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getSeparatorForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getSubTextFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource SubTextFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getSubTextFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getSystemTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource SystemTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getSystemTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getSystemTextFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource SystemTextFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getSystemTextFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getTextHighlightColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource TextHighlightColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getTextHighlightColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getUserTextColor()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource UserTextColor
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getUserTextColor", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getUserTextFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource UserTextFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getUserTextFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWhite()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource White
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWhite", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource WindowBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWindowBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowTitleBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource WindowTitleBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWindowTitleBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowTitleFont()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.FontUIResource WindowTitleFont
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.FontUIResource>(LocalBridgeClazz, "getWindowTitleFont", "()Ljavax/swing/plaf/FontUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowTitleForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource WindowTitleForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWindowTitleForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowTitleInactiveBackground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource WindowTitleInactiveBackground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWindowTitleInactiveBackground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalLookAndFeel.html#getWindowTitleInactiveForeground()"/> 
        /// </summary>
        public static Javax.Swing.Plaf.ColorUIResource WindowTitleInactiveForeground
        {
            get { return SExecuteWithSignature<Javax.Swing.Plaf.ColorUIResource>(LocalBridgeClazz, "getWindowTitleInactiveForeground", "()Ljavax/swing/plaf/ColorUIResource;"); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}