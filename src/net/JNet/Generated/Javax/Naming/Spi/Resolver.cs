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

namespace Javax.Naming.Spi
{
    #region IResolver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IResolver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/Resolver.html#resolveToClass(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Naming.Spi.ResolveResult"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Spi.ResolveResult ResolveToClass(Java.Lang.String arg0, Java.Lang.Class arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/Resolver.html#resolveToClass(javax.naming.Name,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Naming.Spi.ResolveResult"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Spi.ResolveResult ResolveToClass(Javax.Naming.Name arg0, Java.Lang.Class arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Resolver
    public partial class Resolver : Javax.Naming.Spi.IResolver
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/Resolver.html#resolveToClass(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Naming.Spi.ResolveResult"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Spi.ResolveResult ResolveToClass(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<Javax.Naming.Spi.ResolveResult>("resolveToClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/Resolver.html#resolveToClass(javax.naming.Name,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Naming.Spi.ResolveResult"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Spi.ResolveResult ResolveToClass(Javax.Naming.Name arg0, Java.Lang.Class arg1)
        {
            return IExecute<Javax.Naming.Spi.ResolveResult>("resolveToClass", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}