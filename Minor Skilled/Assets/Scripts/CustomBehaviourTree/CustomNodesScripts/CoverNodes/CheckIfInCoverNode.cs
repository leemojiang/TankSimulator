﻿using UnityEngine;

namespace CustomBehaviourTree.CustomNodesScripts.CoverNodes
{
    [CreateAssetMenu(menuName = "Behaviour tree/Cover/CheckIfInCover")]
    public class CheckIfInCoverNode : BehaviourNode
    {
        public override NodeState Evaluate(AIBlackboard blackboard, AIController controller)
        {
            bool hasHitPlayer = false;
            Color hitColor = Color.magenta;

            //Could be on its way to a cover point. Not having this check results in the agent stopping the moment it 
            //doesn't see the player anymore. Keep returning failure until reached destination
            // (prevents next node from executing too soon)
            // if (blackboard.IsMoving)
            // {
            //     _nodeState = NodeState.Failure;
            //     return _nodeState;
            // }
                
            foreach (var raycastTransform in controller.CoverRaycastPositions)
            {
                bool hasHitCollider = Physics.Linecast(raycastTransform.position, GameManager.Instance.Player.EntityOrigin.position, out RaycastHit hit);
                if (!hasHitCollider)
                    continue;
                
                if (hit.collider.transform.root.CompareTag("Player")) 
                { 
                    hitColor = Color.red; 
                    hasHitPlayer = true;
                }
                
                Debug.DrawLine(raycastTransform.position, GameManager.Instance.Player.EntityOrigin.position, hitColor);
            }
            
            //Ray has hit player? Continue with cover finding branch.
            _nodeState = hasHitPlayer ? NodeState.Failure : NodeState.Success;

            return _nodeState;
        }
    }
}