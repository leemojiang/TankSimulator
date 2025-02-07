﻿using System;
using JetBrains.Annotations;
using UnityEngine;

namespace FSM.HUDStates
{
    public abstract class HUDState : FSMState
    {
        public E_TankState ThisState;

        protected GameObject HUDContainer;

        protected PlayerInputActions _inputActions;

        protected virtual void Awake()
        {
            if (HUDContainer == null)
                HUDContainer = this.gameObject;

            _inputActions = new PlayerInputActions();
            _inputActions.Enable();
        }

        public override void Enter()
        {
            HUDContainer.SetActive(true);
        }

        public override void Exit()
        {
            HUDContainer.SetActive(false);
        }
    }
}