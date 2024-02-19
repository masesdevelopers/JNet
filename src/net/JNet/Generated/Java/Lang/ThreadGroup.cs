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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ThreadGroup
    public partial class ThreadGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ThreadGroup(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ThreadGroup(Java.Lang.ThreadGroup arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getMaxPriority()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#setMaxPriority(int)"/>
        /// </summary>
        public int MaxPriority
        {
            get { return IExecute<int>("getMaxPriority"); } set { IExecute("setMaxPriority", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecute<Java.Lang.String>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getParent()"/> 
        /// </summary>
        public Java.Lang.ThreadGroup Parent
        {
            get { return IExecute<Java.Lang.ThreadGroup>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#isDaemon()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDaemon()
        {
            return IExecute<bool>("isDaemon");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#parentOf(java.lang.ThreadGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ParentOf(Java.Lang.ThreadGroup arg0)
        {
            return IExecute<bool>("parentOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#checkAccess()"/>
        /// </summary>
        public void CheckAccess()
        {
            IExecute("checkAccess");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecute("destroy");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#interrupt()"/>
        /// </summary>
        public void Interrupt()
        {
            IExecute("interrupt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#setDaemon(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDaemon(bool arg0)
        {
            IExecute("setDaemon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#activeCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ActiveCount()
        {
            return IExecute<int>("activeCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#activeGroupCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ActiveGroupCount()
        {
            return IExecute<int>("activeGroupCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.Thread[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.Thread[] arg0, bool arg1)
        {
            return IExecute<int>("enumerate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.Thread[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.Thread[] arg0)
        {
            return IExecute<int>("enumerate", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.ThreadGroup[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.ThreadGroup[] arg0, bool arg1)
        {
            return IExecute<int>("enumerate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.ThreadGroup[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.ThreadGroup[] arg0)
        {
            return IExecute<int>("enumerate", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#isDestroyed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecute<bool>("isDestroyed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#list()"/>
        /// </summary>
        public void List()
        {
            IExecute("list");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#uncaughtException(java.lang.Thread,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        public void UncaughtException(Java.Lang.Thread arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            IExecute("uncaughtException", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}