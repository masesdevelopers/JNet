/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming
{
    #region InitialContext
    public partial class InitialContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#%3Cinit%3E(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public InitialContext(Java.Util.Hashtable arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.InitialContext"/> to <see cref="Javax.Naming.Context"/>
        /// </summary>
        public static implicit operator Javax.Naming.Context(Javax.Naming.InitialContext t) => t.Cast<Javax.Naming.Context>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#doLookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static T DoLookup<T>(string arg0)
        {
            return SExecute<T>(LocalClazz, "doLookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#doLookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static T DoLookup<T>(Javax.Naming.Name arg0)
        {
            return SExecute<T>(LocalClazz, "doLookup", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getEnvironment()"/> 
        /// </summary>
        public Java.Util.Hashtable Environment
        {
            get { return IExecute<Java.Util.Hashtable>("getEnvironment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameInNamespace()"/> 
        /// </summary>
        public string NameInNamespace
        {
            get { return IExecute<string>("getNameInNamespace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#addToEnvironment(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object AddToEnvironment(string arg0, object arg1)
        {
            return IExecute("addToEnvironment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(string arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Javax.Naming.Name arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookupLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(string arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookupLink(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Javax.Naming.Name arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#removeFromEnvironment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object RemoveFromEnvironment(string arg0)
        {
            return IExecute("removeFromEnvironment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#composeName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public string ComposeName(string arg0, string arg1)
        {
            return IExecute<string>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#createSubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(string arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#createSubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#composeName(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Name ComposeName(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            return IExecute<Javax.Naming.Name>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameParser(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(string arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameParser(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#listBindings(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(string arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#listBindings(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(string arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#list(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#bind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(string arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#bind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#destroySubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(string arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#destroySubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Javax.Naming.Name arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rebind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(string arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rebind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rename(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(string arg0, string arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rename(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(string arg0)
        {
            IExecute("unbind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#unbind(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Javax.Naming.Name arg0)
        {
            IExecute("unbind", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}