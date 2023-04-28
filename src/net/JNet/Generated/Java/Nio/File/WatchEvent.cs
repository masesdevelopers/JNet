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

namespace Java.Nio.File
{
    #region WatchEvent
    public partial class WatchEvent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#context()"/> 
        /// </summary>
        public object Context
        {
            get { return IExecute("context"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#count()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("count"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#kind()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchEvent.Kind"/></returns>
        public Java.Nio.File.WatchEvent.Kind KindMethod()
        {
            return IExecute<Java.Nio.File.WatchEvent.Kind>("kind");
        }

        #endregion

        #region Nested classes
        #region Kind
        public partial class Kind
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.Kind.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.Kind.html#type()"/> 
            /// </summary>
            public Java.Lang.Class Type
            {
                get { return IExecute<Java.Lang.Class>("type"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Kind<T>
        public partial class Kind<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Nio.File.WatchEvent.Kind{T}"/> to <see cref="Java.Nio.File.WatchEvent.Kind"/>
            /// </summary>
            public static implicit operator Java.Nio.File.WatchEvent.Kind(Java.Nio.File.WatchEvent.Kind<T> t) => t.Cast<Java.Nio.File.WatchEvent.Kind>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.Kind.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.Kind.html#type()"/> 
            /// </summary>
            public Java.Lang.Class Type
            {
                get { return IExecute<Java.Lang.Class>("type"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Modifier
        public partial class Modifier
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.Modifier.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
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

    #region WatchEvent<T>
    public partial class WatchEvent<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.WatchEvent{T}"/> to <see cref="Java.Nio.File.WatchEvent"/>
        /// </summary>
        public static implicit operator Java.Nio.File.WatchEvent(Java.Nio.File.WatchEvent<T> t) => t.Cast<Java.Nio.File.WatchEvent>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#context()"/> 
        /// </summary>
        public T Context
        {
            get { return IExecute<T>("context"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#count()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("count"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchEvent.html#kind()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchEvent.Kind"/></returns>
        public Java.Nio.File.WatchEvent.Kind<T> KindMethod()
        {
            return IExecute<Java.Nio.File.WatchEvent.Kind<T>>("kind");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}