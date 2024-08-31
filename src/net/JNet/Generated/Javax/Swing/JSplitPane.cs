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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JSplitPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html"/>
    /// </summary>
    public partial class JSplitPane : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JSplitPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JSplitPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JSplitPane(params object[] args) : base(args) { }

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

    #region JSplitPane implementation
    public partial class JSplitPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,boolean,java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        public JSplitPane(int arg0, bool arg1, Java.Awt.Component arg2, Java.Awt.Component arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JSplitPane(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        public JSplitPane(int arg0, Java.Awt.Component arg1, Java.Awt.Component arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JSplitPane(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSplitPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JSplitPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#HORIZONTAL_SPLIT"/>
        /// </summary>
        public static int HORIZONTAL_SPLIT { get { if (!_HORIZONTAL_SPLITReady) { _HORIZONTAL_SPLITContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL_SPLIT"); _HORIZONTAL_SPLITReady = true; } return _HORIZONTAL_SPLITContent; } }
        private static int _HORIZONTAL_SPLITContent = default;
        private static bool _HORIZONTAL_SPLITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#VERTICAL_SPLIT"/>
        /// </summary>
        public static int VERTICAL_SPLIT { get { if (!_VERTICAL_SPLITReady) { _VERTICAL_SPLITContent = SGetField<int>(LocalBridgeClazz, "VERTICAL_SPLIT"); _VERTICAL_SPLITReady = true; } return _VERTICAL_SPLITContent; } }
        private static int _VERTICAL_SPLITContent = default;
        private static bool _VERTICAL_SPLITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#BOTTOM"/>
        /// </summary>
        public static Java.Lang.String BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static Java.Lang.String _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#CONTINUOUS_LAYOUT_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String CONTINUOUS_LAYOUT_PROPERTY { get { if (!_CONTINUOUS_LAYOUT_PROPERTYReady) { _CONTINUOUS_LAYOUT_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONTINUOUS_LAYOUT_PROPERTY"); _CONTINUOUS_LAYOUT_PROPERTYReady = true; } return _CONTINUOUS_LAYOUT_PROPERTYContent; } }
        private static Java.Lang.String _CONTINUOUS_LAYOUT_PROPERTYContent = default;
        private static bool _CONTINUOUS_LAYOUT_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER"/>
        /// </summary>
        public static Java.Lang.String DIVIDER { get { if (!_DIVIDERReady) { _DIVIDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DIVIDER"); _DIVIDERReady = true; } return _DIVIDERContent; } }
        private static Java.Lang.String _DIVIDERContent = default;
        private static bool _DIVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER_LOCATION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String DIVIDER_LOCATION_PROPERTY { get { if (!_DIVIDER_LOCATION_PROPERTYReady) { _DIVIDER_LOCATION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DIVIDER_LOCATION_PROPERTY"); _DIVIDER_LOCATION_PROPERTYReady = true; } return _DIVIDER_LOCATION_PROPERTYContent; } }
        private static Java.Lang.String _DIVIDER_LOCATION_PROPERTYContent = default;
        private static bool _DIVIDER_LOCATION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER_SIZE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String DIVIDER_SIZE_PROPERTY { get { if (!_DIVIDER_SIZE_PROPERTYReady) { _DIVIDER_SIZE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DIVIDER_SIZE_PROPERTY"); _DIVIDER_SIZE_PROPERTYReady = true; } return _DIVIDER_SIZE_PROPERTYContent; } }
        private static Java.Lang.String _DIVIDER_SIZE_PROPERTYContent = default;
        private static bool _DIVIDER_SIZE_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#LAST_DIVIDER_LOCATION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String LAST_DIVIDER_LOCATION_PROPERTY { get { if (!_LAST_DIVIDER_LOCATION_PROPERTYReady) { _LAST_DIVIDER_LOCATION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LAST_DIVIDER_LOCATION_PROPERTY"); _LAST_DIVIDER_LOCATION_PROPERTYReady = true; } return _LAST_DIVIDER_LOCATION_PROPERTYContent; } }
        private static Java.Lang.String _LAST_DIVIDER_LOCATION_PROPERTYContent = default;
        private static bool _LAST_DIVIDER_LOCATION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#LEFT"/>
        /// </summary>
        public static Java.Lang.String LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static Java.Lang.String _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#ONE_TOUCH_EXPANDABLE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ONE_TOUCH_EXPANDABLE_PROPERTY { get { if (!_ONE_TOUCH_EXPANDABLE_PROPERTYReady) { _ONE_TOUCH_EXPANDABLE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ONE_TOUCH_EXPANDABLE_PROPERTY"); _ONE_TOUCH_EXPANDABLE_PROPERTYReady = true; } return _ONE_TOUCH_EXPANDABLE_PROPERTYContent; } }
        private static Java.Lang.String _ONE_TOUCH_EXPANDABLE_PROPERTYContent = default;
        private static bool _ONE_TOUCH_EXPANDABLE_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#ORIENTATION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ORIENTATION_PROPERTY { get { if (!_ORIENTATION_PROPERTYReady) { _ORIENTATION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ORIENTATION_PROPERTY"); _ORIENTATION_PROPERTYReady = true; } return _ORIENTATION_PROPERTYContent; } }
        private static Java.Lang.String _ORIENTATION_PROPERTYContent = default;
        private static bool _ORIENTATION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#RESIZE_WEIGHT_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String RESIZE_WEIGHT_PROPERTY { get { if (!_RESIZE_WEIGHT_PROPERTYReady) { _RESIZE_WEIGHT_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESIZE_WEIGHT_PROPERTY"); _RESIZE_WEIGHT_PROPERTYReady = true; } return _RESIZE_WEIGHT_PROPERTYContent; } }
        private static Java.Lang.String _RESIZE_WEIGHT_PROPERTYContent = default;
        private static bool _RESIZE_WEIGHT_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#RIGHT"/>
        /// </summary>
        public static Java.Lang.String RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static Java.Lang.String _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#TOP"/>
        /// </summary>
        public static Java.Lang.String TOP { get { if (!_TOPReady) { _TOPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static Java.Lang.String _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getBottomComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setBottomComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component BottomComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getBottomComponent", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setBottomComponent", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getDividerLocation()"/> 
        /// </summary>
        public int DividerLocation
        {
            get { return IExecuteWithSignature<int>("getDividerLocation", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getDividerSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerSize(int)"/>
        /// </summary>
        public int DividerSize
        {
            get { return IExecuteWithSignature<int>("getDividerSize", "()I"); } set { IExecuteWithSignature("setDividerSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getLastDividerLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setLastDividerLocation(int)"/>
        /// </summary>
        public int LastDividerLocation
        {
            get { return IExecuteWithSignature<int>("getLastDividerLocation", "()I"); } set { IExecuteWithSignature("setLastDividerLocation", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getLeftComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setLeftComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component LeftComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getLeftComponent", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setLeftComponent", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getMaximumDividerLocation()"/> 
        /// </summary>
        public int MaximumDividerLocation
        {
            get { return IExecuteWithSignature<int>("getMaximumDividerLocation", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getMinimumDividerLocation()"/> 
        /// </summary>
        public int MinimumDividerLocation
        {
            get { return IExecuteWithSignature<int>("getMinimumDividerLocation", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecuteWithSignature<int>("getOrientation", "()I"); } set { IExecuteWithSignature("setOrientation", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getResizeWeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setResizeWeight(double)"/>
        /// </summary>
        public double ResizeWeight
        {
            get { return IExecuteWithSignature<double>("getResizeWeight", "()D"); } set { IExecuteWithSignature("setResizeWeight", "(D)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getRightComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setRightComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component RightComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getRightComponent", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setRightComponent", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getTopComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setTopComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component TopComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getTopComponent", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setTopComponent", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#isContinuousLayout()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsContinuousLayout()
        {
            return IExecuteWithSignature<bool>("isContinuousLayout", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#isOneTouchExpandable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOneTouchExpandable()
        {
            return IExecuteWithSignature<bool>("isOneTouchExpandable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#resetToPreferredSizes()"/>
        /// </summary>
        public void ResetToPreferredSizes()
        {
            IExecuteWithSignature("resetToPreferredSizes", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setContinuousLayout(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContinuousLayout(bool arg0)
        {
            IExecuteWithSignature("setContinuousLayout", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerLocation(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetDividerLocation(double arg0)
        {
            IExecuteWithSignature("setDividerLocation", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerLocation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDividerLocation(int arg0)
        {
            IExecuteWithSignature("setDividerLocation", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setOneTouchExpandable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOneTouchExpandable(bool arg0)
        {
            IExecuteWithSignature("setOneTouchExpandable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setUI(javax.swing.plaf.SplitPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.SplitPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.SplitPaneUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/SplitPaneUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}