﻿using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviour tree/Composite/SequenceNode")]
public class SequenceNode : BehaviourNode
{
    public override NodeState Evaluate()
    {
        bool hasRunningChild = false;
        
        foreach (var child in _childNodes)
        {
            switch (child.Evaluate())
            {
                case NodeState.Running:
                    hasRunningChild = true;
                    Debug.Log($"SEQUENCE:<color=orange> Branch:</color> ({child.ShowAscendingLeafChain()})");
                    continue;
                case NodeState.Success:
                    if(child.GetChildCount() == 0)
                        Debug.Log($"SEQUENCE:<color=green> Branch:</color> ({child.ShowAscendingLeafChain()})");
                    continue;
                case NodeState.Failure:
                    Debug.Log($"SEQUENCE:<color=red> Branch:</color>    ({child.ShowAscendingLeafChain()})");
                    _nodeState = NodeState.Failure;
                    return _nodeState;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        _nodeState = hasRunningChild ? NodeState.Running : NodeState.Success;
        return _nodeState;
    }
}