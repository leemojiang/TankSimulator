﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTankCombatState : TankCombatState
{
    private BehaviourTree _tree;
    private AIBlackboard _blackboard;
    private NavMeshAgent _agent;
    private PatrolNode _patrolNode;
    private InvestigateNode _investigateNode;

    protected override void Awake()
    {
        base.Awake();

        _agent = GetComponentInParent<NavMeshAgent>();
        _blackboard = GetComponentInParent<AIBlackboard>();
        _tree = GetComponentInParent<BehaviourTree>();
    }
    
    protected override void Start()
    {
        base.Start();
        
        SequenceNode rootNode = new();
        _patrolNode = new PatrolNode();
        _investigateNode = new InvestigateNode();
        
        _investigateNode.AddChildNode(new CheckIfPlayerInRangeNode());
        _investigateNode.AddChildNode(new CheckIfPlayerInVision());
    
        rootNode.AddChildNode(_patrolNode);
        rootNode.AddChildNode(_investigateNode);
        _tree.SetRootNode(rootNode);
    }


    private void Update()
    {
        _tree.EvaluateTree(_blackboard);
    }

    private void OnDrawGizmos()
    {
        if (_patrolNode != null)
        {
            Gizmos.color = new Color(255, 0, 0);
            Gizmos.DrawSphere(_blackboard.CurrentAgentDestination, 0.5f);
            Handles.Label(_blackboard.CurrentAgentDestination + GameManager.HandlesOffset, "Agent destination");
            
            Gizmos.color = new Color(0, 0, 255f);
            Gizmos.DrawSphere(transform.position, 1f);

            Gizmos.color = Color.red;
        }
    }
}