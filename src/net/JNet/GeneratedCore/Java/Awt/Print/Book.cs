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

namespace Java.Awt.Print
{
    #region Book definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html"/>
    /// </summary>
    public partial class Book : Java.Awt.Print.Pageable
    {
        const string _bridgeClassName = "java.awt.print.Book";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Book() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Book(params object[] args) : base(args) { }

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

    #region Book
    public partial class Book
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#getNumberOfPages()"/> 
        /// </summary>
        public int NumberOfPages
        {
            get { return IExecuteWithSignature<int>("getNumberOfPages", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#getPageFormat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public Java.Awt.Print.PageFormat GetPageFormat(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.PageFormat>("getPageFormat", "(I)Ljava/awt/print/PageFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#getPrintable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.Printable"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public Java.Awt.Print.Printable GetPrintable(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Print.Printable>("getPrintable", "(I)Ljava/awt/print/Printable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#append(java.awt.print.Printable,java.awt.print.PageFormat,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Append(Java.Awt.Print.Printable arg0, Java.Awt.Print.PageFormat arg1, int arg2)
        {
            IExecute("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#append(java.awt.print.Printable,java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Print.PageFormat"/></param>
        public void Append(Java.Awt.Print.Printable arg0, Java.Awt.Print.PageFormat arg1)
        {
            IExecute("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Book.html#setPage(int,java.awt.print.Printable,java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Print.Printable"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public void SetPage(int arg0, Java.Awt.Print.Printable arg1, Java.Awt.Print.PageFormat arg2)
        {
            IExecute("setPage", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}