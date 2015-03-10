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

#include "../btloadtestsuite.h"
#include "behaviac/base/core/profiler/profiler.h"

LOAD_TEST(btunittest, circular_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/circular_ut_0", format);
	myTestAgent->resetProperties();

	myTestAgent->SetVariable("testVar_0", 0);

	const int kCount = 10;
	for (int i = 0; i < kCount; ++i)
	{
		myTestAgent->btexec();
		int p = myTestAgent->GetVariable<int>("testVar_0");
		BEHAVIAC_ASSERT(1 == p);
		BEHAVIAC_UNUSED_VAR(p);
	}

	finlTestEnvNode(myTestAgent);
}

//< selector loop test
LOAD_TEST(btunittest, selector_loop_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_loop_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_loop_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_loop_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_loop_ut_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_loop_ut_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_loop_ut_3)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_loop_ut_3", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(-1, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_loop_ut_4)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_loop_ut_4", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	CHECK_EQUAL(0, myTestAgent->testVar_1);
	myTestAgent->resetProperties();
	myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	CHECK_EQUAL(0, myTestAgent->testVar_1);
	finlTestEnvNode(myTestAgent);
}

//< selector node test
LOAD_TEST(btunittest, selector_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_ut_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_ut_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_ut_3)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_ut_3", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, selector_ut_4)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/selector_ut_4", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

//< sequence node test
LOAD_TEST(btunittest, sequence_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/sequence_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, sequence_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/sequence_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, sequence_ut_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/sequence_ut_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, sequence_ut_3)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/sequence_ut_3", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

