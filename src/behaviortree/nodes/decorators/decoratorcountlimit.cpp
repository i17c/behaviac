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
#include "behaviac/behaviortree/nodes/decorators/decoratorcountlimit.h"

namespace behaviac
{
	DecoratorCountLimit::DecoratorCountLimit()
	{}

	DecoratorCountLimit::~DecoratorCountLimit()
	{}

	void DecoratorCountLimit::load(int version, const char* agentType, const properties_t& properties)
	{
		DecoratorCount::load(version, agentType, properties);
	}

	bool DecoratorCountLimit::IsValid(Agent* pAgent, BehaviorTask* pTask) const
	{
		if (!DecoratorCountLimit::DynamicCast(pTask->GetNode()))
		{
			return false;
		}
	
		return super::IsValid(pAgent, pTask);
	}

	BehaviorTask* DecoratorCountLimit::createTask() const
	{
		DecoratorCountLimitTask* pTask = BEHAVIAC_NEW DecoratorCountLimitTask();
		
		return pTask;
	}

	DecoratorCountLimitTask::DecoratorCountLimitTask() : DecoratorCountTask(), m_bInited(false)
	{
	}

	void DecoratorCountLimitTask::copyto(BehaviorTask* target) const
	{
		super::copyto(target);

		BEHAVIAC_ASSERT(DecoratorCountLimitTask::DynamicCast(target));
		DecoratorCountLimitTask* ttask = (DecoratorCountLimitTask*)target;

		ttask->m_bInited = this->m_bInited;
	}


	void DecoratorCountLimitTask::save(ISerializableNode* node) const
	{
		super::save(node);

		CSerializationID  initId("inited");
		node->setAttr(initId, this->m_bInited);
	}

	void DecoratorCountLimitTask::load(ISerializableNode* node)
	{
		super::load(node);
	}



	bool DecoratorCountLimitTask::CheckPredicates(Agent* pAgent)
	{
		if (!this->m_attachments)
		{
			return false;
		}

		return super::CheckPredicates(pAgent);
	}

	bool DecoratorCountLimitTask::onenter(Agent* pAgent)
	{
		if (this->CheckPredicates(pAgent))
		{
			this->m_bInited = false;
		}

		if (!this->m_bInited)
		{
			this->m_bInited = true;

			int count = this->GetCount(pAgent);

			this->m_n = count;
		}

		//if this->m_n is -1, it is endless
		if (this->m_n > 0)
		{
			this->m_n--;
			return true;
		}
		else if (this->m_n == 0)
		{
			return false;
		}
		else if (this->m_n == -1)
		{
			return true;
		}

		BEHAVIAC_ASSERT(0);

		return false;
	}

	EBTStatus DecoratorCountLimitTask::decorate(EBTStatus status)
	{
		BEHAVIAC_UNUSED_VAR(status);
		BEHAVIAC_ASSERT(this->m_n >= 0 || this->m_n == -1);

		return status;
	}

}//namespace behaviac