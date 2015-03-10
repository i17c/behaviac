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

#include "behaviac/base/base.h"
#include "behaviac/behaviortree/nodes/actions/waitframes.h"
#include "behaviac/agent/agent.h"

namespace behaviac
{
	WaitFrames::WaitFrames() : m_frames_var(0), m_frames_method(0)
	{
	}

	WaitFrames::~WaitFrames()
	{
		BEHAVIAC_DELETE(this->m_frames_var);
		BEHAVIAC_DELETE(this->m_frames_method);
	}

	Property* LoadRight(const char* value, const behaviac::string& propertyName, behaviac::string& typeName);
	CMethodBase* LoadMethod(const char* value);

    void WaitFrames::load(int version, const char* agentType, const properties_t& properties)
    {
		super::load(version, agentType, properties);
        for (propertie_const_iterator_t it = properties.begin(); it != properties.end(); ++it)
        {
            const property_t& p = (*it);

            if (!strcmp(p.name, "Frames"))
			{
				behaviac::string propertyName;

				const char* pParenthesis = strchr(p.value, '(');
				if (pParenthesis == 0)
				{
					behaviac::string typeName;
					this->m_frames_var = LoadRight(p.value, propertyName, typeName);
				}
				else
				{
					//method
					this->m_frames_method = LoadMethod(p.value);
				}
			}
        }
    }

	int WaitFrames::GetFrames(Agent* pAgent) const
	{
		if (this->m_frames_var)
		{
			BEHAVIAC_ASSERT(this->m_frames_var);
			TProperty<int>* pP = (TProperty<int>*)this->m_frames_var;
			uint64_t frames = pP->GetValue(pAgent);

			return (frames == ((uint64_t)-1) ? -1 : (int)frames);
		}
		else if (this->m_frames_method)
		{
			ParentType pt = this->m_frames_method->GetParentType();
			Agent* pParent = pAgent;
			if (pt == PT_INSTANCE)
			{
				pParent = Agent::GetInstance(this->m_frames_method->GetInstanceNameString(), pParent->GetContextId());
				BEHAVIAC_ASSERT(pParent);
			}

            this->m_frames_method->run(pParent, pAgent);

			int frames = 0;
			this->m_frames_method->GetReturnValue(pParent, frames);

			return frames;
		}

		return 0;
	}

	BehaviorTask* WaitFrames::createTask() const
	{
		WaitFramesTask* pTask = BEHAVIAC_NEW WaitFramesTask();

		return pTask;
	}

	WaitFramesTask::WaitFramesTask() : LeafTask(), m_start(0), m_frames(0)
	{
	}

	void WaitFramesTask::copyto(BehaviorTask* target) const
	{
		super::copyto(target);

		BEHAVIAC_ASSERT(WaitFramesTask::DynamicCast(target));
		WaitFramesTask* ttask = (WaitFramesTask*)target;
		ttask->m_start = this->m_start;
		ttask->m_frames = this->m_frames;
	}

	void WaitFramesTask::save(ISerializableNode* node) const
	{
		super::save(node);

		CSerializationID  startId("start");
		node->setAttr(startId, this->m_start);

		CSerializationID  framesId("frames");
		node->setAttr(framesId, this->m_frames);
	}

	void WaitFramesTask::load(ISerializableNode* node)
	{
		super::load(node);
	}

	WaitFramesTask::~WaitFramesTask()
	{
	}

	int WaitFramesTask::GetFrames(Agent* pAgent) const
	{
		BEHAVIAC_ASSERT(WaitFrames::DynamicCast(this->GetNode()));
		const WaitFrames* pWaitNode = (const WaitFrames*)(this->GetNode());

		return pWaitNode ? pWaitNode->GetFrames(pAgent) : 0;
	}

    bool WaitFramesTask::onenter(Agent* pAgent)
    {
        BEHAVIAC_UNUSED_VAR(pAgent);

		this->m_start = 0;
		this->m_frames = this->GetFrames(pAgent);

		if (this->m_frames <= 0)
		{
			return false;
		}

        return true;
    }

    void WaitFramesTask::onexit(Agent* pAgent, EBTStatus s)
    {
        BEHAVIAC_UNUSED_VAR(pAgent);
        BEHAVIAC_UNUSED_VAR(s);
    }

    EBTStatus WaitFramesTask::update(Agent* pAgent, EBTStatus childStatus)
    {
        BEHAVIAC_UNUSED_VAR(pAgent);
        BEHAVIAC_UNUSED_VAR(childStatus);
        
		this->m_start += (int)(Workspace::GetDeltaFrames());
		if (this->m_start >= this->m_frames)
		{
			return BT_SUCCESS;
		}

        return BT_RUNNING;
    }

}