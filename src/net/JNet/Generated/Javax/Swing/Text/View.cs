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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region View
    public partial class View
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#%3Cinit%3E(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public View(Javax.Swing.Text.Element arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#BadBreakWeight"/>
        /// </summary>
        public static int BadBreakWeight { get { if (!_BadBreakWeightReady) { _BadBreakWeightContent = SGetField<int>(LocalBridgeClazz, "BadBreakWeight"); _BadBreakWeightReady = true; } return _BadBreakWeightContent; } }
        private static int _BadBreakWeightContent = default;
        private static bool _BadBreakWeightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#ExcellentBreakWeight"/>
        /// </summary>
        public static int ExcellentBreakWeight { get { if (!_ExcellentBreakWeightReady) { _ExcellentBreakWeightContent = SGetField<int>(LocalBridgeClazz, "ExcellentBreakWeight"); _ExcellentBreakWeightReady = true; } return _ExcellentBreakWeightContent; } }
        private static int _ExcellentBreakWeightContent = default;
        private static bool _ExcellentBreakWeightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#ForcedBreakWeight"/>
        /// </summary>
        public static int ForcedBreakWeight { get { if (!_ForcedBreakWeightReady) { _ForcedBreakWeightContent = SGetField<int>(LocalBridgeClazz, "ForcedBreakWeight"); _ForcedBreakWeightReady = true; } return _ForcedBreakWeightContent; } }
        private static int _ForcedBreakWeightContent = default;
        private static bool _ForcedBreakWeightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#GoodBreakWeight"/>
        /// </summary>
        public static int GoodBreakWeight { get { if (!_GoodBreakWeightReady) { _GoodBreakWeightContent = SGetField<int>(LocalBridgeClazz, "GoodBreakWeight"); _GoodBreakWeightReady = true; } return _GoodBreakWeightContent; } }
        private static int _GoodBreakWeightContent = default;
        private static bool _GoodBreakWeightReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#X_AXIS"/>
        /// </summary>
        public static int X_AXIS { get { if (!_X_AXISReady) { _X_AXISContent = SGetField<int>(LocalBridgeClazz, "X_AXIS"); _X_AXISReady = true; } return _X_AXISContent; } }
        private static int _X_AXISContent = default;
        private static bool _X_AXISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#Y_AXIS"/>
        /// </summary>
        public static int Y_AXIS { get { if (!_Y_AXISReady) { _Y_AXISContent = SGetField<int>(LocalBridgeClazz, "Y_AXIS"); _Y_AXISReady = true; } return _Y_AXISContent; } }
        private static int _Y_AXISContent = default;
        private static bool _Y_AXISReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet Attributes
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getAttributes", "()Ljavax/swing/text/AttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getContainer()"/> 
        /// </summary>
        public Java.Awt.Container Container
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getContainer", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getDocument()"/> 
        /// </summary>
        public Javax.Swing.Text.Document Document
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Document>("getDocument", "()Ljavax/swing/text/Document;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getElement()"/> 
        /// </summary>
        public Javax.Swing.Text.Element Element
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Element>("getElement", "()Ljavax/swing/text/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getEndOffset()"/> 
        /// </summary>
        public int EndOffset
        {
            get { return IExecuteWithSignature<int>("getEndOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics Graphics
        {
            get { return IExecuteWithSignature<Java.Awt.Graphics>("getGraphics", "()Ljava/awt/Graphics;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#setParent(javax.swing.text.View)"/>
        /// </summary>
        public Javax.Swing.Text.View Parent
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.View>("getParent", "()Ljavax/swing/text/View;"); } set { IExecuteWithSignature("setParent", "(Ljavax/swing/text/View;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getStartOffset()"/> 
        /// </summary>
        public int StartOffset
        {
            get { return IExecuteWithSignature<int>("getStartOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getViewCount()"/> 
        /// </summary>
        public int ViewCount
        {
            get { return IExecuteWithSignature<int>("getViewCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getViewFactory()"/> 
        /// </summary>
        public Javax.Swing.Text.ViewFactory ViewFactory
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.ViewFactory>("getViewFactory", "()Ljavax/swing/text/ViewFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getPreferredSpan(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetPreferredSpan(int arg0)
        {
            return IExecuteWithSignature<float>("getPreferredSpan", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#viewToModel(float,float,java.awt.Shape,javax.swing.text.Position.Bias[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="int"/></returns>
        public int ViewToModel(float arg0, float arg1, Java.Awt.Shape arg2, Javax.Swing.Text.Position.Bias[] arg3)
        {
            return IExecute<int>("viewToModel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#modelToView(int,java.awt.Shape,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Java.Awt.Shape ModelToView(int arg0, Java.Awt.Shape arg1, Javax.Swing.Text.Position.Bias arg2)
        {
            return IExecute<Java.Awt.Shape>("modelToView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#paint(java.awt.Graphics,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        public void Paint(Java.Awt.Graphics arg0, Java.Awt.Shape arg1)
        {
            IExecute("paint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#isVisible()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getAlignment(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetAlignment(int arg0)
        {
            return IExecuteWithSignature<float>("getAlignment", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getMaximumSpan(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetMaximumSpan(int arg0)
        {
            return IExecuteWithSignature<float>("getMaximumSpan", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getMinimumSpan(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetMinimumSpan(int arg0)
        {
            return IExecuteWithSignature<float>("getMinimumSpan", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getBreakWeight(int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBreakWeight(int arg0, float arg1, float arg2)
        {
            return IExecute<int>("getBreakWeight", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getNextVisualPositionFrom(int,javax.swing.text.Position.Bias,java.awt.Shape,int,javax.swing.text.Position.Bias[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public int GetNextVisualPositionFrom(int arg0, Javax.Swing.Text.Position.Bias arg1, Java.Awt.Shape arg2, int arg3, Javax.Swing.Text.Position.Bias[] arg4)
        {
            return IExecute<int>("getNextVisualPositionFrom", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getResizeWeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetResizeWeight(int arg0)
        {
            return IExecuteWithSignature<int>("getResizeWeight", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getViewIndex(float,float,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetViewIndex(float arg0, float arg1, Java.Awt.Shape arg2)
        {
            return IExecute<int>("getViewIndex", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getViewIndex(int,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetViewIndex(int arg0, Javax.Swing.Text.Position.Bias arg1)
        {
            return IExecute<int>("getViewIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getChildAllocation(int,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetChildAllocation(int arg0, Java.Awt.Shape arg1)
        {
            return IExecute<Java.Awt.Shape>("getChildAllocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#modelToView(int,javax.swing.text.Position.Bias,int,javax.swing.text.Position.Bias,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Java.Awt.Shape ModelToView(int arg0, Javax.Swing.Text.Position.Bias arg1, int arg2, Javax.Swing.Text.Position.Bias arg3, Java.Awt.Shape arg4)
        {
            return IExecute<Java.Awt.Shape>("modelToView", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getToolTipText(float,float,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetToolTipText(float arg0, float arg1, Java.Awt.Shape arg2)
        {
            return IExecute<Java.Lang.String>("getToolTipText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#breakView(int,int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View BreakView(int arg0, int arg1, float arg2, float arg3)
        {
            return IExecute<Javax.Swing.Text.View>("breakView", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#createFragment(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View CreateFragment(int arg0, int arg1)
        {
            return IExecute<Javax.Swing.Text.View>("createFragment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#getView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View GetView(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.View>("getView", "(I)Ljavax/swing/text/View;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#append(javax.swing.text.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.View"/></param>
        public void Append(Javax.Swing.Text.View arg0)
        {
            IExecuteWithSignature("append", "(Ljavax/swing/text/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#changedUpdate(javax.swing.event.DocumentEvent,java.awt.Shape,javax.swing.text.ViewFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.ViewFactory"/></param>
        public void ChangedUpdate(Javax.Swing.Event.DocumentEvent arg0, Java.Awt.Shape arg1, Javax.Swing.Text.ViewFactory arg2)
        {
            IExecute("changedUpdate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#insert(int,javax.swing.text.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.View"/></param>
        public void Insert(int arg0, Javax.Swing.Text.View arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#insertUpdate(javax.swing.event.DocumentEvent,java.awt.Shape,javax.swing.text.ViewFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.ViewFactory"/></param>
        public void InsertUpdate(Javax.Swing.Event.DocumentEvent arg0, Java.Awt.Shape arg1, Javax.Swing.Text.ViewFactory arg2)
        {
            IExecute("insertUpdate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#preferenceChanged(javax.swing.text.View,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.View"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void PreferenceChanged(Javax.Swing.Text.View arg0, bool arg1, bool arg2)
        {
            IExecute("preferenceChanged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#removeAll()"/>
        /// </summary>
        public void RemoveAll()
        {
            IExecuteWithSignature("removeAll", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#removeUpdate(javax.swing.event.DocumentEvent,java.awt.Shape,javax.swing.text.ViewFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.ViewFactory"/></param>
        public void RemoveUpdate(Javax.Swing.Event.DocumentEvent arg0, Java.Awt.Shape arg1, Javax.Swing.Text.ViewFactory arg2)
        {
            IExecute("removeUpdate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#replace(int,int,javax.swing.text.View[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.View"/></param>
        public void Replace(int arg0, int arg1, Javax.Swing.Text.View[] arg2)
        {
            IExecute("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/View.html#setSize(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetSize(float arg0, float arg1)
        {
            IExecute("setSize", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}