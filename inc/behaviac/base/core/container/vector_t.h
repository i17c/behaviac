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

#ifndef _BASE_VECTOR_H_
#define _BASE_VECTOR_H_

#include "behaviac/base/core/config.h"
#include "behaviac/base/core/assert_t.h"

#include <vector>
#include "behaviac/base/core/memory/stl_allocator.h"

namespace behaviac
{
	template<class _Ty,	class _Ax = behaviac::stl_allocator<_Ty> >
	class vector : public std::vector<_Ty, _Ax>
	{

	};
}//namespace behaviac


#endif //#ifndef _BASE_VECTOR_H_