//< if else node test
LOAD_TEST(btunittest, if_else_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/if_else_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, if_else_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/if_else_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

//< Sequence Stochastic node test
#define STOCHASTIC_SAMPLE_COUNT	9000

void test_stochastic_distribution_0(behaviac::string tree, behaviac::Workspace::EFileFormat format)
{
	behaviac::Profiler::CreateInstance();
	behaviac::Start();
	behaviac::LogManager::GetInstance()->SetEnabled(false);
	behaviac::Config::SetSocketing(false);
	behaviac::Config::SetLogging(false);
	behaviac::Agent::Register<AgentNodeTest>();
	AgentNodeTest* myTestAgent = AgentNodeTest::DynamicCast(behaviac::Agent::Create<AgentNodeTest>());
	behaviac::Agent::SetIdMask(1);
	myTestAgent->SetIdFlag(1);
	behaviac::Workspace::SetWorkspaceSettings("../test/btunittest/BehaviacData/exported", format);
	myTestAgent->btload(tree.c_str());
	myTestAgent->btsetcurrent(tree.c_str());
	myTestAgent->resetProperties();

	int counts[3] = { 0, 0, 0 };
	int loopCount = STOCHASTIC_SAMPLE_COUNT;
	while (loopCount > 0)
	{
		myTestAgent->btexec();
		++(counts[myTestAgent->testVar_0]);
		--loopCount;
	}
#if BEHAVIAC_COMPILER_MSVC
	for (int i = 0; i < 3; ++i)
	{
		int k = counts[i];
		int bias = abs(k - STOCHASTIC_SAMPLE_COUNT / 3);
		CHECK_LESS(bias, (STOCHASTIC_SAMPLE_COUNT / 30));
	}
#endif
	BEHAVIAC_DELETE(myTestAgent);
	behaviac::Agent::UnRegister<AgentNodeTest>();
	behaviac::Stop();
	behaviac::Profiler::DestroyInstance();
}

void test_stochastic_distribution_1(behaviac::string tree, behaviac::Workspace::EFileFormat format,
	int loopCount = STOCHASTIC_SAMPLE_COUNT, int referenceValue = STOCHASTIC_SAMPLE_COUNT / 3, int checkValue = STOCHASTIC_SAMPLE_COUNT / 30)
{
	behaviac::Profiler::CreateInstance();
	behaviac::Start();
	behaviac::LogManager::GetInstance()->SetEnabled(false);
	behaviac::Config::SetSocketing(false);
	behaviac::Config::SetLogging(false);
	behaviac::Agent::Register<AgentNodeTest>();
	AgentNodeTest* myTestAgent = AgentNodeTest::DynamicCast(behaviac::Agent::Create<AgentNodeTest>());
	behaviac::Agent::SetIdMask(1);
	myTestAgent->SetIdFlag(1);
	
	behaviac::Workspace::SetWorkspaceSettings("../test/btunittest/BehaviacData/exported", format);

	int predicateValueCount = 0;
	myTestAgent->btload(tree.c_str());
	myTestAgent->btsetcurrent(tree.c_str());
	myTestAgent->resetProperties();
	while (loopCount > 0)
	{
		myTestAgent->resetProperties();
		myTestAgent->btexec();
		if (myTestAgent->testVar_0 == 0)
			predicateValueCount++;
		--loopCount;
	}
#if BEHAVIAC_COMPILER_MSVC
	int bias = abs(predicateValueCount - referenceValue);
	CHECK_LESS(bias, checkValue);
#endif
	BEHAVIAC_DELETE(myTestAgent);
	behaviac::Agent::UnRegister<AgentNodeTest>();
	behaviac::Stop();
	behaviac::Profiler::DestroyInstance();
}
//
LOAD_TEST(btunittest, sequence_stochastic_ut_0)
{
	test_stochastic_distribution_0("node_test/sequence_stochastic_ut_0", format);
}

LOAD_TEST(btunittest, sequence_stochastic_ut_1)
{	
	test_stochastic_distribution_1("node_test/sequence_stochastic_ut_1", format);
}

LOAD_TEST(btunittest, sequence_stochastic_ut_2)
{
	test_stochastic_distribution_1("node_test/sequence_stochastic_ut_2", format);
}

LOAD_TEST(btunittest, sequence_stochastic_ut_3)
{
	test_stochastic_distribution_1("node_test/sequence_stochastic_ut_3", format);
}

//< Selector Stochastic Tests
LOAD_TEST(btunittest, selector_stochastic_ut_0)
{
	test_stochastic_distribution_0("node_test/selector_stochastic_ut_0", format);
}

LOAD_TEST(btunittest, selector_stochastic_ut_1)
{
	test_stochastic_distribution_1("node_test/selector_stochastic_ut_1", format);
}

LOAD_TEST(btunittest, selector_stochastic_ut_2)
{
	test_stochastic_distribution_1("node_test/selector_stochastic_ut_2", format, 6000, 3000, 200);
}

//< Selector Probability Tests
void test_stochastic_distribution_2(behaviac::string tree, behaviac::Workspace::EFileFormat format, int refs[3])
{
	behaviac::Profiler::CreateInstance();
	behaviac::Start();
	behaviac::LogManager::GetInstance()->SetEnabled(false);
	behaviac::Config::SetSocketing(false);
	behaviac::Config::SetLogging(false);
	behaviac::Agent::Register<AgentNodeTest>();
	AgentNodeTest* myTestAgent = AgentNodeTest::DynamicCast(behaviac::Agent::Create<AgentNodeTest>());
	behaviac::Agent::SetIdMask(1);
	myTestAgent->SetIdFlag(1);
	behaviac::Workspace::SetWorkspaceSettings("../test/btunittest/BehaviacData/exported", format);
	myTestAgent->btload(tree.c_str());
	myTestAgent->btsetcurrent(tree.c_str());
	myTestAgent->resetProperties();

	int counts[3] = { 0, 0, 0 };
	int loopCount = 10000;
	while (loopCount > 0)
	{
		myTestAgent->btexec();
		++(counts[myTestAgent->testVar_0]);
		--loopCount;
	}

	for (int i = 0; i < 3; ++i)
	{
		int k = counts[i];
		int bias = abs(k - refs[i]);
		CHECK_LESS(bias, 1000);
	}

	BEHAVIAC_DELETE(myTestAgent);
	behaviac::Agent::UnRegister<AgentNodeTest>();
	behaviac::Stop();
	behaviac::Profiler::DestroyInstance();
}

LOAD_TEST(btunittest, selector_probability_ut_0)
{
	int refs[3] = { 2000, 3000, 5000 };
	test_stochastic_distribution_2("node_test/selector_probability_ut_0", format, refs);
}

LOAD_TEST(btunittest, selector_probability_ut_1)
{
	int refs[3] = { 0, 5000, 5000 };
	test_stochastic_distribution_2("node_test/selector_probability_ut_1", format, refs);
}

LOAD_TEST(btunittest, selector_probability_ut_2)
{
	const char* tree = "node_test/selector_probability_ut_2";

	behaviac::Profiler::CreateInstance();
	behaviac::Start();
	behaviac::LogManager::GetInstance()->SetEnabled(false);
	behaviac::Config::SetSocketing(false);
	behaviac::Config::SetLogging(false);
	behaviac::Agent::Register<AgentNodeTest>();
	AgentNodeTest* myTestAgent = AgentNodeTest::DynamicCast(behaviac::Agent::Create<AgentNodeTest>());
	behaviac::Agent::SetIdMask(1);
	myTestAgent->SetIdFlag(1);
	behaviac::Workspace::SetWorkspaceSettings("../test/btunittest/BehaviacData/exported", format);
	myTestAgent->btload(tree);
	myTestAgent->btsetcurrent(tree);
	myTestAgent->resetProperties();

	int loopCount = 10000;
	while (loopCount > 0)
	{
		myTestAgent->btexec();
		CHECK_EQUAL(-1, myTestAgent->testVar_0);
		--loopCount;
	}

	BEHAVIAC_DELETE(myTestAgent);
	behaviac::Agent::UnRegister<AgentNodeTest>();
	behaviac::Stop();
	behaviac::Profiler::DestroyInstance();
}

//< Condition Nodes Tests
LOAD_TEST(btunittest, condition_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/condition_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, condition_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/condition_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, condition_ut_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/condition_ut_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(0, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, condition_ut_3)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/condition_ut_3", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	finlTestEnvNode(myTestAgent);
}

//< Action Nodes Tests
LOAD_TEST(btunittest, action_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_0", format);
	myTestAgent->resetProperties();

	behaviac::Agent::CreateInstance<StaticAgent>("StaticAgent");

	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1500, myTestAgent->testVar_0);
	CHECK_EQUAL(1800, myTestAgent->testVar_1);

	behaviac::Agent::DestroyInstance<StaticAgent>();

	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, action_ut_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(1.8f, myTestAgent->testVar_2);
	CHECK_EQUAL(4.5f, myTestAgent->testVar_3);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, action_ut_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(500000, myTestAgent->testVar_0);
	CHECK_EQUAL(1666, myTestAgent->testVar_1);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, action_ut_3)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_3", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2.4f, myTestAgent->testVar_2);
	CHECK_EQUAL(4.0f, myTestAgent->testVar_3);
	finlTestEnvNode(myTestAgent);
}

