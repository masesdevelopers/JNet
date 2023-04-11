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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Random
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
        /// <summary>
        /// Converter from <see cref="Java.Util.Random"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Random t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextBoolean()"/> 
        /// </summary>
        public bool NextBoolean
        {
            get { return IExecute<bool>("nextBoolean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextDouble()"/> 
        /// </summary>
        public double NextDouble
        {
            get { return IExecute<double>("nextDouble"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextFloat()"/> 
        /// </summary>
        public float NextFloat
        {
            get { return IExecute<float>("nextFloat"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextGaussian()"/> 
        /// </summary>
        public double NextGaussian
        {
            get { return IExecute<double>("nextGaussian"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextLong()"/> 
        /// </summary>
        public long NextLong
        {
            get { return IExecute<long>("nextLong"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextInt()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int NextInt()
        {
            return IExecute<int>("nextInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextInt(int arg0)
        {
            return IExecute<int>("nextInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles()
        {
            return IExecute<Java.Util.Stream.DoubleStream>("doubles");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(double arg0, double arg1)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("doubles", arg0, arg1);
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
            return IExecute<Java.Util.Stream.DoubleStream>("doubles", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#doubles(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Doubles(long arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("doubles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints()
        {
            return IExecute<Java.Util.Stream.IntStream>("ints");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(int arg0, int arg1)
        {
            return IExecute<Java.Util.Stream.IntStream>("ints", arg0, arg1);
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
            return IExecute<Java.Util.Stream.IntStream>("ints", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#ints(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream Ints(long arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("ints", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs()
        {
            return IExecute<Java.Util.Stream.LongStream>("longs");
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
            return IExecute<Java.Util.Stream.LongStream>("longs", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0, long arg1)
        {
            return IExecute<Java.Util.Stream.LongStream>("longs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#longs(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Longs(long arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("longs", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#setSeed(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetSeed(long arg0)
        {
            IExecute("setSeed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Random.html#nextBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void NextBytes(byte[] arg0)
        {
            IExecute("nextBytes", new object[] { arg0 });
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}