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
    #region JScrollBar declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html"/>
    /// </summary>
    public partial class JScrollBar : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JScrollBar";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JScrollBar() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JScrollBar(params object[] args) : base(args) { }

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

    #region JScrollBar implementation
    public partial class JScrollBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public JScrollBar(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JScrollBar(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollBar"/> to <see cref="Java.Awt.Adjustable"/>
        /// </summary>
        public static implicit operator Java.Awt.Adjustable(Javax.Swing.JScrollBar t) => t.Cast<Java.Awt.Adjustable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollBar"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JScrollBar t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getAdjustmentListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.AdjustmentListener[] AdjustmentListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.AdjustmentListener>("getAdjustmentListeners", "()[Ljava/awt/event/AdjustmentListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setBlockIncrement(int)"/>
        /// </summary>
        public int BlockIncrement
        {
            get { return IExecuteWithSignature<int>("getBlockIncrement", "()I"); } set { IExecuteWithSignature("setBlockIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecuteWithSignature<int>("getMaximum", "()I"); } set { IExecuteWithSignature("setMaximum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecuteWithSignature<int>("getMinimum", "()I"); } set { IExecuteWithSignature("setMinimum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setModel(javax.swing.BoundedRangeModel)"/>
        /// </summary>
        public Javax.Swing.BoundedRangeModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.BoundedRangeModel>("getModel", "()Ljavax/swing/BoundedRangeModel;"); } set { IExecuteWithSignature("setModel", "(Ljavax/swing/BoundedRangeModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecuteWithSignature<int>("getOrientation", "()I"); } set { IExecuteWithSignature("setOrientation", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setUnitIncrement(int)"/>
        /// </summary>
        public int UnitIncrement
        {
            get { return IExecuteWithSignature<int>("getUnitIncrement", "()I"); } set { IExecuteWithSignature("setUnitIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecuteWithSignature<bool>("getValueIsAdjusting", "()Z"); } set { IExecuteWithSignature("setValueIsAdjusting", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setVisibleAmount(int)"/>
        /// </summary>
        public int VisibleAmount
        {
            get { return IExecuteWithSignature<int>("getVisibleAmount", "()I"); } set { IExecuteWithSignature("setVisibleAmount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getBlockIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBlockIncrement(int arg0)
        {
            return IExecuteWithSignature<int>("getBlockIncrement", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#getUnitIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetUnitIncrement(int arg0)
        {
            return IExecuteWithSignature<int>("getUnitIncrement", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void RemoveAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("removeAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setUI(javax.swing.plaf.ScrollBarUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ScrollBarUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ScrollBarUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/ScrollBarUI;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollBar.html#setValues(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetValues(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setValues", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}