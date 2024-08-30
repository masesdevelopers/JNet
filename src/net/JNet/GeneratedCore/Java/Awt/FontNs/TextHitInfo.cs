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

namespace Java.Awt.FontNs
{
    #region TextHitInfo definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html"/>
    /// </summary>
    public partial class TextHitInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TextHitInfo>
    {
        const string _bridgeClassName = "java.awt.font.TextHitInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextHitInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextHitInfo(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region TextHitInfo
    public partial class TextHitInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#afterOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public static Java.Awt.FontNs.TextHitInfo AfterOffset(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>(LocalBridgeClazz, "afterOffset", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#beforeOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public static Java.Awt.FontNs.TextHitInfo BeforeOffset(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>(LocalBridgeClazz, "beforeOffset", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#leading(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public static Java.Awt.FontNs.TextHitInfo Leading(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>(LocalBridgeClazz, "leading", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#trailing(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public static Java.Awt.FontNs.TextHitInfo Trailing(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>(LocalBridgeClazz, "trailing", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getCharIndex()"/> 
        /// </summary>
        public int CharIndex
        {
            get { return IExecuteWithSignature<int>("getCharIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getInsertionIndex()"/> 
        /// </summary>
        public int InsertionIndex
        {
            get { return IExecuteWithSignature<int>("getInsertionIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getOtherHit()"/> 
        /// </summary>
        public Java.Awt.FontNs.TextHitInfo OtherHit
        {
            get { return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getOtherHit", "()Ljava/awt/font/TextHitInfo;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#isLeadingEdge()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeadingEdge()
        {
            return IExecuteWithSignature<bool>("isLeadingEdge", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getOffsetHit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetOffsetHit(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextHitInfo>("getOffsetHit", "(I)Ljava/awt/font/TextHitInfo;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}