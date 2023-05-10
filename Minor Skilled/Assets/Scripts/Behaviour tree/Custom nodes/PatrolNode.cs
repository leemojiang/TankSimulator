﻿using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class PatrolNode : BehaviourNode
{ 
    public float PatrolRange { get; private set; } = 50f;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _stoppingDistance = 2f;

    public PatrolNode(AIBlackboard blackboard) : base(blackboard)
    {
        
    }

    public override NodeState Evaluate()
    {
        if (CheckIfReachedDestination())
            FindNewDestination();
        else _blackboard.Agent.SetDestination(_blackboard.CurrentAgentDestination);
        
        _nodeState = NodeState.Running;
        return _nodeState;
    }

    public override void DrawGizmos()
    {
        Handles.color = new Color(0, 255, 0, 0.05f);
        Handles.DrawSolidDisc(_blackboard.ThisTrans.position, _blackboard.ThisTrans.up, _blackboard.MaxPatrolRange);
        Handles.Label(_blackboard.ThisTrans.position + _blackboard.ThisTrans.right * _blackboard.MaxPatrolRange, $"Max patrol range: {_blackboard.MaxPatrolRange}");

        Handles.color = new Color(255, 0, 0, 0.05f);
        Handles.DrawSolidDisc(_blackboard.ThisTrans.position, _blackboard.ThisTrans.up, _blackboard.MaxInstantVisionRange);
        Handles.Label(_blackboard.ThisTrans.position + _blackboard.ThisTrans.right * _blackboard.MaxInstantVisionRange, $"Max instant vision range: {_blackboard.MaxInstantVisionRange}");
    }

    private void FindNewDestination()
    {
        _blackboard.CurrentAgentDestination = RandomNavmeshLocation();
        _blackboard.Agent.SetDestination(_blackboard.CurrentAgentDestination);
    }

    private bool CheckIfReachedDestination()
    {
        if (_blackboard.CurrentAgentDestination == Vector3.zero) 
            return true;
        
        float distanceToDestination = Vector3.Distance(_blackboard.ThisTrans.position, _blackboard.CurrentAgentDestination);

        if (distanceToDestination <= _blackboard.Agent.stoppingDistance)
            return true;
        return false;
    }
    
    public Vector3 RandomNavmeshLocation() {
        Vector3 randomDirection = Random.insideUnitSphere * _blackboard.MaxPatrolRange;
        randomDirection += _blackboard.ThisTrans.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, _blackboard.MaxPatrolRange, 1)) {
            finalPosition = hit.position;            
        }
        return finalPosition;
    }
}