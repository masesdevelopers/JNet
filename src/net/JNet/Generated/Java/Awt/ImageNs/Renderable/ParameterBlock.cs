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

namespace Java.Awt.ImageNs.Renderable
{
    #region ParameterBlock
    public partial class ParameterBlock
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#%3Cinit%3E(java.util.Vector,java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg1"><see cref="Java.Util.Vector"/></param>
        public ParameterBlock(Java.Util.Vector<object> arg0, Java.Util.Vector<object> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#%3Cinit%3E(java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public ParameterBlock(Java.Util.Vector<object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.ImageNs.Renderable.ParameterBlock t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.ImageNs.Renderable.ParameterBlock t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getNumParameters()"/> 
        /// </summary>
        public int NumParameters
        {
            get { return IExecuteWithSignature<int>("getNumParameters", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getNumSources()"/> 
        /// </summary>
        public int NumSources
        {
            get { return IExecuteWithSignature<int>("getNumSources", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getParamClasses()"/> 
        /// </summary>
        public Java.Lang.Class[] ParamClasses
        {
            get { return IExecuteWithSignatureArray<Java.Lang.Class>("getParamClasses", "()[Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#setParameters(java.util.Vector)"/>
        /// </summary>
        public Java.Util.Vector<object> Parameters
        {
            get { return IExecuteWithSignature<Java.Util.Vector<object>>("getParameters", "()Ljava/util/Vector;"); } set { IExecuteWithSignature("setParameters", "(Ljava/util/Vector;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getSources()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#setSources(java.util.Vector)"/>
        /// </summary>
        public Java.Util.Vector<object> Sources
        {
            get { return IExecuteWithSignature<Java.Util.Vector<object>>("getSources", "()Ljava/util/Vector;"); } set { IExecuteWithSignature("setSources", "(Ljava/util/Vector;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getByteParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte GetByteParameter(int arg0)
        {
            return IExecuteWithSignature<byte>("getByteParameter", "(I)B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getCharParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetCharParameter(int arg0)
        {
            return IExecuteWithSignature<char>("getCharParameter", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getDoubleParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetDoubleParameter(int arg0)
        {
            return IExecuteWithSignature<double>("getDoubleParameter", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getFloatParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloatParameter(int arg0)
        {
            return IExecuteWithSignature<float>("getFloatParameter", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getIntParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIntParameter(int arg0)
        {
            return IExecuteWithSignature<int>("getIntParameter", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(byte arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(B)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(char arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(C)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(double arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(D)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(float arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(F)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(I)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(long arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(J)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#add(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Add(short arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("add", "(S)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#addSource(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock AddSource(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("addSource", "(Ljava/lang/Object;)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(byte,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(byte arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(char,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(char arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(double arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(float arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(object arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(long arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#set(short,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock Set(short arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#setSource(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock SetSource(object arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("setSource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getRenderableSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></returns>
        public Java.Awt.ImageNs.Renderable.RenderableImage GetRenderableSource(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.RenderableImage>("getRenderableSource", "(I)Ljava/awt/image/renderable/RenderableImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getRenderedSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage GetRenderedSource(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("getRenderedSource", "(I)Ljava/awt/image/RenderedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getObjectParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObjectParameter(int arg0)
        {
            return IExecuteWithSignature("getObjectParameter", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetSource(int arg0)
        {
            return IExecuteWithSignature("getSource", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#shallowClone()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object ShallowClone()
        {
            return IExecuteWithSignature("shallowClone", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getLongParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLongParameter(int arg0)
        {
            return IExecuteWithSignature<long>("getLongParameter", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#getShortParameter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short GetShortParameter(int arg0)
        {
            return IExecuteWithSignature<short>("getShortParameter", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#removeParameters()"/>
        /// </summary>
        public void RemoveParameters()
        {
            IExecuteWithSignature("removeParameters", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ParameterBlock.html#removeSources()"/>
        /// </summary>
        public void RemoveSources()
        {
            IExecuteWithSignature("removeSources", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}