﻿/*
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

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System;

namespace MASES.JNetReflector.Templates
{
    public class Template
    {
        static readonly string[] templateStrings = new string[]
        {
            AllPackageClassesTemplate,
            AllPackageClassesStubClassTemplate,
            AllPackageClassesStubClassListenerTemplate,
            AllPackageClassesStubClassMainClassTemplate,
            AllPackageClassesStubExceptionTemplate,

            SingleClassTemplate,
            SingleClassFileTemplate,

            SingleConstructorTemplate,
            SingleFieldTemplate,
            SingleMethodTemplate,
            SinglePropertyTemplate,
        };

        static Template()
        {
            foreach (var item in templateStrings)
            {
                string template = string.Empty;
                using (var stream = typeof(Template).Assembly.GetManifestResourceStream(typeof(Template).Namespace + "." + item))
                {
                    using (var sr = new StreamReader(stream))
                    {
                        template = sr.ReadToEnd();
                    }
                }
                templates.Add(item, template);
            }
        }

        static readonly IDictionary<string, string> templates = new ConcurrentDictionary<string, string>();
        public static string GetTemplate(string templateName)
        {
            string template;
            if (!templates.TryGetValue(templateName, out template))
            {
                throw new InvalidOperationException(string.Format("Missing template {0}", templateName));
            }
            return template;
        }

        public const string AllPackageClassesTemplate = "AllPackageClasses.template";
        public const string AllPackageClassesStubClassTemplate = "AllPackageClassesStubClass.template";
        public const string AllPackageClassesStubClassListenerTemplate = "AllPackageClassesStubClassListener.template";
        public const string AllPackageClassesStubClassMainClassTemplate = "AllPackageClassesStubClassMainClass.template";
        public const string AllPackageClassesStubExceptionTemplate = "AllPackageClassesStubException.template";

        public const string SingleClassTemplate = "SingleClass.template";
        public const string SingleClassFileTemplate = "SingleClassFile.template";
        public const string SingleConstructorTemplate = "SingleConstructor.template";
        public const string SingleFieldTemplate = "SingleField.template";
        public const string SingleMethodTemplate = "SingleMethod.template";
        public const string SinglePropertyTemplate = "SingleProperty.template";
    }

    public class AllPackageClasses
    {
        public const string VERSION = "ALLPACKAGE_VERSION_PLACEHOLDER";
        public const string JAR = "ALLPACKAGE_JAR_PLACEHOLDER";
        public const string NAMESPACE = "ALLPACKAGE_NAMESPACE_PLACEHOLDER";
        public const string CLASSES = "// ALLPACKAGE_CLASSES_PLACEHOLDER";

        public static string DocTemplate(string jdocUrl) => jdocUrl != null ? HREF_URL : CREF_URL;

        const string CREF_URL = "<see cref=\"{0}\"/>";
        const string HREF_URL = "<see href=\"{0}\"/>";

        public class ClassStub
        {
            public const string DECORATION = "ALLPACKAGE_CLASSES_STUB_CLASS_DECORATION_PLACEHOLDER";
            public const string HELP = "ALLPACKAGE_CLASSES_STUB_CLASS_HELP_PLACEHOLDER";
            public const string SIMPLECLASS = "ALLPACKAGE_CLASSES_STUB_SIMPLECLASS_PLACEHOLDER";
            public const string CLASS = "ALLPACKAGE_CLASSES_STUB_CLASS_PLACEHOLDER";
            public const string BASECLASS = "ALLPACKAGE_CLASSES_STUB_BASECLASS_PLACEHOLDER";
            public const string WHERECLAUSES = "ALLPACKAGE_CLASSES_STUB_WHERECLAUSES_PLACEHOLDER";
            public const string JAVACLASS = "ALLPACKAGE_CLASSES_STUB_JAVACLASS_PLACEHOLDER";
            public const string CONSTRUCTORS = "// ALLPACKAGE_CLASSES_STUB_CONSTRUCTORS_PLACEHOLDER";
            public const string OPERATORS = "// ALLPACKAGE_CLASSES_STUB_OPERATORS_PLACEHOLDER";
            public const string FIELDS = "// ALLPACKAGE_CLASSES_STUB_FIELDS_PLACEHOLDER";
            public const string STATICMETHODS = "// ALLPACKAGE_CLASSES_STUB_STATIC_METHODS_PLACEHOLDER";
            public const string METHODS = "// ALLPACKAGE_CLASSES_STUB_METHODS_PLACEHOLDER";
            public const string NESTED_CLASSES = "// ALLPACKAGE_CLASSES_STUB_NESTED_CLASSES_PLACEHOLDER";

            public const string ISABSTRACT = "ALLPACKAGE_CLASSES_STUB_ISABSTRACT_PLACEHOLDER";
            public const string ISCLOSEABLE = "ALLPACKAGE_CLASSES_STUB_ISCLOSEABLE_PLACEHOLDER";
            public const string ISINTERFACE = "ALLPACKAGE_CLASSES_STUB_ISINTERFACE_PLACEHOLDER";
            public const string ISSTATIC = "ALLPACKAGE_CLASSES_STUB_ISSTATIC_PLACEHOLDER";

            public static readonly string HELP_PARAM_SEE_DECORATION = "<see cref=\"{0}\"/>";
            public static readonly string HELP_TYPEPARAM_DECORATION = "/// <typeparam name=\"{0}\">{1}</typeparam>";

            public static string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                    + "/// ALLPACKAGE_CLASSES_STUB_CLASS_HELP_PLACEHOLDER" + Environment.NewLine
                                                    + "/// </summary>";
            public const string OBSOLETE_DECORATION = "[System.Obsolete()]";

            public class ConstructorStub
            {
                public const string DECORATION = "CONSTRUCTOR_STUB_CONSTRUCTOR_DECORATION_PLACEHOLDER";
                public const string HELP = "CONSTRUCTOR_STUB_CONSTRUCTOR_HELP_PLACEHOLDER";
                public const string MODIFIER = "CONSTRUCTOR_STUB_MODIFIER_PLACEHOLDER";
                public const string NAME = "CONSTRUCTOR_STUB_CONSTRUCTOR_NAME_PLACEHOLDER";
                public const string PARAMETERS = "CONSTRUCTOR_STUB_PARAMETERS_PLACEHOLDER";
                public const string EXECUTION = "CONSTRUCTOR_STUB_EXECUTION_PLACEHOLDER";

                public static readonly string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                                 + "/// CONSTRUCTOR_STUB_CONSTRUCTOR_HELP_PLACEHOLDER" + Environment.NewLine
                                                                 + "/// </summary>";
                public static readonly string HELP_PARAM_DECORATION = "/// <param name=\"{0}\">{1}</param>";
                public static readonly string HELP_PARAM_SEE_DECORATION = "<see cref=\"{0}\"/>";
                public static readonly string HELP_PARAM_TYPEPARAMREF_DECORATION = "<typeparamref name=\"{0}\"/>";
                public static readonly string HELP_EXCEPTION_DECORATION = "/// <exception cref=\"{0}\"/>";
                public const string OBSOLETE_DECORATION = "[System.Obsolete()]";
            }

            public class OperatorStub
            {
                public const string IMPLICIT_EXECUTION_FORMAT = "public static implicit operator {0}({1} t) => t.Cast<{0}>();";
                public static readonly string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                                   + "/// Converter from <see cref=\"{1}\"/> to <see cref=\"{0}\"/>" + Environment.NewLine
                                                                   + "/// </summary>";
            }

            public class MethodStub
            {
                public const string DECORATION = "METHOD_STUB_METHOD_DECORATION_PLACEHOLDER";
                public const string HELP = "METHOD_STUB_METHOD_HELP_PLACEHOLDER";
                public const string MODIFIER = "METHOD_STUB_MODIFIER_PLACEHOLDER";
                public const string RETURNTYPE = "METHOD_STUB_RETURN_TYPE_PLACEHOLDER";
                public const string NAME = "METHOD_STUB_METHOD_NAME_PLACEHOLDER";
                public const string PARAMETERS = "METHOD_STUB_PARAMETERS_PLACEHOLDER";
                public const string WHERECLAUSES = "METHOD_STUB_WHERECLAUSES_PLACEHOLDER";
                public const string EXECUTION = "METHOD_STUB_EXECUTION_PLACEHOLDER";
                public const string EXECUTION_FORMAT = "{0}{1}{2}(\"{3}\"{4});";
                public const string SINGLE_ARRAY_EXECUTION_FORMAT = "new object[] {{ {0} }}";
                public const string STATIC_EXECUTION_FORMAT = "{0}{1}{2}(LocalBridgeClazz, \"{3}\"{4});";
                public const string EXECUTION_FORMAT_EXCEPTION = "var obj = {0}<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>(\"{1}\"{2}); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<{3}>(obj);";
                public const string STATIC_EXECUTION_FORMAT_EXCEPTION = "var obj = {0}<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>(LocalBridgeClazz, \"{1}\"{2}); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<{3}>(obj);";
                public static readonly string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                                 + "/// METHOD_STUB_METHOD_HELP_PLACEHOLDER" + Environment.NewLine
                                                                 + "/// </summary>";
                public static readonly string HELP_PARAM_DECORATION = "/// <param name=\"{0}\">{1}</param>";
                public static readonly string HELP_PARAM_SEE_DECORATION = "<see cref=\"{0}\"/>";
                public static readonly string HELP_PARAM_TYPEPARAMREF_DECORATION = "<typeparamref name=\"{0}\"/>";
                public static readonly string HELP_TYPEPARAM_DECORATION = "/// <typeparam name=\"{0}\">{1}</typeparam>";
                public static readonly string HELP_RETURN_DECORATION = "/// <returns>{0}</returns>";
                public static readonly string HELP_EXCEPTION_DECORATION = "/// <exception cref=\"{0}\"/>";
                public const string OBSOLETE_DECORATION = "[System.Obsolete()]";

                public const string STATIC_EXECUTE = "SExecute";
                public const string INSTANCE_EXECUTE = "IExecute";
            }

            public class PropertyStub
            {
                public const string DECORATION = "PROPERTY_STUB_DECORATION_PLACEHOLDER";
                public const string GET_HELP = "PROPERTY_STUB_GET_PROPERTY_HELP_PLACEHOLDER";
                public const string SET_HELP = "PROPERTY_STUB_SET_PROPERTY_HELP_PLACEHOLDER";
                public const string MODIFIER = "PROPERTY_STUB_MODIFIER_PLACEHOLDER";
                public const string TYPE = "PROPERTY_STUB_RETURN_TYPE_PLACEHOLDER";
                public const string NAME = "PROPERTY_STUB_PROPERTY_NAME_PLACEHOLDER";
                public const string EXECUTION = "PROPERTY_STUB_EXECUTION_PLACEHOLDER";
                public const string GET_EXECUTION_FORMAT = "get {{ return {0}{1}(\"{2}\"); }}";
                public const string STATIC_GET_EXECUTION_FORMAT = "get {{ return {0}{1}(LocalBridgeClazz, \"{2}\"); }}";
                public const string SET_EXECUTION_FORMAT = " set {{ {0}(\"{1}\", value); }}";
                public const string SET_ARRAY_EXECUTION_FORMAT = " set {{ {0}(\"{1}\", new object[] { value }); }}";
                public const string STATIC_SET_EXECUTION_FORMAT = " set {{ {0}(LocalBridgeClazz, \"{1}\", value); }}";
                public const string STATIC_SET_ARRAY_EXECUTION_FORMAT = " set {{ {0}(LocalBridgeClazz, \"{1}\", new object[] { value }); }}";
                public const string GET_EXECUTION_FORMAT_EXCEPTION = "get {{ var obj = {0}<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>(\"{2}\"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<{1}>(obj); }}";
                public const string STATIC_GET_EXECUTION_FORMAT_EXCEPTION = "get {{ var obj = {0}<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>(LocalBridgeClazz, \"{2}\"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<{1}>(obj); }}";

                public static readonly string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                                 + "/// PROPERTY_STUB_GET_PROPERTY_HELP_PLACEHOLDER PROPERTY_STUB_SET_PROPERTY_HELP_PLACEHOLDER" + Environment.NewLine
                                                                 + "/// </summary>";
                public const string OBSOLETE_DECORATION = "[System.Obsolete()]";
            }

            public class FieldStub
            {
                public const string DECORATION = "FIELD_STUB_FIELD_DECORATION_PLACEHOLDER";
                public const string HELP = "FIELD_STUB_FIELD_HELP_PLACEHOLDER";
                public const string MODIFIER = "FIELD_STUB_MODIFIER_PLACEHOLDER";
                public const string TYPE = "FIELD_STUB_TYPE_PLACEHOLDER";
                public const string NAME = "FIELD_STUB_FIELD_NAME_PLACEHOLDER";
                public const string EXECUTION = "FIELD_STUB_EXECUTION_PLACEHOLDER";
                public const string GET_EXECUTION_FORMAT = "get {{ return {0}{1}(\"{2}\"); }}";
                public const string GET_STATIC_EXECUTION_FORMAT = "get {{ return {0}{1}(LocalBridgeClazz, \"{2}\"); }}";
                public const string SET_EXECUTION_FORMAT = "set {{ ISetField(\"{0}\", value); }}";
                public const string SET_STATIC_EXECUTION_FORMAT = "set {{ SSetField(LocalBridgeClazz, \"{0}\", value); }}";

                public static readonly string DEFAULT_DECORATION = "/// <summary>" + Environment.NewLine
                                                                 + "/// FIELD_STUB_FIELD_HELP_PLACEHOLDER" + Environment.NewLine
                                                                 + "/// </summary>";
                public const string OBSOLETE_DECORATION = "[System.Obsolete()]";
            }
        }
    }
}
