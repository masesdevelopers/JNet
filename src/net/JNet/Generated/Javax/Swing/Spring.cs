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

namespace Javax.Swing
{
    #region Spring declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html"/>
    /// </summary>
    public partial class Spring : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Spring>
    {
        const string _bridgeClassName = "javax.swing.Spring";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Spring class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Spring() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Spring class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Spring(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region Spring implementation
    public partial class Spring
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#UNSET"/>
        /// </summary>
        public static int UNSET { get { if (!_UNSETReady) { _UNSETContent = SGetField<int>(LocalBridgeClazz, "UNSET"); _UNSETReady = true; } return _UNSETContent; } }
        private static int _UNSETContent = default;
        private static bool _UNSETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#constant(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Constant(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "constant", "(III)Ljavax/swing/Spring;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#constant(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Constant(int arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "constant", "(I)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#height(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Height(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "height", "(Ljava/awt/Component;)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#max(javax.swing.Spring,javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Max(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "max", "(Ljavax/swing/Spring;Ljavax/swing/Spring;)Ljavax/swing/Spring;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#minus(javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Minus(Javax.Swing.Spring arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "minus", "(Ljavax/swing/Spring;)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#scale(javax.swing.Spring,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Scale(Javax.Swing.Spring arg0, float arg1)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "scale", "(Ljavax/swing/Spring;F)Ljavax/swing/Spring;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#sum(javax.swing.Spring,javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Sum(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "sum", "(Ljavax/swing/Spring;Ljavax/swing/Spring;)Ljavax/swing/Spring;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#width(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Width(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "width", "(Ljava/awt/Component;)Ljavax/swing/Spring;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getMaximumValue()"/> 
        /// </summary>
        public int MaximumValue
        {
            get { return IExecuteWithSignature<int>("getMaximumValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getMinimumValue()"/> 
        /// </summary>
        public int MinimumValue
        {
            get { return IExecuteWithSignature<int>("getMinimumValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getPreferredValue()"/> 
        /// </summary>
        public int PreferredValue
        {
            get { return IExecuteWithSignature<int>("getPreferredValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}