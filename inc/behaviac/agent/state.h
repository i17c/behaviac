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

#ifndef _BEHAVIAC_STATE_H_
#define _BEHAVIAC_STATE_H_

#include "behaviac/base/base.h"
#include "behaviac/property/properties.h"

namespace behaviac
{
	class Property;
	class World;
	class BehaviorTreeTask;

	/*! \addtogroup Agent
	* @{
	* \addtogroup State_t
	* @{ */

	/// The State_t class
	/*!
	I don't know what is this!
	*/

	class BEHAVIAC_API State_t
	{
	protected:
		Variables			m_vars;
		BehaviorTreeTask*	m_bt;

		friend class Agent;
		friend class Context;
	public:
		State_t();
		State_t(const State_t& c);
		virtual ~State_t();

		void Clear();

		bool SaveToFile(const char* fileName) const;
		bool LoadFromFile(const char* fileName);

		bool SaveToFile(IFile* file) const;
		virtual bool LoadFromFile(IFile* file);
	protected:
		State_t& operator=(const State_t& c);
	};

	/*! @} */
	/*! @} */

	typedef behaviac::map<const behaviac::string, State_t> States_t;
}


#endif//#ifndef _BEHAVIAC_STATE_H_
