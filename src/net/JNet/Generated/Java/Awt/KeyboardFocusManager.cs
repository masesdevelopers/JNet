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

namespace Java.Awt
{
    #region KeyboardFocusManager
    public partial class KeyboardFocusManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.KeyboardFocusManager"/> to <see cref="Java.Awt.KeyEventDispatcher"/>
        /// </summary>
        public static implicit operator Java.Awt.KeyEventDispatcher(Java.Awt.KeyboardFocusManager t) => t.Cast<Java.Awt.KeyEventDispatcher>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.KeyboardFocusManager"/> to <see cref="Java.Awt.KeyEventPostProcessor"/>
        /// </summary>
        public static implicit operator Java.Awt.KeyEventPostProcessor(Java.Awt.KeyboardFocusManager t) => t.Cast<Java.Awt.KeyEventPostProcessor>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#BACKWARD_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int BACKWARD_TRAVERSAL_KEYS { get { if (!_BACKWARD_TRAVERSAL_KEYSReady) { _BACKWARD_TRAVERSAL_KEYSContent = SGetField<int>(LocalBridgeClazz, "BACKWARD_TRAVERSAL_KEYS"); _BACKWARD_TRAVERSAL_KEYSReady = true; } return _BACKWARD_TRAVERSAL_KEYSContent; } }
        private static int _BACKWARD_TRAVERSAL_KEYSContent = default;
        private static bool _BACKWARD_TRAVERSAL_KEYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#DOWN_CYCLE_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int DOWN_CYCLE_TRAVERSAL_KEYS { get { if (!_DOWN_CYCLE_TRAVERSAL_KEYSReady) { _DOWN_CYCLE_TRAVERSAL_KEYSContent = SGetField<int>(LocalBridgeClazz, "DOWN_CYCLE_TRAVERSAL_KEYS"); _DOWN_CYCLE_TRAVERSAL_KEYSReady = true; } return _DOWN_CYCLE_TRAVERSAL_KEYSContent; } }
        private static int _DOWN_CYCLE_TRAVERSAL_KEYSContent = default;
        private static bool _DOWN_CYCLE_TRAVERSAL_KEYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#FORWARD_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int FORWARD_TRAVERSAL_KEYS { get { if (!_FORWARD_TRAVERSAL_KEYSReady) { _FORWARD_TRAVERSAL_KEYSContent = SGetField<int>(LocalBridgeClazz, "FORWARD_TRAVERSAL_KEYS"); _FORWARD_TRAVERSAL_KEYSReady = true; } return _FORWARD_TRAVERSAL_KEYSContent; } }
        private static int _FORWARD_TRAVERSAL_KEYSContent = default;
        private static bool _FORWARD_TRAVERSAL_KEYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#UP_CYCLE_TRAVERSAL_KEYS"/>
        /// </summary>
        public static int UP_CYCLE_TRAVERSAL_KEYS { get { if (!_UP_CYCLE_TRAVERSAL_KEYSReady) { _UP_CYCLE_TRAVERSAL_KEYSContent = SGetField<int>(LocalBridgeClazz, "UP_CYCLE_TRAVERSAL_KEYS"); _UP_CYCLE_TRAVERSAL_KEYSReady = true; } return _UP_CYCLE_TRAVERSAL_KEYSContent; } }
        private static int _UP_CYCLE_TRAVERSAL_KEYSContent = default;
        private static bool _UP_CYCLE_TRAVERSAL_KEYSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getCurrentKeyboardFocusManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setCurrentKeyboardFocusManager(java.awt.KeyboardFocusManager)"/>
        /// </summary>
        public static Java.Awt.KeyboardFocusManager CurrentKeyboardFocusManager
        {
            get { return SExecuteWithSignature<Java.Awt.KeyboardFocusManager>(LocalBridgeClazz, "getCurrentKeyboardFocusManager", "()Ljava/awt/KeyboardFocusManager;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setCurrentKeyboardFocusManager", "(Ljava/awt/KeyboardFocusManager;)V", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getActiveWindow()"/> 
        /// </summary>
        public Java.Awt.Window ActiveWindow
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getActiveWindow", "()Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getCurrentFocusCycleRoot()"/> 
        /// </summary>
        public Java.Awt.Container CurrentFocusCycleRoot
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getCurrentFocusCycleRoot", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getDefaultFocusTraversalPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setDefaultFocusTraversalPolicy(java.awt.FocusTraversalPolicy)"/>
        /// </summary>
        public Java.Awt.FocusTraversalPolicy DefaultFocusTraversalPolicy
        {
            get { return IExecuteWithSignature<Java.Awt.FocusTraversalPolicy>("getDefaultFocusTraversalPolicy", "()Ljava/awt/FocusTraversalPolicy;"); } set { IExecuteWithSignature("setDefaultFocusTraversalPolicy", "(Ljava/awt/FocusTraversalPolicy;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getFocusedWindow()"/> 
        /// </summary>
        public Java.Awt.Window FocusedWindow
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getFocusedWindow", "()Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component FocusOwner
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getFocusOwner", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPermanentFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component PermanentFocusOwner
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getPermanentFocusOwner", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getVetoableChangeListeners()"/> 
        /// </summary>
        public Java.Beans.VetoableChangeListener[] VetoableChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners", "()[Ljava/beans/VetoableChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#dispatchEvent(java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.AWTEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchEvent", "(Ljava/awt/AWTEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#dispatchKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchKeyEvent", "(Ljava/awt/event/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#postProcessKeyEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PostProcessKeyEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("postProcessKeyEvent", "(Ljava/awt/event/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#downFocusCycle(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void DownFocusCycle(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("downFocusCycle", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusNextComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void FocusNextComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("focusNextComponent", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusPreviousComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void FocusPreviousComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("focusPreviousComponent", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#processKeyEvent(java.awt.Component,java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public void ProcessKeyEvent(Java.Awt.Component arg0, Java.Awt.EventNs.KeyEvent arg1)
        {
            IExecute("processKeyEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#upFocusCycle(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void UpFocusCycle(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("upFocusCycle", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#downFocusCycle()"/>
        /// </summary>
        public void DownFocusCycle()
        {
            IExecuteWithSignature("downFocusCycle", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusNextComponent()"/>
        /// </summary>
        public void FocusNextComponent()
        {
            IExecuteWithSignature("focusNextComponent", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#focusPreviousComponent()"/>
        /// </summary>
        public void FocusPreviousComponent()
        {
            IExecuteWithSignature("focusPreviousComponent", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#redispatchEvent(java.awt.Component,java.awt.AWTEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.AWTEvent"/></param>
        public void RedispatchEvent(Java.Awt.Component arg0, Java.Awt.AWTEvent arg1)
        {
            IExecute("redispatchEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#upFocusCycle()"/>
        /// </summary>
        public void UpFocusCycle()
        {
            IExecuteWithSignature("upFocusCycle", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getDefaultFocusTraversalKeys(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Awt.AWTKeyStroke> GetDefaultFocusTraversalKeys(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Awt.AWTKeyStroke>>("getDefaultFocusTraversalKeys", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#getVetoableChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Beans.VetoableChangeListener"/></returns>
        public Java.Beans.VetoableChangeListener[] GetVetoableChangeListeners(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners", "(Ljava/lang/String;)[Ljava/beans/VetoableChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addKeyEventDispatcher(java.awt.KeyEventDispatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventDispatcher"/></param>
        public void AddKeyEventDispatcher(Java.Awt.KeyEventDispatcher arg0)
        {
            IExecuteWithSignature("addKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addKeyEventPostProcessor(java.awt.KeyEventPostProcessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventPostProcessor"/></param>
        public void AddKeyEventPostProcessor(Java.Awt.KeyEventPostProcessor arg0)
        {
            IExecuteWithSignature("addKeyEventPostProcessor", "(Ljava/awt/KeyEventPostProcessor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecuteWithSignature("addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("addVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#clearFocusOwner()"/>
        /// </summary>
        public void ClearFocusOwner()
        {
            IExecuteWithSignature("clearFocusOwner", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#clearGlobalFocusOwner()"/>
        /// </summary>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ClearGlobalFocusOwner()
        {
            IExecuteWithSignature("clearGlobalFocusOwner", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeKeyEventDispatcher(java.awt.KeyEventDispatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventDispatcher"/></param>
        public void RemoveKeyEventDispatcher(Java.Awt.KeyEventDispatcher arg0)
        {
            IExecuteWithSignature("removeKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeKeyEventPostProcessor(java.awt.KeyEventPostProcessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.KeyEventPostProcessor"/></param>
        public void RemoveKeyEventPostProcessor(Java.Awt.KeyEventPostProcessor arg0)
        {
            IExecuteWithSignature("removeKeyEventPostProcessor", "(Ljava/awt/KeyEventPostProcessor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecuteWithSignature("removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Lang.String arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("removeVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setDefaultFocusTraversalKeys(int,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg1ExtendsJava_Awt_AWTKeyStroke"><see cref="Java.Awt.AWTKeyStroke"/></typeparam>
        public void SetDefaultFocusTraversalKeys<Arg1ExtendsJava_Awt_AWTKeyStroke>(int arg0, Java.Util.Set<Arg1ExtendsJava_Awt_AWTKeyStroke> arg1) where Arg1ExtendsJava_Awt_AWTKeyStroke : Java.Awt.AWTKeyStroke
        {
            IExecute("setDefaultFocusTraversalKeys", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/KeyboardFocusManager.html#setGlobalCurrentFocusCycleRoot(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetGlobalCurrentFocusCycleRoot(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("setGlobalCurrentFocusCycleRoot", "(Ljava/awt/Container;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}