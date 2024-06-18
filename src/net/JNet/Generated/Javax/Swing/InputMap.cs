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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region InputMap
    public partial class InputMap
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#setParent(javax.swing.InputMap)"/>
        /// </summary>
        public Javax.Swing.InputMap Parent
        {
            get { return IExecuteWithSignature<Javax.Swing.InputMap>("getParent", "()Ljavax/swing/InputMap;"); } set { IExecuteWithSignature("setParent", "(Ljavax/swing/InputMap;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#get(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Javax.Swing.KeyStroke arg0)
        {
            return IExecuteWithSignature("get", "(Ljavax/swing/KeyStroke;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#allKeys()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public Javax.Swing.KeyStroke[] AllKeys()
        {
            return IExecuteWithSignatureArray<Javax.Swing.KeyStroke>("allKeys", "()[Ljavax/swing/KeyStroke;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#keys()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public Javax.Swing.KeyStroke[] Keys()
        {
            return IExecuteWithSignatureArray<Javax.Swing.KeyStroke>("keys", "()[Ljavax/swing/KeyStroke;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#put(javax.swing.KeyStroke,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(Javax.Swing.KeyStroke arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#remove(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        public void Remove(Javax.Swing.KeyStroke arg0)
        {
            IExecuteWithSignature("remove", "(Ljavax/swing/KeyStroke;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}