//< Wait For Signal Tests
LOAD_TEST(btunittest, action_ut_waitforsignal_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_waitforsignal_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(-1, myTestAgent->testVar_1);
	CHECK_EQUAL(-1.0f, myTestAgent->testVar_2);
	myTestAgent->resetProperties();
	myTestAgent->testVar_0 = 0;
	myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_1);
	CHECK_EQUAL(2.3f, myTestAgent->testVar_2);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, action_ut_waitforsignal_1)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_waitforsignal_1", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(-1, myTestAgent->testVar_1);
	CHECK_EQUAL(-1.0f, myTestAgent->testVar_2);
	myTestAgent->resetProperties();
	myTestAgent->testVar_2 = 0.0f;
	myTestAgent->btexec();
	CHECK_EQUAL(1, myTestAgent->testVar_1);
	CHECK_EQUAL(2.3f, myTestAgent->testVar_2);
	finlTestEnvNode(myTestAgent);
}

LOAD_TEST(btunittest, action_ut_waitforsignal_2)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_ut_waitforsignal_2", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(-1.0f, myTestAgent->testVar_2);
	CHECK_EQUAL(behaviac::BT_RUNNING, status);
	myTestAgent->resetProperties();
	myTestAgent->testVar_2 = 0.0f;
	status = myTestAgent->btexec();
	CHECK_EQUAL(2.3f, myTestAgent->testVar_2);
	CHECK_EQUAL(behaviac::BT_SUCCESS, status);
	finlTestEnvNode(myTestAgent);
}

//< Wait For Frames Tests
LOAD_TEST(btunittest, action_waitframes_ut_0)
{
	behaviac::Profiler::CreateInstance();
	behaviac::Start();
	behaviac::LogManager::GetInstance()->SetEnabled(false);
	behaviac::Config::SetSocketing(false);
	behaviac::Config::SetLogging(false);
	behaviac::Agent::Register<AgentNodeTest>();
	AgentNodeTest* myTestAgent = AgentNodeTest::DynamicCast(behaviac::Agent::Create<AgentNodeTest>());
	behaviac::Agent::SetIdMask(1);
	myTestAgent->SetIdFlag(1);
	behaviac::Workspace::SetWorkspaceSettings("../test/btunittest/BehaviacData/exported", format);
	myTestAgent->btload("node_test/action_waitframes_ut_0");
	myTestAgent->btsetcurrent("node_test/action_waitframes_ut_0");
	myTestAgent->resetProperties();

	int loopCount = 0;
	while (loopCount < 5)
	{
		myTestAgent->btexec();
		if (loopCount < 4)
		{
			CHECK_EQUAL(1, myTestAgent->testVar_0);
		}
		else
		{
			CHECK_EQUAL(2, myTestAgent->testVar_0);
		}
		++loopCount;
	}

	behaviac::Workspace::SetDeltaFrames(5);
	myTestAgent->resetProperties();
	myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	behaviac::Workspace::SetDeltaFrames(1);

	BEHAVIAC_DELETE(myTestAgent);
	behaviac::Agent::UnRegister<AgentNodeTest>();
	behaviac::Stop();
	behaviac::Profiler::DestroyInstance();
}

//< Noop Node Test
LOAD_TEST(btunittest, action_noop_ut_0)
{
	AgentNodeTest* myTestAgent = initTestEnvNode("node_test/action_noop_ut_0", format);
	myTestAgent->resetProperties();
	behaviac::EBTStatus status = myTestAgent->btexec();
	CHECK_EQUAL(2, myTestAgent->testVar_0);
	CHECK_EQUAL(behaviac::BT_SUCCESS, status);
	finlTestEnvNode(myTestAgent);
}