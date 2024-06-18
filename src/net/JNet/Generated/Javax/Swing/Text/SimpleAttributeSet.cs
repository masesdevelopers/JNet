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

namespace Javax.Swing.Text
{
    #region SimpleAttributeSet
    public partial class SimpleAttributeSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#%3Cinit%3E(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public SimpleAttributeSet(Javax.Swing.Text.AttributeSet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Javax.Swing.Text.MutableAttributeSet"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.MutableAttributeSet(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Javax.Swing.Text.MutableAttributeSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#EMPTY"/>
        /// </summary>
        public static Javax.Swing.Text.AttributeSet EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Javax.Swing.Text.AttributeSet>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Javax.Swing.Text.AttributeSet _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttributeNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> AttributeNames
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<object>>("getAttributeNames", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getResolveParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#setResolveParent(javax.swing.text.AttributeSet)"/>
        /// </summary>
        public Javax.Swing.Text.AttributeSet ResolveParent
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getResolveParent", "()Ljavax/swing/text/AttributeSet;"); } set { IExecuteWithSignature("setResolveParent", "(Ljavax/swing/text/AttributeSet;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttribute(object arg0, object arg1)
        {
            return IExecute<bool>("containsAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#containsAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("containsAttributes", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isDefined(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefined(object arg0)
        {
            return IExecuteWithSignature<bool>("isDefined", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isEqual(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljavax/swing/text/AttributeSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(object arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#copyAttributes()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet CopyAttributes()
        {
            return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("copyAttributes", "()Ljavax/swing/text/AttributeSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#addAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddAttribute(object arg0, object arg1)
        {
            IExecute("addAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#addAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public void AddAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            IExecuteWithSignature("addAttributes", "(Ljavax/swing/text/AttributeSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveAttribute(object arg0)
        {
            IExecuteWithSignature("removeAttribute", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttributes(java.util.Enumeration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Enumeration"/></param>
        public void RemoveAttributes(Java.Util.Enumeration<object> arg0)
        {
            IExecuteWithSignature("removeAttributes", "(Ljava/util/Enumeration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public void RemoveAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            IExecuteWithSignature("removeAttributes", "(Ljavax/swing/text/AttributeSet;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}