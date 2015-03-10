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
using Behaviac.Design;
using Behaviac.Design.Attachments;

namespace PluginBehaviac.NodeExporters
{
    public class EventCppExporter : AttachmentCppExporter
    {
        protected override bool ShouldGenerateClass()
        {
            return true;
        }

        protected override void GenerateMethod(Attachment attachment, StreamWriter stream, string indent)
        {
            Event evt = attachment as Event;
            Debug.Check(evt != null);

            stream.WriteLine("{0}\tpublic:", indent);

            stream.WriteLine("{0}\t\tvoid Initialize(const char* eventName, const char* referencedBehavior, TriggerMode mode, bool once)", indent);
            stream.WriteLine("{0}\t\t{{", indent);
            stream.WriteLine("{0}\t\t\tthis->m_event = LoadMethod(eventName);", indent);
            stream.WriteLine("{0}\t\t\tthis->m_referencedBehaviorPath = referencedBehavior;", indent);
            stream.WriteLine("{0}\t\t\tthis->m_triggerMode = mode;", indent);
            stream.WriteLine("{0}\t\t\tthis->m_bTriggeredOnce = once;", indent);
            stream.WriteLine("{0}\t\t}}", indent);
        }

        public override void GenerateInstance(Attachment attachment, StreamWriter stream, string indent, string nodeName, string agentType, string btClassName)
        {
            base.GenerateInstance(attachment, stream, indent, nodeName, agentType, btClassName);

            Event evt = attachment as Event;
            Debug.Check(evt != null);

            if (evt.EventName != null)
            {
                string eventName = evt.EventName.GetExportValue().Replace("\"", "\\\"");

                stream.WriteLine("{0}\t{1}->Initialize(\"{2}\", \"{3}\", {4}, {5});",
                    indent, nodeName, eventName, evt.ReferenceFilename,
                    (evt.TriggerMode == TriggerMode.Transfer) ? "TM_Transfer" : "TM_Return",
                    evt.TriggeredOnce ? "true" : "false");
            }
        }
    }
}
