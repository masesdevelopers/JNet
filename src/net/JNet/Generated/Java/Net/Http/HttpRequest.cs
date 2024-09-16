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

namespace Java.Net.Http
{
    #region HttpRequest declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html"/>
    /// </summary>
    public partial class HttpRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HttpRequest>
    {
        const string _bridgeClassName = "java.net.http.HttpRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HttpRequest class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HttpRequest class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpRequest(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
        #region BodyPublisher declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublisher.html"/>
        /// </summary>
        public partial class BodyPublisher : Java.Util.Concurrent.Flow.Publisher<Java.Nio.ByteBuffer>
        {
            const string _bridgeClassName = "java.net.http.HttpRequest$BodyPublisher";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("BodyPublisher class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BodyPublisher() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("BodyPublisher class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BodyPublisher(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region BodyPublishers declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html"/>
        /// </summary>
        public partial class BodyPublishers : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BodyPublishers>
        {
            const string _bridgeClassName = "java.net.http.HttpRequest$BodyPublishers";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BodyPublishers() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BodyPublishers(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Builder declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "java.net.http.HttpRequest$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Builder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Builder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Builder(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region HttpRequest implementation
    public partial class HttpRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#newBuilder()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
        public static Java.Net.Http.HttpRequest.Builder NewBuilder()
        {
            return SExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>(LocalBridgeClazz, "newBuilder", "()Ljava/net/http/HttpRequest$Builder;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#newBuilder(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
        public static Java.Net.Http.HttpRequest.Builder NewBuilder(Java.Net.URI arg0)
        {
            return SExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>(LocalBridgeClazz, "newBuilder", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#expectContinue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ExpectContinue()
        {
            return IExecuteWithSignature<bool>("expectContinue", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#method()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Method()
        {
            return IExecuteWithSignature<Java.Lang.String>("method", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#headers()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpHeaders"/></returns>
        public Java.Net.Http.HttpHeaders Headers()
        {
            return IExecuteWithSignature<Java.Net.Http.HttpHeaders>("headers", "()Ljava/net/http/HttpHeaders;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#uri()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Uri()
        {
            return IExecuteWithSignature<Java.Net.URI>("uri", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#version()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.Http.HttpClient.Version> Version()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Net.Http.HttpClient.Version>>("version", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#bodyPublisher()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.Http.HttpRequest.BodyPublisher> BodyPublisherMethod()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Net.Http.HttpRequest.BodyPublisher>>("bodyPublisher", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.html#timeout()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Duration> Timeout()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Duration>>("timeout", "()Ljava/util/Optional;");
        }

        #endregion

        #region Nested classes
        #region BodyPublisher implementation
        public partial class BodyPublisher
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublisher.html#contentLength()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long ContentLength()
            {
                return IExecuteWithSignature<long>("contentLength", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BodyPublishers implementation
        public partial class BodyPublishers
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#fromPublisher(java.util.concurrent.Flow.Publisher,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Publisher"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <typeparam name="Arg0ExtendsJava_Nio_ByteBuffer"><see cref="Java.Nio.ByteBuffer"/></typeparam>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher FromPublisher<Arg0ExtendsJava_Nio_ByteBuffer>(Java.Util.Concurrent.Flow.Publisher<Arg0ExtendsJava_Nio_ByteBuffer> arg0, long arg1) where Arg0ExtendsJava_Nio_ByteBuffer : Java.Nio.ByteBuffer
            {
                return SExecute<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "fromPublisher", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#fromPublisher(java.util.concurrent.Flow.Publisher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Publisher"/></param>
            /// <typeparam name="Arg0ExtendsJava_Nio_ByteBuffer"><see cref="Java.Nio.ByteBuffer"/></typeparam>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher FromPublisher<Arg0ExtendsJava_Nio_ByteBuffer>(Java.Util.Concurrent.Flow.Publisher<Arg0ExtendsJava_Nio_ByteBuffer> arg0) where Arg0ExtendsJava_Nio_ByteBuffer : Java.Nio.ByteBuffer
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "fromPublisher", "(Ljava/util/concurrent/Flow$Publisher;)Ljava/net/http/HttpRequest$BodyPublisher;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#noBody()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher NoBody()
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "noBody", "()Ljava/net/http/HttpRequest$BodyPublisher;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofByteArray(byte[],int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfByteArray(byte[] arg0, int arg1, int arg2)
            {
                return SExecute<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofByteArray", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofByteArray(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfByteArray(byte[] arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofByteArray", "([B)Ljava/net/http/HttpRequest$BodyPublisher;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofByteArrays(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfByteArrays(Java.Lang.Iterable<byte[]> arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofByteArrays", "(Ljava/lang/Iterable;)Ljava/net/http/HttpRequest$BodyPublisher;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofFile(java.nio.file.Path)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            /// <exception cref="Java.Io.FileNotFoundException"/>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfFile(Java.Nio.File.Path arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofFile", "(Ljava/nio/file/Path;)Ljava/net/http/HttpRequest$BodyPublisher;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofInputStream(java.util.function.Supplier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
            /// <typeparam name="Arg0ExtendsJava_Io_InputStream"><see cref="Java.Io.InputStream"/></typeparam>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfInputStream<Arg0ExtendsJava_Io_InputStream>(Java.Util.Function.Supplier<Arg0ExtendsJava_Io_InputStream> arg0) where Arg0ExtendsJava_Io_InputStream : Java.Io.InputStream
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofInputStream", "(Ljava/util/function/Supplier;)Ljava/net/http/HttpRequest$BodyPublisher;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofString(java.lang.String,java.nio.charset.Charset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfString(Java.Lang.String arg0, Java.Nio.Charset.Charset arg1)
            {
                return SExecute<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofString", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.BodyPublishers.html#ofString(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></returns>
            public static Java.Net.Http.HttpRequest.BodyPublisher OfString(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpRequest.BodyPublisher>(LocalBridgeClazz, "ofString", "(Ljava/lang/String;)Ljava/net/http/HttpRequest$BodyPublisher;", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpRequest"/></returns>
            public Java.Net.Http.HttpRequest Build()
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest>("build", "()Ljava/net/http/HttpRequest;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#copy()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Copy()
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("copy", "()Ljava/net/http/HttpRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#DELETE()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder DELETE()
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("DELETE", "()Ljava/net/http/HttpRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#expectContinue(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder ExpectContinue(bool arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("expectContinue", "(Z)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#GET()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder GET()
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("GET", "()Ljava/net/http/HttpRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#header(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Header(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecute<Java.Net.Http.HttpRequest.Builder>("header", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#headers(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Headers(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("headers", "([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;"); else return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("headers", "([Ljava/lang/String;)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#method(java.lang.String,java.net.http.HttpRequest.BodyPublisher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Method(Java.Lang.String arg0, Java.Net.Http.HttpRequest.BodyPublisher arg1)
            {
                return IExecute<Java.Net.Http.HttpRequest.Builder>("method", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#POST(java.net.http.HttpRequest.BodyPublisher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder POST(Java.Net.Http.HttpRequest.BodyPublisher arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("POST", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#PUT(java.net.http.HttpRequest.BodyPublisher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest.BodyPublisher"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder PUT(Java.Net.Http.HttpRequest.BodyPublisher arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("PUT", "(Ljava/net/http/HttpRequest$BodyPublisher;)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#setHeader(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder SetHeader(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecute<Java.Net.Http.HttpRequest.Builder>("setHeader", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#timeout(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Timeout(Java.Time.Duration arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("timeout", "(Ljava/time/Duration;)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#uri(java.net.URI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.URI"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Uri(Java.Net.URI arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("uri", "(Ljava/net/URI;)Ljava/net/http/HttpRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpRequest.Builder.html#version(java.net.http.HttpClient.Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpClient.Version"/></param>
            /// <returns><see cref="Java.Net.Http.HttpRequest.Builder"/></returns>
            public Java.Net.Http.HttpRequest.Builder Version(Java.Net.Http.HttpClient.Version arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpRequest.Builder>("version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpRequest$Builder;", arg0);
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
}