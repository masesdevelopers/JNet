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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Smartcardio
{
    #region Card
    public partial class Card
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#getATR()"/> 
        /// </summary>
        public Javax.Smartcardio.ATR ATR
        {
            get { return IExecuteWithSignature<Javax.Smartcardio.ATR>("getATR", "()Ljavax/smartcardio/ATR;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#getBasicChannel()"/> 
        /// </summary>
        public Javax.Smartcardio.CardChannel BasicChannel
        {
            get { return IExecuteWithSignature<Javax.Smartcardio.CardChannel>("getBasicChannel", "()Ljavax/smartcardio/CardChannel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#getProtocol()"/> 
        /// </summary>
        public Java.Lang.String Protocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#transmitControlCommand(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public byte[] TransmitControlCommand(int arg0, byte[] arg1)
        {
            return IExecuteArray<byte>("transmitControlCommand", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#openLogicalChannel()"/>
        /// </summary>

        /// <returns><see cref="Javax.Smartcardio.CardChannel"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Javax.Smartcardio.CardChannel OpenLogicalChannel()
        {
            return IExecuteWithSignature<Javax.Smartcardio.CardChannel>("openLogicalChannel", "()Ljavax/smartcardio/CardChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#beginExclusive()"/>
        /// </summary>

        /// <exception cref="Javax.Smartcardio.CardException"/>
        public void BeginExclusive()
        {
            IExecuteWithSignature("beginExclusive", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#disconnect(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public void Disconnect(bool arg0)
        {
            IExecuteWithSignature("disconnect", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/Card.html#endExclusive()"/>
        /// </summary>

        /// <exception cref="Javax.Smartcardio.CardException"/>
        public void EndExclusive()
        {
            IExecuteWithSignature("endExclusive", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}