﻿using UnityEditor;
using UnityEngine;

namespace CustomBehaviourTree.CustomNodesScripts.DetectionNodes
{
    [CreateAssetMenu(menuName = "Behaviour tree/Detection/CheckFOVNode")]
    public class CheckFOVNode : BehaviourNode
    {
        private Vector3 _targetPosition;

        [SerializeField] private Color _fovConeColour;
        [field: SerializeField] public string RangeName { set; get; }
        [field: SerializeField] public float RangeValue { set; get; }

        [field: SerializeField] private float _viewAngle;

        public override NodeState Evaluate(AIBlackboard blackboard, AIController controller)
        {
            if (PointCheck.IsPointInsideFOV(blackboard.PointToRotateTurretTo, controller.transform, _viewAngle))
            {
                _nodeState = NodeState.Success;
            }
            else
            {
                _nodeState = NodeState.Failure;
            }

            return _nodeState;
        }

#if UNITY_EDITOR
        public override void DrawGizmos(AIBlackboard blackboard, AIController controller)
        {
            Transform turretTransform = controller.ComponentManager.TurretControlComp.TurretTransform;
            Handles.color = _fovConeColour;
            Handles.DrawSolidArc(controller.transform.position, controller.transform.up, turretTransform.forward,
                -_viewAngle / 2, RangeValue);
            Handles.DrawSolidArc(controller.transform.position, controller.transform.up, turretTransform.forward,
                _viewAngle / 2, RangeValue);
            Handles.Label(controller.transform.position + Vector3.right * RangeValue, $"{RangeName}: {RangeValue}");
        }
        #endif
    }
}