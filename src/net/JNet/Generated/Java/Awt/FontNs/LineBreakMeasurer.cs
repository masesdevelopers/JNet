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
    #region LineBreakMeasurer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html"/>
    /// </summary>
    public partial class LineBreakMeasurer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LineBreakMeasurer>
    {
        const string _bridgeClassName = "java.awt.font.LineBreakMeasurer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LineBreakMeasurer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LineBreakMeasurer(params object[] args) : base(args) { }

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

    #region LineBreakMeasurer implementation
    public partial class LineBreakMeasurer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#%3Cinit%3E(java.text.AttributedCharacterIterator,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        public LineBreakMeasurer(Java.Text.AttributedCharacterIterator arg0, Java.Awt.FontNs.FontRenderContext arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#%3Cinit%3E(java.text.AttributedCharacterIterator,java.text.BreakIterator,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="Java.Text.BreakIterator"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        public LineBreakMeasurer(Java.Text.AttributedCharacterIterator arg0, Java.Text.BreakIterator arg1, Java.Awt.FontNs.FontRenderContext arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#getPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#setPosition(int)"/>
        /// </summary>
        public int Position
        {
            get { return IExecuteWithSignature<int>("getPosition", "()I"); } set { IExecuteWithSignature("setPosition", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#nextOffset(float,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextOffset(float arg0, int arg1, bool arg2)
        {
            return IExecute<int>("nextOffset", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#nextOffset(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextOffset(float arg0)
        {
            return IExecuteWithSignature<int>("nextOffset", "(F)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#nextLayout(float,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextLayout"/></returns>
        public Java.Awt.FontNs.TextLayout NextLayout(float arg0, int arg1, bool arg2)
        {
            return IExecute<Java.Awt.FontNs.TextLayout>("nextLayout", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#nextLayout(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextLayout"/></returns>
        public Java.Awt.FontNs.TextLayout NextLayout(float arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontNs.TextLayout>("nextLayout", "(F)Ljava/awt/font/TextLayout;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#deleteChar(java.text.AttributedCharacterIterator,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void DeleteChar(Java.Text.AttributedCharacterIterator arg0, int arg1)
        {
            IExecute("deleteChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineBreakMeasurer.html#insertChar(java.text.AttributedCharacterIterator,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InsertChar(Java.Text.AttributedCharacterIterator arg0, int arg1)
        {
            IExecute("insertChar", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}