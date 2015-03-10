/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Behaviac.Design.Attachments;

namespace PluginBehaviac.NodeExporters
{
    public class AttachmentCsExporter : AttachmentExporter
    {
        public static AttachmentCsExporter CreateInstance(Attachment attachment)
        {
            if (attachment != null)
            {
                string attachmentExporter = "PluginBehaviac.NodeExporters." + attachment.ExportClass + "CsExporter";
                Type exporterType = Type.GetType(attachmentExporter);
                if (exporterType != null)
                {
                    return (AttachmentCsExporter)Activator.CreateInstance(exporterType);
                }
            }

            return new AttachmentCsExporter();
        }

        public void GenerateClass(Attachment attachment, StreamWriter stream, string indent, string nodeName, string btClassName)
        {
            if (ShouldGenerateClass())
            {
                string className = GetGeneratedClassName(attachment, btClassName, nodeName);

                stream.WriteLine("{0}\tclass {1} : behaviac.{2}\r\n{0}\t{{", indent, className, attachment.ExportClass);

                GenerateMethod(attachment, stream, indent);

                stream.WriteLine("{0}\t}}\r\n", indent);
            }
        }

        public virtual void GenerateInstance(Attachment attachment, StreamWriter stream, string indent, string nodeName, string agentType, string btClassName)
        {
            string className = GetGeneratedClassName(attachment, btClassName, nodeName);

            // create a new instance of the node
            stream.WriteLine("{0}\t{1} {2} = new {1}();", indent, className, nodeName);

            // set its basic properties
            stream.WriteLine("{0}\t{1}.SetClassNameString(\"{2}\");", indent, nodeName, attachment.ExportClass);
            stream.WriteLine("{0}\t{1}.SetId({2});", indent, nodeName, attachment.Id);
            stream.WriteLine("#if !BEHAVIAC_RELEASE");
            stream.WriteLine("{0}\t{1}.SetAgentType(\"{2}\");", indent, nodeName, agentType.Replace("::", "."));
            stream.WriteLine("#endif");
        }

        protected string GetGeneratedClassName(Attachment attachment, string btClassName, string nodeName)
        {
            if (ShouldGenerateClass())
            {
                return string.Format("{0}_{1}_{2}", attachment.ExportClass, btClassName, nodeName);
            }

            return attachment.ExportClass;
        }

        protected virtual bool ShouldGenerateClass()
        {
            return false;
        }

        protected virtual void GenerateMethod(Attachment attachment, StreamWriter stream, string indent)
        {
        }
    }
}
