// ---------------------------------------------------------------------
// This file is auto-generated, so please don't modify it by yourself!
// Export file: ../Scripts/generated_behaviors.cs
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace behaviac
{
	class AgentExtra_Generated
	{
		private static Dictionary<string, FieldInfo> _fields = new Dictionary<string, FieldInfo>();
		private static Dictionary<string, PropertyInfo> _properties = new Dictionary<string, PropertyInfo>();
		private static Dictionary<string, MethodInfo> _methods = new Dictionary<string, MethodInfo>();

		public static object GetProperty(behaviac.Agent agent, string property)
		{
			Type type = agent.GetType();
			string propertyName = type.FullName + property;
			if (_fields.ContainsKey(propertyName))
			{
				return _fields[propertyName].GetValue(agent);
			}

			if (_properties.ContainsKey(propertyName))
			{
				return _properties[propertyName].GetValue(agent, null);
			}

			while (type != typeof(object))
			{
				FieldInfo field = type.GetField(property, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (field != null)
				{
					_fields[propertyName] = field;
					return field.GetValue(agent);
				}

				PropertyInfo prop = type.GetProperty(property, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (prop != null)
				{
					_properties[propertyName] = prop;
					return prop.GetValue(agent, null);
				}

				type = type.BaseType;
			}
			Debug.Check(false, "No property can be found!");
			return null;
		}

		public static void SetProperty(behaviac.Agent agent, string property, object value)
		{
			Type type = agent.GetType();
			string propertyName = type.FullName + property;
			if (_fields.ContainsKey(propertyName))
			{
				_fields[propertyName].SetValue(agent, value);
				return;
			}

			if (_properties.ContainsKey(propertyName))
			{
				_properties[propertyName].SetValue(agent, value, null);
				return;
			}

			while (type != typeof(object))
			{
				FieldInfo field = type.GetField(property, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (field != null)
				{
					_fields[propertyName] = field;
					field.SetValue(agent, value);
					return;
				}

				PropertyInfo prop = type.GetProperty(property, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (prop != null)
				{
					_properties[propertyName] = prop;
					prop.SetValue(agent, value, null);
					return;
				}

				type = type.BaseType;
			}
			Debug.Check(false, "No property can be found!");
		}

		public static object ExecuteMethod(behaviac.Agent agent, string method, object[] args)
		{
			Type type = agent.GetType();
			string methodName = type.FullName + method;
			if (_methods.ContainsKey(methodName))
			{
				return _methods[methodName].Invoke(agent, args);;
			}

			while (type != typeof(object))
			{
				MethodInfo m = type.GetMethod(method, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (m != null)
				{
					_methods[methodName] = m;
					return m.Invoke(agent, args);
				}

				type = type.BaseType;
			}
			Debug.Check(false, "No method can be found!");
			return null;
		}
	}

	// Source file: Level_DeathMatch_0

	class DecoratorLoop_bt_Level_DeathMatch_0_node1 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Level_DeathMatch_0_node1()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Level_DeathMatch_0_node16 : behaviac.Parallel
	{
		public Parallel_bt_Level_DeathMatch_0_node16()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class Condition_bt_Level_DeathMatch_0_node11 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_0_node11()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_WaveCount") == 2998764825u);
			int opl = (int)pAgent.GetVariable(2998764825u);
			int opr = 0;
			bool op = opl > opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node14 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node14()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 3000;
		}
	}

	class Assignment_bt_Level_DeathMatch_0_node15 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = 2;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SpawnCountPerWave") == 193379536u);
			pAgent.SetVariable("parT_SpawnCountPerWave", opr, 193379536u);
			return result;
		}
	}

	class DecoratorNot_bt_Level_DeathMatch_0_node12 : behaviac.DecoratorNot
	{
		public DecoratorNot_bt_Level_DeathMatch_0_node12()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class DecoratorLoopUntil_bt_Level_DeathMatch_0_node6 : behaviac.DecoratorLoopUntil
	{
		public DecoratorLoopUntil_bt_Level_DeathMatch_0_node6()
		{
			m_bDecorateWhenChildEnds = true;
			m_until = false;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Condition_bt_Level_DeathMatch_0_node3 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_0_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SpawnCountPerWave") == 193379536u);
			int opl = (int)pAgent.GetVariable(193379536u);
			int opr = 0;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Level_DeathMatch_0_node10 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_0_node10()
		{
			method_p0 = eGameForce.BLUE_FORCE;
			method_p1 = 8f;
			method_p2 = "Tank_Wander_RandomFire";
			method_p3 = 2000;
			method_p4 = 1000;
			method_p5 = 1;
			method_p6 = 1;
			method_p7 = 180f;
			method_p8 = 360f;
			method_p10.a = 1f;
			method_p10.b = 1f;
			method_p10.g = 0f;
			method_p10.r = 0f;
			method_p11 = -1;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SpawnCountPerWave") == 193379536u);
			int method_p9 = (int)pAgent.GetVariable(193379536u);
			((GameLevelCommon)pAgent).spawnGameActor(method_p0, method_p1, method_p2, method_p3, method_p4, method_p5, method_p6, method_p7, method_p8, method_p9, method_p10, method_p11);
			return EBTStatus.BT_SUCCESS;
		}
		eGameForce method_p0;
		float method_p1;
		string method_p2;
		int method_p3;
		int method_p4;
		int method_p5;
		int method_p6;
		float method_p7;
		float method_p8;
		UnityEngine.Color method_p10;
		int method_p11;
	}

	class Compute_bt_Level_DeathMatch_0_node8 : behaviac.Compute
	{
		public Compute_bt_Level_DeathMatch_0_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SpawnCountPerWave") == 193379536u);
			int opr1 = (int)pAgent.GetVariable(193379536u);
			int opr2 = 1;
			int opr = (int)(opr1 - opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SpawnCountPerWave") == 193379536u);
			pAgent.SetVariable("parT_SpawnCountPerWave", opr, 193379536u);
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node9 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node9()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node7 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node7()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Compute_bt_Level_DeathMatch_0_node2 : behaviac.Compute
	{
		public Compute_bt_Level_DeathMatch_0_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_WaveCount") == 2998764825u);
			int opr1 = (int)pAgent.GetVariable(2998764825u);
			int opr2 = 1;
			int opr = (int)(opr1 - opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_WaveCount") == 2998764825u);
			pAgent.SetVariable("parT_WaveCount", opr, 2998764825u);
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node4 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node4()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Condition_bt_Level_DeathMatch_0_node28 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_0_node28()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_GameStopped") == 1723664313u);
			bool opl = (bool)pAgent.GetVariable(1723664313u);
			bool opr = false;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Level_DeathMatch_0_node25 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node25()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).getEnemyCount();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyCount") == 2685115492u);
			pAgent.SetVariable("parT_EnemyCount", opr, 2685115492u);
			return result;
		}
	}

	class Condition_bt_Level_DeathMatch_0_node26 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_0_node26()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyCount") == 2685115492u);
			int opl = (int)pAgent.GetVariable(2685115492u);
			int opr = 0;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node30 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node30()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 3000;
		}
	}

	class Action_bt_Level_DeathMatch_0_node27 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_0_node27()
		{
			method_p0 = true;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).stopGame(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
		bool method_p0;
	}

	class Assignment_bt_Level_DeathMatch_0_node29 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node29()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			bool opr = true;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_GameStopped") == 1723664313u);
			pAgent.SetVariable("parT_GameStopped", opr, 1723664313u);
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node18 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node18()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Assignment_bt_Level_DeathMatch_0_node19 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node19()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = 2;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			pAgent.SetVariable("parT_AwardType", opr, 1346337780u);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_0_node22 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node22()
		{
			opr_p0 = 5;
			opr_p1 = 20;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardX") == 1534020959u);
			pAgent.SetVariable("parT_AwardX", opr, 1534020959u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Assignment_bt_Level_DeathMatch_0_node23 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_0_node23()
		{
			opr_p0 = 5;
			opr_p1 = 20;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardY") == 1114930206u);
			pAgent.SetVariable("parT_AwardY", opr, 1114930206u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Action_bt_Level_DeathMatch_0_node20 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_0_node20()
		{
			method_p3 = 20f;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			int method_p0 = (int)pAgent.GetVariable(1346337780u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardX") == 1534020959u);
			int method_p1 = (int)pAgent.GetVariable(1534020959u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardY") == 1114930206u);
			int method_p2 = (int)pAgent.GetVariable(1114930206u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).spawnAward(method_p0, method_p1, method_p2, method_p3);
			return result;
		}
		float method_p3;
	}

	class Wait_bt_Level_DeathMatch_0_node21 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node21()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Predicate_bt_Level_DeathMatch_0_attach32 : behaviac.Predicate
	{
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_FAILURE;
			this.m_bAnd = false;
			bool opl = ((GameLevelCommon)pAgent).isPlayerAlive;
			bool opr = false;
			bool op = opl == opr;
			if (op)
				result = EBTStatus.BT_SUCCESS;
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node33 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node33()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Wait_bt_Level_DeathMatch_0_node35 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_0_node35()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Action_bt_Level_DeathMatch_0_node37 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_0_node37()
		{
			method_p0 = eGameForce.RED_FORCE;
			method_p1 = 8f;
			method_p2 = "Tank_Nav";
			method_p3 = 1500;
			method_p4 = 500;
			method_p5 = 1;
			method_p6 = 3;
			method_p7 = 180f;
			method_p8 = 180f;
			method_p9 = 0;
			method_p10.a = 1f;
			method_p10.b = 0f;
			method_p10.g = 0f;
			method_p10.r = 1f;
			method_p11 = -1;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).spawnGameActor(method_p0, method_p1, method_p2, method_p3, method_p4, method_p5, method_p6, method_p7, method_p8, method_p9, method_p10, method_p11);
			return EBTStatus.BT_SUCCESS;
		}
		eGameForce method_p0;
		float method_p1;
		string method_p2;
		int method_p3;
		int method_p4;
		int method_p5;
		int method_p6;
		float method_p7;
		float method_p8;
		int method_p9;
		UnityEngine.Color method_p10;
		int method_p11;
	}

	public static class bt_Level_DeathMatch_0
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Level_DeathMatch_0");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("GameLevelCommon");
#endif
			// pars
			bt.AddPar("int", "parT_SpawnCountPerWave", "0", "");
			bt.AddPar("int", "parT_WaveCount", "10", "");
			bt.AddPar("int", "parT_AwardType", "0", "");
			bt.AddPar("int", "parT_AwardX", "0", "");
			bt.AddPar("int", "parT_AwardY", "0", "");
			bt.AddPar("int", "parT_EnemyCount", "0", "");
			bt.AddPar("bool", "parT_GameStopped", "false", "");
			// children
			{
				DecoratorLoop_bt_Level_DeathMatch_0_node1 node1 = new DecoratorLoop_bt_Level_DeathMatch_0_node1();
				node1.SetClassNameString("DecoratorLoop");
				node1.SetId(1);
#if !BEHAVIAC_RELEASE
				node1.SetAgentType("GameLevelCommon");
#endif
				bt.AddChild(node1);
				{
					Parallel_bt_Level_DeathMatch_0_node16 node16 = new Parallel_bt_Level_DeathMatch_0_node16();
					node16.SetClassNameString("Parallel");
					node16.SetId(16);
#if !BEHAVIAC_RELEASE
					node16.SetAgentType("GameLevelCommon");
#endif
					node1.AddChild(node16);
					{
						IfElse node17 = new IfElse();
						node17.SetClassNameString("IfElse");
						node17.SetId(17);
#if !BEHAVIAC_RELEASE
						node17.SetAgentType("GameLevelCommon");
#endif
						node16.AddChild(node17);
						{
							Condition_bt_Level_DeathMatch_0_node11 node11 = new Condition_bt_Level_DeathMatch_0_node11();
							node11.SetClassNameString("Condition");
							node11.SetId(11);
#if !BEHAVIAC_RELEASE
							node11.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node11);
							node17.SetHasEvents(node17.HasEvents() | node11.HasEvents());
						}
						{
							Sequence node5 = new Sequence();
							node5.SetClassNameString("Sequence");
							node5.SetId(5);
#if !BEHAVIAC_RELEASE
							node5.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node5);
							{
								Wait_bt_Level_DeathMatch_0_node14 node14 = new Wait_bt_Level_DeathMatch_0_node14();
								node14.SetClassNameString("Wait");
								node14.SetId(14);
#if !BEHAVIAC_RELEASE
								node14.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node14);
								node5.SetHasEvents(node5.HasEvents() | node14.HasEvents());
							}
							{
								Assignment_bt_Level_DeathMatch_0_node15 node15 = new Assignment_bt_Level_DeathMatch_0_node15();
								node15.SetClassNameString("Assignment");
								node15.SetId(15);
#if !BEHAVIAC_RELEASE
								node15.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node15);
								node5.SetHasEvents(node5.HasEvents() | node15.HasEvents());
							}
							{
								DecoratorNot_bt_Level_DeathMatch_0_node12 node12 = new DecoratorNot_bt_Level_DeathMatch_0_node12();
								node12.SetClassNameString("DecoratorNot");
								node12.SetId(12);
#if !BEHAVIAC_RELEASE
								node12.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node12);
								{
									DecoratorLoopUntil_bt_Level_DeathMatch_0_node6 node6 = new DecoratorLoopUntil_bt_Level_DeathMatch_0_node6();
									node6.SetClassNameString("DecoratorLoopUntil");
									node6.SetId(6);
#if !BEHAVIAC_RELEASE
									node6.SetAgentType("GameLevelCommon");
#endif
									node12.AddChild(node6);
									{
										Sequence node0 = new Sequence();
										node0.SetClassNameString("Sequence");
										node0.SetId(0);
#if !BEHAVIAC_RELEASE
										node0.SetAgentType("GameLevelCommon");
#endif
										node6.AddChild(node0);
										{
											Condition_bt_Level_DeathMatch_0_node3 node3 = new Condition_bt_Level_DeathMatch_0_node3();
											node3.SetClassNameString("Condition");
											node3.SetId(3);
#if !BEHAVIAC_RELEASE
											node3.SetAgentType("GameLevelCommon");
#endif
											node0.AddChild(node3);
											node0.SetHasEvents(node0.HasEvents() | node3.HasEvents());
										}
										{
											Action_bt_Level_DeathMatch_0_node10 node10 = new Action_bt_Level_DeathMatch_0_node10();
											node10.SetClassNameString("Action");
											node10.SetId(10);
#if !BEHAVIAC_RELEASE
											node10.SetAgentType("GameLevelCommon");
#endif
											node0.AddChild(node10);
											node0.SetHasEvents(node0.HasEvents() | node10.HasEvents());
										}
										{
											Compute_bt_Level_DeathMatch_0_node8 node8 = new Compute_bt_Level_DeathMatch_0_node8();
											node8.SetClassNameString("Compute");
											node8.SetId(8);
#if !BEHAVIAC_RELEASE
											node8.SetAgentType("GameLevelCommon");
#endif
											node0.AddChild(node8);
											node0.SetHasEvents(node0.HasEvents() | node8.HasEvents());
										}
										{
											Wait_bt_Level_DeathMatch_0_node9 node9 = new Wait_bt_Level_DeathMatch_0_node9();
											node9.SetClassNameString("Wait");
											node9.SetId(9);
#if !BEHAVIAC_RELEASE
											node9.SetAgentType("GameLevelCommon");
#endif
											node0.AddChild(node9);
											node0.SetHasEvents(node0.HasEvents() | node9.HasEvents());
										}
										node6.SetHasEvents(node6.HasEvents() | node0.HasEvents());
									}
									node12.SetHasEvents(node12.HasEvents() | node6.HasEvents());
								}
								node5.SetHasEvents(node5.HasEvents() | node12.HasEvents());
							}
							{
								Wait_bt_Level_DeathMatch_0_node7 node7 = new Wait_bt_Level_DeathMatch_0_node7();
								node7.SetClassNameString("Wait");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node7);
								node5.SetHasEvents(node5.HasEvents() | node7.HasEvents());
							}
							{
								Compute_bt_Level_DeathMatch_0_node2 node2 = new Compute_bt_Level_DeathMatch_0_node2();
								node2.SetClassNameString("Compute");
								node2.SetId(2);
#if !BEHAVIAC_RELEASE
								node2.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node2);
								node5.SetHasEvents(node5.HasEvents() | node2.HasEvents());
							}
							node17.SetHasEvents(node17.HasEvents() | node5.HasEvents());
						}
						{
							DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node4 node4 = new DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node4();
							node4.SetClassNameString("DecoratorAlwaysSuccess");
							node4.SetId(4);
#if !BEHAVIAC_RELEASE
							node4.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node4);
							{
								Sequence node24 = new Sequence();
								node24.SetClassNameString("Sequence");
								node24.SetId(24);
#if !BEHAVIAC_RELEASE
								node24.SetAgentType("GameLevelCommon");
#endif
								node4.AddChild(node24);
								{
									Condition_bt_Level_DeathMatch_0_node28 node28 = new Condition_bt_Level_DeathMatch_0_node28();
									node28.SetClassNameString("Condition");
									node28.SetId(28);
#if !BEHAVIAC_RELEASE
									node28.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node28);
									node24.SetHasEvents(node24.HasEvents() | node28.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_0_node25 node25 = new Assignment_bt_Level_DeathMatch_0_node25();
									node25.SetClassNameString("Assignment");
									node25.SetId(25);
#if !BEHAVIAC_RELEASE
									node25.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node25);
									node24.SetHasEvents(node24.HasEvents() | node25.HasEvents());
								}
								{
									Condition_bt_Level_DeathMatch_0_node26 node26 = new Condition_bt_Level_DeathMatch_0_node26();
									node26.SetClassNameString("Condition");
									node26.SetId(26);
#if !BEHAVIAC_RELEASE
									node26.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node26);
									node24.SetHasEvents(node24.HasEvents() | node26.HasEvents());
								}
								{
									Wait_bt_Level_DeathMatch_0_node30 node30 = new Wait_bt_Level_DeathMatch_0_node30();
									node30.SetClassNameString("Wait");
									node30.SetId(30);
#if !BEHAVIAC_RELEASE
									node30.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node30);
									node24.SetHasEvents(node24.HasEvents() | node30.HasEvents());
								}
								{
									Action_bt_Level_DeathMatch_0_node27 node27 = new Action_bt_Level_DeathMatch_0_node27();
									node27.SetClassNameString("Action");
									node27.SetId(27);
#if !BEHAVIAC_RELEASE
									node27.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node27);
									node24.SetHasEvents(node24.HasEvents() | node27.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_0_node29 node29 = new Assignment_bt_Level_DeathMatch_0_node29();
									node29.SetClassNameString("Assignment");
									node29.SetId(29);
#if !BEHAVIAC_RELEASE
									node29.SetAgentType("GameLevelCommon");
#endif
									node24.AddChild(node29);
									node24.SetHasEvents(node24.HasEvents() | node29.HasEvents());
								}
								node4.SetHasEvents(node4.HasEvents() | node24.HasEvents());
							}
							node17.SetHasEvents(node17.HasEvents() | node4.HasEvents());
						}
						node16.SetHasEvents(node16.HasEvents() | node17.HasEvents());
					}
					{
						Sequence node13 = new Sequence();
						node13.SetClassNameString("Sequence");
						node13.SetId(13);
#if !BEHAVIAC_RELEASE
						node13.SetAgentType("GameLevelCommon");
#endif
						node16.AddChild(node13);
						{
							Wait_bt_Level_DeathMatch_0_node18 node18 = new Wait_bt_Level_DeathMatch_0_node18();
							node18.SetClassNameString("Wait");
							node18.SetId(18);
#if !BEHAVIAC_RELEASE
							node18.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node18);
							node13.SetHasEvents(node13.HasEvents() | node18.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_0_node19 node19 = new Assignment_bt_Level_DeathMatch_0_node19();
							node19.SetClassNameString("Assignment");
							node19.SetId(19);
#if !BEHAVIAC_RELEASE
							node19.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node19);
							node13.SetHasEvents(node13.HasEvents() | node19.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_0_node22 node22 = new Assignment_bt_Level_DeathMatch_0_node22();
							node22.SetClassNameString("Assignment");
							node22.SetId(22);
#if !BEHAVIAC_RELEASE
							node22.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node22);
							node13.SetHasEvents(node13.HasEvents() | node22.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_0_node23 node23 = new Assignment_bt_Level_DeathMatch_0_node23();
							node23.SetClassNameString("Assignment");
							node23.SetId(23);
#if !BEHAVIAC_RELEASE
							node23.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node23);
							node13.SetHasEvents(node13.HasEvents() | node23.HasEvents());
						}
						{
							Action_bt_Level_DeathMatch_0_node20 node20 = new Action_bt_Level_DeathMatch_0_node20();
							node20.SetClassNameString("Action");
							node20.SetId(20);
#if !BEHAVIAC_RELEASE
							node20.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node20);
							node13.SetHasEvents(node13.HasEvents() | node20.HasEvents());
						}
						{
							Wait_bt_Level_DeathMatch_0_node21 node21 = new Wait_bt_Level_DeathMatch_0_node21();
							node21.SetClassNameString("Wait");
							node21.SetId(21);
#if !BEHAVIAC_RELEASE
							node21.SetAgentType("GameLevelCommon");
#endif
							node13.AddChild(node21);
							node13.SetHasEvents(node13.HasEvents() | node21.HasEvents());
						}
						node16.SetHasEvents(node16.HasEvents() | node13.HasEvents());
					}
					{
						WaitforSignal node31 = new WaitforSignal();
						node31.SetClassNameString("WaitforSignal");
						node31.SetId(31);
#if !BEHAVIAC_RELEASE
						node31.SetAgentType("GameLevelCommon");
#endif
						// attachments
						{
							Predicate_bt_Level_DeathMatch_0_attach32 attach32 = new Predicate_bt_Level_DeathMatch_0_attach32();
							attach32.SetClassNameString("Predicate");
							attach32.SetId(32);
#if !BEHAVIAC_RELEASE
							attach32.SetAgentType("GameLevelCommon");
#endif
							node31.Attach(attach32);
						}
						node16.AddChild(node31);
						{
							DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node33 node33 = new DecoratorAlwaysSuccess_bt_Level_DeathMatch_0_node33();
							node33.SetClassNameString("DecoratorAlwaysSuccess");
							node33.SetId(33);
#if !BEHAVIAC_RELEASE
							node33.SetAgentType("GameLevelCommon");
#endif
							node31.AddChild(node33);
							{
								Sequence node34 = new Sequence();
								node34.SetClassNameString("Sequence");
								node34.SetId(34);
#if !BEHAVIAC_RELEASE
								node34.SetAgentType("GameLevelCommon");
#endif
								node33.AddChild(node34);
								{
									Wait_bt_Level_DeathMatch_0_node35 node35 = new Wait_bt_Level_DeathMatch_0_node35();
									node35.SetClassNameString("Wait");
									node35.SetId(35);
#if !BEHAVIAC_RELEASE
									node35.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node35);
									node34.SetHasEvents(node34.HasEvents() | node35.HasEvents());
								}
								{
									Action_bt_Level_DeathMatch_0_node37 node37 = new Action_bt_Level_DeathMatch_0_node37();
									node37.SetClassNameString("Action");
									node37.SetId(37);
#if !BEHAVIAC_RELEASE
									node37.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node37);
									node34.SetHasEvents(node34.HasEvents() | node37.HasEvents());
								}
								node33.SetHasEvents(node33.HasEvents() | node34.HasEvents());
							}
							node31.SetHasEvents(node31.HasEvents() | node33.HasEvents());
						}
						node16.SetHasEvents(node16.HasEvents() | node31.HasEvents());
					}
					node1.SetHasEvents(node1.HasEvents() | node16.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node1.HasEvents());
			}
			return true;
		}
	}

	// Source file: Level_DeathMatch_1

	class DecoratorLoopUntil_bt_Level_DeathMatch_1_node10 : behaviac.DecoratorLoopUntil
	{
		public DecoratorLoopUntil_bt_Level_DeathMatch_1_node10()
		{
			m_bDecorateWhenChildEnds = true;
			m_until = false;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Condition_bt_Level_DeathMatch_1_node4 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_1_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opl = (int)pAgent.GetVariable(2453283515u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorCount") == 515203555u);
			int opr = (int)pAgent.GetVariable(515203555u);
			bool op = opl < opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node12 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIDs") == 4274851919u);
			List<int> opr_p0 = (List<int>)pAgent.GetVariable(4274851919u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			int opr = (int)GameLevelCommon.getIntArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			pAgent.SetVariable("parT_ID", opr, 1986102671u);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node13 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node13()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_LifeCounts") == 1547128421u);
			List<int> opr_p0 = (List<int>)pAgent.GetVariable(1547128421u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			int opr = (int)GameLevelCommon.getIntArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			pAgent.SetVariable("parT_Life", opr, 2469591944u);
			return result;
		}
	}

	class Action_bt_Level_DeathMatch_1_node15 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int method_p0 = (int)pAgent.GetVariable(1986102671u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			int method_p1 = (int)pAgent.GetVariable(2469591944u);
			((GameLevelCommon)pAgent).setActorLifeCount(method_p0, method_p1);
			return EBTStatus.BT_SUCCESS;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node51 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node51()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Forces") == 3373971921u);
			List<eGameForce> opr_p0 = (List<eGameForce>)pAgent.GetVariable(3373971921u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			eGameForce opr = (eGameForce)GameLevelCommon.getGameForceArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorForce") == 2293135530u);
			pAgent.SetVariable("parT_ActorForce", opr, 2293135530u);
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node53 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node53()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Condition_bt_Level_DeathMatch_1_node52 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_1_node52()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorForce") == 2293135530u);
			eGameForce opl = (eGameForce)pAgent.GetVariable(2293135530u);
			eGameForce opr = eGameForce.RED_FORCE;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node55 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node55()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int opr = (int)pAgent.GetVariable(1986102671u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RedForceID") == 3502538092u);
			pAgent.SetVariable("parT_RedForceID", opr, 3502538092u);
			return result;
		}
	}

	class Action_bt_Level_DeathMatch_1_node26 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node26()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RedForceID") == 3502538092u);
			int method_p0 = (int)pAgent.GetVariable(3502538092u);
			((GameLevelCommon)pAgent).setMainCharID(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
	}

	class Compute_bt_Level_DeathMatch_1_node16 : behaviac.Compute
	{
		public Compute_bt_Level_DeathMatch_1_node16()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr1 = (int)pAgent.GetVariable(2453283515u);
			int opr2 = 1;
			int opr = (int)(opr1 + opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			pAgent.SetVariable("parT_PlayerIndex", opr, 2453283515u);
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_1_node47 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node47()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class DecoratorLoop_bt_Level_DeathMatch_1_node50 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Level_DeathMatch_1_node50()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Level_DeathMatch_1_node14 : behaviac.Parallel
	{
		public Parallel_bt_Level_DeathMatch_1_node14()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node18 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node18()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Condition_bt_Level_DeathMatch_1_node9 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_1_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opl = (int)pAgent.GetVariable(2453283515u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorCount") == 515203555u);
			int opr = (int)pAgent.GetVariable(515203555u);
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node19 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node19()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = 0;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			pAgent.SetVariable("parT_PlayerIndex", opr, 2453283515u);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node20 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node20()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIDs") == 4274851919u);
			List<int> opr_p0 = (List<int>)pAgent.GetVariable(4274851919u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			int opr = (int)GameLevelCommon.getIntArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			pAgent.SetVariable("parT_ID", opr, 1986102671u);
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node21 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node21()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class DecoratorNot_bt_Level_DeathMatch_1_node36 : behaviac.DecoratorNot
	{
		public DecoratorNot_bt_Level_DeathMatch_1_node36()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Action_bt_Level_DeathMatch_1_node7 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int method_p0 = (int)pAgent.GetVariable(1986102671u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).isActorAlive(method_p0);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node39 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node39()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int opr_p0 = (int)pAgent.GetVariable(1986102671u);
			int opr = (int)((GameLevelCommon)pAgent).getActorLifeCount(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			pAgent.SetVariable("parT_Life", opr, 2469591944u);
			return result;
		}
	}

	class Condition_bt_Level_DeathMatch_1_node37 : behaviac.Condition
	{
		public Condition_bt_Level_DeathMatch_1_node37()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			int opl = (int)pAgent.GetVariable(2469591944u);
			int opr = 0;
			bool op = opl > opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node40 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node40()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Forces") == 3373971921u);
			List<eGameForce> opr_p0 = (List<eGameForce>)pAgent.GetVariable(3373971921u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			eGameForce opr = (eGameForce)GameLevelCommon.getGameForceArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorForce") == 2293135530u);
			pAgent.SetVariable("parT_ActorForce", opr, 2293135530u);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node48 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node48()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ForceColors") == 2503413296u);
			List<UnityEngine.Color> opr_p0 = (List<UnityEngine.Color>)pAgent.GetVariable(2503413296u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			UnityEngine.Color opr = (UnityEngine.Color)GameLevelCommon.getColorArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorColor") == 1681699911u);
			pAgent.SetVariable("parT_ActorColor", opr, 1681699911u);
			return result;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node25 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node25()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_BehaviorTree") == 1995133426u);
			List<string> opr_p0 = (List<string>)pAgent.GetVariable(1995133426u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr_p1 = (int)pAgent.GetVariable(2453283515u);
			string opr = (string)GameLevelCommon.getStringArrayElement(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Tree") == 1190938892u);
			pAgent.SetVariable("parT_Tree", opr, 1190938892u);
			return result;
		}
	}

	class Action_bt_Level_DeathMatch_1_node49 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node49()
		{
			method_p1 = 10f;
			method_p3 = 1500;
			method_p4 = 500;
			method_p5 = 1;
			method_p6 = 3;
			method_p7 = 180f;
			method_p8 = 360f;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorForce") == 2293135530u);
			eGameForce method_p0 = (eGameForce)pAgent.GetVariable(2293135530u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Tree") == 1190938892u);
			string method_p2 = (string)pAgent.GetVariable(1190938892u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int method_p9 = (int)pAgent.GetVariable(2453283515u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ActorColor") == 1681699911u);
			UnityEngine.Color method_p10 = (UnityEngine.Color)pAgent.GetVariable(1681699911u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int method_p11 = (int)pAgent.GetVariable(1986102671u);
			((GameLevelCommon)pAgent).spawnGameActor(method_p0, method_p1, method_p2, method_p3, method_p4, method_p5, method_p6, method_p7, method_p8, method_p9, method_p10, method_p11);
			return EBTStatus.BT_SUCCESS;
		}
		float method_p1;
		int method_p3;
		int method_p4;
		int method_p5;
		int method_p6;
		float method_p7;
		float method_p8;
	}

	class Compute_bt_Level_DeathMatch_1_node41 : behaviac.Compute
	{
		public Compute_bt_Level_DeathMatch_1_node41()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			int opr1 = (int)pAgent.GetVariable(2469591944u);
			int opr2 = 1;
			int opr = (int)(opr1 - opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			pAgent.SetVariable("parT_Life", opr, 2469591944u);
			return result;
		}
	}

	class Action_bt_Level_DeathMatch_1_node35 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node35()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_ID") == 1986102671u);
			int method_p0 = (int)pAgent.GetVariable(1986102671u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_Life") == 2469591944u);
			int method_p1 = (int)pAgent.GetVariable(2469591944u);
			((GameLevelCommon)pAgent).setActorLifeCount(method_p0, method_p1);
			return EBTStatus.BT_SUCCESS;
		}
	}

	class Compute_bt_Level_DeathMatch_1_node0 : behaviac.Compute
	{
		public Compute_bt_Level_DeathMatch_1_node0()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			int opr1 = (int)pAgent.GetVariable(2453283515u);
			int opr2 = 1;
			int opr = (int)(opr1 + opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerIndex") == 2453283515u);
			pAgent.SetVariable("parT_PlayerIndex", opr, 2453283515u);
			return result;
		}
	}

	class Action_bt_Level_DeathMatch_1_node5 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).isAllEnemyDeadForever();
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_1_node1 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node1()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Action_bt_Level_DeathMatch_1_node30 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node30()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).showCredit();
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_1_node32 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node32()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 6000;
		}
	}

	class Action_bt_Level_DeathMatch_1_node23 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node23()
		{
			method_p0 = true;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).stopGame(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
		bool method_p0;
	}

	class Action_bt_Level_DeathMatch_1_node22 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node22()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).isPlayerDeadForever();
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_1_node28 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node28()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Action_bt_Level_DeathMatch_1_node33 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node33()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).showCredit();
			return result;
		}
	}

	class Wait_bt_Level_DeathMatch_1_node56 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node56()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 6000;
		}
	}

	class Action_bt_Level_DeathMatch_1_node27 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node27()
		{
			method_p0 = false;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).stopGame(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
		bool method_p0;
	}

	class Wait_bt_Level_DeathMatch_1_node31 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node31()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 8000;
		}
	}

	class Assignment_bt_Level_DeathMatch_1_node42 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node42()
		{
			opr_p0 = 0;
			opr_p1 = 4;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			pAgent.SetVariable("parT_AwardType", opr, 1346337780u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Assignment_bt_Level_DeathMatch_1_node43 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node43()
		{
			opr_p0 = 5;
			opr_p1 = 20;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardX") == 1534020959u);
			pAgent.SetVariable("parT_AwardX", opr, 1534020959u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Assignment_bt_Level_DeathMatch_1_node44 : behaviac.Assignment
	{
		public Assignment_bt_Level_DeathMatch_1_node44()
		{
			opr_p0 = 5;
			opr_p1 = 20;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardY") == 1114930206u);
			pAgent.SetVariable("parT_AwardY", opr, 1114930206u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Action_bt_Level_DeathMatch_1_node45 : behaviac.Action
	{
		public Action_bt_Level_DeathMatch_1_node45()
		{
			method_p3 = 20f;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			int method_p0 = (int)pAgent.GetVariable(1346337780u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardX") == 1534020959u);
			int method_p1 = (int)pAgent.GetVariable(1534020959u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardY") == 1114930206u);
			int method_p2 = (int)pAgent.GetVariable(1114930206u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).spawnAward(method_p0, method_p1, method_p2, method_p3);
			return result;
		}
		float method_p3;
	}

	class Wait_bt_Level_DeathMatch_1_node46 : behaviac.Wait
	{
		public Wait_bt_Level_DeathMatch_1_node46()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	public static class bt_Level_DeathMatch_1
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Level_DeathMatch_1");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("GameLevelCommon");
#endif
			// pars
			bt.AddPar("vector<int>", "parT_PlayerIDs", "4:10|11|12|13", "");
			bt.AddPar("int", "parT_ID", "0", "");
			bt.AddPar("int", "parT_Life", "0", "");
			bt.AddPar("int", "parT_PlayerIndex", "0", "");
			bt.AddPar("vector<int>", "parT_LifeCounts", "4:1|1|1|1", "");
			bt.AddPar("int", "parT_EnemyCount", "0", "");
			bt.AddPar("int", "parT_AwardX", "0", "");
			bt.AddPar("int", "parT_AwardY", "0", "");
			bt.AddPar("int", "parT_AwardType", "0", "");
			bt.AddPar("vector<UnityEngine.Color>", "parT_ForceColors", "4:{a=1;b=0;g=0;r=1;}|{a=1;b=1;g=0;r=0;}|{a=1;b=0;g=1;r=1;}|{a=1;b=0;g=1;r=0;}", "");
			bt.AddPar("vector<eGameForce>", "parT_Forces", "4:BLUE_FORCE|BLUE_FORCE|BLUE_FORCE|RED_FORCE", "");
			bt.AddPar("eGameForce", "parT_ActorForce", "BLUE_FORCE", "");
			bt.AddPar("UnityEngine.Color", "parT_ActorColor", "{a=0;b=0;g=0;r=0;}", "");
			bt.AddPar("int", "parT_RedForceID", "0", "");
			bt.AddPar("int", "parT_ActorCount", "4", "");
			bt.AddPar("vector<string>", "parT_BehaviorTree", "4:\"Tank_SafeWander_RandomFire\"|\"Tank_SafeWander_RandomFire\"|\"Tank_SafeWander_RandomFire\"|\"Tank_Agressive\"", "");
			bt.AddPar("string", "parT_Tree", "", "");
			// children
			{
				Selector node3 = new Selector();
				node3.SetClassNameString("Selector");
				node3.SetId(3);
#if !BEHAVIAC_RELEASE
				node3.SetAgentType("GameLevelCommon");
#endif
				bt.AddChild(node3);
				{
					DecoratorLoopUntil_bt_Level_DeathMatch_1_node10 node10 = new DecoratorLoopUntil_bt_Level_DeathMatch_1_node10();
					node10.SetClassNameString("DecoratorLoopUntil");
					node10.SetId(10);
#if !BEHAVIAC_RELEASE
					node10.SetAgentType("GameLevelCommon");
#endif
					node3.AddChild(node10);
					{
						Sequence node17 = new Sequence();
						node17.SetClassNameString("Sequence");
						node17.SetId(17);
#if !BEHAVIAC_RELEASE
						node17.SetAgentType("GameLevelCommon");
#endif
						node10.AddChild(node17);
						{
							Condition_bt_Level_DeathMatch_1_node4 node4 = new Condition_bt_Level_DeathMatch_1_node4();
							node4.SetClassNameString("Condition");
							node4.SetId(4);
#if !BEHAVIAC_RELEASE
							node4.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node4);
							node17.SetHasEvents(node17.HasEvents() | node4.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_1_node12 node12 = new Assignment_bt_Level_DeathMatch_1_node12();
							node12.SetClassNameString("Assignment");
							node12.SetId(12);
#if !BEHAVIAC_RELEASE
							node12.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node12);
							node17.SetHasEvents(node17.HasEvents() | node12.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_1_node13 node13 = new Assignment_bt_Level_DeathMatch_1_node13();
							node13.SetClassNameString("Assignment");
							node13.SetId(13);
#if !BEHAVIAC_RELEASE
							node13.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node13);
							node17.SetHasEvents(node17.HasEvents() | node13.HasEvents());
						}
						{
							Action_bt_Level_DeathMatch_1_node15 node15 = new Action_bt_Level_DeathMatch_1_node15();
							node15.SetClassNameString("Action");
							node15.SetId(15);
#if !BEHAVIAC_RELEASE
							node15.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node15);
							node17.SetHasEvents(node17.HasEvents() | node15.HasEvents());
						}
						{
							Assignment_bt_Level_DeathMatch_1_node51 node51 = new Assignment_bt_Level_DeathMatch_1_node51();
							node51.SetClassNameString("Assignment");
							node51.SetId(51);
#if !BEHAVIAC_RELEASE
							node51.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node51);
							node17.SetHasEvents(node17.HasEvents() | node51.HasEvents());
						}
						{
							DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node53 node53 = new DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node53();
							node53.SetClassNameString("DecoratorAlwaysSuccess");
							node53.SetId(53);
#if !BEHAVIAC_RELEASE
							node53.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node53);
							{
								Sequence node54 = new Sequence();
								node54.SetClassNameString("Sequence");
								node54.SetId(54);
#if !BEHAVIAC_RELEASE
								node54.SetAgentType("GameLevelCommon");
#endif
								node53.AddChild(node54);
								{
									Condition_bt_Level_DeathMatch_1_node52 node52 = new Condition_bt_Level_DeathMatch_1_node52();
									node52.SetClassNameString("Condition");
									node52.SetId(52);
#if !BEHAVIAC_RELEASE
									node52.SetAgentType("GameLevelCommon");
#endif
									node54.AddChild(node52);
									node54.SetHasEvents(node54.HasEvents() | node52.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_1_node55 node55 = new Assignment_bt_Level_DeathMatch_1_node55();
									node55.SetClassNameString("Assignment");
									node55.SetId(55);
#if !BEHAVIAC_RELEASE
									node55.SetAgentType("GameLevelCommon");
#endif
									node54.AddChild(node55);
									node54.SetHasEvents(node54.HasEvents() | node55.HasEvents());
								}
								{
									Action_bt_Level_DeathMatch_1_node26 node26 = new Action_bt_Level_DeathMatch_1_node26();
									node26.SetClassNameString("Action");
									node26.SetId(26);
#if !BEHAVIAC_RELEASE
									node26.SetAgentType("GameLevelCommon");
#endif
									node54.AddChild(node26);
									node54.SetHasEvents(node54.HasEvents() | node26.HasEvents());
								}
								node53.SetHasEvents(node53.HasEvents() | node54.HasEvents());
							}
							node17.SetHasEvents(node17.HasEvents() | node53.HasEvents());
						}
						{
							Compute_bt_Level_DeathMatch_1_node16 node16 = new Compute_bt_Level_DeathMatch_1_node16();
							node16.SetClassNameString("Compute");
							node16.SetId(16);
#if !BEHAVIAC_RELEASE
							node16.SetAgentType("GameLevelCommon");
#endif
							node17.AddChild(node16);
							node17.SetHasEvents(node17.HasEvents() | node16.HasEvents());
						}
						node10.SetHasEvents(node10.HasEvents() | node17.HasEvents());
					}
					node3.SetHasEvents(node3.HasEvents() | node10.HasEvents());
				}
				{
					Sequence node6 = new Sequence();
					node6.SetClassNameString("Sequence");
					node6.SetId(6);
#if !BEHAVIAC_RELEASE
					node6.SetAgentType("GameLevelCommon");
#endif
					node3.AddChild(node6);
					{
						Wait_bt_Level_DeathMatch_1_node47 node47 = new Wait_bt_Level_DeathMatch_1_node47();
						node47.SetClassNameString("Wait");
						node47.SetId(47);
#if !BEHAVIAC_RELEASE
						node47.SetAgentType("GameLevelCommon");
#endif
						node6.AddChild(node47);
						node6.SetHasEvents(node6.HasEvents() | node47.HasEvents());
					}
					{
						DecoratorLoop_bt_Level_DeathMatch_1_node50 node50 = new DecoratorLoop_bt_Level_DeathMatch_1_node50();
						node50.SetClassNameString("DecoratorLoop");
						node50.SetId(50);
#if !BEHAVIAC_RELEASE
						node50.SetAgentType("GameLevelCommon");
#endif
						node6.AddChild(node50);
						{
							Parallel_bt_Level_DeathMatch_1_node14 node14 = new Parallel_bt_Level_DeathMatch_1_node14();
							node14.SetClassNameString("Parallel");
							node14.SetId(14);
#if !BEHAVIAC_RELEASE
							node14.SetAgentType("GameLevelCommon");
#endif
							node50.AddChild(node14);
							{
								Sequence node11 = new Sequence();
								node11.SetClassNameString("Sequence");
								node11.SetId(11);
#if !BEHAVIAC_RELEASE
								node11.SetAgentType("GameLevelCommon");
#endif
								node14.AddChild(node11);
								{
									DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node18 node18 = new DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node18();
									node18.SetClassNameString("DecoratorAlwaysSuccess");
									node18.SetId(18);
#if !BEHAVIAC_RELEASE
									node18.SetAgentType("GameLevelCommon");
#endif
									node11.AddChild(node18);
									{
										Sequence node8 = new Sequence();
										node8.SetClassNameString("Sequence");
										node8.SetId(8);
#if !BEHAVIAC_RELEASE
										node8.SetAgentType("GameLevelCommon");
#endif
										node18.AddChild(node8);
										{
											Condition_bt_Level_DeathMatch_1_node9 node9 = new Condition_bt_Level_DeathMatch_1_node9();
											node9.SetClassNameString("Condition");
											node9.SetId(9);
#if !BEHAVIAC_RELEASE
											node9.SetAgentType("GameLevelCommon");
#endif
											node8.AddChild(node9);
											node8.SetHasEvents(node8.HasEvents() | node9.HasEvents());
										}
										{
											Assignment_bt_Level_DeathMatch_1_node19 node19 = new Assignment_bt_Level_DeathMatch_1_node19();
											node19.SetClassNameString("Assignment");
											node19.SetId(19);
#if !BEHAVIAC_RELEASE
											node19.SetAgentType("GameLevelCommon");
#endif
											node8.AddChild(node19);
											node8.SetHasEvents(node8.HasEvents() | node19.HasEvents());
										}
										node18.SetHasEvents(node18.HasEvents() | node8.HasEvents());
									}
									node11.SetHasEvents(node11.HasEvents() | node18.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_1_node20 node20 = new Assignment_bt_Level_DeathMatch_1_node20();
									node20.SetClassNameString("Assignment");
									node20.SetId(20);
#if !BEHAVIAC_RELEASE
									node20.SetAgentType("GameLevelCommon");
#endif
									node11.AddChild(node20);
									node11.SetHasEvents(node11.HasEvents() | node20.HasEvents());
								}
								{
									DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node21 node21 = new DecoratorAlwaysSuccess_bt_Level_DeathMatch_1_node21();
									node21.SetClassNameString("DecoratorAlwaysSuccess");
									node21.SetId(21);
#if !BEHAVIAC_RELEASE
									node21.SetAgentType("GameLevelCommon");
#endif
									node11.AddChild(node21);
									{
										Sequence node29 = new Sequence();
										node29.SetClassNameString("Sequence");
										node29.SetId(29);
#if !BEHAVIAC_RELEASE
										node29.SetAgentType("GameLevelCommon");
#endif
										node21.AddChild(node29);
										{
											DecoratorNot_bt_Level_DeathMatch_1_node36 node36 = new DecoratorNot_bt_Level_DeathMatch_1_node36();
											node36.SetClassNameString("DecoratorNot");
											node36.SetId(36);
#if !BEHAVIAC_RELEASE
											node36.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node36);
											{
												Action_bt_Level_DeathMatch_1_node7 node7 = new Action_bt_Level_DeathMatch_1_node7();
												node7.SetClassNameString("Action");
												node7.SetId(7);
#if !BEHAVIAC_RELEASE
												node7.SetAgentType("GameLevelCommon");
#endif
												node36.AddChild(node7);
												node36.SetHasEvents(node36.HasEvents() | node7.HasEvents());
											}
											node29.SetHasEvents(node29.HasEvents() | node36.HasEvents());
										}
										{
											Assignment_bt_Level_DeathMatch_1_node39 node39 = new Assignment_bt_Level_DeathMatch_1_node39();
											node39.SetClassNameString("Assignment");
											node39.SetId(39);
#if !BEHAVIAC_RELEASE
											node39.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node39);
											node29.SetHasEvents(node29.HasEvents() | node39.HasEvents());
										}
										{
											Condition_bt_Level_DeathMatch_1_node37 node37 = new Condition_bt_Level_DeathMatch_1_node37();
											node37.SetClassNameString("Condition");
											node37.SetId(37);
#if !BEHAVIAC_RELEASE
											node37.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node37);
											node29.SetHasEvents(node29.HasEvents() | node37.HasEvents());
										}
										{
											Assignment_bt_Level_DeathMatch_1_node40 node40 = new Assignment_bt_Level_DeathMatch_1_node40();
											node40.SetClassNameString("Assignment");
											node40.SetId(40);
#if !BEHAVIAC_RELEASE
											node40.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node40);
											node29.SetHasEvents(node29.HasEvents() | node40.HasEvents());
										}
										{
											Assignment_bt_Level_DeathMatch_1_node48 node48 = new Assignment_bt_Level_DeathMatch_1_node48();
											node48.SetClassNameString("Assignment");
											node48.SetId(48);
#if !BEHAVIAC_RELEASE
											node48.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node48);
											node29.SetHasEvents(node29.HasEvents() | node48.HasEvents());
										}
										{
											Assignment_bt_Level_DeathMatch_1_node25 node25 = new Assignment_bt_Level_DeathMatch_1_node25();
											node25.SetClassNameString("Assignment");
											node25.SetId(25);
#if !BEHAVIAC_RELEASE
											node25.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node25);
											node29.SetHasEvents(node29.HasEvents() | node25.HasEvents());
										}
										{
											Action_bt_Level_DeathMatch_1_node49 node49 = new Action_bt_Level_DeathMatch_1_node49();
											node49.SetClassNameString("Action");
											node49.SetId(49);
#if !BEHAVIAC_RELEASE
											node49.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node49);
											node29.SetHasEvents(node29.HasEvents() | node49.HasEvents());
										}
										{
											Compute_bt_Level_DeathMatch_1_node41 node41 = new Compute_bt_Level_DeathMatch_1_node41();
											node41.SetClassNameString("Compute");
											node41.SetId(41);
#if !BEHAVIAC_RELEASE
											node41.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node41);
											node29.SetHasEvents(node29.HasEvents() | node41.HasEvents());
										}
										{
											Action_bt_Level_DeathMatch_1_node35 node35 = new Action_bt_Level_DeathMatch_1_node35();
											node35.SetClassNameString("Action");
											node35.SetId(35);
#if !BEHAVIAC_RELEASE
											node35.SetAgentType("GameLevelCommon");
#endif
											node29.AddChild(node35);
											node29.SetHasEvents(node29.HasEvents() | node35.HasEvents());
										}
										node21.SetHasEvents(node21.HasEvents() | node29.HasEvents());
									}
									node11.SetHasEvents(node11.HasEvents() | node21.HasEvents());
								}
								{
									Compute_bt_Level_DeathMatch_1_node0 node0 = new Compute_bt_Level_DeathMatch_1_node0();
									node0.SetClassNameString("Compute");
									node0.SetId(0);
#if !BEHAVIAC_RELEASE
									node0.SetAgentType("GameLevelCommon");
#endif
									node11.AddChild(node0);
									node11.SetHasEvents(node11.HasEvents() | node0.HasEvents());
								}
								node14.SetHasEvents(node14.HasEvents() | node11.HasEvents());
							}
							{
								Selector node2 = new Selector();
								node2.SetClassNameString("Selector");
								node2.SetId(2);
#if !BEHAVIAC_RELEASE
								node2.SetAgentType("GameLevelCommon");
#endif
								node14.AddChild(node2);
								{
									Sequence node38 = new Sequence();
									node38.SetClassNameString("Sequence");
									node38.SetId(38);
#if !BEHAVIAC_RELEASE
									node38.SetAgentType("GameLevelCommon");
#endif
									node2.AddChild(node38);
									{
										Action_bt_Level_DeathMatch_1_node5 node5 = new Action_bt_Level_DeathMatch_1_node5();
										node5.SetClassNameString("Action");
										node5.SetId(5);
#if !BEHAVIAC_RELEASE
										node5.SetAgentType("GameLevelCommon");
#endif
										node38.AddChild(node5);
										node38.SetHasEvents(node38.HasEvents() | node5.HasEvents());
									}
									{
										Wait_bt_Level_DeathMatch_1_node1 node1 = new Wait_bt_Level_DeathMatch_1_node1();
										node1.SetClassNameString("Wait");
										node1.SetId(1);
#if !BEHAVIAC_RELEASE
										node1.SetAgentType("GameLevelCommon");
#endif
										node38.AddChild(node1);
										node38.SetHasEvents(node38.HasEvents() | node1.HasEvents());
									}
									{
										Action_bt_Level_DeathMatch_1_node30 node30 = new Action_bt_Level_DeathMatch_1_node30();
										node30.SetClassNameString("Action");
										node30.SetId(30);
#if !BEHAVIAC_RELEASE
										node30.SetAgentType("GameLevelCommon");
#endif
										node38.AddChild(node30);
										node38.SetHasEvents(node38.HasEvents() | node30.HasEvents());
									}
									{
										Wait_bt_Level_DeathMatch_1_node32 node32 = new Wait_bt_Level_DeathMatch_1_node32();
										node32.SetClassNameString("Wait");
										node32.SetId(32);
#if !BEHAVIAC_RELEASE
										node32.SetAgentType("GameLevelCommon");
#endif
										node38.AddChild(node32);
										node38.SetHasEvents(node38.HasEvents() | node32.HasEvents());
									}
									{
										Action_bt_Level_DeathMatch_1_node23 node23 = new Action_bt_Level_DeathMatch_1_node23();
										node23.SetClassNameString("Action");
										node23.SetId(23);
#if !BEHAVIAC_RELEASE
										node23.SetAgentType("GameLevelCommon");
#endif
										node38.AddChild(node23);
										node38.SetHasEvents(node38.HasEvents() | node23.HasEvents());
									}
									node2.SetHasEvents(node2.HasEvents() | node38.HasEvents());
								}
								{
									Sequence node24 = new Sequence();
									node24.SetClassNameString("Sequence");
									node24.SetId(24);
#if !BEHAVIAC_RELEASE
									node24.SetAgentType("GameLevelCommon");
#endif
									node2.AddChild(node24);
									{
										Action_bt_Level_DeathMatch_1_node22 node22 = new Action_bt_Level_DeathMatch_1_node22();
										node22.SetClassNameString("Action");
										node22.SetId(22);
#if !BEHAVIAC_RELEASE
										node22.SetAgentType("GameLevelCommon");
#endif
										node24.AddChild(node22);
										node24.SetHasEvents(node24.HasEvents() | node22.HasEvents());
									}
									{
										Wait_bt_Level_DeathMatch_1_node28 node28 = new Wait_bt_Level_DeathMatch_1_node28();
										node28.SetClassNameString("Wait");
										node28.SetId(28);
#if !BEHAVIAC_RELEASE
										node28.SetAgentType("GameLevelCommon");
#endif
										node24.AddChild(node28);
										node24.SetHasEvents(node24.HasEvents() | node28.HasEvents());
									}
									{
										Action_bt_Level_DeathMatch_1_node33 node33 = new Action_bt_Level_DeathMatch_1_node33();
										node33.SetClassNameString("Action");
										node33.SetId(33);
#if !BEHAVIAC_RELEASE
										node33.SetAgentType("GameLevelCommon");
#endif
										node24.AddChild(node33);
										node24.SetHasEvents(node24.HasEvents() | node33.HasEvents());
									}
									{
										Wait_bt_Level_DeathMatch_1_node56 node56 = new Wait_bt_Level_DeathMatch_1_node56();
										node56.SetClassNameString("Wait");
										node56.SetId(56);
#if !BEHAVIAC_RELEASE
										node56.SetAgentType("GameLevelCommon");
#endif
										node24.AddChild(node56);
										node24.SetHasEvents(node24.HasEvents() | node56.HasEvents());
									}
									{
										Action_bt_Level_DeathMatch_1_node27 node27 = new Action_bt_Level_DeathMatch_1_node27();
										node27.SetClassNameString("Action");
										node27.SetId(27);
#if !BEHAVIAC_RELEASE
										node27.SetAgentType("GameLevelCommon");
#endif
										node24.AddChild(node27);
										node24.SetHasEvents(node24.HasEvents() | node27.HasEvents());
									}
									node2.SetHasEvents(node2.HasEvents() | node24.HasEvents());
								}
								node14.SetHasEvents(node14.HasEvents() | node2.HasEvents());
							}
							{
								Sequence node34 = new Sequence();
								node34.SetClassNameString("Sequence");
								node34.SetId(34);
#if !BEHAVIAC_RELEASE
								node34.SetAgentType("GameLevelCommon");
#endif
								node14.AddChild(node34);
								{
									Wait_bt_Level_DeathMatch_1_node31 node31 = new Wait_bt_Level_DeathMatch_1_node31();
									node31.SetClassNameString("Wait");
									node31.SetId(31);
#if !BEHAVIAC_RELEASE
									node31.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node31);
									node34.SetHasEvents(node34.HasEvents() | node31.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_1_node42 node42 = new Assignment_bt_Level_DeathMatch_1_node42();
									node42.SetClassNameString("Assignment");
									node42.SetId(42);
#if !BEHAVIAC_RELEASE
									node42.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node42);
									node34.SetHasEvents(node34.HasEvents() | node42.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_1_node43 node43 = new Assignment_bt_Level_DeathMatch_1_node43();
									node43.SetClassNameString("Assignment");
									node43.SetId(43);
#if !BEHAVIAC_RELEASE
									node43.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node43);
									node34.SetHasEvents(node34.HasEvents() | node43.HasEvents());
								}
								{
									Assignment_bt_Level_DeathMatch_1_node44 node44 = new Assignment_bt_Level_DeathMatch_1_node44();
									node44.SetClassNameString("Assignment");
									node44.SetId(44);
#if !BEHAVIAC_RELEASE
									node44.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node44);
									node34.SetHasEvents(node34.HasEvents() | node44.HasEvents());
								}
								{
									Action_bt_Level_DeathMatch_1_node45 node45 = new Action_bt_Level_DeathMatch_1_node45();
									node45.SetClassNameString("Action");
									node45.SetId(45);
#if !BEHAVIAC_RELEASE
									node45.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node45);
									node34.SetHasEvents(node34.HasEvents() | node45.HasEvents());
								}
								{
									Wait_bt_Level_DeathMatch_1_node46 node46 = new Wait_bt_Level_DeathMatch_1_node46();
									node46.SetClassNameString("Wait");
									node46.SetId(46);
#if !BEHAVIAC_RELEASE
									node46.SetAgentType("GameLevelCommon");
#endif
									node34.AddChild(node46);
									node34.SetHasEvents(node34.HasEvents() | node46.HasEvents());
								}
								node14.SetHasEvents(node14.HasEvents() | node34.HasEvents());
							}
							node50.SetHasEvents(node50.HasEvents() | node14.HasEvents());
						}
						node6.SetHasEvents(node6.HasEvents() | node50.HasEvents());
					}
					node3.SetHasEvents(node3.HasEvents() | node6.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node3.HasEvents());
			}
			return true;
		}
	}

	// Source file: Level_Survival

	class Assignment_bt_Level_Survival_node36 : behaviac.Assignment
	{
		public Assignment_bt_Level_Survival_node36()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = 9;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			pAgent.SetVariable("parT_PlayerLifeCount", opr, 1348569231u);
			return result;
		}
	}

	class Action_bt_Level_Survival_node28 : behaviac.Action
	{
		public Action_bt_Level_Survival_node28()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerID") == 2931189165u);
			int method_p0 = (int)pAgent.GetVariable(2931189165u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			int method_p1 = (int)pAgent.GetVariable(1348569231u);
			((GameLevelCommon)pAgent).setActorLifeCount(method_p0, method_p1);
			return EBTStatus.BT_SUCCESS;
		}
	}

	class DecoratorLoop_bt_Level_Survival_node27 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Level_Survival_node27()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Level_Survival_node0 : behaviac.Parallel
	{
		public Parallel_bt_Level_Survival_node0()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class Wait_bt_Level_Survival_node6 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node6()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Assignment_bt_Level_Survival_node1 : behaviac.Assignment
	{
		public Assignment_bt_Level_Survival_node1()
		{
			opr_p0 = 0;
			opr_p1 = 4;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			pAgent.SetVariable("parT_AwardType", opr, 1346337780u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Action_bt_Level_Survival_node17 : behaviac.Action
	{
		public Action_bt_Level_Survival_node17()
		{
			method_p1 = -1;
			method_p2 = -1;
			method_p3 = 20f;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardType") == 1346337780u);
			int method_p0 = (int)pAgent.GetVariable(1346337780u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).spawnAward(method_p0, method_p1, method_p2, method_p3);
			return result;
		}
		int method_p1;
		int method_p2;
		float method_p3;
	}

	class Wait_bt_Level_Survival_node2 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node2()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 10000;
		}
	}

	class Assignment_bt_Level_Survival_node9 : behaviac.Assignment
	{
		public Assignment_bt_Level_Survival_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int opr = (int)((GameLevelCommon)pAgent).getEnemyCount();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyCount") == 2685115492u);
			pAgent.SetVariable("parT_EnemyCount", opr, 2685115492u);
			return result;
		}
	}

	class Condition_bt_Level_Survival_node11 : behaviac.Condition
	{
		public Condition_bt_Level_Survival_node11()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyCount") == 2685115492u);
			int opl = (int)pAgent.GetVariable(2685115492u);
			int opr = 10;
			bool op = opl < opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Level_Survival_node18 : behaviac.Action
	{
		public Action_bt_Level_Survival_node18()
		{
			method_p0 = eGameForce.BLUE_FORCE;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).spawnRandomActor(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
		eGameForce method_p0;
	}

	class Wait_bt_Level_Survival_node10 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node10()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 3000;
		}
	}

	class Predicate_bt_Level_Survival_attach19 : behaviac.Predicate
	{
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_FAILURE;
			this.m_bAnd = true;
			bool opl = ((GameLevelCommon)pAgent).isPlayerAlive;
			bool opr = false;
			bool op = opl == opr;
			if (op)
				result = EBTStatus.BT_SUCCESS;
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Level_Survival_node20 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Level_Survival_node20()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Wait_bt_Level_Survival_node26 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node26()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Assignment_bt_Level_Survival_node24 : behaviac.Assignment
	{
		public Assignment_bt_Level_Survival_node24()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerID") == 2931189165u);
			int opr_p0 = (int)pAgent.GetVariable(2931189165u);
			int opr = (int)((GameLevelCommon)pAgent).getActorLifeCount(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			pAgent.SetVariable("parT_PlayerLifeCount", opr, 1348569231u);
			return result;
		}
	}

	class Condition_bt_Level_Survival_node21 : behaviac.Condition
	{
		public Condition_bt_Level_Survival_node21()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			int opl = (int)pAgent.GetVariable(1348569231u);
			int opr = 0;
			bool op = opl > opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Level_Survival_node22 : behaviac.Action
	{
		public Action_bt_Level_Survival_node22()
		{
			method_p0 = eGameForce.RED_FORCE;
			method_p1 = 16f;
			method_p2 = "Tank_Agressive";
			method_p3 = 800;
			method_p4 = 300;
			method_p5 = 1;
			method_p6 = 3;
			method_p7 = 720f;
			method_p8 = 720f;
			method_p9 = 0;
			method_p10.a = 1f;
			method_p10.b = 0f;
			method_p10.g = 1f;
			method_p10.r = 0f;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerID") == 2931189165u);
			int method_p11 = (int)pAgent.GetVariable(2931189165u);
			((GameLevelCommon)pAgent).spawnGameActor(method_p0, method_p1, method_p2, method_p3, method_p4, method_p5, method_p6, method_p7, method_p8, method_p9, method_p10, method_p11);
			return EBTStatus.BT_SUCCESS;
		}
		eGameForce method_p0;
		float method_p1;
		string method_p2;
		int method_p3;
		int method_p4;
		int method_p5;
		int method_p6;
		float method_p7;
		float method_p8;
		int method_p9;
		UnityEngine.Color method_p10;
	}

	class Compute_bt_Level_Survival_node38 : behaviac.Compute
	{
		public Compute_bt_Level_Survival_node38()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			int opr1 = (int)pAgent.GetVariable(1348569231u);
			int opr2 = 1;
			int opr = (int)(opr1 - opr2);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			pAgent.SetVariable("parT_PlayerLifeCount", opr, 1348569231u);
			return result;
		}
	}

	class Action_bt_Level_Survival_node39 : behaviac.Action
	{
		public Action_bt_Level_Survival_node39()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerID") == 2931189165u);
			int method_p0 = (int)pAgent.GetVariable(2931189165u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			int method_p1 = (int)pAgent.GetVariable(1348569231u);
			((GameLevelCommon)pAgent).setActorLifeCount(method_p0, method_p1);
			return EBTStatus.BT_SUCCESS;
		}
	}

	class Condition_bt_Level_Survival_node31 : behaviac.Condition
	{
		public Condition_bt_Level_Survival_node31()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PlayerLifeCount") == 1348569231u);
			int opl = (int)pAgent.GetVariable(1348569231u);
			int opr = 0;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Condition_bt_Level_Survival_node32 : behaviac.Condition
	{
		public Condition_bt_Level_Survival_node32()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			bool opl = ((GameLevelCommon)pAgent).isPlayerAlive;
			bool opr = false;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Condition_bt_Level_Survival_node34 : behaviac.Condition
	{
		public Condition_bt_Level_Survival_node34()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_GameStopped") == 1723664313u);
			bool opl = (bool)pAgent.GetVariable(1723664313u);
			bool opr = false;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Wait_bt_Level_Survival_node37 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node37()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Action_bt_Level_Survival_node7 : behaviac.Action
	{
		public Action_bt_Level_Survival_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameLevelCommon)pAgent).showCredit();
			return result;
		}
	}

	class Wait_bt_Level_Survival_node4 : behaviac.Wait
	{
		public Wait_bt_Level_Survival_node4()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 6000;
		}
	}

	class Action_bt_Level_Survival_node33 : behaviac.Action
	{
		public Action_bt_Level_Survival_node33()
		{
			method_p0 = false;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			((GameLevelCommon)pAgent).stopGame(method_p0);
			return EBTStatus.BT_SUCCESS;
		}
		bool method_p0;
	}

	class Assignment_bt_Level_Survival_node35 : behaviac.Assignment
	{
		public Assignment_bt_Level_Survival_node35()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			bool opr = true;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_GameStopped") == 1723664313u);
			pAgent.SetVariable("parT_GameStopped", opr, 1723664313u);
			return result;
		}
	}

	public static class bt_Level_Survival
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Level_Survival");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("GameLevelCommon");
#endif
			// pars
			bt.AddPar("int", "parT_EnemyCount", "0", "");
			bt.AddPar("int", "parT_AwardType", "0", "");
			bt.AddPar("float", "parT_rotateSpeed", "0", "");
			bt.AddPar("int", "parT_PlayerLifeCount", "0", "");
			bt.AddPar("int", "parT_PlayerID", "1", "");
			bt.AddPar("bool", "parT_GameStopped", "false", "");
			// children
			{
				Sequence node23 = new Sequence();
				node23.SetClassNameString("Sequence");
				node23.SetId(23);
#if !BEHAVIAC_RELEASE
				node23.SetAgentType("GameLevelCommon");
#endif
				bt.AddChild(node23);
				{
					Assignment_bt_Level_Survival_node36 node36 = new Assignment_bt_Level_Survival_node36();
					node36.SetClassNameString("Assignment");
					node36.SetId(36);
#if !BEHAVIAC_RELEASE
					node36.SetAgentType("GameLevelCommon");
#endif
					node23.AddChild(node36);
					node23.SetHasEvents(node23.HasEvents() | node36.HasEvents());
				}
				{
					Action_bt_Level_Survival_node28 node28 = new Action_bt_Level_Survival_node28();
					node28.SetClassNameString("Action");
					node28.SetId(28);
#if !BEHAVIAC_RELEASE
					node28.SetAgentType("GameLevelCommon");
#endif
					node23.AddChild(node28);
					node23.SetHasEvents(node23.HasEvents() | node28.HasEvents());
				}
				{
					DecoratorLoop_bt_Level_Survival_node27 node27 = new DecoratorLoop_bt_Level_Survival_node27();
					node27.SetClassNameString("DecoratorLoop");
					node27.SetId(27);
#if !BEHAVIAC_RELEASE
					node27.SetAgentType("GameLevelCommon");
#endif
					node23.AddChild(node27);
					{
						Parallel_bt_Level_Survival_node0 node0 = new Parallel_bt_Level_Survival_node0();
						node0.SetClassNameString("Parallel");
						node0.SetId(0);
#if !BEHAVIAC_RELEASE
						node0.SetAgentType("GameLevelCommon");
#endif
						node27.AddChild(node0);
						{
							Sequence node5 = new Sequence();
							node5.SetClassNameString("Sequence");
							node5.SetId(5);
#if !BEHAVIAC_RELEASE
							node5.SetAgentType("GameLevelCommon");
#endif
							node0.AddChild(node5);
							{
								Wait_bt_Level_Survival_node6 node6 = new Wait_bt_Level_Survival_node6();
								node6.SetClassNameString("Wait");
								node6.SetId(6);
#if !BEHAVIAC_RELEASE
								node6.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node6);
								node5.SetHasEvents(node5.HasEvents() | node6.HasEvents());
							}
							{
								Assignment_bt_Level_Survival_node1 node1 = new Assignment_bt_Level_Survival_node1();
								node1.SetClassNameString("Assignment");
								node1.SetId(1);
#if !BEHAVIAC_RELEASE
								node1.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node1);
								node5.SetHasEvents(node5.HasEvents() | node1.HasEvents());
							}
							{
								Action_bt_Level_Survival_node17 node17 = new Action_bt_Level_Survival_node17();
								node17.SetClassNameString("Action");
								node17.SetId(17);
#if !BEHAVIAC_RELEASE
								node17.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node17);
								node5.SetHasEvents(node5.HasEvents() | node17.HasEvents());
							}
							{
								Wait_bt_Level_Survival_node2 node2 = new Wait_bt_Level_Survival_node2();
								node2.SetClassNameString("Wait");
								node2.SetId(2);
#if !BEHAVIAC_RELEASE
								node2.SetAgentType("GameLevelCommon");
#endif
								node5.AddChild(node2);
								node5.SetHasEvents(node5.HasEvents() | node2.HasEvents());
							}
							node0.SetHasEvents(node0.HasEvents() | node5.HasEvents());
						}
						{
							Sequence node3 = new Sequence();
							node3.SetClassNameString("Sequence");
							node3.SetId(3);
#if !BEHAVIAC_RELEASE
							node3.SetAgentType("GameLevelCommon");
#endif
							node0.AddChild(node3);
							{
								Assignment_bt_Level_Survival_node9 node9 = new Assignment_bt_Level_Survival_node9();
								node9.SetClassNameString("Assignment");
								node9.SetId(9);
#if !BEHAVIAC_RELEASE
								node9.SetAgentType("GameLevelCommon");
#endif
								node3.AddChild(node9);
								node3.SetHasEvents(node3.HasEvents() | node9.HasEvents());
							}
							{
								Condition_bt_Level_Survival_node11 node11 = new Condition_bt_Level_Survival_node11();
								node11.SetClassNameString("Condition");
								node11.SetId(11);
#if !BEHAVIAC_RELEASE
								node11.SetAgentType("GameLevelCommon");
#endif
								node3.AddChild(node11);
								node3.SetHasEvents(node3.HasEvents() | node11.HasEvents());
							}
							{
								Action_bt_Level_Survival_node18 node18 = new Action_bt_Level_Survival_node18();
								node18.SetClassNameString("Action");
								node18.SetId(18);
#if !BEHAVIAC_RELEASE
								node18.SetAgentType("GameLevelCommon");
#endif
								node3.AddChild(node18);
								node3.SetHasEvents(node3.HasEvents() | node18.HasEvents());
							}
							{
								Wait_bt_Level_Survival_node10 node10 = new Wait_bt_Level_Survival_node10();
								node10.SetClassNameString("Wait");
								node10.SetId(10);
#if !BEHAVIAC_RELEASE
								node10.SetAgentType("GameLevelCommon");
#endif
								node3.AddChild(node10);
								node3.SetHasEvents(node3.HasEvents() | node10.HasEvents());
							}
							node0.SetHasEvents(node0.HasEvents() | node3.HasEvents());
						}
						{
							WaitforSignal node13 = new WaitforSignal();
							node13.SetClassNameString("WaitforSignal");
							node13.SetId(13);
#if !BEHAVIAC_RELEASE
							node13.SetAgentType("GameLevelCommon");
#endif
							// attachments
							{
								Predicate_bt_Level_Survival_attach19 attach19 = new Predicate_bt_Level_Survival_attach19();
								attach19.SetClassNameString("Predicate");
								attach19.SetId(19);
#if !BEHAVIAC_RELEASE
								attach19.SetAgentType("GameLevelCommon");
#endif
								node13.Attach(attach19);
							}
							node0.AddChild(node13);
							{
								DecoratorAlwaysSuccess_bt_Level_Survival_node20 node20 = new DecoratorAlwaysSuccess_bt_Level_Survival_node20();
								node20.SetClassNameString("DecoratorAlwaysSuccess");
								node20.SetId(20);
#if !BEHAVIAC_RELEASE
								node20.SetAgentType("GameLevelCommon");
#endif
								node13.AddChild(node20);
								{
									Sequence node25 = new Sequence();
									node25.SetClassNameString("Sequence");
									node25.SetId(25);
#if !BEHAVIAC_RELEASE
									node25.SetAgentType("GameLevelCommon");
#endif
									node20.AddChild(node25);
									{
										Wait_bt_Level_Survival_node26 node26 = new Wait_bt_Level_Survival_node26();
										node26.SetClassNameString("Wait");
										node26.SetId(26);
#if !BEHAVIAC_RELEASE
										node26.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node26);
										node25.SetHasEvents(node25.HasEvents() | node26.HasEvents());
									}
									{
										Assignment_bt_Level_Survival_node24 node24 = new Assignment_bt_Level_Survival_node24();
										node24.SetClassNameString("Assignment");
										node24.SetId(24);
#if !BEHAVIAC_RELEASE
										node24.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node24);
										node25.SetHasEvents(node25.HasEvents() | node24.HasEvents());
									}
									{
										Condition_bt_Level_Survival_node21 node21 = new Condition_bt_Level_Survival_node21();
										node21.SetClassNameString("Condition");
										node21.SetId(21);
#if !BEHAVIAC_RELEASE
										node21.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node21);
										node25.SetHasEvents(node25.HasEvents() | node21.HasEvents());
									}
									{
										Action_bt_Level_Survival_node22 node22 = new Action_bt_Level_Survival_node22();
										node22.SetClassNameString("Action");
										node22.SetId(22);
#if !BEHAVIAC_RELEASE
										node22.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node22);
										node25.SetHasEvents(node25.HasEvents() | node22.HasEvents());
									}
									{
										Compute_bt_Level_Survival_node38 node38 = new Compute_bt_Level_Survival_node38();
										node38.SetClassNameString("Compute");
										node38.SetId(38);
#if !BEHAVIAC_RELEASE
										node38.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node38);
										node25.SetHasEvents(node25.HasEvents() | node38.HasEvents());
									}
									{
										Action_bt_Level_Survival_node39 node39 = new Action_bt_Level_Survival_node39();
										node39.SetClassNameString("Action");
										node39.SetId(39);
#if !BEHAVIAC_RELEASE
										node39.SetAgentType("GameLevelCommon");
#endif
										node25.AddChild(node39);
										node25.SetHasEvents(node25.HasEvents() | node39.HasEvents());
									}
									node20.SetHasEvents(node20.HasEvents() | node25.HasEvents());
								}
								node13.SetHasEvents(node13.HasEvents() | node20.HasEvents());
							}
							node0.SetHasEvents(node0.HasEvents() | node13.HasEvents());
						}
						{
							Sequence node29 = new Sequence();
							node29.SetClassNameString("Sequence");
							node29.SetId(29);
#if !BEHAVIAC_RELEASE
							node29.SetAgentType("GameLevelCommon");
#endif
							node0.AddChild(node29);
							{
								And node30 = new And();
								node30.SetClassNameString("And");
								node30.SetId(30);
#if !BEHAVIAC_RELEASE
								node30.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node30);
								{
									Condition_bt_Level_Survival_node31 node31 = new Condition_bt_Level_Survival_node31();
									node31.SetClassNameString("Condition");
									node31.SetId(31);
#if !BEHAVIAC_RELEASE
									node31.SetAgentType("GameLevelCommon");
#endif
									node30.AddChild(node31);
									node30.SetHasEvents(node30.HasEvents() | node31.HasEvents());
								}
								{
									Condition_bt_Level_Survival_node32 node32 = new Condition_bt_Level_Survival_node32();
									node32.SetClassNameString("Condition");
									node32.SetId(32);
#if !BEHAVIAC_RELEASE
									node32.SetAgentType("GameLevelCommon");
#endif
									node30.AddChild(node32);
									node30.SetHasEvents(node30.HasEvents() | node32.HasEvents());
								}
								{
									Condition_bt_Level_Survival_node34 node34 = new Condition_bt_Level_Survival_node34();
									node34.SetClassNameString("Condition");
									node34.SetId(34);
#if !BEHAVIAC_RELEASE
									node34.SetAgentType("GameLevelCommon");
#endif
									node30.AddChild(node34);
									node30.SetHasEvents(node30.HasEvents() | node34.HasEvents());
								}
								node29.SetHasEvents(node29.HasEvents() | node30.HasEvents());
							}
							{
								Wait_bt_Level_Survival_node37 node37 = new Wait_bt_Level_Survival_node37();
								node37.SetClassNameString("Wait");
								node37.SetId(37);
#if !BEHAVIAC_RELEASE
								node37.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node37);
								node29.SetHasEvents(node29.HasEvents() | node37.HasEvents());
							}
							{
								Action_bt_Level_Survival_node7 node7 = new Action_bt_Level_Survival_node7();
								node7.SetClassNameString("Action");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node7);
								node29.SetHasEvents(node29.HasEvents() | node7.HasEvents());
							}
							{
								Wait_bt_Level_Survival_node4 node4 = new Wait_bt_Level_Survival_node4();
								node4.SetClassNameString("Wait");
								node4.SetId(4);
#if !BEHAVIAC_RELEASE
								node4.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node4);
								node29.SetHasEvents(node29.HasEvents() | node4.HasEvents());
							}
							{
								Action_bt_Level_Survival_node33 node33 = new Action_bt_Level_Survival_node33();
								node33.SetClassNameString("Action");
								node33.SetId(33);
#if !BEHAVIAC_RELEASE
								node33.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node33);
								node29.SetHasEvents(node29.HasEvents() | node33.HasEvents());
							}
							{
								Assignment_bt_Level_Survival_node35 node35 = new Assignment_bt_Level_Survival_node35();
								node35.SetClassNameString("Assignment");
								node35.SetId(35);
#if !BEHAVIAC_RELEASE
								node35.SetAgentType("GameLevelCommon");
#endif
								node29.AddChild(node35);
								node29.SetHasEvents(node29.HasEvents() | node35.HasEvents());
							}
							node0.SetHasEvents(node0.HasEvents() | node29.HasEvents());
						}
						node27.SetHasEvents(node27.HasEvents() | node0.HasEvents());
					}
					node23.SetHasEvents(node23.HasEvents() | node27.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node23.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Agressive

	class DecoratorLoop_bt_Tank_Agressive_node2 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Agressive_node2()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_Agressive_node0 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Agressive_node0()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorAlwaysRunning_bt_Tank_Agressive_node38 : behaviac.DecoratorAlwaysRunning
	{
		public DecoratorAlwaysRunning_bt_Tank_Agressive_node38()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class DecoratorAlwaysFailure_bt_Tank_Agressive_node25 : behaviac.DecoratorAlwaysFailure
	{
		public DecoratorAlwaysFailure_bt_Tank_Agressive_node25()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_Agressive_node26 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node26()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			bool opr = true;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavFailed") == 972142594u);
			pAgent.SetVariable("parT_NavFailed", opr, 972142594u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node35 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node35()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = (int)((GameLevelCommon)pAgent_opr).getNearestAwardID();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			pAgent.SetVariable("parT_AwardID", opr, 2554131854u);
			return result;
		}
	}

	class Condition_bt_Tank_Agressive_node34 : behaviac.Condition
	{
		public Condition_bt_Tank_Agressive_node34()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			int opl = (int)pAgent.GetVariable(2554131854u);
			int opr = -1;
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Tank_Agressive_node37 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node37()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			int opr_p0 = (int)pAgent.GetVariable(2554131854u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getAwardPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavTargetPosition") == 2368420228u);
			pAgent.SetVariable("parT_NavTargetPosition", opr, 2368420228u);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node24 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node24()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavTargetPosition") == 2368420228u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(2368420228u);
			behaviac.Agent pAgent_method_p1 = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_method_p1 != null);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, GameLevelCommon.actorWalkLevel);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node5 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	class Parallel_bt_Tank_Agressive_node15 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Agressive_node15()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ONE;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorNot_bt_Tank_Agressive_node21 : behaviac.DecoratorNot
	{
		public DecoratorNot_bt_Tank_Agressive_node21()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Wait_bt_Tank_Agressive_node19 : behaviac.Wait
	{
		public Wait_bt_Tank_Agressive_node19()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Assignment_bt_Tank_Agressive_node20 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node20()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			bool opr = false;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavFailed") == 972142594u);
			pAgent.SetVariable("parT_NavFailed", opr, 972142594u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node4 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(((GameActor)pAgent).force);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node7 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node33 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node33()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			behaviac.Agent pAgent_method_p1 = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_method_p1 != null);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, GameLevelCommon.actorWalkLevel);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node13 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node13()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	class Condition_bt_Tank_Agressive_node6 : behaviac.Condition
	{
		public Condition_bt_Tank_Agressive_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavFailed") == 972142594u);
			bool opl = (bool)pAgent.GetVariable(972142594u);
			bool opr = true;
			bool op = opl == opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Parallel_bt_Tank_Agressive_node1 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Agressive_node1()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ONE;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class SelectorStochastic_bt_Tank_Agressive_node9 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_Agressive_node9()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_Agressive_node36 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node36()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.TOP;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node11 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node11()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.RIGHT;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node14 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node14()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.BOTTOM;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_Agressive_node16 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node16()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.LEFT;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Wait_bt_Tank_Agressive_node17 : behaviac.Wait
	{
		public Wait_bt_Tank_Agressive_node17()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Assignment_bt_Tank_Agressive_node18 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node18()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			eMapDirection opr_p0 = (eMapDirection)pAgent.GetVariable(1696414415u);
			eMapDirection opr = (eMapDirection)((GameActor)pAgent).getBestMoveDirection(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			pAgent.SetVariable("parT_SafeMoveDirection", opr, 3893705419u);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node27 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node27()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			eMapDirection method_p0 = (eMapDirection)pAgent.GetVariable(3893705419u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveToDirection(method_p0);
			return result;
		}
	}

	class DecoratorAlwaysRunning_bt_Tank_Agressive_node10 : behaviac.DecoratorAlwaysRunning
	{
		public DecoratorAlwaysRunning_bt_Tank_Agressive_node10()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_Agressive_node29 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Agressive_node29()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = (float)((Player)pAgent).detectNearestEnemyInView();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			pAgent.SetVariable("parT_EnemyAzimuth", opr, 2614361194u);
			return result;
		}
	}

	class Condition_bt_Tank_Agressive_node30 : behaviac.Condition
	{
		public Condition_bt_Tank_Agressive_node30()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			float opl = (float)pAgent.GetVariable(2614361194u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_Agressive_node31 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node31()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			float method_p0 = (float)pAgent.GetVariable(2614361194u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_Agressive_node32 : behaviac.Action
	{
		public Action_bt_Tank_Agressive_node32()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Agressive
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Agressive");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("UnityEngine.Vector3", "parT_NavTargetPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("eMapDirection", "parT_TendencyDirection", "UNKNOWN", "");
			bt.AddPar("bool", "parT_CanReachToAward", "false", "");
			bt.AddPar("int", "parT_AwardID", "0", "");
			bt.AddPar("float", "parT_EnemyAzimuth_0", "0", "");
			bt.AddPar("eMapDirection", "parT_SafeMoveDirection", "UNKNOWN", "");
			bt.AddPar("eMapDirection", "parT_RandomMoveDirection", "UNKNOWN", "");
			bt.AddPar("bool", "parT_NavFailed", "false", "");
			bt.AddPar("float", "parT_EnemyAzimuth", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Agressive_node2 node2 = new DecoratorLoop_bt_Tank_Agressive_node2();
				node2.SetClassNameString("DecoratorLoop");
				node2.SetId(2);
#if !BEHAVIAC_RELEASE
				node2.SetAgentType("Player");
#endif
				bt.AddChild(node2);
				{
					Parallel_bt_Tank_Agressive_node0 node0 = new Parallel_bt_Tank_Agressive_node0();
					node0.SetClassNameString("Parallel");
					node0.SetId(0);
#if !BEHAVIAC_RELEASE
					node0.SetAgentType("Player");
#endif
					node2.AddChild(node0);
					{
						DecoratorAlwaysRunning_bt_Tank_Agressive_node38 node38 = new DecoratorAlwaysRunning_bt_Tank_Agressive_node38();
						node38.SetClassNameString("DecoratorAlwaysRunning");
						node38.SetId(38);
#if !BEHAVIAC_RELEASE
						node38.SetAgentType("Player");
#endif
						node0.AddChild(node38);
						{
							Selector node39 = new Selector();
							node39.SetClassNameString("Selector");
							node39.SetId(39);
#if !BEHAVIAC_RELEASE
							node39.SetAgentType("Player");
#endif
							node38.AddChild(node39);
							{
								DecoratorAlwaysFailure_bt_Tank_Agressive_node25 node25 = new DecoratorAlwaysFailure_bt_Tank_Agressive_node25();
								node25.SetClassNameString("DecoratorAlwaysFailure");
								node25.SetId(25);
#if !BEHAVIAC_RELEASE
								node25.SetAgentType("Player");
#endif
								node39.AddChild(node25);
								{
									Assignment_bt_Tank_Agressive_node26 node26 = new Assignment_bt_Tank_Agressive_node26();
									node26.SetClassNameString("Assignment");
									node26.SetId(26);
#if !BEHAVIAC_RELEASE
									node26.SetAgentType("Player");
#endif
									node25.AddChild(node26);
									node25.SetHasEvents(node25.HasEvents() | node26.HasEvents());
								}
								node39.SetHasEvents(node39.HasEvents() | node25.HasEvents());
							}
							{
								Sequence node22 = new Sequence();
								node22.SetClassNameString("Sequence");
								node22.SetId(22);
#if !BEHAVIAC_RELEASE
								node22.SetAgentType("Player");
#endif
								node39.AddChild(node22);
								{
									Assignment_bt_Tank_Agressive_node35 node35 = new Assignment_bt_Tank_Agressive_node35();
									node35.SetClassNameString("Assignment");
									node35.SetId(35);
#if !BEHAVIAC_RELEASE
									node35.SetAgentType("Player");
#endif
									node22.AddChild(node35);
									node22.SetHasEvents(node22.HasEvents() | node35.HasEvents());
								}
								{
									Condition_bt_Tank_Agressive_node34 node34 = new Condition_bt_Tank_Agressive_node34();
									node34.SetClassNameString("Condition");
									node34.SetId(34);
#if !BEHAVIAC_RELEASE
									node34.SetAgentType("Player");
#endif
									node22.AddChild(node34);
									node22.SetHasEvents(node22.HasEvents() | node34.HasEvents());
								}
								{
									Assignment_bt_Tank_Agressive_node37 node37 = new Assignment_bt_Tank_Agressive_node37();
									node37.SetClassNameString("Assignment");
									node37.SetId(37);
#if !BEHAVIAC_RELEASE
									node37.SetAgentType("Player");
#endif
									node22.AddChild(node37);
									node22.SetHasEvents(node22.HasEvents() | node37.HasEvents());
								}
								{
									Action_bt_Tank_Agressive_node24 node24 = new Action_bt_Tank_Agressive_node24();
									node24.SetClassNameString("Action");
									node24.SetId(24);
#if !BEHAVIAC_RELEASE
									node24.SetAgentType("Player");
#endif
									node22.AddChild(node24);
									node22.SetHasEvents(node22.HasEvents() | node24.HasEvents());
								}
								{
									Action_bt_Tank_Agressive_node5 node5 = new Action_bt_Tank_Agressive_node5();
									node5.SetClassNameString("Action");
									node5.SetId(5);
#if !BEHAVIAC_RELEASE
									node5.SetAgentType("Player");
#endif
									node22.AddChild(node5);
									node22.SetHasEvents(node22.HasEvents() | node5.HasEvents());
								}
								node39.SetHasEvents(node39.HasEvents() | node22.HasEvents());
							}
							{
								Parallel_bt_Tank_Agressive_node15 node15 = new Parallel_bt_Tank_Agressive_node15();
								node15.SetClassNameString("Parallel");
								node15.SetId(15);
#if !BEHAVIAC_RELEASE
								node15.SetAgentType("Player");
#endif
								node39.AddChild(node15);
								{
									DecoratorNot_bt_Tank_Agressive_node21 node21 = new DecoratorNot_bt_Tank_Agressive_node21();
									node21.SetClassNameString("DecoratorNot");
									node21.SetId(21);
#if !BEHAVIAC_RELEASE
									node21.SetAgentType("Player");
#endif
									node15.AddChild(node21);
									{
										Sequence node8 = new Sequence();
										node8.SetClassNameString("Sequence");
										node8.SetId(8);
#if !BEHAVIAC_RELEASE
										node8.SetAgentType("Player");
#endif
										node21.AddChild(node8);
										{
											Wait_bt_Tank_Agressive_node19 node19 = new Wait_bt_Tank_Agressive_node19();
											node19.SetClassNameString("Wait");
											node19.SetId(19);
#if !BEHAVIAC_RELEASE
											node19.SetAgentType("Player");
#endif
											node8.AddChild(node19);
											node8.SetHasEvents(node8.HasEvents() | node19.HasEvents());
										}
										{
											Assignment_bt_Tank_Agressive_node20 node20 = new Assignment_bt_Tank_Agressive_node20();
											node20.SetClassNameString("Assignment");
											node20.SetId(20);
#if !BEHAVIAC_RELEASE
											node20.SetAgentType("Player");
#endif
											node8.AddChild(node20);
											node8.SetHasEvents(node8.HasEvents() | node20.HasEvents());
										}
										node21.SetHasEvents(node21.HasEvents() | node8.HasEvents());
									}
									node15.SetHasEvents(node15.HasEvents() | node21.HasEvents());
								}
								{
									Sequence node3 = new Sequence();
									node3.SetClassNameString("Sequence");
									node3.SetId(3);
#if !BEHAVIAC_RELEASE
									node3.SetAgentType("Player");
#endif
									node15.AddChild(node3);
									{
										Assignment_bt_Tank_Agressive_node4 node4 = new Assignment_bt_Tank_Agressive_node4();
										node4.SetClassNameString("Assignment");
										node4.SetId(4);
#if !BEHAVIAC_RELEASE
										node4.SetAgentType("Player");
#endif
										node3.AddChild(node4);
										node3.SetHasEvents(node3.HasEvents() | node4.HasEvents());
									}
									{
										Assignment_bt_Tank_Agressive_node7 node7 = new Assignment_bt_Tank_Agressive_node7();
										node7.SetClassNameString("Assignment");
										node7.SetId(7);
#if !BEHAVIAC_RELEASE
										node7.SetAgentType("Player");
#endif
										node3.AddChild(node7);
										node3.SetHasEvents(node3.HasEvents() | node7.HasEvents());
									}
									{
										Action_bt_Tank_Agressive_node33 node33 = new Action_bt_Tank_Agressive_node33();
										node33.SetClassNameString("Action");
										node33.SetId(33);
#if !BEHAVIAC_RELEASE
										node33.SetAgentType("Player");
#endif
										node3.AddChild(node33);
										node3.SetHasEvents(node3.HasEvents() | node33.HasEvents());
									}
									{
										Action_bt_Tank_Agressive_node13 node13 = new Action_bt_Tank_Agressive_node13();
										node13.SetClassNameString("Action");
										node13.SetId(13);
#if !BEHAVIAC_RELEASE
										node13.SetAgentType("Player");
#endif
										node3.AddChild(node13);
										node3.SetHasEvents(node3.HasEvents() | node13.HasEvents());
									}
									node15.SetHasEvents(node15.HasEvents() | node3.HasEvents());
								}
								node39.SetHasEvents(node39.HasEvents() | node15.HasEvents());
							}
							{
								Sequence node23 = new Sequence();
								node23.SetClassNameString("Sequence");
								node23.SetId(23);
#if !BEHAVIAC_RELEASE
								node23.SetAgentType("Player");
#endif
								node39.AddChild(node23);
								{
									Condition_bt_Tank_Agressive_node6 node6 = new Condition_bt_Tank_Agressive_node6();
									node6.SetClassNameString("Condition");
									node6.SetId(6);
#if !BEHAVIAC_RELEASE
									node6.SetAgentType("Player");
#endif
									node23.AddChild(node6);
									node23.SetHasEvents(node23.HasEvents() | node6.HasEvents());
								}
								{
									Parallel_bt_Tank_Agressive_node1 node1 = new Parallel_bt_Tank_Agressive_node1();
									node1.SetClassNameString("Parallel");
									node1.SetId(1);
#if !BEHAVIAC_RELEASE
									node1.SetAgentType("Player");
#endif
									node23.AddChild(node1);
									{
										Sequence node12 = new Sequence();
										node12.SetClassNameString("Sequence");
										node12.SetId(12);
#if !BEHAVIAC_RELEASE
										node12.SetAgentType("Player");
#endif
										node1.AddChild(node12);
										{
											SelectorStochastic_bt_Tank_Agressive_node9 node9 = new SelectorStochastic_bt_Tank_Agressive_node9();
											node9.SetClassNameString("SelectorStochastic");
											node9.SetId(9);
#if !BEHAVIAC_RELEASE
											node9.SetAgentType("Player");
#endif
											node12.AddChild(node9);
											{
												Assignment_bt_Tank_Agressive_node36 node36 = new Assignment_bt_Tank_Agressive_node36();
												node36.SetClassNameString("Assignment");
												node36.SetId(36);
#if !BEHAVIAC_RELEASE
												node36.SetAgentType("Player");
#endif
												node9.AddChild(node36);
												node9.SetHasEvents(node9.HasEvents() | node36.HasEvents());
											}
											{
												Assignment_bt_Tank_Agressive_node11 node11 = new Assignment_bt_Tank_Agressive_node11();
												node11.SetClassNameString("Assignment");
												node11.SetId(11);
#if !BEHAVIAC_RELEASE
												node11.SetAgentType("Player");
#endif
												node9.AddChild(node11);
												node9.SetHasEvents(node9.HasEvents() | node11.HasEvents());
											}
											{
												Assignment_bt_Tank_Agressive_node14 node14 = new Assignment_bt_Tank_Agressive_node14();
												node14.SetClassNameString("Assignment");
												node14.SetId(14);
#if !BEHAVIAC_RELEASE
												node14.SetAgentType("Player");
#endif
												node9.AddChild(node14);
												node9.SetHasEvents(node9.HasEvents() | node14.HasEvents());
											}
											{
												Assignment_bt_Tank_Agressive_node16 node16 = new Assignment_bt_Tank_Agressive_node16();
												node16.SetClassNameString("Assignment");
												node16.SetId(16);
#if !BEHAVIAC_RELEASE
												node16.SetAgentType("Player");
#endif
												node9.AddChild(node16);
												node9.SetHasEvents(node9.HasEvents() | node16.HasEvents());
											}
											node12.SetHasEvents(node12.HasEvents() | node9.HasEvents());
										}
										{
											Wait_bt_Tank_Agressive_node17 node17 = new Wait_bt_Tank_Agressive_node17();
											node17.SetClassNameString("Wait");
											node17.SetId(17);
#if !BEHAVIAC_RELEASE
											node17.SetAgentType("Player");
#endif
											node12.AddChild(node17);
											node12.SetHasEvents(node12.HasEvents() | node17.HasEvents());
										}
										node1.SetHasEvents(node1.HasEvents() | node12.HasEvents());
									}
									{
										Sequence node49 = new Sequence();
										node49.SetClassNameString("Sequence");
										node49.SetId(49);
#if !BEHAVIAC_RELEASE
										node49.SetAgentType("Player");
#endif
										node1.AddChild(node49);
										{
											Assignment_bt_Tank_Agressive_node18 node18 = new Assignment_bt_Tank_Agressive_node18();
											node18.SetClassNameString("Assignment");
											node18.SetId(18);
#if !BEHAVIAC_RELEASE
											node18.SetAgentType("Player");
#endif
											node49.AddChild(node18);
											node49.SetHasEvents(node49.HasEvents() | node18.HasEvents());
										}
										{
											Action_bt_Tank_Agressive_node27 node27 = new Action_bt_Tank_Agressive_node27();
											node27.SetClassNameString("Action");
											node27.SetId(27);
#if !BEHAVIAC_RELEASE
											node27.SetAgentType("Player");
#endif
											node49.AddChild(node27);
											node49.SetHasEvents(node49.HasEvents() | node27.HasEvents());
										}
										node1.SetHasEvents(node1.HasEvents() | node49.HasEvents());
									}
									node23.SetHasEvents(node23.HasEvents() | node1.HasEvents());
								}
								node39.SetHasEvents(node39.HasEvents() | node23.HasEvents());
							}
							node38.SetHasEvents(node38.HasEvents() | node39.HasEvents());
						}
						node0.SetHasEvents(node0.HasEvents() | node38.HasEvents());
					}
					{
						DecoratorAlwaysRunning_bt_Tank_Agressive_node10 node10 = new DecoratorAlwaysRunning_bt_Tank_Agressive_node10();
						node10.SetClassNameString("DecoratorAlwaysRunning");
						node10.SetId(10);
#if !BEHAVIAC_RELEASE
						node10.SetAgentType("Player");
#endif
						node0.AddChild(node10);
						{
							Sequence node28 = new Sequence();
							node28.SetClassNameString("Sequence");
							node28.SetId(28);
#if !BEHAVIAC_RELEASE
							node28.SetAgentType("Player");
#endif
							node10.AddChild(node28);
							{
								Assignment_bt_Tank_Agressive_node29 node29 = new Assignment_bt_Tank_Agressive_node29();
								node29.SetClassNameString("Assignment");
								node29.SetId(29);
#if !BEHAVIAC_RELEASE
								node29.SetAgentType("Player");
#endif
								node28.AddChild(node29);
								node28.SetHasEvents(node28.HasEvents() | node29.HasEvents());
							}
							{
								Condition_bt_Tank_Agressive_node30 node30 = new Condition_bt_Tank_Agressive_node30();
								node30.SetClassNameString("Condition");
								node30.SetId(30);
#if !BEHAVIAC_RELEASE
								node30.SetAgentType("Player");
#endif
								node28.AddChild(node30);
								node28.SetHasEvents(node28.HasEvents() | node30.HasEvents());
							}
							{
								Action_bt_Tank_Agressive_node31 node31 = new Action_bt_Tank_Agressive_node31();
								node31.SetClassNameString("Action");
								node31.SetId(31);
#if !BEHAVIAC_RELEASE
								node31.SetAgentType("Player");
#endif
								node28.AddChild(node31);
								node28.SetHasEvents(node28.HasEvents() | node31.HasEvents());
							}
							{
								Action_bt_Tank_Agressive_node32 node32 = new Action_bt_Tank_Agressive_node32();
								node32.SetClassNameString("Action");
								node32.SetId(32);
#if !BEHAVIAC_RELEASE
								node32.SetAgentType("Player");
#endif
								node28.AddChild(node32);
								node28.SetHasEvents(node28.HasEvents() | node32.HasEvents());
							}
							node10.SetHasEvents(node10.HasEvents() | node28.HasEvents());
						}
						node0.SetHasEvents(node0.HasEvents() | node10.HasEvents());
					}
					node2.SetHasEvents(node2.HasEvents() | node0.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node2.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Chase

	class DecoratorLoop_bt_Tank_Chase_node4 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Chase_node4()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_Chase_node9 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Chase_node9()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorNot_bt_Tank_Chase_node5 : behaviac.DecoratorNot
	{
		public DecoratorNot_bt_Tank_Chase_node5()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Wait_bt_Tank_Chase_node7 : behaviac.Wait
	{
		public Wait_bt_Tank_Chase_node7()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 1000;
		}
	}

	class Assignment_bt_Tank_Chase_node6 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Chase_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(((GameActor)pAgent).force);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
	}

	class Assignment_bt_Tank_Chase_node0 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Chase_node0()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Action_bt_Tank_Chase_node1 : behaviac.Action
	{
		public Action_bt_Tank_Chase_node1()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			behaviac.Agent pAgent_method_p1 = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_method_p1 != null);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, GameLevelCommon.actorWalkLevel);
			return result;
		}
	}

	class Action_bt_Tank_Chase_node2 : behaviac.Action
	{
		public Action_bt_Tank_Chase_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	public static class bt_Tank_Chase
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Chase");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			// children
			{
				DecoratorLoop_bt_Tank_Chase_node4 node4 = new DecoratorLoop_bt_Tank_Chase_node4();
				node4.SetClassNameString("DecoratorLoop");
				node4.SetId(4);
#if !BEHAVIAC_RELEASE
				node4.SetAgentType("Player");
#endif
				bt.AddChild(node4);
				{
					Parallel_bt_Tank_Chase_node9 node9 = new Parallel_bt_Tank_Chase_node9();
					node9.SetClassNameString("Parallel");
					node9.SetId(9);
#if !BEHAVIAC_RELEASE
					node9.SetAgentType("Player");
#endif
					node4.AddChild(node9);
					{
						DecoratorNot_bt_Tank_Chase_node5 node5 = new DecoratorNot_bt_Tank_Chase_node5();
						node5.SetClassNameString("DecoratorNot");
						node5.SetId(5);
#if !BEHAVIAC_RELEASE
						node5.SetAgentType("Player");
#endif
						node9.AddChild(node5);
						{
							Wait_bt_Tank_Chase_node7 node7 = new Wait_bt_Tank_Chase_node7();
							node7.SetClassNameString("Wait");
							node7.SetId(7);
#if !BEHAVIAC_RELEASE
							node7.SetAgentType("Player");
#endif
							node5.AddChild(node7);
							node5.SetHasEvents(node5.HasEvents() | node7.HasEvents());
						}
						node9.SetHasEvents(node9.HasEvents() | node5.HasEvents());
					}
					{
						Sequence node8 = new Sequence();
						node8.SetClassNameString("Sequence");
						node8.SetId(8);
#if !BEHAVIAC_RELEASE
						node8.SetAgentType("Player");
#endif
						node9.AddChild(node8);
						{
							Assignment_bt_Tank_Chase_node6 node6 = new Assignment_bt_Tank_Chase_node6();
							node6.SetClassNameString("Assignment");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node8.AddChild(node6);
							node8.SetHasEvents(node8.HasEvents() | node6.HasEvents());
						}
						{
							Assignment_bt_Tank_Chase_node0 node0 = new Assignment_bt_Tank_Chase_node0();
							node0.SetClassNameString("Assignment");
							node0.SetId(0);
#if !BEHAVIAC_RELEASE
							node0.SetAgentType("Player");
#endif
							node8.AddChild(node0);
							node8.SetHasEvents(node8.HasEvents() | node0.HasEvents());
						}
						{
							Action_bt_Tank_Chase_node1 node1 = new Action_bt_Tank_Chase_node1();
							node1.SetClassNameString("Action");
							node1.SetId(1);
#if !BEHAVIAC_RELEASE
							node1.SetAgentType("Player");
#endif
							node8.AddChild(node1);
							node8.SetHasEvents(node8.HasEvents() | node1.HasEvents());
						}
						{
							Action_bt_Tank_Chase_node2 node2 = new Action_bt_Tank_Chase_node2();
							node2.SetClassNameString("Action");
							node2.SetId(2);
#if !BEHAVIAC_RELEASE
							node2.SetAgentType("Player");
#endif
							node8.AddChild(node2);
							node8.SetHasEvents(node8.HasEvents() | node2.HasEvents());
						}
						node9.SetHasEvents(node9.HasEvents() | node8.HasEvents());
					}
					node4.SetHasEvents(node4.HasEvents() | node9.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node4.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Destroy_Enemy

	class DecoratorAlwaysRunning_bt_Tank_Destroy_Enemy_node10 : behaviac.DecoratorAlwaysRunning
	{
		public DecoratorAlwaysRunning_bt_Tank_Destroy_Enemy_node10()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_Destroy_Enemy_node5 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Destroy_Enemy_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(((GameActor)pAgent).force);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
	}

	class Condition_bt_Tank_Destroy_Enemy_node9 : behaviac.Condition
	{
		public Condition_bt_Tank_Destroy_Enemy_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Assignment_bt_Tank_Destroy_Enemy_node7 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Destroy_Enemy_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Action_bt_Tank_Destroy_Enemy_node8 : behaviac.Action
	{
		public Action_bt_Tank_Destroy_Enemy_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			behaviac.Agent pAgent_method_p1 = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_method_p1 != null);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, GameLevelCommon.soilSteelWalkLevel);
			return result;
		}
	}

	class Action_bt_Tank_Destroy_Enemy_node6 : behaviac.Action
	{
		public Action_bt_Tank_Destroy_Enemy_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	class Condition_bt_Tank_Destroy_Enemy_node12 : behaviac.Condition
	{
		public Condition_bt_Tank_Destroy_Enemy_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Action_bt_Tank_Destroy_Enemy_node1 : behaviac.Action
	{
		public Action_bt_Tank_Destroy_Enemy_node1()
		{
			method_p0 = 1;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).canDestroyBrick(method_p0);
			return result;
		}
		int method_p0;
	}

	class Action_bt_Tank_Destroy_Enemy_node3 : behaviac.Action
	{
		public Action_bt_Tank_Destroy_Enemy_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(((GameActor)pAgent).currentOrientation);
			return result;
		}
	}

	class Action_bt_Tank_Destroy_Enemy_node4 : behaviac.Action
	{
		public Action_bt_Tank_Destroy_Enemy_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Destroy_Enemy
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Destroy_Enemy");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			// children
			{
				DecoratorAlwaysRunning_bt_Tank_Destroy_Enemy_node10 node10 = new DecoratorAlwaysRunning_bt_Tank_Destroy_Enemy_node10();
				node10.SetClassNameString("DecoratorAlwaysRunning");
				node10.SetId(10);
#if !BEHAVIAC_RELEASE
				node10.SetAgentType("Player");
#endif
				bt.AddChild(node10);
				{
					Selector node11 = new Selector();
					node11.SetClassNameString("Selector");
					node11.SetId(11);
#if !BEHAVIAC_RELEASE
					node11.SetAgentType("Player");
#endif
					node10.AddChild(node11);
					{
						Sequence node2 = new Sequence();
						node2.SetClassNameString("Sequence");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node11.AddChild(node2);
						{
							Assignment_bt_Tank_Destroy_Enemy_node5 node5 = new Assignment_bt_Tank_Destroy_Enemy_node5();
							node5.SetClassNameString("Assignment");
							node5.SetId(5);
#if !BEHAVIAC_RELEASE
							node5.SetAgentType("Player");
#endif
							node2.AddChild(node5);
							node2.SetHasEvents(node2.HasEvents() | node5.HasEvents());
						}
						{
							Condition_bt_Tank_Destroy_Enemy_node9 node9 = new Condition_bt_Tank_Destroy_Enemy_node9();
							node9.SetClassNameString("Condition");
							node9.SetId(9);
#if !BEHAVIAC_RELEASE
							node9.SetAgentType("Player");
#endif
							node2.AddChild(node9);
							node2.SetHasEvents(node2.HasEvents() | node9.HasEvents());
						}
						{
							Assignment_bt_Tank_Destroy_Enemy_node7 node7 = new Assignment_bt_Tank_Destroy_Enemy_node7();
							node7.SetClassNameString("Assignment");
							node7.SetId(7);
#if !BEHAVIAC_RELEASE
							node7.SetAgentType("Player");
#endif
							node2.AddChild(node7);
							node2.SetHasEvents(node2.HasEvents() | node7.HasEvents());
						}
						{
							Action_bt_Tank_Destroy_Enemy_node8 node8 = new Action_bt_Tank_Destroy_Enemy_node8();
							node8.SetClassNameString("Action");
							node8.SetId(8);
#if !BEHAVIAC_RELEASE
							node8.SetAgentType("Player");
#endif
							node2.AddChild(node8);
							node2.SetHasEvents(node2.HasEvents() | node8.HasEvents());
						}
						{
							Action_bt_Tank_Destroy_Enemy_node6 node6 = new Action_bt_Tank_Destroy_Enemy_node6();
							node6.SetClassNameString("Action");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node2.AddChild(node6);
							node2.SetHasEvents(node2.HasEvents() | node6.HasEvents());
						}
						node11.SetHasEvents(node11.HasEvents() | node2.HasEvents());
					}
					{
						Sequence node0 = new Sequence();
						node0.SetClassNameString("Sequence");
						node0.SetId(0);
#if !BEHAVIAC_RELEASE
						node0.SetAgentType("Player");
#endif
						node11.AddChild(node0);
						{
							Condition_bt_Tank_Destroy_Enemy_node12 node12 = new Condition_bt_Tank_Destroy_Enemy_node12();
							node12.SetClassNameString("Condition");
							node12.SetId(12);
#if !BEHAVIAC_RELEASE
							node12.SetAgentType("Player");
#endif
							node0.AddChild(node12);
							node0.SetHasEvents(node0.HasEvents() | node12.HasEvents());
						}
						{
							Action_bt_Tank_Destroy_Enemy_node1 node1 = new Action_bt_Tank_Destroy_Enemy_node1();
							node1.SetClassNameString("Action");
							node1.SetId(1);
#if !BEHAVIAC_RELEASE
							node1.SetAgentType("Player");
#endif
							node0.AddChild(node1);
							node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
						}
						{
							Action_bt_Tank_Destroy_Enemy_node3 node3 = new Action_bt_Tank_Destroy_Enemy_node3();
							node3.SetClassNameString("Action");
							node3.SetId(3);
#if !BEHAVIAC_RELEASE
							node3.SetAgentType("Player");
#endif
							node0.AddChild(node3);
							node0.SetHasEvents(node0.HasEvents() | node3.HasEvents());
						}
						{
							Action_bt_Tank_Destroy_Enemy_node4 node4 = new Action_bt_Tank_Destroy_Enemy_node4();
							node4.SetClassNameString("Action");
							node4.SetId(4);
#if !BEHAVIAC_RELEASE
							node4.SetAgentType("Player");
#endif
							node0.AddChild(node4);
							node0.SetHasEvents(node0.HasEvents() | node4.HasEvents());
						}
						node11.SetHasEvents(node11.HasEvents() | node0.HasEvents());
					}
					node10.SetHasEvents(node10.HasEvents() | node11.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node10.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Fire

	class DecoratorLoop_bt_Tank_Fire_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Fire_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_Fire_node1 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Fire_node1()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorAlwaysSuccess_bt_Tank_Fire_node5 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Tank_Fire_node5()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class SelectorProbability_bt_Tank_Fire_node2 : behaviac.SelectorProbability
	{
		public SelectorProbability_bt_Tank_Fire_node2()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class DecoratorWeight_bt_Tank_Fire_node6 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Fire_node6()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 70;
		}
	}

	class Action_bt_Tank_Fire_node7 : behaviac.Action
	{
		public Action_bt_Tank_Fire_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class DecoratorWeight_bt_Tank_Fire_node8 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Fire_node8()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 30;
		}
	}

	class Assignment_bt_Tank_Fire_node11 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_node11()
		{
			opr_p1 = eMapDirection.UNKNOWN;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
		eMapDirection opr_p1;
	}

	class Condition_bt_Tank_Fire_node3 : behaviac.Condition
	{
		public Condition_bt_Tank_Fire_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_Fire_node4 : behaviac.Action
	{
		public Action_bt_Tank_Fire_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_Fire_node16 : behaviac.Action
	{
		public Action_bt_Tank_Fire_node16()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Fire
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Fire");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Fire_node0 node0 = new DecoratorLoop_bt_Tank_Fire_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Parallel_bt_Tank_Fire_node1 node1 = new Parallel_bt_Tank_Fire_node1();
					node1.SetClassNameString("Parallel");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						DecoratorAlwaysSuccess_bt_Tank_Fire_node5 node5 = new DecoratorAlwaysSuccess_bt_Tank_Fire_node5();
						node5.SetClassNameString("DecoratorAlwaysSuccess");
						node5.SetId(5);
#if !BEHAVIAC_RELEASE
						node5.SetAgentType("Player");
#endif
						node1.AddChild(node5);
						{
							SelectorProbability_bt_Tank_Fire_node2 node2 = new SelectorProbability_bt_Tank_Fire_node2();
							node2.SetClassNameString("SelectorProbability");
							node2.SetId(2);
#if !BEHAVIAC_RELEASE
							node2.SetAgentType("Player");
#endif
							node5.AddChild(node2);
							{
								DecoratorWeight_bt_Tank_Fire_node6 node6 = new DecoratorWeight_bt_Tank_Fire_node6();
								node6.SetClassNameString("DecoratorWeight");
								node6.SetId(6);
#if !BEHAVIAC_RELEASE
								node6.SetAgentType("Player");
#endif
								node2.AddChild(node6);
								{
									Action_bt_Tank_Fire_node7 node7 = new Action_bt_Tank_Fire_node7();
									node7.SetClassNameString("Action");
									node7.SetId(7);
#if !BEHAVIAC_RELEASE
									node7.SetAgentType("Player");
#endif
									node6.AddChild(node7);
									node6.SetHasEvents(node6.HasEvents() | node7.HasEvents());
								}
								node2.SetHasEvents(node2.HasEvents() | node6.HasEvents());
							}
							{
								DecoratorWeight_bt_Tank_Fire_node8 node8 = new DecoratorWeight_bt_Tank_Fire_node8();
								node8.SetClassNameString("DecoratorWeight");
								node8.SetId(8);
#if !BEHAVIAC_RELEASE
								node8.SetAgentType("Player");
#endif
								node2.AddChild(node8);
								{
									Sequence node9 = new Sequence();
									node9.SetClassNameString("Sequence");
									node9.SetId(9);
#if !BEHAVIAC_RELEASE
									node9.SetAgentType("Player");
#endif
									node8.AddChild(node9);
									{
										Assignment_bt_Tank_Fire_node11 node11 = new Assignment_bt_Tank_Fire_node11();
										node11.SetClassNameString("Assignment");
										node11.SetId(11);
#if !BEHAVIAC_RELEASE
										node11.SetAgentType("Player");
#endif
										node9.AddChild(node11);
										node9.SetHasEvents(node9.HasEvents() | node11.HasEvents());
									}
									{
										Sequence node10 = new Sequence();
										node10.SetClassNameString("Sequence");
										node10.SetId(10);
#if !BEHAVIAC_RELEASE
										node10.SetAgentType("Player");
#endif
										node9.AddChild(node10);
										{
											Condition_bt_Tank_Fire_node3 node3 = new Condition_bt_Tank_Fire_node3();
											node3.SetClassNameString("Condition");
											node3.SetId(3);
#if !BEHAVIAC_RELEASE
											node3.SetAgentType("Player");
#endif
											node10.AddChild(node3);
											node10.SetHasEvents(node10.HasEvents() | node3.HasEvents());
										}
										{
											Action_bt_Tank_Fire_node4 node4 = new Action_bt_Tank_Fire_node4();
											node4.SetClassNameString("Action");
											node4.SetId(4);
#if !BEHAVIAC_RELEASE
											node4.SetAgentType("Player");
#endif
											node10.AddChild(node4);
											node10.SetHasEvents(node10.HasEvents() | node4.HasEvents());
										}
										node9.SetHasEvents(node9.HasEvents() | node10.HasEvents());
									}
									node8.SetHasEvents(node8.HasEvents() | node9.HasEvents());
								}
								node2.SetHasEvents(node2.HasEvents() | node8.HasEvents());
							}
							node5.SetHasEvents(node5.HasEvents() | node2.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node5.HasEvents());
					}
					{
						Action_bt_Tank_Fire_node16 node16 = new Action_bt_Tank_Fire_node16();
						node16.SetClassNameString("Action");
						node16.SetId(16);
#if !BEHAVIAC_RELEASE
						node16.SetAgentType("Player");
#endif
						node1.AddChild(node16);
						node1.SetHasEvents(node1.HasEvents() | node16.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Fire_Detect

	class DecoratorLoop_bt_Tank_Fire_Detect_node5 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Fire_Detect_node5()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Assignment_bt_Tank_Fire_Detect_node0 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Detect_node0()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = (float)((Player)pAgent).detectNearestEnemyInView();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			pAgent.SetVariable("parT_EnemyAzimuth", opr, 2614361194u);
			return result;
		}
	}

	class Condition_bt_Tank_Fire_Detect_node2 : behaviac.Condition
	{
		public Condition_bt_Tank_Fire_Detect_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			float opl = (float)pAgent.GetVariable(2614361194u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_Fire_Detect_node3 : behaviac.Action
	{
		public Action_bt_Tank_Fire_Detect_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_EnemyAzimuth") == 2614361194u);
			float method_p0 = (float)pAgent.GetVariable(2614361194u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_Fire_Detect_node1 : behaviac.Action
	{
		public Action_bt_Tank_Fire_Detect_node1()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Fire_Detect
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Fire_Detect");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("float", "parT_EnemyAzimuth", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Fire_Detect_node5 node5 = new DecoratorLoop_bt_Tank_Fire_Detect_node5();
				node5.SetClassNameString("DecoratorLoop");
				node5.SetId(5);
#if !BEHAVIAC_RELEASE
				node5.SetAgentType("Player");
#endif
				bt.AddChild(node5);
				{
					Sequence node6 = new Sequence();
					node6.SetClassNameString("Sequence");
					node6.SetId(6);
#if !BEHAVIAC_RELEASE
					node6.SetAgentType("Player");
#endif
					node5.AddChild(node6);
					{
						Assignment_bt_Tank_Fire_Detect_node0 node0 = new Assignment_bt_Tank_Fire_Detect_node0();
						node0.SetClassNameString("Assignment");
						node0.SetId(0);
#if !BEHAVIAC_RELEASE
						node0.SetAgentType("Player");
#endif
						node6.AddChild(node0);
						node6.SetHasEvents(node6.HasEvents() | node0.HasEvents());
					}
					{
						Condition_bt_Tank_Fire_Detect_node2 node2 = new Condition_bt_Tank_Fire_Detect_node2();
						node2.SetClassNameString("Condition");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node6.AddChild(node2);
						node6.SetHasEvents(node6.HasEvents() | node2.HasEvents());
					}
					{
						Action_bt_Tank_Fire_Detect_node3 node3 = new Action_bt_Tank_Fire_Detect_node3();
						node3.SetClassNameString("Action");
						node3.SetId(3);
#if !BEHAVIAC_RELEASE
						node3.SetAgentType("Player");
#endif
						node6.AddChild(node3);
						node6.SetHasEvents(node6.HasEvents() | node3.HasEvents());
					}
					{
						Action_bt_Tank_Fire_Detect_node1 node1 = new Action_bt_Tank_Fire_Detect_node1();
						node1.SetClassNameString("Action");
						node1.SetId(1);
#if !BEHAVIAC_RELEASE
						node1.SetAgentType("Player");
#endif
						node6.AddChild(node1);
						node6.SetHasEvents(node6.HasEvents() | node1.HasEvents());
					}
					node5.SetHasEvents(node5.HasEvents() | node6.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node5.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Fire_Only

	class DecoratorLoop_bt_Tank_Fire_Only_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Fire_Only_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Assignment_bt_Tank_Fire_Only_node4 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Only_node4()
		{
			opr_p0 = 1000;
			opr_p1 = 8000;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = (int)((GameLevelCommon)pAgent_opr).randomNumberInt(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_FireInterval") == 1636165819u);
			pAgent.SetVariable("parT_FireInterval", opr, 1636165819u);
			return result;
		}
		int opr_p0;
		int opr_p1;
	}

	class Wait_bt_Tank_Fire_Only_node3 : behaviac.Wait
	{
		public Wait_bt_Tank_Fire_Only_node3()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_FireInterval") == 1636165819u);
			return (int)pAgent.GetVariable(1636165819u);
		}
	}

	class Action_bt_Tank_Fire_Only_node2 : behaviac.Action
	{
		public Action_bt_Tank_Fire_Only_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Fire_Only
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Fire_Only");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("int", "parT_FireInterval", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Fire_Only_node0 node0 = new DecoratorLoop_bt_Tank_Fire_Only_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Sequence node1 = new Sequence();
					node1.SetClassNameString("Sequence");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						Assignment_bt_Tank_Fire_Only_node4 node4 = new Assignment_bt_Tank_Fire_Only_node4();
						node4.SetClassNameString("Assignment");
						node4.SetId(4);
#if !BEHAVIAC_RELEASE
						node4.SetAgentType("Player");
#endif
						node1.AddChild(node4);
						node1.SetHasEvents(node1.HasEvents() | node4.HasEvents());
					}
					{
						Wait_bt_Tank_Fire_Only_node3 node3 = new Wait_bt_Tank_Fire_Only_node3();
						node3.SetClassNameString("Wait");
						node3.SetId(3);
#if !BEHAVIAC_RELEASE
						node3.SetAgentType("Player");
#endif
						node1.AddChild(node3);
						node1.SetHasEvents(node1.HasEvents() | node3.HasEvents());
					}
					{
						Action_bt_Tank_Fire_Only_node2 node2 = new Action_bt_Tank_Fire_Only_node2();
						node2.SetClassNameString("Action");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node1.AddChild(node2);
						node1.SetHasEvents(node1.HasEvents() | node2.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Fire_Random

	class DecoratorLoop_bt_Tank_Fire_Random_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Fire_Random_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class SelectorStochastic_bt_Tank_Fire_Random_node2 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_Fire_Random_node2()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_Fire_Random_node8 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Random_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 180f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Fire_Random_node6 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Random_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 90f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Fire_Random_node7 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Random_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 0f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Fire_Random_node9 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Fire_Random_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 270f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Action_bt_Tank_Fire_Random_node3 : behaviac.Action
	{
		public Action_bt_Tank_Fire_Random_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			float method_p0 = (float)pAgent.GetVariable(3496662299u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_Fire_Random_node10 : behaviac.Action
	{
		public Action_bt_Tank_Fire_Random_node10()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Fire_Random
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Fire_Random");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("float", "parT_AimAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Fire_Random_node0 node0 = new DecoratorLoop_bt_Tank_Fire_Random_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Sequence node1 = new Sequence();
					node1.SetClassNameString("Sequence");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						SelectorStochastic_bt_Tank_Fire_Random_node2 node2 = new SelectorStochastic_bt_Tank_Fire_Random_node2();
						node2.SetClassNameString("SelectorStochastic");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node1.AddChild(node2);
						{
							Assignment_bt_Tank_Fire_Random_node8 node8 = new Assignment_bt_Tank_Fire_Random_node8();
							node8.SetClassNameString("Assignment");
							node8.SetId(8);
#if !BEHAVIAC_RELEASE
							node8.SetAgentType("Player");
#endif
							node2.AddChild(node8);
							node2.SetHasEvents(node2.HasEvents() | node8.HasEvents());
						}
						{
							Assignment_bt_Tank_Fire_Random_node6 node6 = new Assignment_bt_Tank_Fire_Random_node6();
							node6.SetClassNameString("Assignment");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node2.AddChild(node6);
							node2.SetHasEvents(node2.HasEvents() | node6.HasEvents());
						}
						{
							Assignment_bt_Tank_Fire_Random_node7 node7 = new Assignment_bt_Tank_Fire_Random_node7();
							node7.SetClassNameString("Assignment");
							node7.SetId(7);
#if !BEHAVIAC_RELEASE
							node7.SetAgentType("Player");
#endif
							node2.AddChild(node7);
							node2.SetHasEvents(node2.HasEvents() | node7.HasEvents());
						}
						{
							Assignment_bt_Tank_Fire_Random_node9 node9 = new Assignment_bt_Tank_Fire_Random_node9();
							node9.SetClassNameString("Assignment");
							node9.SetId(9);
#if !BEHAVIAC_RELEASE
							node9.SetAgentType("Player");
#endif
							node2.AddChild(node9);
							node2.SetHasEvents(node2.HasEvents() | node9.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node2.HasEvents());
					}
					{
						Action_bt_Tank_Fire_Random_node3 node3 = new Action_bt_Tank_Fire_Random_node3();
						node3.SetClassNameString("Action");
						node3.SetId(3);
#if !BEHAVIAC_RELEASE
						node3.SetAgentType("Player");
#endif
						node1.AddChild(node3);
						node1.SetHasEvents(node1.HasEvents() | node3.HasEvents());
					}
					{
						Action_bt_Tank_Fire_Random_node10 node10 = new Action_bt_Tank_Fire_Random_node10();
						node10.SetClassNameString("Action");
						node10.SetId(10);
#if !BEHAVIAC_RELEASE
						node10.SetAgentType("Player");
#endif
						node1.AddChild(node10);
						node1.SetHasEvents(node1.HasEvents() | node10.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_SafeWander

	class DecoratorAlwaysRunning_bt_Tank_SafeWander_node0 : behaviac.DecoratorAlwaysRunning
	{
		public DecoratorAlwaysRunning_bt_Tank_SafeWander_node0()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_SafeWander_node2 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_node2()
		{
			opr_p0 = eMapDirection.UNKNOWN;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = (eMapDirection)((GameActor)pAgent).getBestMoveDirection(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			pAgent.SetVariable("parT_SafeMoveDirection", opr, 3893705419u);
			return result;
		}
		eMapDirection opr_p0;
	}

	class Action_bt_Tank_SafeWander_node3 : behaviac.Action
	{
		public Action_bt_Tank_SafeWander_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			eMapDirection method_p0 = (eMapDirection)pAgent.GetVariable(3893705419u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveToDirection(method_p0);
			return result;
		}
	}

	public static class bt_Tank_SafeWander
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_SafeWander");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("eMapDirection", "parT_SafeMoveDirection", "UNKNOWN", "");
			// children
			{
				DecoratorAlwaysRunning_bt_Tank_SafeWander_node0 node0 = new DecoratorAlwaysRunning_bt_Tank_SafeWander_node0();
				node0.SetClassNameString("DecoratorAlwaysRunning");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Sequence node1 = new Sequence();
					node1.SetClassNameString("Sequence");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						Assignment_bt_Tank_SafeWander_node2 node2 = new Assignment_bt_Tank_SafeWander_node2();
						node2.SetClassNameString("Assignment");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node1.AddChild(node2);
						node1.SetHasEvents(node1.HasEvents() | node2.HasEvents());
					}
					{
						Action_bt_Tank_SafeWander_node3 node3 = new Action_bt_Tank_SafeWander_node3();
						node3.SetClassNameString("Action");
						node3.SetId(3);
#if !BEHAVIAC_RELEASE
						node3.SetAgentType("Player");
#endif
						node1.AddChild(node3);
						node1.SetHasEvents(node1.HasEvents() | node3.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_SafeWander_RandomFire

	class DecoratorLoop_bt_Tank_SafeWander_RandomFire_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_SafeWander_RandomFire_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_SafeWander_RandomFire_node1 : behaviac.Parallel
	{
		public Parallel_bt_Tank_SafeWander_RandomFire_node1()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class DecoratorLoop_bt_Tank_SafeWander_RandomFire_node9 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_SafeWander_RandomFire_node9()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_SafeWander_RandomFire_node11 : behaviac.Parallel
	{
		public Parallel_bt_Tank_SafeWander_RandomFire_node11()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class SelectorStochastic_bt_Tank_SafeWander_RandomFire_node21 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_SafeWander_RandomFire_node21()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node10 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node10()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.TOP;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node5 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.RIGHT;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node2 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.BOTTOM;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node3 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.LEFT;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			pAgent.SetVariable("parT_RandomMoveDirection", opr, 1696414415u);
			return result;
		}
	}

	class Wait_bt_Tank_SafeWander_RandomFire_node4 : behaviac.Wait
	{
		public Wait_bt_Tank_SafeWander_RandomFire_node4()
		{
			m_ignoreTimeScale = false;
		}
		protected override float GetTime(Agent pAgent)
		{
			return 2000;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node6 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RandomMoveDirection") == 1696414415u);
			eMapDirection opr_p0 = (eMapDirection)pAgent.GetVariable(1696414415u);
			eMapDirection opr = (eMapDirection)((GameActor)pAgent).getBestMoveDirection(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			pAgent.SetVariable("parT_SafeMoveDirection", opr, 3893705419u);
			return result;
		}
	}

	class Action_bt_Tank_SafeWander_RandomFire_node8 : behaviac.Action
	{
		public Action_bt_Tank_SafeWander_RandomFire_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_SafeMoveDirection") == 3893705419u);
			eMapDirection method_p0 = (eMapDirection)pAgent.GetVariable(3893705419u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveToDirection(method_p0);
			return result;
		}
	}

	class SelectorStochastic_bt_Tank_SafeWander_RandomFire_node12 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_SafeWander_RandomFire_node12()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node13 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node13()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 180f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node14 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node14()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 90f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node15 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 0f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_SafeWander_RandomFire_node16 : behaviac.Assignment
	{
		public Assignment_bt_Tank_SafeWander_RandomFire_node16()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 270f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Action_bt_Tank_SafeWander_RandomFire_node17 : behaviac.Action
	{
		public Action_bt_Tank_SafeWander_RandomFire_node17()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			float method_p0 = (float)pAgent.GetVariable(3496662299u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_SafeWander_RandomFire_node18 : behaviac.Action
	{
		public Action_bt_Tank_SafeWander_RandomFire_node18()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_SafeWander_RandomFire
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_SafeWander_RandomFire");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			bt.AddPar("float", "parT_AimAngle", "0", "");
			bt.AddPar("eMapDirection", "parT_SafeMoveDirection", "UNKNOWN", "");
			bt.AddPar("eMapDirection", "parT_RandomMoveDirection", "UNKNOWN", "");
			// children
			{
				DecoratorLoop_bt_Tank_SafeWander_RandomFire_node0 node0 = new DecoratorLoop_bt_Tank_SafeWander_RandomFire_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Parallel_bt_Tank_SafeWander_RandomFire_node1 node1 = new Parallel_bt_Tank_SafeWander_RandomFire_node1();
					node1.SetClassNameString("Parallel");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						DecoratorLoop_bt_Tank_SafeWander_RandomFire_node9 node9 = new DecoratorLoop_bt_Tank_SafeWander_RandomFire_node9();
						node9.SetClassNameString("DecoratorLoop");
						node9.SetId(9);
#if !BEHAVIAC_RELEASE
						node9.SetAgentType("Player");
#endif
						node1.AddChild(node9);
						{
							Parallel_bt_Tank_SafeWander_RandomFire_node11 node11 = new Parallel_bt_Tank_SafeWander_RandomFire_node11();
							node11.SetClassNameString("Parallel");
							node11.SetId(11);
#if !BEHAVIAC_RELEASE
							node11.SetAgentType("Player");
#endif
							node9.AddChild(node11);
							{
								Sequence node7 = new Sequence();
								node7.SetClassNameString("Sequence");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("Player");
#endif
								node11.AddChild(node7);
								{
									SelectorStochastic_bt_Tank_SafeWander_RandomFire_node21 node21 = new SelectorStochastic_bt_Tank_SafeWander_RandomFire_node21();
									node21.SetClassNameString("SelectorStochastic");
									node21.SetId(21);
#if !BEHAVIAC_RELEASE
									node21.SetAgentType("Player");
#endif
									node7.AddChild(node21);
									{
										Assignment_bt_Tank_SafeWander_RandomFire_node10 node10 = new Assignment_bt_Tank_SafeWander_RandomFire_node10();
										node10.SetClassNameString("Assignment");
										node10.SetId(10);
#if !BEHAVIAC_RELEASE
										node10.SetAgentType("Player");
#endif
										node21.AddChild(node10);
										node21.SetHasEvents(node21.HasEvents() | node10.HasEvents());
									}
									{
										Assignment_bt_Tank_SafeWander_RandomFire_node5 node5 = new Assignment_bt_Tank_SafeWander_RandomFire_node5();
										node5.SetClassNameString("Assignment");
										node5.SetId(5);
#if !BEHAVIAC_RELEASE
										node5.SetAgentType("Player");
#endif
										node21.AddChild(node5);
										node21.SetHasEvents(node21.HasEvents() | node5.HasEvents());
									}
									{
										Assignment_bt_Tank_SafeWander_RandomFire_node2 node2 = new Assignment_bt_Tank_SafeWander_RandomFire_node2();
										node2.SetClassNameString("Assignment");
										node2.SetId(2);
#if !BEHAVIAC_RELEASE
										node2.SetAgentType("Player");
#endif
										node21.AddChild(node2);
										node21.SetHasEvents(node21.HasEvents() | node2.HasEvents());
									}
									{
										Assignment_bt_Tank_SafeWander_RandomFire_node3 node3 = new Assignment_bt_Tank_SafeWander_RandomFire_node3();
										node3.SetClassNameString("Assignment");
										node3.SetId(3);
#if !BEHAVIAC_RELEASE
										node3.SetAgentType("Player");
#endif
										node21.AddChild(node3);
										node21.SetHasEvents(node21.HasEvents() | node3.HasEvents());
									}
									node7.SetHasEvents(node7.HasEvents() | node21.HasEvents());
								}
								{
									Wait_bt_Tank_SafeWander_RandomFire_node4 node4 = new Wait_bt_Tank_SafeWander_RandomFire_node4();
									node4.SetClassNameString("Wait");
									node4.SetId(4);
#if !BEHAVIAC_RELEASE
									node4.SetAgentType("Player");
#endif
									node7.AddChild(node4);
									node7.SetHasEvents(node7.HasEvents() | node4.HasEvents());
								}
								node11.SetHasEvents(node11.HasEvents() | node7.HasEvents());
							}
							{
								Sequence node19 = new Sequence();
								node19.SetClassNameString("Sequence");
								node19.SetId(19);
#if !BEHAVIAC_RELEASE
								node19.SetAgentType("Player");
#endif
								node11.AddChild(node19);
								{
									Assignment_bt_Tank_SafeWander_RandomFire_node6 node6 = new Assignment_bt_Tank_SafeWander_RandomFire_node6();
									node6.SetClassNameString("Assignment");
									node6.SetId(6);
#if !BEHAVIAC_RELEASE
									node6.SetAgentType("Player");
#endif
									node19.AddChild(node6);
									node19.SetHasEvents(node19.HasEvents() | node6.HasEvents());
								}
								{
									Action_bt_Tank_SafeWander_RandomFire_node8 node8 = new Action_bt_Tank_SafeWander_RandomFire_node8();
									node8.SetClassNameString("Action");
									node8.SetId(8);
#if !BEHAVIAC_RELEASE
									node8.SetAgentType("Player");
#endif
									node19.AddChild(node8);
									node19.SetHasEvents(node19.HasEvents() | node8.HasEvents());
								}
								node11.SetHasEvents(node11.HasEvents() | node19.HasEvents());
							}
							node9.SetHasEvents(node9.HasEvents() | node11.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node9.HasEvents());
					}
					{
						Sequence node22 = new Sequence();
						node22.SetClassNameString("Sequence");
						node22.SetId(22);
#if !BEHAVIAC_RELEASE
						node22.SetAgentType("Player");
#endif
						node1.AddChild(node22);
						{
							SelectorStochastic_bt_Tank_SafeWander_RandomFire_node12 node12 = new SelectorStochastic_bt_Tank_SafeWander_RandomFire_node12();
							node12.SetClassNameString("SelectorStochastic");
							node12.SetId(12);
#if !BEHAVIAC_RELEASE
							node12.SetAgentType("Player");
#endif
							node22.AddChild(node12);
							{
								Assignment_bt_Tank_SafeWander_RandomFire_node13 node13 = new Assignment_bt_Tank_SafeWander_RandomFire_node13();
								node13.SetClassNameString("Assignment");
								node13.SetId(13);
#if !BEHAVIAC_RELEASE
								node13.SetAgentType("Player");
#endif
								node12.AddChild(node13);
								node12.SetHasEvents(node12.HasEvents() | node13.HasEvents());
							}
							{
								Assignment_bt_Tank_SafeWander_RandomFire_node14 node14 = new Assignment_bt_Tank_SafeWander_RandomFire_node14();
								node14.SetClassNameString("Assignment");
								node14.SetId(14);
#if !BEHAVIAC_RELEASE
								node14.SetAgentType("Player");
#endif
								node12.AddChild(node14);
								node12.SetHasEvents(node12.HasEvents() | node14.HasEvents());
							}
							{
								Assignment_bt_Tank_SafeWander_RandomFire_node15 node15 = new Assignment_bt_Tank_SafeWander_RandomFire_node15();
								node15.SetClassNameString("Assignment");
								node15.SetId(15);
#if !BEHAVIAC_RELEASE
								node15.SetAgentType("Player");
#endif
								node12.AddChild(node15);
								node12.SetHasEvents(node12.HasEvents() | node15.HasEvents());
							}
							{
								Assignment_bt_Tank_SafeWander_RandomFire_node16 node16 = new Assignment_bt_Tank_SafeWander_RandomFire_node16();
								node16.SetClassNameString("Assignment");
								node16.SetId(16);
#if !BEHAVIAC_RELEASE
								node16.SetAgentType("Player");
#endif
								node12.AddChild(node16);
								node12.SetHasEvents(node12.HasEvents() | node16.HasEvents());
							}
							node22.SetHasEvents(node22.HasEvents() | node12.HasEvents());
						}
						{
							Action_bt_Tank_SafeWander_RandomFire_node17 node17 = new Action_bt_Tank_SafeWander_RandomFire_node17();
							node17.SetClassNameString("Action");
							node17.SetId(17);
#if !BEHAVIAC_RELEASE
							node17.SetAgentType("Player");
#endif
							node22.AddChild(node17);
							node22.SetHasEvents(node22.HasEvents() | node17.HasEvents());
						}
						{
							Action_bt_Tank_SafeWander_RandomFire_node18 node18 = new Action_bt_Tank_SafeWander_RandomFire_node18();
							node18.SetClassNameString("Action");
							node18.SetId(18);
#if !BEHAVIAC_RELEASE
							node18.SetAgentType("Player");
#endif
							node22.AddChild(node18);
							node22.SetHasEvents(node22.HasEvents() | node18.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node22.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Take_Award_Destroy_Enemy

	class DecoratorAlwaysRunning_bt_Tank_Take_Award_Destroy_Enemy_node10 : behaviac.DecoratorAlwaysRunning
	{
		public DecoratorAlwaysRunning_bt_Tank_Take_Award_Destroy_Enemy_node10()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node18 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node18()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(((GameActor)pAgent).force);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
	}

	class Condition_bt_Tank_Take_Award_Destroy_Enemy_node19 : behaviac.Condition
	{
		public Condition_bt_Tank_Take_Award_Destroy_Enemy_node19()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node20 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node20()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Condition_bt_Tank_Take_Award_Destroy_Enemy_node14 : behaviac.Condition
	{
		public Condition_bt_Tank_Take_Award_Destroy_Enemy_node14()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			int opl = ((Player)pAgent).damageLevel;
			int opr = 1;
			bool op = opl > opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node15 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = GameLevelCommon.soilSteelWalkLevel;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			pAgent.SetVariable("parT_PathFindLevel", opr, 3496548986u);
			return result;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node16 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node16()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = GameLevelCommon.soilWalkLevel;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			pAgent.SetVariable("parT_PathFindLevel", opr, 3496548986u);
			return result;
		}
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node8 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			int method_p1 = (int)pAgent.GetVariable(3496548986u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, method_p1);
			return result;
		}
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node29 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node29()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node28 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node28()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = (int)((GameLevelCommon)pAgent_opr).getNearestAwardID();
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			pAgent.SetVariable("parT_AwardID", opr, 2554131854u);
			return result;
		}
	}

	class Condition_bt_Tank_Take_Award_Destroy_Enemy_node34 : behaviac.Condition
	{
		public Condition_bt_Tank_Take_Award_Destroy_Enemy_node34()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			int opl = (int)pAgent.GetVariable(2554131854u);
			int opr = -1;
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node37 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node37()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AwardID") == 2554131854u);
			int opr_p0 = (int)pAgent.GetVariable(2554131854u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getAwardPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavTargetPosition") == 2368420228u);
			pAgent.SetVariable("parT_NavTargetPosition", opr, 2368420228u);
			return result;
		}
	}

	class Condition_bt_Tank_Take_Award_Destroy_Enemy_node24 : behaviac.Condition
	{
		public Condition_bt_Tank_Take_Award_Destroy_Enemy_node24()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			int opl = ((Player)pAgent).damageLevel;
			int opr = 1;
			bool op = opl > opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node25 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node25()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = GameLevelCommon.soilSteelWalkLevel;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			pAgent.SetVariable("parT_PathFindLevel", opr, 3496548986u);
			return result;
		}
	}

	class Assignment_bt_Tank_Take_Award_Destroy_Enemy_node26 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Take_Award_Destroy_Enemy_node26()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			int opr = GameLevelCommon.soilWalkLevel;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			pAgent.SetVariable("parT_PathFindLevel", opr, 3496548986u);
			return result;
		}
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node21 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node21()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_NavTargetPosition") == 2368420228u);
			UnityEngine.Vector3 method_p0 = (UnityEngine.Vector3)pAgent.GetVariable(2368420228u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_PathFindLevel") == 3496548986u);
			int method_p1 = (int)pAgent.GetVariable(3496548986u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).findPath(method_p0, method_p1);
			return result;
		}
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node30 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node30()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).navigate();
			return result;
		}
	}

	class Condition_bt_Tank_Take_Award_Destroy_Enemy_node12 : behaviac.Condition
	{
		public Condition_bt_Tank_Take_Award_Destroy_Enemy_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node1 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node1()
		{
			method_p0 = 1;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).canDestroyBrick(method_p0);
			return result;
		}
		int method_p0;
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node3 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(((GameActor)pAgent).currentOrientation);
			return result;
		}
	}

	class Action_bt_Tank_Take_Award_Destroy_Enemy_node4 : behaviac.Action
	{
		public Action_bt_Tank_Take_Award_Destroy_Enemy_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_Take_Award_Destroy_Enemy
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Take_Award_Destroy_Enemy");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			bt.AddPar("int", "parT_PathFindLevel", "0", "");
			bt.AddPar("UnityEngine.Vector3", "parT_NavTargetPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("int", "parT_AwardID", "0", "");
			// children
			{
				DecoratorAlwaysRunning_bt_Tank_Take_Award_Destroy_Enemy_node10 node10 = new DecoratorAlwaysRunning_bt_Tank_Take_Award_Destroy_Enemy_node10();
				node10.SetClassNameString("DecoratorAlwaysRunning");
				node10.SetId(10);
#if !BEHAVIAC_RELEASE
				node10.SetAgentType("Player");
#endif
				bt.AddChild(node10);
				{
					Selector node11 = new Selector();
					node11.SetClassNameString("Selector");
					node11.SetId(11);
#if !BEHAVIAC_RELEASE
					node11.SetAgentType("Player");
#endif
					node10.AddChild(node11);
					{
						Sequence node17 = new Sequence();
						node17.SetClassNameString("Sequence");
						node17.SetId(17);
#if !BEHAVIAC_RELEASE
						node17.SetAgentType("Player");
#endif
						node11.AddChild(node17);
						{
							Assignment_bt_Tank_Take_Award_Destroy_Enemy_node18 node18 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node18();
							node18.SetClassNameString("Assignment");
							node18.SetId(18);
#if !BEHAVIAC_RELEASE
							node18.SetAgentType("Player");
#endif
							node17.AddChild(node18);
							node17.SetHasEvents(node17.HasEvents() | node18.HasEvents());
						}
						{
							Condition_bt_Tank_Take_Award_Destroy_Enemy_node19 node19 = new Condition_bt_Tank_Take_Award_Destroy_Enemy_node19();
							node19.SetClassNameString("Condition");
							node19.SetId(19);
#if !BEHAVIAC_RELEASE
							node19.SetAgentType("Player");
#endif
							node17.AddChild(node19);
							node17.SetHasEvents(node17.HasEvents() | node19.HasEvents());
						}
						{
							Assignment_bt_Tank_Take_Award_Destroy_Enemy_node20 node20 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node20();
							node20.SetClassNameString("Assignment");
							node20.SetId(20);
#if !BEHAVIAC_RELEASE
							node20.SetAgentType("Player");
#endif
							node17.AddChild(node20);
							node17.SetHasEvents(node17.HasEvents() | node20.HasEvents());
						}
						{
							IfElse node13 = new IfElse();
							node13.SetClassNameString("IfElse");
							node13.SetId(13);
#if !BEHAVIAC_RELEASE
							node13.SetAgentType("Player");
#endif
							node17.AddChild(node13);
							{
								Condition_bt_Tank_Take_Award_Destroy_Enemy_node14 node14 = new Condition_bt_Tank_Take_Award_Destroy_Enemy_node14();
								node14.SetClassNameString("Condition");
								node14.SetId(14);
#if !BEHAVIAC_RELEASE
								node14.SetAgentType("Player");
#endif
								node13.AddChild(node14);
								node13.SetHasEvents(node13.HasEvents() | node14.HasEvents());
							}
							{
								Assignment_bt_Tank_Take_Award_Destroy_Enemy_node15 node15 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node15();
								node15.SetClassNameString("Assignment");
								node15.SetId(15);
#if !BEHAVIAC_RELEASE
								node15.SetAgentType("Player");
#endif
								node13.AddChild(node15);
								node13.SetHasEvents(node13.HasEvents() | node15.HasEvents());
							}
							{
								Assignment_bt_Tank_Take_Award_Destroy_Enemy_node16 node16 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node16();
								node16.SetClassNameString("Assignment");
								node16.SetId(16);
#if !BEHAVIAC_RELEASE
								node16.SetAgentType("Player");
#endif
								node13.AddChild(node16);
								node13.SetHasEvents(node13.HasEvents() | node16.HasEvents());
							}
							node17.SetHasEvents(node17.HasEvents() | node13.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node8 node8 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node8();
							node8.SetClassNameString("Action");
							node8.SetId(8);
#if !BEHAVIAC_RELEASE
							node8.SetAgentType("Player");
#endif
							node17.AddChild(node8);
							node17.SetHasEvents(node17.HasEvents() | node8.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node29 node29 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node29();
							node29.SetClassNameString("Action");
							node29.SetId(29);
#if !BEHAVIAC_RELEASE
							node29.SetAgentType("Player");
#endif
							node17.AddChild(node29);
							node17.SetHasEvents(node17.HasEvents() | node29.HasEvents());
						}
						node11.SetHasEvents(node11.HasEvents() | node17.HasEvents());
					}
					{
						Sequence node27 = new Sequence();
						node27.SetClassNameString("Sequence");
						node27.SetId(27);
#if !BEHAVIAC_RELEASE
						node27.SetAgentType("Player");
#endif
						node11.AddChild(node27);
						{
							Assignment_bt_Tank_Take_Award_Destroy_Enemy_node28 node28 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node28();
							node28.SetClassNameString("Assignment");
							node28.SetId(28);
#if !BEHAVIAC_RELEASE
							node28.SetAgentType("Player");
#endif
							node27.AddChild(node28);
							node27.SetHasEvents(node27.HasEvents() | node28.HasEvents());
						}
						{
							Condition_bt_Tank_Take_Award_Destroy_Enemy_node34 node34 = new Condition_bt_Tank_Take_Award_Destroy_Enemy_node34();
							node34.SetClassNameString("Condition");
							node34.SetId(34);
#if !BEHAVIAC_RELEASE
							node34.SetAgentType("Player");
#endif
							node27.AddChild(node34);
							node27.SetHasEvents(node27.HasEvents() | node34.HasEvents());
						}
						{
							Assignment_bt_Tank_Take_Award_Destroy_Enemy_node37 node37 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node37();
							node37.SetClassNameString("Assignment");
							node37.SetId(37);
#if !BEHAVIAC_RELEASE
							node37.SetAgentType("Player");
#endif
							node27.AddChild(node37);
							node27.SetHasEvents(node27.HasEvents() | node37.HasEvents());
						}
						{
							IfElse node23 = new IfElse();
							node23.SetClassNameString("IfElse");
							node23.SetId(23);
#if !BEHAVIAC_RELEASE
							node23.SetAgentType("Player");
#endif
							node27.AddChild(node23);
							{
								Condition_bt_Tank_Take_Award_Destroy_Enemy_node24 node24 = new Condition_bt_Tank_Take_Award_Destroy_Enemy_node24();
								node24.SetClassNameString("Condition");
								node24.SetId(24);
#if !BEHAVIAC_RELEASE
								node24.SetAgentType("Player");
#endif
								node23.AddChild(node24);
								node23.SetHasEvents(node23.HasEvents() | node24.HasEvents());
							}
							{
								Assignment_bt_Tank_Take_Award_Destroy_Enemy_node25 node25 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node25();
								node25.SetClassNameString("Assignment");
								node25.SetId(25);
#if !BEHAVIAC_RELEASE
								node25.SetAgentType("Player");
#endif
								node23.AddChild(node25);
								node23.SetHasEvents(node23.HasEvents() | node25.HasEvents());
							}
							{
								Assignment_bt_Tank_Take_Award_Destroy_Enemy_node26 node26 = new Assignment_bt_Tank_Take_Award_Destroy_Enemy_node26();
								node26.SetClassNameString("Assignment");
								node26.SetId(26);
#if !BEHAVIAC_RELEASE
								node26.SetAgentType("Player");
#endif
								node23.AddChild(node26);
								node23.SetHasEvents(node23.HasEvents() | node26.HasEvents());
							}
							node27.SetHasEvents(node27.HasEvents() | node23.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node21 node21 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node21();
							node21.SetClassNameString("Action");
							node21.SetId(21);
#if !BEHAVIAC_RELEASE
							node21.SetAgentType("Player");
#endif
							node27.AddChild(node21);
							node27.SetHasEvents(node27.HasEvents() | node21.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node30 node30 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node30();
							node30.SetClassNameString("Action");
							node30.SetId(30);
#if !BEHAVIAC_RELEASE
							node30.SetAgentType("Player");
#endif
							node27.AddChild(node30);
							node27.SetHasEvents(node27.HasEvents() | node30.HasEvents());
						}
						node11.SetHasEvents(node11.HasEvents() | node27.HasEvents());
					}
					{
						Sequence node2 = new Sequence();
						node2.SetClassNameString("Sequence");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node11.AddChild(node2);
						{
							Condition_bt_Tank_Take_Award_Destroy_Enemy_node12 node12 = new Condition_bt_Tank_Take_Award_Destroy_Enemy_node12();
							node12.SetClassNameString("Condition");
							node12.SetId(12);
#if !BEHAVIAC_RELEASE
							node12.SetAgentType("Player");
#endif
							node2.AddChild(node12);
							node2.SetHasEvents(node2.HasEvents() | node12.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node1 node1 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node1();
							node1.SetClassNameString("Action");
							node1.SetId(1);
#if !BEHAVIAC_RELEASE
							node1.SetAgentType("Player");
#endif
							node2.AddChild(node1);
							node2.SetHasEvents(node2.HasEvents() | node1.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node3 node3 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node3();
							node3.SetClassNameString("Action");
							node3.SetId(3);
#if !BEHAVIAC_RELEASE
							node3.SetAgentType("Player");
#endif
							node2.AddChild(node3);
							node2.SetHasEvents(node2.HasEvents() | node3.HasEvents());
						}
						{
							Action_bt_Tank_Take_Award_Destroy_Enemy_node4 node4 = new Action_bt_Tank_Take_Award_Destroy_Enemy_node4();
							node4.SetClassNameString("Action");
							node4.SetId(4);
#if !BEHAVIAC_RELEASE
							node4.SetAgentType("Player");
#endif
							node2.AddChild(node4);
							node2.SetHasEvents(node2.HasEvents() | node4.HasEvents());
						}
						node11.SetHasEvents(node11.HasEvents() | node2.HasEvents());
					}
					node10.SetHasEvents(node10.HasEvents() | node11.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node10.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_TendencyWander

	class DecoratorLoop_bt_Tank_TendencyWander_node16 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_TendencyWander_node16()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class SelectorProbability_bt_Tank_TendencyWander_node17 : behaviac.SelectorProbability
	{
		public SelectorProbability_bt_Tank_TendencyWander_node17()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class DecoratorWeight_bt_Tank_TendencyWander_node2 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_TendencyWander_node2()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 70;
		}
	}

	class Action_bt_Tank_TendencyWander_node6 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class DecoratorWeight_bt_Tank_TendencyWander_node7 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_TendencyWander_node7()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 30;
		}
	}

	class Assignment_bt_Tank_TendencyWander_node8 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.UNKNOWN;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			pAgent.SetVariable("parT_TendencyDirection", opr, 2737250380u);
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Tank_TendencyWander_node11 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Tank_TendencyWander_node11()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_TendencyWander_node15 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(((GameActor)pAgent).force);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
	}

	class Condition_bt_Tank_TendencyWander_node13 : behaviac.Condition
	{
		public Condition_bt_Tank_TendencyWander_node13()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Assignment_bt_Tank_TendencyWander_node5 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_node12 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 opr_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			eMapDirection opr = (eMapDirection)((Player)pAgent).locationTendencyToTarget(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			pAgent.SetVariable("parT_TendencyDirection", opr, 2737250380u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_node10 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_node10()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			eMapDirection opr_p1 = (eMapDirection)pAgent.GetVariable(2737250380u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
	}

	class Condition_bt_Tank_TendencyWander_node9 : behaviac.Condition
	{
		public Condition_bt_Tank_TendencyWander_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_TendencyWander_node3 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	public static class bt_Tank_TendencyWander
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_TendencyWander");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("eMapDirection", "parT_TendencyDirection", "UNKNOWN", "");
			// children
			{
				DecoratorLoop_bt_Tank_TendencyWander_node16 node16 = new DecoratorLoop_bt_Tank_TendencyWander_node16();
				node16.SetClassNameString("DecoratorLoop");
				node16.SetId(16);
#if !BEHAVIAC_RELEASE
				node16.SetAgentType("Player");
#endif
				bt.AddChild(node16);
				{
					SelectorProbability_bt_Tank_TendencyWander_node17 node17 = new SelectorProbability_bt_Tank_TendencyWander_node17();
					node17.SetClassNameString("SelectorProbability");
					node17.SetId(17);
#if !BEHAVIAC_RELEASE
					node17.SetAgentType("Player");
#endif
					node16.AddChild(node17);
					{
						DecoratorWeight_bt_Tank_TendencyWander_node2 node2 = new DecoratorWeight_bt_Tank_TendencyWander_node2();
						node2.SetClassNameString("DecoratorWeight");
						node2.SetId(2);
#if !BEHAVIAC_RELEASE
						node2.SetAgentType("Player");
#endif
						node17.AddChild(node2);
						{
							Action_bt_Tank_TendencyWander_node6 node6 = new Action_bt_Tank_TendencyWander_node6();
							node6.SetClassNameString("Action");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node2.AddChild(node6);
							node2.SetHasEvents(node2.HasEvents() | node6.HasEvents());
						}
						node17.SetHasEvents(node17.HasEvents() | node2.HasEvents());
					}
					{
						DecoratorWeight_bt_Tank_TendencyWander_node7 node7 = new DecoratorWeight_bt_Tank_TendencyWander_node7();
						node7.SetClassNameString("DecoratorWeight");
						node7.SetId(7);
#if !BEHAVIAC_RELEASE
						node7.SetAgentType("Player");
#endif
						node17.AddChild(node7);
						{
							Sequence node0 = new Sequence();
							node0.SetClassNameString("Sequence");
							node0.SetId(0);
#if !BEHAVIAC_RELEASE
							node0.SetAgentType("Player");
#endif
							node7.AddChild(node0);
							{
								Assignment_bt_Tank_TendencyWander_node8 node8 = new Assignment_bt_Tank_TendencyWander_node8();
								node8.SetClassNameString("Assignment");
								node8.SetId(8);
#if !BEHAVIAC_RELEASE
								node8.SetAgentType("Player");
#endif
								node0.AddChild(node8);
								node0.SetHasEvents(node0.HasEvents() | node8.HasEvents());
							}
							{
								DecoratorAlwaysSuccess_bt_Tank_TendencyWander_node11 node11 = new DecoratorAlwaysSuccess_bt_Tank_TendencyWander_node11();
								node11.SetClassNameString("DecoratorAlwaysSuccess");
								node11.SetId(11);
#if !BEHAVIAC_RELEASE
								node11.SetAgentType("Player");
#endif
								node0.AddChild(node11);
								{
									Sequence node14 = new Sequence();
									node14.SetClassNameString("Sequence");
									node14.SetId(14);
#if !BEHAVIAC_RELEASE
									node14.SetAgentType("Player");
#endif
									node11.AddChild(node14);
									{
										Assignment_bt_Tank_TendencyWander_node15 node15 = new Assignment_bt_Tank_TendencyWander_node15();
										node15.SetClassNameString("Assignment");
										node15.SetId(15);
#if !BEHAVIAC_RELEASE
										node15.SetAgentType("Player");
#endif
										node14.AddChild(node15);
										node14.SetHasEvents(node14.HasEvents() | node15.HasEvents());
									}
									{
										Condition_bt_Tank_TendencyWander_node13 node13 = new Condition_bt_Tank_TendencyWander_node13();
										node13.SetClassNameString("Condition");
										node13.SetId(13);
#if !BEHAVIAC_RELEASE
										node13.SetAgentType("Player");
#endif
										node14.AddChild(node13);
										node14.SetHasEvents(node14.HasEvents() | node13.HasEvents());
									}
									{
										Assignment_bt_Tank_TendencyWander_node5 node5 = new Assignment_bt_Tank_TendencyWander_node5();
										node5.SetClassNameString("Assignment");
										node5.SetId(5);
#if !BEHAVIAC_RELEASE
										node5.SetAgentType("Player");
#endif
										node14.AddChild(node5);
										node14.SetHasEvents(node14.HasEvents() | node5.HasEvents());
									}
									{
										Assignment_bt_Tank_TendencyWander_node12 node12 = new Assignment_bt_Tank_TendencyWander_node12();
										node12.SetClassNameString("Assignment");
										node12.SetId(12);
#if !BEHAVIAC_RELEASE
										node12.SetAgentType("Player");
#endif
										node14.AddChild(node12);
										node14.SetHasEvents(node14.HasEvents() | node12.HasEvents());
									}
									node11.SetHasEvents(node11.HasEvents() | node14.HasEvents());
								}
								node0.SetHasEvents(node0.HasEvents() | node11.HasEvents());
							}
							{
								Assignment_bt_Tank_TendencyWander_node10 node10 = new Assignment_bt_Tank_TendencyWander_node10();
								node10.SetClassNameString("Assignment");
								node10.SetId(10);
#if !BEHAVIAC_RELEASE
								node10.SetAgentType("Player");
#endif
								node0.AddChild(node10);
								node0.SetHasEvents(node0.HasEvents() | node10.HasEvents());
							}
							{
								Sequence node1 = new Sequence();
								node1.SetClassNameString("Sequence");
								node1.SetId(1);
#if !BEHAVIAC_RELEASE
								node1.SetAgentType("Player");
#endif
								node0.AddChild(node1);
								{
									Condition_bt_Tank_TendencyWander_node9 node9 = new Condition_bt_Tank_TendencyWander_node9();
									node9.SetClassNameString("Condition");
									node9.SetId(9);
#if !BEHAVIAC_RELEASE
									node9.SetAgentType("Player");
#endif
									node1.AddChild(node9);
									node1.SetHasEvents(node1.HasEvents() | node9.HasEvents());
								}
								{
									Action_bt_Tank_TendencyWander_node3 node3 = new Action_bt_Tank_TendencyWander_node3();
									node3.SetClassNameString("Action");
									node3.SetId(3);
#if !BEHAVIAC_RELEASE
									node3.SetAgentType("Player");
#endif
									node1.AddChild(node3);
									node1.SetHasEvents(node1.HasEvents() | node3.HasEvents());
								}
								node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
							}
							node7.SetHasEvents(node7.HasEvents() | node0.HasEvents());
						}
						node17.SetHasEvents(node17.HasEvents() | node7.HasEvents());
					}
					node16.SetHasEvents(node16.HasEvents() | node17.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node16.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_TendencyWander_RandomFire

	class DecoratorLoop_bt_Tank_TendencyWander_RandomFire_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_TendencyWander_RandomFire_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_TendencyWander_RandomFire_node1 : behaviac.Parallel
	{
		public Parallel_bt_Tank_TendencyWander_RandomFire_node1()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ALL;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class SelectorProbability_bt_Tank_TendencyWander_RandomFire_node4 : behaviac.SelectorProbability
	{
		public SelectorProbability_bt_Tank_TendencyWander_RandomFire_node4()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node16 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node16()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 70;
		}
	}

	class Action_bt_Tank_TendencyWander_RandomFire_node2 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_RandomFire_node2()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node6 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node6()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 30;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node17 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node17()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			eMapDirection opr = eMapDirection.UNKNOWN;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			pAgent.SetVariable("parT_TendencyDirection", opr, 2737250380u);
			return result;
		}
	}

	class DecoratorAlwaysSuccess_bt_Tank_TendencyWander_RandomFire_node8 : behaviac.DecoratorAlwaysSuccess
	{
		public DecoratorAlwaysSuccess_bt_Tank_TendencyWander_RandomFire_node8()
		{
			m_bDecorateWhenChildEnds = false;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node14 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node14()
		{
			opr_p0 = eGameForce.RED_FORCE;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			behaviac.Agent opr = (behaviac.Agent)((GameLevelCommon)pAgent_opr).getNearestEnemy(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			pAgent.SetVariable("parT_nearestEnemy", opr, 575719424u);
			return result;
		}
		eGameForce opr_p0;
	}

	class Condition_bt_Tank_TendencyWander_RandomFire_node15 : behaviac.Condition
	{
		public Condition_bt_Tank_TendencyWander_RandomFire_node15()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opl = (behaviac.Agent)pAgent.GetVariable(575719424u);
			bool op = opl != opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
		behaviac.Agent opr = null;
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node13 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node13()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_nearestEnemy") == 575719424u);
			behaviac.Agent opr_p0 = (behaviac.Agent)pAgent.GetVariable(575719424u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			UnityEngine.Vector3 opr = (UnityEngine.Vector3)((GameLevelCommon)pAgent_opr).getEnemyPosition(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			pAgent.SetVariable("parT_enemyPosition", opr, 1980067727u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node5 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node5()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_enemyPosition") == 1980067727u);
			UnityEngine.Vector3 opr_p0 = (UnityEngine.Vector3)pAgent.GetVariable(1980067727u);
			eMapDirection opr = (eMapDirection)((Player)pAgent).locationTendencyToTarget(opr_p0);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			pAgent.SetVariable("parT_TendencyDirection", opr, 2737250380u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node12 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_TendencyDirection") == 2737250380u);
			eMapDirection opr_p1 = (eMapDirection)pAgent.GetVariable(2737250380u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
	}

	class Condition_bt_Tank_TendencyWander_RandomFire_node18 : behaviac.Condition
	{
		public Condition_bt_Tank_TendencyWander_RandomFire_node18()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_TendencyWander_RandomFire_node9 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_RandomFire_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	class SelectorStochastic_bt_Tank_TendencyWander_RandomFire_node3 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_TendencyWander_RandomFire_node3()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node19 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node19()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 180f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node20 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node20()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 90f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node21 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node21()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 0f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_TendencyWander_RandomFire_node22 : behaviac.Assignment
	{
		public Assignment_bt_Tank_TendencyWander_RandomFire_node22()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 270f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Action_bt_Tank_TendencyWander_RandomFire_node23 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_RandomFire_node23()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			float method_p0 = (float)pAgent.GetVariable(3496662299u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_TendencyWander_RandomFire_node24 : behaviac.Action
	{
		public Action_bt_Tank_TendencyWander_RandomFire_node24()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	public static class bt_Tank_TendencyWander_RandomFire
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_TendencyWander_RandomFire");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			bt.AddPar("behaviac.Agent", "parT_nearestEnemy", "null", "");
			bt.AddPar("UnityEngine.Vector3", "parT_enemyPosition", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("eMapDirection", "parT_TendencyDirection", "UNKNOWN", "");
			bt.AddPar("float", "parT_AimAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_TendencyWander_RandomFire_node0 node0 = new DecoratorLoop_bt_Tank_TendencyWander_RandomFire_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Parallel_bt_Tank_TendencyWander_RandomFire_node1 node1 = new Parallel_bt_Tank_TendencyWander_RandomFire_node1();
					node1.SetClassNameString("Parallel");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						SelectorProbability_bt_Tank_TendencyWander_RandomFire_node4 node4 = new SelectorProbability_bt_Tank_TendencyWander_RandomFire_node4();
						node4.SetClassNameString("SelectorProbability");
						node4.SetId(4);
#if !BEHAVIAC_RELEASE
						node4.SetAgentType("Player");
#endif
						node1.AddChild(node4);
						{
							DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node16 node16 = new DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node16();
							node16.SetClassNameString("DecoratorWeight");
							node16.SetId(16);
#if !BEHAVIAC_RELEASE
							node16.SetAgentType("Player");
#endif
							node4.AddChild(node16);
							{
								Action_bt_Tank_TendencyWander_RandomFire_node2 node2 = new Action_bt_Tank_TendencyWander_RandomFire_node2();
								node2.SetClassNameString("Action");
								node2.SetId(2);
#if !BEHAVIAC_RELEASE
								node2.SetAgentType("Player");
#endif
								node16.AddChild(node2);
								node16.SetHasEvents(node16.HasEvents() | node2.HasEvents());
							}
							node4.SetHasEvents(node4.HasEvents() | node16.HasEvents());
						}
						{
							DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node6 node6 = new DecoratorWeight_bt_Tank_TendencyWander_RandomFire_node6();
							node6.SetClassNameString("DecoratorWeight");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node4.AddChild(node6);
							{
								Sequence node7 = new Sequence();
								node7.SetClassNameString("Sequence");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("Player");
#endif
								node6.AddChild(node7);
								{
									Assignment_bt_Tank_TendencyWander_RandomFire_node17 node17 = new Assignment_bt_Tank_TendencyWander_RandomFire_node17();
									node17.SetClassNameString("Assignment");
									node17.SetId(17);
#if !BEHAVIAC_RELEASE
									node17.SetAgentType("Player");
#endif
									node7.AddChild(node17);
									node7.SetHasEvents(node7.HasEvents() | node17.HasEvents());
								}
								{
									DecoratorAlwaysSuccess_bt_Tank_TendencyWander_RandomFire_node8 node8 = new DecoratorAlwaysSuccess_bt_Tank_TendencyWander_RandomFire_node8();
									node8.SetClassNameString("DecoratorAlwaysSuccess");
									node8.SetId(8);
#if !BEHAVIAC_RELEASE
									node8.SetAgentType("Player");
#endif
									node7.AddChild(node8);
									{
										Sequence node11 = new Sequence();
										node11.SetClassNameString("Sequence");
										node11.SetId(11);
#if !BEHAVIAC_RELEASE
										node11.SetAgentType("Player");
#endif
										node8.AddChild(node11);
										{
											Assignment_bt_Tank_TendencyWander_RandomFire_node14 node14 = new Assignment_bt_Tank_TendencyWander_RandomFire_node14();
											node14.SetClassNameString("Assignment");
											node14.SetId(14);
#if !BEHAVIAC_RELEASE
											node14.SetAgentType("Player");
#endif
											node11.AddChild(node14);
											node11.SetHasEvents(node11.HasEvents() | node14.HasEvents());
										}
										{
											Condition_bt_Tank_TendencyWander_RandomFire_node15 node15 = new Condition_bt_Tank_TendencyWander_RandomFire_node15();
											node15.SetClassNameString("Condition");
											node15.SetId(15);
#if !BEHAVIAC_RELEASE
											node15.SetAgentType("Player");
#endif
											node11.AddChild(node15);
											node11.SetHasEvents(node11.HasEvents() | node15.HasEvents());
										}
										{
											Assignment_bt_Tank_TendencyWander_RandomFire_node13 node13 = new Assignment_bt_Tank_TendencyWander_RandomFire_node13();
											node13.SetClassNameString("Assignment");
											node13.SetId(13);
#if !BEHAVIAC_RELEASE
											node13.SetAgentType("Player");
#endif
											node11.AddChild(node13);
											node11.SetHasEvents(node11.HasEvents() | node13.HasEvents());
										}
										{
											Assignment_bt_Tank_TendencyWander_RandomFire_node5 node5 = new Assignment_bt_Tank_TendencyWander_RandomFire_node5();
											node5.SetClassNameString("Assignment");
											node5.SetId(5);
#if !BEHAVIAC_RELEASE
											node5.SetAgentType("Player");
#endif
											node11.AddChild(node5);
											node11.SetHasEvents(node11.HasEvents() | node5.HasEvents());
										}
										node8.SetHasEvents(node8.HasEvents() | node11.HasEvents());
									}
									node7.SetHasEvents(node7.HasEvents() | node8.HasEvents());
								}
								{
									Assignment_bt_Tank_TendencyWander_RandomFire_node12 node12 = new Assignment_bt_Tank_TendencyWander_RandomFire_node12();
									node12.SetClassNameString("Assignment");
									node12.SetId(12);
#if !BEHAVIAC_RELEASE
									node12.SetAgentType("Player");
#endif
									node7.AddChild(node12);
									node7.SetHasEvents(node7.HasEvents() | node12.HasEvents());
								}
								{
									Sequence node10 = new Sequence();
									node10.SetClassNameString("Sequence");
									node10.SetId(10);
#if !BEHAVIAC_RELEASE
									node10.SetAgentType("Player");
#endif
									node7.AddChild(node10);
									{
										Condition_bt_Tank_TendencyWander_RandomFire_node18 node18 = new Condition_bt_Tank_TendencyWander_RandomFire_node18();
										node18.SetClassNameString("Condition");
										node18.SetId(18);
#if !BEHAVIAC_RELEASE
										node18.SetAgentType("Player");
#endif
										node10.AddChild(node18);
										node10.SetHasEvents(node10.HasEvents() | node18.HasEvents());
									}
									{
										Action_bt_Tank_TendencyWander_RandomFire_node9 node9 = new Action_bt_Tank_TendencyWander_RandomFire_node9();
										node9.SetClassNameString("Action");
										node9.SetId(9);
#if !BEHAVIAC_RELEASE
										node9.SetAgentType("Player");
#endif
										node10.AddChild(node9);
										node10.SetHasEvents(node10.HasEvents() | node9.HasEvents());
									}
									node7.SetHasEvents(node7.HasEvents() | node10.HasEvents());
								}
								node6.SetHasEvents(node6.HasEvents() | node7.HasEvents());
							}
							node4.SetHasEvents(node4.HasEvents() | node6.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node4.HasEvents());
					}
					{
						Sequence node27 = new Sequence();
						node27.SetClassNameString("Sequence");
						node27.SetId(27);
#if !BEHAVIAC_RELEASE
						node27.SetAgentType("Player");
#endif
						node1.AddChild(node27);
						{
							SelectorStochastic_bt_Tank_TendencyWander_RandomFire_node3 node3 = new SelectorStochastic_bt_Tank_TendencyWander_RandomFire_node3();
							node3.SetClassNameString("SelectorStochastic");
							node3.SetId(3);
#if !BEHAVIAC_RELEASE
							node3.SetAgentType("Player");
#endif
							node27.AddChild(node3);
							{
								Assignment_bt_Tank_TendencyWander_RandomFire_node19 node19 = new Assignment_bt_Tank_TendencyWander_RandomFire_node19();
								node19.SetClassNameString("Assignment");
								node19.SetId(19);
#if !BEHAVIAC_RELEASE
								node19.SetAgentType("Player");
#endif
								node3.AddChild(node19);
								node3.SetHasEvents(node3.HasEvents() | node19.HasEvents());
							}
							{
								Assignment_bt_Tank_TendencyWander_RandomFire_node20 node20 = new Assignment_bt_Tank_TendencyWander_RandomFire_node20();
								node20.SetClassNameString("Assignment");
								node20.SetId(20);
#if !BEHAVIAC_RELEASE
								node20.SetAgentType("Player");
#endif
								node3.AddChild(node20);
								node3.SetHasEvents(node3.HasEvents() | node20.HasEvents());
							}
							{
								Assignment_bt_Tank_TendencyWander_RandomFire_node21 node21 = new Assignment_bt_Tank_TendencyWander_RandomFire_node21();
								node21.SetClassNameString("Assignment");
								node21.SetId(21);
#if !BEHAVIAC_RELEASE
								node21.SetAgentType("Player");
#endif
								node3.AddChild(node21);
								node3.SetHasEvents(node3.HasEvents() | node21.HasEvents());
							}
							{
								Assignment_bt_Tank_TendencyWander_RandomFire_node22 node22 = new Assignment_bt_Tank_TendencyWander_RandomFire_node22();
								node22.SetClassNameString("Assignment");
								node22.SetId(22);
#if !BEHAVIAC_RELEASE
								node22.SetAgentType("Player");
#endif
								node3.AddChild(node22);
								node3.SetHasEvents(node3.HasEvents() | node22.HasEvents());
							}
							node27.SetHasEvents(node27.HasEvents() | node3.HasEvents());
						}
						{
							Action_bt_Tank_TendencyWander_RandomFire_node23 node23 = new Action_bt_Tank_TendencyWander_RandomFire_node23();
							node23.SetClassNameString("Action");
							node23.SetId(23);
#if !BEHAVIAC_RELEASE
							node23.SetAgentType("Player");
#endif
							node27.AddChild(node23);
							node27.SetHasEvents(node27.HasEvents() | node23.HasEvents());
						}
						{
							Action_bt_Tank_TendencyWander_RandomFire_node24 node24 = new Action_bt_Tank_TendencyWander_RandomFire_node24();
							node24.SetClassNameString("Action");
							node24.SetId(24);
#if !BEHAVIAC_RELEASE
							node24.SetAgentType("Player");
#endif
							node27.AddChild(node24);
							node27.SetHasEvents(node27.HasEvents() | node24.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node27.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_WalkUtilCollision

	class DecoratorLoop_bt_Tank_WalkUtilCollision_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_WalkUtilCollision_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Action_bt_Tank_WalkUtilCollision_node1 : behaviac.Action
	{
		public Action_bt_Tank_WalkUtilCollision_node1()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class Assignment_bt_Tank_WalkUtilCollision_node6 : behaviac.Assignment
	{
		public Assignment_bt_Tank_WalkUtilCollision_node6()
		{
			opr_p1 = eMapDirection.UNKNOWN;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
		eMapDirection opr_p1;
	}

	class Condition_bt_Tank_WalkUtilCollision_node7 : behaviac.Condition
	{
		public Condition_bt_Tank_WalkUtilCollision_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_WalkUtilCollision_node22 : behaviac.Action
	{
		public Action_bt_Tank_WalkUtilCollision_node22()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	public static class bt_Tank_WalkUtilCollision
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_WalkUtilCollision");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("UnityEngine.Vector3", "parT_moveTarget", "{kEpsilon=0;x=0;y=0;z=0;}", "");
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_WalkUtilCollision_node0 node0 = new DecoratorLoop_bt_Tank_WalkUtilCollision_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Selector node4 = new Selector();
					node4.SetClassNameString("Selector");
					node4.SetId(4);
#if !BEHAVIAC_RELEASE
					node4.SetAgentType("Player");
#endif
					node0.AddChild(node4);
					{
						Action_bt_Tank_WalkUtilCollision_node1 node1 = new Action_bt_Tank_WalkUtilCollision_node1();
						node1.SetClassNameString("Action");
						node1.SetId(1);
#if !BEHAVIAC_RELEASE
						node1.SetAgentType("Player");
#endif
						node4.AddChild(node1);
						node4.SetHasEvents(node4.HasEvents() | node1.HasEvents());
					}
					{
						Sequence node9 = new Sequence();
						node9.SetClassNameString("Sequence");
						node9.SetId(9);
#if !BEHAVIAC_RELEASE
						node9.SetAgentType("Player");
#endif
						node4.AddChild(node9);
						{
							Assignment_bt_Tank_WalkUtilCollision_node6 node6 = new Assignment_bt_Tank_WalkUtilCollision_node6();
							node6.SetClassNameString("Assignment");
							node6.SetId(6);
#if !BEHAVIAC_RELEASE
							node6.SetAgentType("Player");
#endif
							node9.AddChild(node6);
							node9.SetHasEvents(node9.HasEvents() | node6.HasEvents());
						}
						{
							Sequence node2 = new Sequence();
							node2.SetClassNameString("Sequence");
							node2.SetId(2);
#if !BEHAVIAC_RELEASE
							node2.SetAgentType("Player");
#endif
							node9.AddChild(node2);
							{
								Condition_bt_Tank_WalkUtilCollision_node7 node7 = new Condition_bt_Tank_WalkUtilCollision_node7();
								node7.SetClassNameString("Condition");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("Player");
#endif
								node2.AddChild(node7);
								node2.SetHasEvents(node2.HasEvents() | node7.HasEvents());
							}
							{
								Action_bt_Tank_WalkUtilCollision_node22 node22 = new Action_bt_Tank_WalkUtilCollision_node22();
								node22.SetClassNameString("Action");
								node22.SetId(22);
#if !BEHAVIAC_RELEASE
								node22.SetAgentType("Player");
#endif
								node2.AddChild(node22);
								node2.SetHasEvents(node2.HasEvents() | node22.HasEvents());
							}
							node9.SetHasEvents(node9.HasEvents() | node2.HasEvents());
						}
						node4.SetHasEvents(node4.HasEvents() | node9.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node4.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Wander

	class DecoratorLoop_bt_Tank_Wander_node6 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Wander_node6()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class SelectorProbability_bt_Tank_Wander_node2 : behaviac.SelectorProbability
	{
		public SelectorProbability_bt_Tank_Wander_node2()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class DecoratorWeight_bt_Tank_Wander_node0 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Wander_node0()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 70;
		}
	}

	class Action_bt_Tank_Wander_node7 : behaviac.Action
	{
		public Action_bt_Tank_Wander_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class DecoratorWeight_bt_Tank_Wander_node8 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Wander_node8()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 30;
		}
	}

	class Assignment_bt_Tank_Wander_node11 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_node11()
		{
			opr_p1 = eMapDirection.UNKNOWN;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
		eMapDirection opr_p1;
	}

	class Condition_bt_Tank_Wander_node3 : behaviac.Condition
	{
		public Condition_bt_Tank_Wander_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_Wander_node4 : behaviac.Action
	{
		public Action_bt_Tank_Wander_node4()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	public static class bt_Tank_Wander
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Wander");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Wander_node6 node6 = new DecoratorLoop_bt_Tank_Wander_node6();
				node6.SetClassNameString("DecoratorLoop");
				node6.SetId(6);
#if !BEHAVIAC_RELEASE
				node6.SetAgentType("Player");
#endif
				bt.AddChild(node6);
				{
					SelectorProbability_bt_Tank_Wander_node2 node2 = new SelectorProbability_bt_Tank_Wander_node2();
					node2.SetClassNameString("SelectorProbability");
					node2.SetId(2);
#if !BEHAVIAC_RELEASE
					node2.SetAgentType("Player");
#endif
					node6.AddChild(node2);
					{
						DecoratorWeight_bt_Tank_Wander_node0 node0 = new DecoratorWeight_bt_Tank_Wander_node0();
						node0.SetClassNameString("DecoratorWeight");
						node0.SetId(0);
#if !BEHAVIAC_RELEASE
						node0.SetAgentType("Player");
#endif
						node2.AddChild(node0);
						{
							Action_bt_Tank_Wander_node7 node7 = new Action_bt_Tank_Wander_node7();
							node7.SetClassNameString("Action");
							node7.SetId(7);
#if !BEHAVIAC_RELEASE
							node7.SetAgentType("Player");
#endif
							node0.AddChild(node7);
							node0.SetHasEvents(node0.HasEvents() | node7.HasEvents());
						}
						node2.SetHasEvents(node2.HasEvents() | node0.HasEvents());
					}
					{
						DecoratorWeight_bt_Tank_Wander_node8 node8 = new DecoratorWeight_bt_Tank_Wander_node8();
						node8.SetClassNameString("DecoratorWeight");
						node8.SetId(8);
#if !BEHAVIAC_RELEASE
						node8.SetAgentType("Player");
#endif
						node2.AddChild(node8);
						{
							Sequence node9 = new Sequence();
							node9.SetClassNameString("Sequence");
							node9.SetId(9);
#if !BEHAVIAC_RELEASE
							node9.SetAgentType("Player");
#endif
							node8.AddChild(node9);
							{
								Assignment_bt_Tank_Wander_node11 node11 = new Assignment_bt_Tank_Wander_node11();
								node11.SetClassNameString("Assignment");
								node11.SetId(11);
#if !BEHAVIAC_RELEASE
								node11.SetAgentType("Player");
#endif
								node9.AddChild(node11);
								node9.SetHasEvents(node9.HasEvents() | node11.HasEvents());
							}
							{
								Sequence node10 = new Sequence();
								node10.SetClassNameString("Sequence");
								node10.SetId(10);
#if !BEHAVIAC_RELEASE
								node10.SetAgentType("Player");
#endif
								node9.AddChild(node10);
								{
									Condition_bt_Tank_Wander_node3 node3 = new Condition_bt_Tank_Wander_node3();
									node3.SetClassNameString("Condition");
									node3.SetId(3);
#if !BEHAVIAC_RELEASE
									node3.SetAgentType("Player");
#endif
									node10.AddChild(node3);
									node10.SetHasEvents(node10.HasEvents() | node3.HasEvents());
								}
								{
									Action_bt_Tank_Wander_node4 node4 = new Action_bt_Tank_Wander_node4();
									node4.SetClassNameString("Action");
									node4.SetId(4);
#if !BEHAVIAC_RELEASE
									node4.SetAgentType("Player");
#endif
									node10.AddChild(node4);
									node10.SetHasEvents(node10.HasEvents() | node4.HasEvents());
								}
								node9.SetHasEvents(node9.HasEvents() | node10.HasEvents());
							}
							node8.SetHasEvents(node8.HasEvents() | node9.HasEvents());
						}
						node2.SetHasEvents(node2.HasEvents() | node8.HasEvents());
					}
					node6.SetHasEvents(node6.HasEvents() | node2.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node6.HasEvents());
			}
			return true;
		}
	}

	// Source file: Tank_Wander_RandomFire

	class DecoratorLoop_bt_Tank_Wander_RandomFire_node0 : behaviac.DecoratorLoop
	{
		public DecoratorLoop_bt_Tank_Wander_RandomFire_node0()
		{
			m_bDecorateWhenChildEnds = true;
		}
		protected override int GetCount(Agent pAgent)
		{
			return -1;
		}
	}

	class Parallel_bt_Tank_Wander_RandomFire_node1 : behaviac.Parallel
	{
		public Parallel_bt_Tank_Wander_RandomFire_node1()
		{
			m_failPolicy = behaviac.FAILURE_POLICY.FAIL_ON_ONE;
			m_succeedPolicy = behaviac.SUCCESS_POLICY.SUCCEED_ON_ALL;
			m_exitPolicy = behaviac.EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			m_childFinishPolicy = behaviac.CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}

	class SelectorStochastic_bt_Tank_Wander_RandomFire_node2 : behaviac.SelectorStochastic
	{
		public SelectorStochastic_bt_Tank_Wander_RandomFire_node2()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class Assignment_bt_Tank_Wander_RandomFire_node8 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_RandomFire_node8()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 180f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Wander_RandomFire_node6 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_RandomFire_node6()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 90f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Wander_RandomFire_node7 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_RandomFire_node7()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 0f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Assignment_bt_Tank_Wander_RandomFire_node9 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_RandomFire_node9()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			float opr = 270f;
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			pAgent.SetVariable("parT_AimAngle", opr, 3496662299u);
			return result;
		}
	}

	class Action_bt_Tank_Wander_RandomFire_node3 : behaviac.Action
	{
		public Action_bt_Tank_Wander_RandomFire_node3()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_AimAngle") == 3496662299u);
			float method_p0 = (float)pAgent.GetVariable(3496662299u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).aimToAngle(method_p0);
			return result;
		}
	}

	class Action_bt_Tank_Wander_RandomFire_node10 : behaviac.Action
	{
		public Action_bt_Tank_Wander_RandomFire_node10()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((Player)pAgent).fire();
			return result;
		}
	}

	class SelectorProbability_bt_Tank_Wander_RandomFire_node5 : behaviac.SelectorProbability
	{
		public SelectorProbability_bt_Tank_Wander_RandomFire_node5()
		{
		}
		public void Initialize(string method)
		{
			this.m_method = Action.LoadMethod(method);
		}
	}

	class DecoratorWeight_bt_Tank_Wander_RandomFire_node11 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Wander_RandomFire_node11()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 70;
		}
	}

	class Action_bt_Tank_Wander_RandomFire_node12 : behaviac.Action
	{
		public Action_bt_Tank_Wander_RandomFire_node12()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).moveForward();
			return result;
		}
	}

	class DecoratorWeight_bt_Tank_Wander_RandomFire_node13 : behaviac.DecoratorWeight
	{
		public DecoratorWeight_bt_Tank_Wander_RandomFire_node13()
		{
			m_bDecorateWhenChildEnds = false;
		}
		protected override int GetWeight(Agent pAgent)
		{
			return 30;
		}
	}

	class Assignment_bt_Tank_Wander_RandomFire_node15 : behaviac.Assignment
	{
		public Assignment_bt_Tank_Wander_RandomFire_node15()
		{
			opr_p1 = eMapDirection.UNKNOWN;
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Debug.Check(behaviac.Utils.MakeVariableId("parIn_Self") == 2069719536u);
			GameActor opr_p0 = (GameActor)pAgent.GetVariable(2069719536u);
			behaviac.Agent pAgent_opr = behaviac.Agent.GetInstance("GameLevel", pAgent.GetContextId());
			Debug.Check(pAgent_opr != null);
			float opr = (float)((GameLevelCommon)pAgent_opr).getAvailabeMoveDirection(opr_p0, opr_p1);
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			pAgent.SetVariable("parT_RotateAngle", opr, 760191237u);
			return result;
		}
		eMapDirection opr_p1;
	}

	class Condition_bt_Tank_Wander_RandomFire_node17 : behaviac.Condition
	{
		public Condition_bt_Tank_Wander_RandomFire_node17()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float opl = (float)pAgent.GetVariable(760191237u);
			float opr = 0f;
			bool op = opl >= opr;
			return op ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}

	class Action_bt_Tank_Wander_RandomFire_node18 : behaviac.Action
	{
		public Action_bt_Tank_Wander_RandomFire_node18()
		{
		}
		protected override EBTStatus update_impl(behaviac.Agent pAgent, behaviac.EBTStatus childStatus)
		{
			Debug.Check(behaviac.Utils.MakeVariableId("parT_RotateAngle") == 760191237u);
			float method_p0 = (float)pAgent.GetVariable(760191237u);
			behaviac.EBTStatus result = (behaviac.EBTStatus)((GameActor)pAgent).rotateToAngle(method_p0);
			return result;
		}
	}

	public static class bt_Tank_Wander_RandomFire
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Tank_Wander_RandomFire");
#if !BEHAVIAC_RELEASE
			bt.SetAgentType("Player");
#endif
			// pars
			bt.AddPar("Player", "parIn_Self", "null", "");
			bt.AddPar("float", "parT_RotateAngle", "0", "");
			bt.AddPar("float", "parT_AimAngle", "0", "");
			// children
			{
				DecoratorLoop_bt_Tank_Wander_RandomFire_node0 node0 = new DecoratorLoop_bt_Tank_Wander_RandomFire_node0();
				node0.SetClassNameString("DecoratorLoop");
				node0.SetId(0);
#if !BEHAVIAC_RELEASE
				node0.SetAgentType("Player");
#endif
				bt.AddChild(node0);
				{
					Parallel_bt_Tank_Wander_RandomFire_node1 node1 = new Parallel_bt_Tank_Wander_RandomFire_node1();
					node1.SetClassNameString("Parallel");
					node1.SetId(1);
#if !BEHAVIAC_RELEASE
					node1.SetAgentType("Player");
#endif
					node0.AddChild(node1);
					{
						Sequence node4 = new Sequence();
						node4.SetClassNameString("Sequence");
						node4.SetId(4);
#if !BEHAVIAC_RELEASE
						node4.SetAgentType("Player");
#endif
						node1.AddChild(node4);
						{
							SelectorStochastic_bt_Tank_Wander_RandomFire_node2 node2 = new SelectorStochastic_bt_Tank_Wander_RandomFire_node2();
							node2.SetClassNameString("SelectorStochastic");
							node2.SetId(2);
#if !BEHAVIAC_RELEASE
							node2.SetAgentType("Player");
#endif
							node4.AddChild(node2);
							{
								Assignment_bt_Tank_Wander_RandomFire_node8 node8 = new Assignment_bt_Tank_Wander_RandomFire_node8();
								node8.SetClassNameString("Assignment");
								node8.SetId(8);
#if !BEHAVIAC_RELEASE
								node8.SetAgentType("Player");
#endif
								node2.AddChild(node8);
								node2.SetHasEvents(node2.HasEvents() | node8.HasEvents());
							}
							{
								Assignment_bt_Tank_Wander_RandomFire_node6 node6 = new Assignment_bt_Tank_Wander_RandomFire_node6();
								node6.SetClassNameString("Assignment");
								node6.SetId(6);
#if !BEHAVIAC_RELEASE
								node6.SetAgentType("Player");
#endif
								node2.AddChild(node6);
								node2.SetHasEvents(node2.HasEvents() | node6.HasEvents());
							}
							{
								Assignment_bt_Tank_Wander_RandomFire_node7 node7 = new Assignment_bt_Tank_Wander_RandomFire_node7();
								node7.SetClassNameString("Assignment");
								node7.SetId(7);
#if !BEHAVIAC_RELEASE
								node7.SetAgentType("Player");
#endif
								node2.AddChild(node7);
								node2.SetHasEvents(node2.HasEvents() | node7.HasEvents());
							}
							{
								Assignment_bt_Tank_Wander_RandomFire_node9 node9 = new Assignment_bt_Tank_Wander_RandomFire_node9();
								node9.SetClassNameString("Assignment");
								node9.SetId(9);
#if !BEHAVIAC_RELEASE
								node9.SetAgentType("Player");
#endif
								node2.AddChild(node9);
								node2.SetHasEvents(node2.HasEvents() | node9.HasEvents());
							}
							node4.SetHasEvents(node4.HasEvents() | node2.HasEvents());
						}
						{
							Action_bt_Tank_Wander_RandomFire_node3 node3 = new Action_bt_Tank_Wander_RandomFire_node3();
							node3.SetClassNameString("Action");
							node3.SetId(3);
#if !BEHAVIAC_RELEASE
							node3.SetAgentType("Player");
#endif
							node4.AddChild(node3);
							node4.SetHasEvents(node4.HasEvents() | node3.HasEvents());
						}
						{
							Action_bt_Tank_Wander_RandomFire_node10 node10 = new Action_bt_Tank_Wander_RandomFire_node10();
							node10.SetClassNameString("Action");
							node10.SetId(10);
#if !BEHAVIAC_RELEASE
							node10.SetAgentType("Player");
#endif
							node4.AddChild(node10);
							node4.SetHasEvents(node4.HasEvents() | node10.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node4.HasEvents());
					}
					{
						SelectorProbability_bt_Tank_Wander_RandomFire_node5 node5 = new SelectorProbability_bt_Tank_Wander_RandomFire_node5();
						node5.SetClassNameString("SelectorProbability");
						node5.SetId(5);
#if !BEHAVIAC_RELEASE
						node5.SetAgentType("Player");
#endif
						node1.AddChild(node5);
						{
							DecoratorWeight_bt_Tank_Wander_RandomFire_node11 node11 = new DecoratorWeight_bt_Tank_Wander_RandomFire_node11();
							node11.SetClassNameString("DecoratorWeight");
							node11.SetId(11);
#if !BEHAVIAC_RELEASE
							node11.SetAgentType("Player");
#endif
							node5.AddChild(node11);
							{
								Action_bt_Tank_Wander_RandomFire_node12 node12 = new Action_bt_Tank_Wander_RandomFire_node12();
								node12.SetClassNameString("Action");
								node12.SetId(12);
#if !BEHAVIAC_RELEASE
								node12.SetAgentType("Player");
#endif
								node11.AddChild(node12);
								node11.SetHasEvents(node11.HasEvents() | node12.HasEvents());
							}
							node5.SetHasEvents(node5.HasEvents() | node11.HasEvents());
						}
						{
							DecoratorWeight_bt_Tank_Wander_RandomFire_node13 node13 = new DecoratorWeight_bt_Tank_Wander_RandomFire_node13();
							node13.SetClassNameString("DecoratorWeight");
							node13.SetId(13);
#if !BEHAVIAC_RELEASE
							node13.SetAgentType("Player");
#endif
							node5.AddChild(node13);
							{
								Sequence node14 = new Sequence();
								node14.SetClassNameString("Sequence");
								node14.SetId(14);
#if !BEHAVIAC_RELEASE
								node14.SetAgentType("Player");
#endif
								node13.AddChild(node14);
								{
									Assignment_bt_Tank_Wander_RandomFire_node15 node15 = new Assignment_bt_Tank_Wander_RandomFire_node15();
									node15.SetClassNameString("Assignment");
									node15.SetId(15);
#if !BEHAVIAC_RELEASE
									node15.SetAgentType("Player");
#endif
									node14.AddChild(node15);
									node14.SetHasEvents(node14.HasEvents() | node15.HasEvents());
								}
								{
									Sequence node16 = new Sequence();
									node16.SetClassNameString("Sequence");
									node16.SetId(16);
#if !BEHAVIAC_RELEASE
									node16.SetAgentType("Player");
#endif
									node14.AddChild(node16);
									{
										Condition_bt_Tank_Wander_RandomFire_node17 node17 = new Condition_bt_Tank_Wander_RandomFire_node17();
										node17.SetClassNameString("Condition");
										node17.SetId(17);
#if !BEHAVIAC_RELEASE
										node17.SetAgentType("Player");
#endif
										node16.AddChild(node17);
										node16.SetHasEvents(node16.HasEvents() | node17.HasEvents());
									}
									{
										Action_bt_Tank_Wander_RandomFire_node18 node18 = new Action_bt_Tank_Wander_RandomFire_node18();
										node18.SetClassNameString("Action");
										node18.SetId(18);
#if !BEHAVIAC_RELEASE
										node18.SetAgentType("Player");
#endif
										node16.AddChild(node18);
										node16.SetHasEvents(node16.HasEvents() | node18.HasEvents());
									}
									node14.SetHasEvents(node14.HasEvents() | node16.HasEvents());
								}
								node13.SetHasEvents(node13.HasEvents() | node14.HasEvents());
							}
							node5.SetHasEvents(node5.HasEvents() | node13.HasEvents());
						}
						node1.SetHasEvents(node1.HasEvents() | node5.HasEvents());
					}
					node0.SetHasEvents(node0.HasEvents() | node1.HasEvents());
				}
				bt.SetHasEvents(bt.HasEvents() | node0.HasEvents());
			}
			return true;
		}
	}

}
