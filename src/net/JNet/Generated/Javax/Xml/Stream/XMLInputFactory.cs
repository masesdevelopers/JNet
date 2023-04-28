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

namespace Javax.Xml.Stream
{
    #region XMLInputFactory
    public partial class XMLInputFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#ALLOCATOR"/>
        /// </summary>
        public static string ALLOCATOR { get { return LocalClazz.GetField<string>("ALLOCATOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_COALESCING"/>
        /// </summary>
        public static string IS_COALESCING { get { return LocalClazz.GetField<string>("IS_COALESCING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_NAMESPACE_AWARE"/>
        /// </summary>
        public static string IS_NAMESPACE_AWARE { get { return LocalClazz.GetField<string>("IS_NAMESPACE_AWARE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_REPLACING_ENTITY_REFERENCES"/>
        /// </summary>
        public static string IS_REPLACING_ENTITY_REFERENCES { get { return LocalClazz.GetField<string>("IS_REPLACING_ENTITY_REFERENCES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_SUPPORTING_EXTERNAL_ENTITIES"/>
        /// </summary>
        public static string IS_SUPPORTING_EXTERNAL_ENTITIES { get { return LocalClazz.GetField<string>("IS_SUPPORTING_EXTERNAL_ENTITIES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#IS_VALIDATING"/>
        /// </summary>
        public static string IS_VALIDATING { get { return LocalClazz.GetField<string>("IS_VALIDATING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#REPORTER"/>
        /// </summary>
        public static string REPORTER { get { return LocalClazz.GetField<string>("REPORTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#RESOLVER"/>
        /// </summary>
        public static string RESOLVER { get { return LocalClazz.GetField<string>("RESOLVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#SUPPORT_DTD"/>
        /// </summary>
        public static string SUPPORT_DTD { get { return LocalClazz.GetField<string>("SUPPORT_DTD"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newDefaultFactory()"/> 
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewDefaultFactory
        {
            get { return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalClazz, "newDefaultFactory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newInstance()"/> 
        /// </summary>
        public static Javax.Xml.Stream.XMLInputFactory NewInstance
        {
            get { return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalClazz, "newInstance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory()
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalClazz, "newFactory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#newFactory(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLInputFactory"/></returns>
        /// <exception cref="Javax.Xml.Stream.FactoryConfigurationError"/>
        public static Javax.Xml.Stream.XMLInputFactory NewFactory(string arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Stream.XMLInputFactory>(LocalClazz, "newFactory", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getEventAllocator()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setEventAllocator(javax.xml.stream.util.XMLEventAllocator)"/>
        /// </summary>
        public Javax.Xml.Stream.Util.XMLEventAllocator EventAllocator
        {
            get { return IExecute<Javax.Xml.Stream.Util.XMLEventAllocator>("getEventAllocator"); } set { IExecute("setEventAllocator", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLReporter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLReporter(javax.xml.stream.XMLReporter)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLReporter XMLReporter
        {
            get { return IExecute<Javax.Xml.Stream.XMLReporter>("getXMLReporter"); } set { IExecute("setXMLReporter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getXMLResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setXMLResolver(javax.xml.stream.XMLResolver)"/>
        /// </summary>
        public Javax.Xml.Stream.XMLResolver XMLResolver
        {
            get { return IExecute<Javax.Xml.Stream.XMLResolver>("getXMLResolver"); } set { IExecute("setXMLResolver", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#isPropertySupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertySupported(string arg0)
        {
            return IExecute<bool>("isPropertySupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLEventReader,javax.xml.stream.EventFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.EventFilter"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateFilteredReader(Javax.Xml.Stream.XMLEventReader arg0, Javax.Xml.Stream.EventFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0, string arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(string arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(java.lang.String,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(string arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.stream.XMLStreamReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Stream.XMLStreamReader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLEventReader(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLEventReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLEventReader CreateXMLEventReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLEventReader>("createXMLEventReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createFilteredReader(javax.xml.stream.XMLStreamReader,javax.xml.stream.StreamFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamReader"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Stream.StreamFilter"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateFilteredReader(Javax.Xml.Stream.XMLStreamReader arg0, Javax.Xml.Stream.StreamFilter arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createFilteredReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0, string arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.InputStream arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Java.Io.Reader arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(string arg0, Java.Io.InputStream arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(java.lang.String,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(string arg0, Java.Io.Reader arg1)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#createXMLStreamReader(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Stream.XMLStreamReader"/></returns>
        /// <exception cref="Javax.Xml.Stream.XMLStreamException"/>
        public Javax.Xml.Stream.XMLStreamReader CreateXMLStreamReader(Javax.Xml.Transform.Source arg0)
        {
            return IExecute<Javax.Xml.Stream.XMLStreamReader>("createXMLStreamReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/XMLInputFactory.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetProperty(string arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}