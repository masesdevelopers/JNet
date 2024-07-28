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
    #region JComponent
    public partial class JComponent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComponent"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.JComponent t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#UNDEFINED_CONDITION"/>
        /// </summary>
        public static int UNDEFINED_CONDITION { get { if (!_UNDEFINED_CONDITIONReady) { _UNDEFINED_CONDITIONContent = SGetField<int>(LocalBridgeClazz, "UNDEFINED_CONDITION"); _UNDEFINED_CONDITIONReady = true; } return _UNDEFINED_CONDITIONContent; } }
        private static int _UNDEFINED_CONDITIONContent = default;
        private static bool _UNDEFINED_CONDITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_ANCESTOR_OF_FOCUSED_COMPONENT"/>
        /// </summary>
        public static int WHEN_ANCESTOR_OF_FOCUSED_COMPONENT { get { if (!_WHEN_ANCESTOR_OF_FOCUSED_COMPONENTReady) { _WHEN_ANCESTOR_OF_FOCUSED_COMPONENTContent = SGetField<int>(LocalBridgeClazz, "WHEN_ANCESTOR_OF_FOCUSED_COMPONENT"); _WHEN_ANCESTOR_OF_FOCUSED_COMPONENTReady = true; } return _WHEN_ANCESTOR_OF_FOCUSED_COMPONENTContent; } }
        private static int _WHEN_ANCESTOR_OF_FOCUSED_COMPONENTContent = default;
        private static bool _WHEN_ANCESTOR_OF_FOCUSED_COMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_FOCUSED"/>
        /// </summary>
        public static int WHEN_FOCUSED { get { if (!_WHEN_FOCUSEDReady) { _WHEN_FOCUSEDContent = SGetField<int>(LocalBridgeClazz, "WHEN_FOCUSED"); _WHEN_FOCUSEDReady = true; } return _WHEN_FOCUSEDContent; } }
        private static int _WHEN_FOCUSEDContent = default;
        private static bool _WHEN_FOCUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_IN_FOCUSED_WINDOW"/>
        /// </summary>
        public static int WHEN_IN_FOCUSED_WINDOW { get { if (!_WHEN_IN_FOCUSED_WINDOWReady) { _WHEN_IN_FOCUSED_WINDOWContent = SGetField<int>(LocalBridgeClazz, "WHEN_IN_FOCUSED_WINDOW"); _WHEN_IN_FOCUSED_WINDOWReady = true; } return _WHEN_IN_FOCUSED_WINDOWContent; } }
        private static int _WHEN_IN_FOCUSED_WINDOWContent = default;
        private static bool _WHEN_IN_FOCUSED_WINDOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#TOOL_TIP_TEXT_KEY"/>
        /// </summary>
        public static Java.Lang.String TOOL_TIP_TEXT_KEY { get { if (!_TOOL_TIP_TEXT_KEYReady) { _TOOL_TIP_TEXT_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOOL_TIP_TEXT_KEY"); _TOOL_TIP_TEXT_KEYReady = true; } return _TOOL_TIP_TEXT_KEYContent; } }
        private static Java.Lang.String _TOOL_TIP_TEXT_KEYContent = default;
        private static bool _TOOL_TIP_TEXT_KEYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getDefaultLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDefaultLocale(java.util.Locale)"/>
        /// </summary>
        public static Java.Util.Locale DefaultLocale
        {
            get { return SExecuteWithSignature<Java.Util.Locale>(LocalBridgeClazz, "getDefaultLocale", "()Ljava/util/Locale;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setDefaultLocale", "(Ljava/util/Locale;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isLightweightComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLightweightComponent(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isLightweightComponent", "(Ljava/awt/Component;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getActionMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setActionMap(javax.swing.ActionMap)"/>
        /// </summary>
        public Javax.Swing.ActionMap ActionMap
        {
            get { return IExecuteWithSignature<Javax.Swing.ActionMap>("getActionMap", "()Ljavax/swing/ActionMap;"); } set { IExecuteWithSignature("setActionMap", "(Ljavax/swing/ActionMap;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getAncestorListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.AncestorListener[] AncestorListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.AncestorListener>("getAncestorListeners", "()[Ljavax/swing/event/AncestorListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getAutoscrolls()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAutoscrolls(boolean)"/>
        /// </summary>
        public bool Autoscrolls
        {
            get { return IExecuteWithSignature<bool>("getAutoscrolls", "()Z"); } set { IExecuteWithSignature("setAutoscrolls", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border Border
        {
            get { return IExecuteWithSignature<Javax.Swing.Border.Border>("getBorder", "()Ljavax/swing/border/Border;"); } set { IExecuteWithSignature("setBorder", "(Ljavax/swing/border/Border;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getComponentPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setComponentPopupMenu(javax.swing.JPopupMenu)"/>
        /// </summary>
        public Javax.Swing.JPopupMenu ComponentPopupMenu
        {
            get { return IExecuteWithSignature<Javax.Swing.JPopupMenu>("getComponentPopupMenu", "()Ljavax/swing/JPopupMenu;"); } set { IExecuteWithSignature("setComponentPopupMenu", "(Ljavax/swing/JPopupMenu;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getDebugGraphicsOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDebugGraphicsOptions(int)"/>
        /// </summary>
        public int DebugGraphicsOptions
        {
            get { return IExecuteWithSignature<int>("getDebugGraphicsOptions", "()I"); } set { IExecuteWithSignature("setDebugGraphicsOptions", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInheritsPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInheritsPopupMenu(boolean)"/>
        /// </summary>
        public bool InheritsPopupMenu
        {
            get { return IExecuteWithSignature<bool>("getInheritsPopupMenu", "()Z"); } set { IExecuteWithSignature("setInheritsPopupMenu", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputMap()"/> 
        /// </summary>
        public Javax.Swing.InputMap InputMap
        {
            get { return IExecuteWithSignature<Javax.Swing.InputMap>("getInputMap", "()Ljavax/swing/InputMap;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputVerifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInputVerifier(javax.swing.InputVerifier)"/>
        /// </summary>
        public Javax.Swing.InputVerifier InputVerifier
        {
            get { return IExecuteWithSignature<Javax.Swing.InputVerifier>("getInputVerifier", "()Ljavax/swing/InputVerifier;"); } set { IExecuteWithSignature("setInputVerifier", "(Ljavax/swing/InputVerifier;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getRegisteredKeyStrokes()"/> 
        /// </summary>
        public Javax.Swing.KeyStroke[] RegisteredKeyStrokes
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.KeyStroke>("getRegisteredKeyStrokes", "()[Ljavax/swing/KeyStroke;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getRootPane()"/> 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JRootPane>("getRootPane", "()Ljavax/swing/JRootPane;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setToolTipText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ToolTipText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getToolTipText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setToolTipText", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getTopLevelAncestor()"/> 
        /// </summary>
        public Java.Awt.Container TopLevelAncestor
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getTopLevelAncestor", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getTransferHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setTransferHandler(javax.swing.TransferHandler)"/>
        /// </summary>
        public Javax.Swing.TransferHandler TransferHandler
        {
            get { return IExecuteWithSignature<Javax.Swing.TransferHandler>("getTransferHandler", "()Ljavax/swing/TransferHandler;"); } set { IExecuteWithSignature("setTransferHandler", "(Ljavax/swing/TransferHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getUI()"/> 
        /// </summary>
        public Javax.Swing.Plaf.ComponentUI UI
        {
            get { return IExecuteWithSignature<Javax.Swing.Plaf.ComponentUI>("getUI", "()Ljavax/swing/plaf/ComponentUI;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getUIClassID()"/> 
        /// </summary>
        public Java.Lang.String UIClassID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUIClassID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVerifyInputWhenFocusTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setVerifyInputWhenFocusTarget(boolean)"/>
        /// </summary>
        public bool VerifyInputWhenFocusTarget
        {
            get { return IExecuteWithSignature<bool>("getVerifyInputWhenFocusTarget", "()Z"); } set { IExecuteWithSignature("setVerifyInputWhenFocusTarget", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVetoableChangeListeners()"/> 
        /// </summary>
        public Java.Beans.VetoableChangeListener[] VetoableChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners", "()[Ljava/beans/VetoableChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVisibleRect()"/> 
        /// </summary>
        public Java.Awt.Rectangle VisibleRect
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getVisibleRect", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isOptimizedDrawingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOptimizedDrawingEnabled()
        {
            return IExecuteWithSignature<bool>("isOptimizedDrawingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isPaintingTile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPaintingTile()
        {
            return IExecuteWithSignature<bool>("isPaintingTile", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isRequestFocusEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequestFocusEnabled()
        {
            return IExecuteWithSignature<bool>("isRequestFocusEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#requestFocus(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestFocus(bool arg0)
        {
            return IExecuteWithSignature<bool>("requestFocus", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isPaintingForPrint()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPaintingForPrint()
        {
            return IExecuteWithSignature<bool>("isPaintingForPrint", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getClientProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetClientProperty(object arg0)
        {
            return IExecuteWithSignature("getClientProperty", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputMap(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.InputMap"/></returns>
        public Javax.Swing.InputMap GetInputMap(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.InputMap>("getInputMap", "(I)Ljavax/swing/InputMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#putClientProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutClientProperty(object arg0, object arg1)
        {
            IExecute("putClientProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInputMap(int,javax.swing.InputMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.InputMap"/></param>
        public void SetInputMap(int arg0, Javax.Swing.InputMap arg1)
        {
            IExecute("setInputMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getConditionForKeyStroke(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConditionForKeyStroke(Javax.Swing.KeyStroke arg0)
        {
            return IExecuteWithSignature<int>("getConditionForKeyStroke", "(Ljavax/swing/KeyStroke;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getActionForKeyStroke(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="Java.Awt.EventNs.ActionListener"/></returns>
        public Java.Awt.EventNs.ActionListener GetActionForKeyStroke(Javax.Swing.KeyStroke arg0)
        {
            return IExecuteWithSignature<Java.Awt.EventNs.ActionListener>("getActionForKeyStroke", "(Ljavax/swing/KeyStroke;)Ljava/awt/event/ActionListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getActionForKeyStroke(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="Java.Awt.EventNs.ActionListener"/></returns>
        public Java.Awt.EventNs.ActionListener GetActionForKeyStrokeDirect(Javax.Swing.KeyStroke arg0)
        {
            return IExecuteWithSignature<Java.Awt.EventNs.ActionListenerDirect, Java.Awt.EventNs.ActionListener>("getActionForKeyStroke", "(Ljavax/swing/KeyStroke;)Ljava/awt/event/ActionListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInsets(java.awt.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Insets"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(Java.Awt.Insets arg0)
        {
            return IExecuteWithSignature<Java.Awt.Insets>("getInsets", "(Ljava/awt/Insets;)Ljava/awt/Insets;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getPopupLocation(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point GetPopupLocation(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecuteWithSignature<Java.Awt.Point>("getPopupLocation", "(Ljava/awt/event/MouseEvent;)Ljava/awt/Point;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipLocation(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point GetToolTipLocation(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecuteWithSignature<Java.Awt.Point>("getToolTipLocation", "(Ljava/awt/event/MouseEvent;)Ljava/awt/Point;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipText(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetToolTipText(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getToolTipText", "(Ljava/awt/event/MouseEvent;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#createToolTip()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.JToolTip"/></returns>
        public Javax.Swing.JToolTip CreateToolTip()
        {
            return IExecuteWithSignature<Javax.Swing.JToolTip>("createToolTip", "()Ljavax/swing/JToolTip;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#addVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecuteWithSignature("addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#removeVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecuteWithSignature("removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#addAncestorListener(javax.swing.event.AncestorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorListener"/></param>
        public void AddAncestorListener(Javax.Swing.Event.AncestorListener arg0)
        {
            IExecuteWithSignature("addAncestorListener", "(Ljavax/swing/event/AncestorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#computeVisibleRect(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void ComputeVisibleRect(Java.Awt.Rectangle arg0)
        {
            IExecuteWithSignature("computeVisibleRect", "(Ljava/awt/Rectangle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#firePropertyChange(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void FirePropertyChange(Java.Lang.String arg0, bool arg1, bool arg2)
        {
            IExecute("firePropertyChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#firePropertyChange(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void FirePropertyChange(Java.Lang.String arg0, int arg1, int arg2)
        {
            IExecute("firePropertyChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#grabFocus()"/>
        /// </summary>
        public void GrabFocus()
        {
            IExecuteWithSignature("grabFocus", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#paintImmediately(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void PaintImmediately(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("paintImmediately", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#paintImmediately(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void PaintImmediately(Java.Awt.Rectangle arg0)
        {
            IExecuteWithSignature("paintImmediately", "(Ljava/awt/Rectangle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#registerKeyboardAction(java.awt.event.ActionListener,java.lang.String,javax.swing.KeyStroke,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void RegisterKeyboardAction(Java.Awt.EventNs.ActionListener arg0, Java.Lang.String arg1, Javax.Swing.KeyStroke arg2, int arg3)
        {
            IExecute("registerKeyboardAction", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#registerKeyboardAction(java.awt.event.ActionListener,javax.swing.KeyStroke,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RegisterKeyboardAction(Java.Awt.EventNs.ActionListener arg0, Javax.Swing.KeyStroke arg1, int arg2)
        {
            IExecute("registerKeyboardAction", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#removeAncestorListener(javax.swing.event.AncestorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorListener"/></param>
        public void RemoveAncestorListener(Javax.Swing.Event.AncestorListener arg0)
        {
            IExecuteWithSignature("removeAncestorListener", "(Ljavax/swing/event/AncestorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#repaint(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void Repaint(Java.Awt.Rectangle arg0)
        {
            IExecuteWithSignature("repaint", "(Ljava/awt/Rectangle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#resetKeyboardActions()"/>
        /// </summary>
        public void ResetKeyboardActions()
        {
            IExecuteWithSignature("resetKeyboardActions", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#scrollRectToVisible(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void ScrollRectToVisible(Java.Awt.Rectangle arg0)
        {
            IExecuteWithSignature("scrollRectToVisible", "(Ljava/awt/Rectangle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAlignmentX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAlignmentX(float arg0)
        {
            IExecuteWithSignature("setAlignmentX", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAlignmentY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAlignmentY(float arg0)
        {
            IExecuteWithSignature("setAlignmentY", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDoubleBuffered(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDoubleBuffered(bool arg0)
        {
            IExecuteWithSignature("setDoubleBuffered", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setOpaque(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOpaque(bool arg0)
        {
            IExecuteWithSignature("setOpaque", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setRequestFocusEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRequestFocusEnabled(bool arg0)
        {
            IExecuteWithSignature("setRequestFocusEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#unregisterKeyboardAction(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        public void UnregisterKeyboardAction(Javax.Swing.KeyStroke arg0)
        {
            IExecuteWithSignature("unregisterKeyboardAction", "(Ljavax/swing/KeyStroke;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#updateUI()"/>
        /// </summary>
        public void UpdateUI()
        {
            IExecuteWithSignature("updateUI", "()V");
        }

        #endregion

        #region Nested classes
        #region AccessibleJComponent
        public partial class AccessibleJComponent
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getAccessibleKeyBinding()"/> 
            /// </summary>
            public Javax.Accessibility.AccessibleKeyBinding AccessibleKeyBinding
            {
                get { return IExecuteWithSignature<Javax.Accessibility.AccessibleKeyBinding>("getAccessibleKeyBinding", "()Ljavax/accessibility/AccessibleKeyBinding;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getTitledBorderText()"/> 
            /// </summary>
            public Java.Lang.String TitledBorderText
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getTitledBorderText", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getToolTipText()"/> 
            /// </summary>
            public Java.Lang.String ToolTipText
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getToolTipText", "()Ljava/lang/String;"); }
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