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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform
{
    #region IErrorListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.xml.transform.ErrorListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html"/>
    /// </summary>
    public partial interface IErrorListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#error(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#fatalError(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#warning(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ErrorListener
    public partial class ErrorListener : Javax.Xml.Transform.IErrorListener
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
        /// Handlers initializer for <see cref="ErrorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("error", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(ErrorEventHandler));
            AddEventHandler("fatalError", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(FatalErrorEventHandler));
            AddEventHandler("warning", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(WarningEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#error(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <remarks>If <see cref="OnError"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<MASES.JCOBridge.C2JBridge.JVMBridgeException> OnError { get; set; } = null;

        void ErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnError != null) ? OnError : Error;
            methodToExecute.Invoke(JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#error(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        public virtual void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#fatalError(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFatalError"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<MASES.JCOBridge.C2JBridge.JVMBridgeException> OnFatalError { get; set; } = null;

        void FatalErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnFatalError != null) ? OnFatalError : FatalError;
            methodToExecute.Invoke(JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#fatalError(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        public virtual void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#warning(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWarning"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<MASES.JCOBridge.C2JBridge.JVMBridgeException> OnWarning { get; set; } = null;

        void WarningEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnWarning != null) ? OnWarning : Warning;
            methodToExecute.Invoke(JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/ErrorListener.html#warning(javax.xml.transform.TransformerException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.TransformerException"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        public virtual void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}