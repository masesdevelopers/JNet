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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Catalog
{
    #region CatalogManager declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html"/>
    /// </summary>
    public partial class CatalogManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CatalogManager>
    {
        const string _bridgeClassName = "javax.xml.catalog.CatalogManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CatalogManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CatalogManager(params object[] args) : base(args) { }

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

    #region CatalogManager implementation
    public partial class CatalogManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalog(javax.xml.catalog.CatalogFeatures,java.net.URI[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures"/></param>
        /// <param name="arg1"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.Catalog"/></returns>
        public static Javax.Xml.Catalog.Catalog Catalog(Javax.Xml.Catalog.CatalogFeatures arg0, params Java.Net.URI[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Javax.Xml.Catalog.Catalog>(LocalBridgeClazz, "catalog", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/Catalog;", arg0); else return SExecuteWithSignature<Javax.Xml.Catalog.Catalog>(LocalBridgeClazz, "catalog", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/Catalog;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalogResolver(javax.xml.catalog.Catalog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.Catalog"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogResolver"/></returns>
        public static Javax.Xml.Catalog.CatalogResolver CatalogResolver(Javax.Xml.Catalog.Catalog arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Catalog.CatalogResolver>(LocalBridgeClazz, "catalogResolver", "(Ljavax/xml/catalog/Catalog;)Ljavax/xml/catalog/CatalogResolver;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/catalog/CatalogManager.html#catalogResolver(javax.xml.catalog.CatalogFeatures,java.net.URI[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Catalog.CatalogFeatures"/></param>
        /// <param name="arg1"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Javax.Xml.Catalog.CatalogResolver"/></returns>
        public static Javax.Xml.Catalog.CatalogResolver CatalogResolver(Javax.Xml.Catalog.CatalogFeatures arg0, params Java.Net.URI[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Javax.Xml.Catalog.CatalogResolver>(LocalBridgeClazz, "catalogResolver", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/CatalogResolver;", arg0); else return SExecuteWithSignature<Javax.Xml.Catalog.CatalogResolver>(LocalBridgeClazz, "catalogResolver", "(Ljavax/xml/catalog/CatalogFeatures;[Ljava/net/URI;)Ljavax/xml/catalog/CatalogResolver;", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}