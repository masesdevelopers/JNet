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
    #region UIDefaults
    public partial class UIDefaults
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#%3Cinit%3E(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public UIDefaults(int arg0, float arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getDefaultLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#setDefaultLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale DefaultLocale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getDefaultLocale", "()Ljava/util/Locale;"); } set { IExecuteWithSignature("setDefaultLocale", "(Ljava/util/Locale;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getBoolean(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getBoolean(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(object arg0)
        {
            return IExecuteWithSignature<bool>("getBoolean", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getInt(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getInt(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(object arg0)
        {
            return IExecuteWithSignature<int>("getInt", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getColor(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetColor(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Awt.Color>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getColor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetColor(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getColor", "(Ljava/lang/Object;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getDimension(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetDimension(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Awt.Dimension>("getDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getDimension(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetDimension(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("getDimension", "(Ljava/lang/Object;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getFont(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Awt.Font>("getFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getFont(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font GetFont(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Font>("getFont", "(Ljava/lang/Object;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getInsets(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Awt.Insets>("getInsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getInsets(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Insets>("getInsets", "(Ljava/lang/Object;)Ljava/awt/Insets;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getUIClass(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <typeparam name="ReturnExtendsJavax_Swing_Plaf_ComponentUI"><see cref="Javax.Swing.Plaf.ComponentUI"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetUIClass<ReturnExtendsJavax_Swing_Plaf_ComponentUI>(Java.Lang.String arg0, Java.Lang.ClassLoader arg1) where ReturnExtendsJavax_Swing_Plaf_ComponentUI : Javax.Swing.Plaf.ComponentUI
        {
            return IExecute<Java.Lang.Class>("getUIClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getUIClass(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Swing_Plaf_ComponentUI"><see cref="Javax.Swing.Plaf.ComponentUI"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetUIClass<ReturnExtendsJavax_Swing_Plaf_ComponentUI>(Java.Lang.String arg0) where ReturnExtendsJavax_Swing_Plaf_ComponentUI : Javax.Swing.Plaf.ComponentUI
        {
            return IExecuteWithSignature<Java.Lang.Class>("getUIClass", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#get(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0, Java.Util.Locale arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getString(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getString(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(object arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getBorder(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public Javax.Swing.Border.Border GetBorder(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Javax.Swing.Border.Border>("getBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getBorder(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public Javax.Swing.Border.Border GetBorder(object arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Border.Border>("getBorder", "(Ljava/lang/Object;)Ljavax/swing/border/Border;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getIcon(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIcon(object arg0, Java.Util.Locale arg1)
        {
            return IExecute<Javax.Swing.Icon>("getIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getIcon(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIcon(object arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getIcon", "(Ljava/lang/Object;)Ljavax/swing/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#getUI(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.ComponentUI"/></returns>
        public Javax.Swing.Plaf.ComponentUI GetUI(Javax.Swing.JComponent arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Plaf.ComponentUI>("getUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#addResourceBundle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AddResourceBundle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addResourceBundle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#removeResourceBundle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveResourceBundle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeResourceBundle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.html#putDefaults(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void PutDefaults(object[] arg0)
        {
            IExecuteWithSignature("putDefaults", "([Ljava/lang/Object;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes
        #region ActiveValue
        public partial class ActiveValue
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.ActiveValue.html#createValue(javax.swing.UIDefaults)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.UIDefaults"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateValue(Javax.Swing.UIDefaults arg0)
            {
                return IExecuteWithSignature("createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LazyInputMap
        public partial class LazyInputMap
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.LazyInputMap.html#createValue(javax.swing.UIDefaults)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.UIDefaults"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateValue(Javax.Swing.UIDefaults arg0)
            {
                return IExecuteWithSignature("createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LazyValue
        public partial class LazyValue
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.LazyValue.html#createValue(javax.swing.UIDefaults)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.UIDefaults"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateValue(Javax.Swing.UIDefaults arg0)
            {
                return IExecuteWithSignature("createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ProxyLazyValue
        public partial class ProxyLazyValue
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.ProxyLazyValue.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public ProxyLazyValue(Java.Lang.String arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.ProxyLazyValue.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public ProxyLazyValue(Java.Lang.String arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIDefaults.ProxyLazyValue.html#createValue(javax.swing.UIDefaults)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.UIDefaults"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateValue(Javax.Swing.UIDefaults arg0)
            {
                return IExecuteWithSignature("createValue", "(Ljavax/swing/UIDefaults;)Ljava/lang/Object;", arg0);
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