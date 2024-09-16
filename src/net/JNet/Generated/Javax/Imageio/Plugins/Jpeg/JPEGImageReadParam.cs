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

namespace Javax.Imageio.Plugins.Jpeg
{
    #region JPEGImageReadParam declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html"/>
    /// </summary>
    public partial class JPEGImageReadParam : Javax.Imageio.ImageReadParam
    {
        const string _bridgeClassName = "javax.imageio.plugins.jpeg.JPEGImageReadParam";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JPEGImageReadParam() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JPEGImageReadParam(params object[] args) : base(args) { }

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

    #region JPEGImageReadParam implementation
    public partial class JPEGImageReadParam
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getACHuffmanTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] ACHuffmanTables
        {
            get { return IExecuteWithSignatureArray<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>("getACHuffmanTables", "()[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getDCHuffmanTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] DCHuffmanTables
        {
            get { return IExecuteWithSignatureArray<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>("getDCHuffmanTables", "()[Ljavax/imageio/plugins/jpeg/JPEGHuffmanTable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getQTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGQTable[] QTables
        {
            get { return IExecuteWithSignatureArray<Javax.Imageio.Plugins.Jpeg.JPEGQTable>("getQTables", "()[Ljavax/imageio/plugins/jpeg/JPEGQTable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#areTablesSet()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AreTablesSet()
        {
            return IExecuteWithSignature<bool>("areTablesSet", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#setDecodeTables(javax.imageio.plugins.jpeg.JPEGQTable[],javax.imageio.plugins.jpeg.JPEGHuffmanTable[],javax.imageio.plugins.jpeg.JPEGHuffmanTable[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGQTable"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable"/></param>
        public void SetDecodeTables(Javax.Imageio.Plugins.Jpeg.JPEGQTable[] arg0, Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] arg1, Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] arg2)
        {
            IExecute("setDecodeTables", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#unsetDecodeTables()"/>
        /// </summary>
        public void UnsetDecodeTables()
        {
            IExecuteWithSignature("unsetDecodeTables", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}