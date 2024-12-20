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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Random declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html"/>
    /// </summary>
    public partial class Random : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.Random";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Random() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Random(params object[] args) : base(args) { }

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

    #region Random implementation
    public partial class Random
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public Random(long arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool NextBoolean()
        {
            return IExecuteWithSignature<bool>("nextBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double NextDouble()
        {
            return IExecuteWithSignature<double>("nextDouble", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float NextFloat()
        {
            return IExecuteWithSignature<float>("nextFloat", "()F");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NextInt()
        {
            return IExecuteWithSignature<int>("nextInt", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextInt(int arg0)
        {
            return IExecuteWithSignature<int>("nextInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles()
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(double arg0, double arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(DD)Ljava/util/stream/DoubleStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles(long,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(long arg0, double arg1, double arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(JDD)Ljava/util/stream/DoubleStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("doubles", "(J)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints()
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "()Ljava/util/stream/IntStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(II)Ljava/util/stream/IntStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints(long,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(long arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(JII)Ljava/util/stream/IntStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("ints", "(J)Ljava/util/stream/IntStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs()
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs(long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(JJJ)Ljava/util/stream/LongStream;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(JJ)Ljava/util/stream/LongStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("longs", "(J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long NextLong()
        {
            return IExecuteWithSignature<long>("nextLong", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextGaussian()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double NextGaussian()
        {
            return IExecuteWithSignature<double>("nextGaussian", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#setSeed(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetSeed(long arg0)
        {
            IExecuteWithSignature("setSeed", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void NextBytes(byte[] arg0)
        {
            IExecuteWithSignature("nextBytes", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}