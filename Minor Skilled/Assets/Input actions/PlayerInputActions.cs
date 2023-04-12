//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input actions/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Tank movement"",
            ""id"": ""5b3aecbc-2dc5-4276-8545-caad1a667647"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""23affdb2-0436-435b-a1cc-03484e14a52b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""6ca4411b-1a7b-43b8-a2f7-56c6ab5c91ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncreaseGear"",
                    ""type"": ""Button"",
                    ""id"": ""313b954f-21e1-4c7c-915d-da13a034234d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseGear"",
                    ""type"": ""Button"",
                    ""id"": ""be759fe6-6cfd-4f3b-82e7-f42c338ab6ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurretRotate"",
                    ""type"": ""Value"",
                    ""id"": ""12e9ce37-f78d-4fc8-b60c-de4d2806f8a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2,ScaleVector2(x=2,y=2)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ShellSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""ad4f3900-b1c0-4e39-aec6-106056e75a69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomADS"",
                    ""type"": ""Button"",
                    ""id"": ""e9d0d277-eecc-4e6f-acfe-0225cc7c53b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ff5e96bf-5203-4ccb-8185-db0bed639b88"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""62152f70-0826-4af4-ae61-8e74535e7937"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40c7f29c-e514-424f-98b0-9189f9d40506"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""81dde49f-1ef2-4772-b6ee-f4005b39bd71"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cbfb3294-61c0-4d2b-b63c-9bed4e8a7597"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b754ef64-9bcc-4cbe-ade5-ef1086c6a463"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5915e918-35ef-4437-afd7-4c6bdb314519"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5b82f05-5206-4bfb-9387-32d95e7f7077"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8ee1fe1-6e35-42c0-9d36-346b833c4627"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShellSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bac6d537-baeb-4e28-b603-c3534dcc0241"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurretRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3723c74-dc09-4321-8be4-1cdef9821fd8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomADS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tank inspection"",
            ""id"": ""9fdae027-3088-448a-b802-ae71285b08c4"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""247a3333-d24b-451f-b96e-9fa4782e989f"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""InspectTank"",
                    ""type"": ""Value"",
                    ""id"": ""1bdee200-bcc0-4c1d-b364-e2075823e52d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2,ScaleVector2(x=2,y=2)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AllowInspection"",
                    ""type"": ""Button"",
                    ""id"": ""50ac47e4-ab7a-4fc3-aaf2-19fb2ff13a3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ff77ac7d-38c0-48c1-bbd5-2cea7cae1c3a"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d7fbbeb-e8c2-4a94-923b-9150b2c6977d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InspectTank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""091e1318-a6cb-4d15-8151-dcd910bb8a2b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AllowInspection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StateSwitcher"",
            ""id"": ""bdcc613d-9aa7-497d-9951-a18ce3dfedb2"",
            ""actions"": [
                {
                    ""name"": ""EnableADSView"",
                    ""type"": ""Button"",
                    ""id"": ""254b149d-6989-413d-9bb4-d65dfe4ba2d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EnableThirdPersonView"",
                    ""type"": ""Button"",
                    ""id"": ""9f8dc3f7-368c-4650-bad3-fee64968f6d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EnableInspectionView"",
                    ""type"": ""Button"",
                    ""id"": ""f06feee9-12ed-45af-833b-028fc6782ba3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EnableHostileInspectionView"",
                    ""type"": ""Button"",
                    ""id"": ""a268df35-c39c-4d67-863b-fec876d13351"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a57eab4-c981-4339-bd56-ad0a298a491b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableADSView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9972fcd2-14f6-458e-9cd4-8a4afbd42c1a"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableThirdPersonView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33e5edeb-082c-4da5-b6d6-3bf99482c283"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableInspectionView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7df14631-b23d-4650-b6f3-b165e27ee79f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableHostileInspectionView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Tank movement
        m_Tankmovement = asset.FindActionMap("Tank movement", throwIfNotFound: true);
        m_Tankmovement_Move = m_Tankmovement.FindAction("Move", throwIfNotFound: true);
        m_Tankmovement_Shoot = m_Tankmovement.FindAction("Shoot", throwIfNotFound: true);
        m_Tankmovement_IncreaseGear = m_Tankmovement.FindAction("IncreaseGear", throwIfNotFound: true);
        m_Tankmovement_DecreaseGear = m_Tankmovement.FindAction("DecreaseGear", throwIfNotFound: true);
        m_Tankmovement_TurretRotate = m_Tankmovement.FindAction("TurretRotate", throwIfNotFound: true);
        m_Tankmovement_ShellSwitch = m_Tankmovement.FindAction("ShellSwitch", throwIfNotFound: true);
        m_Tankmovement_ZoomADS = m_Tankmovement.FindAction("ZoomADS", throwIfNotFound: true);
        // Tank inspection
        m_Tankinspection = asset.FindActionMap("Tank inspection", throwIfNotFound: true);
        m_Tankinspection_Zoom = m_Tankinspection.FindAction("Zoom", throwIfNotFound: true);
        m_Tankinspection_InspectTank = m_Tankinspection.FindAction("InspectTank", throwIfNotFound: true);
        m_Tankinspection_AllowInspection = m_Tankinspection.FindAction("AllowInspection", throwIfNotFound: true);
        // StateSwitcher
        m_StateSwitcher = asset.FindActionMap("StateSwitcher", throwIfNotFound: true);
        m_StateSwitcher_EnableADSView = m_StateSwitcher.FindAction("EnableADSView", throwIfNotFound: true);
        m_StateSwitcher_EnableThirdPersonView = m_StateSwitcher.FindAction("EnableThirdPersonView", throwIfNotFound: true);
        m_StateSwitcher_EnableInspectionView = m_StateSwitcher.FindAction("EnableInspectionView", throwIfNotFound: true);
        m_StateSwitcher_EnableHostileInspectionView = m_StateSwitcher.FindAction("EnableHostileInspectionView", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Tank movement
    private readonly InputActionMap m_Tankmovement;
    private List<ITankmovementActions> m_TankmovementActionsCallbackInterfaces = new List<ITankmovementActions>();
    private readonly InputAction m_Tankmovement_Move;
    private readonly InputAction m_Tankmovement_Shoot;
    private readonly InputAction m_Tankmovement_IncreaseGear;
    private readonly InputAction m_Tankmovement_DecreaseGear;
    private readonly InputAction m_Tankmovement_TurretRotate;
    private readonly InputAction m_Tankmovement_ShellSwitch;
    private readonly InputAction m_Tankmovement_ZoomADS;
    public struct TankmovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public TankmovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Tankmovement_Move;
        public InputAction @Shoot => m_Wrapper.m_Tankmovement_Shoot;
        public InputAction @IncreaseGear => m_Wrapper.m_Tankmovement_IncreaseGear;
        public InputAction @DecreaseGear => m_Wrapper.m_Tankmovement_DecreaseGear;
        public InputAction @TurretRotate => m_Wrapper.m_Tankmovement_TurretRotate;
        public InputAction @ShellSwitch => m_Wrapper.m_Tankmovement_ShellSwitch;
        public InputAction @ZoomADS => m_Wrapper.m_Tankmovement_ZoomADS;
        public InputActionMap Get() { return m_Wrapper.m_Tankmovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankmovementActions set) { return set.Get(); }
        public void AddCallbacks(ITankmovementActions instance)
        {
            if (instance == null || m_Wrapper.m_TankmovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TankmovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @IncreaseGear.started += instance.OnIncreaseGear;
            @IncreaseGear.performed += instance.OnIncreaseGear;
            @IncreaseGear.canceled += instance.OnIncreaseGear;
            @DecreaseGear.started += instance.OnDecreaseGear;
            @DecreaseGear.performed += instance.OnDecreaseGear;
            @DecreaseGear.canceled += instance.OnDecreaseGear;
            @TurretRotate.started += instance.OnTurretRotate;
            @TurretRotate.performed += instance.OnTurretRotate;
            @TurretRotate.canceled += instance.OnTurretRotate;
            @ShellSwitch.started += instance.OnShellSwitch;
            @ShellSwitch.performed += instance.OnShellSwitch;
            @ShellSwitch.canceled += instance.OnShellSwitch;
            @ZoomADS.started += instance.OnZoomADS;
            @ZoomADS.performed += instance.OnZoomADS;
            @ZoomADS.canceled += instance.OnZoomADS;
        }

        private void UnregisterCallbacks(ITankmovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @IncreaseGear.started -= instance.OnIncreaseGear;
            @IncreaseGear.performed -= instance.OnIncreaseGear;
            @IncreaseGear.canceled -= instance.OnIncreaseGear;
            @DecreaseGear.started -= instance.OnDecreaseGear;
            @DecreaseGear.performed -= instance.OnDecreaseGear;
            @DecreaseGear.canceled -= instance.OnDecreaseGear;
            @TurretRotate.started -= instance.OnTurretRotate;
            @TurretRotate.performed -= instance.OnTurretRotate;
            @TurretRotate.canceled -= instance.OnTurretRotate;
            @ShellSwitch.started -= instance.OnShellSwitch;
            @ShellSwitch.performed -= instance.OnShellSwitch;
            @ShellSwitch.canceled -= instance.OnShellSwitch;
            @ZoomADS.started -= instance.OnZoomADS;
            @ZoomADS.performed -= instance.OnZoomADS;
            @ZoomADS.canceled -= instance.OnZoomADS;
        }

        public void RemoveCallbacks(ITankmovementActions instance)
        {
            if (m_Wrapper.m_TankmovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITankmovementActions instance)
        {
            foreach (var item in m_Wrapper.m_TankmovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TankmovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TankmovementActions @Tankmovement => new TankmovementActions(this);

    // Tank inspection
    private readonly InputActionMap m_Tankinspection;
    private List<ITankinspectionActions> m_TankinspectionActionsCallbackInterfaces = new List<ITankinspectionActions>();
    private readonly InputAction m_Tankinspection_Zoom;
    private readonly InputAction m_Tankinspection_InspectTank;
    private readonly InputAction m_Tankinspection_AllowInspection;
    public struct TankinspectionActions
    {
        private @PlayerInputActions m_Wrapper;
        public TankinspectionActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_Tankinspection_Zoom;
        public InputAction @InspectTank => m_Wrapper.m_Tankinspection_InspectTank;
        public InputAction @AllowInspection => m_Wrapper.m_Tankinspection_AllowInspection;
        public InputActionMap Get() { return m_Wrapper.m_Tankinspection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankinspectionActions set) { return set.Get(); }
        public void AddCallbacks(ITankinspectionActions instance)
        {
            if (instance == null || m_Wrapper.m_TankinspectionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TankinspectionActionsCallbackInterfaces.Add(instance);
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
            @InspectTank.started += instance.OnInspectTank;
            @InspectTank.performed += instance.OnInspectTank;
            @InspectTank.canceled += instance.OnInspectTank;
            @AllowInspection.started += instance.OnAllowInspection;
            @AllowInspection.performed += instance.OnAllowInspection;
            @AllowInspection.canceled += instance.OnAllowInspection;
        }

        private void UnregisterCallbacks(ITankinspectionActions instance)
        {
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
            @InspectTank.started -= instance.OnInspectTank;
            @InspectTank.performed -= instance.OnInspectTank;
            @InspectTank.canceled -= instance.OnInspectTank;
            @AllowInspection.started -= instance.OnAllowInspection;
            @AllowInspection.performed -= instance.OnAllowInspection;
            @AllowInspection.canceled -= instance.OnAllowInspection;
        }

        public void RemoveCallbacks(ITankinspectionActions instance)
        {
            if (m_Wrapper.m_TankinspectionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITankinspectionActions instance)
        {
            foreach (var item in m_Wrapper.m_TankinspectionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TankinspectionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TankinspectionActions @Tankinspection => new TankinspectionActions(this);

    // StateSwitcher
    private readonly InputActionMap m_StateSwitcher;
    private List<IStateSwitcherActions> m_StateSwitcherActionsCallbackInterfaces = new List<IStateSwitcherActions>();
    private readonly InputAction m_StateSwitcher_EnableADSView;
    private readonly InputAction m_StateSwitcher_EnableThirdPersonView;
    private readonly InputAction m_StateSwitcher_EnableInspectionView;
    private readonly InputAction m_StateSwitcher_EnableHostileInspectionView;
    public struct StateSwitcherActions
    {
        private @PlayerInputActions m_Wrapper;
        public StateSwitcherActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnableADSView => m_Wrapper.m_StateSwitcher_EnableADSView;
        public InputAction @EnableThirdPersonView => m_Wrapper.m_StateSwitcher_EnableThirdPersonView;
        public InputAction @EnableInspectionView => m_Wrapper.m_StateSwitcher_EnableInspectionView;
        public InputAction @EnableHostileInspectionView => m_Wrapper.m_StateSwitcher_EnableHostileInspectionView;
        public InputActionMap Get() { return m_Wrapper.m_StateSwitcher; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StateSwitcherActions set) { return set.Get(); }
        public void AddCallbacks(IStateSwitcherActions instance)
        {
            if (instance == null || m_Wrapper.m_StateSwitcherActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_StateSwitcherActionsCallbackInterfaces.Add(instance);
            @EnableADSView.started += instance.OnEnableADSView;
            @EnableADSView.performed += instance.OnEnableADSView;
            @EnableADSView.canceled += instance.OnEnableADSView;
            @EnableThirdPersonView.started += instance.OnEnableThirdPersonView;
            @EnableThirdPersonView.performed += instance.OnEnableThirdPersonView;
            @EnableThirdPersonView.canceled += instance.OnEnableThirdPersonView;
            @EnableInspectionView.started += instance.OnEnableInspectionView;
            @EnableInspectionView.performed += instance.OnEnableInspectionView;
            @EnableInspectionView.canceled += instance.OnEnableInspectionView;
            @EnableHostileInspectionView.started += instance.OnEnableHostileInspectionView;
            @EnableHostileInspectionView.performed += instance.OnEnableHostileInspectionView;
            @EnableHostileInspectionView.canceled += instance.OnEnableHostileInspectionView;
        }

        private void UnregisterCallbacks(IStateSwitcherActions instance)
        {
            @EnableADSView.started -= instance.OnEnableADSView;
            @EnableADSView.performed -= instance.OnEnableADSView;
            @EnableADSView.canceled -= instance.OnEnableADSView;
            @EnableThirdPersonView.started -= instance.OnEnableThirdPersonView;
            @EnableThirdPersonView.performed -= instance.OnEnableThirdPersonView;
            @EnableThirdPersonView.canceled -= instance.OnEnableThirdPersonView;
            @EnableInspectionView.started -= instance.OnEnableInspectionView;
            @EnableInspectionView.performed -= instance.OnEnableInspectionView;
            @EnableInspectionView.canceled -= instance.OnEnableInspectionView;
            @EnableHostileInspectionView.started -= instance.OnEnableHostileInspectionView;
            @EnableHostileInspectionView.performed -= instance.OnEnableHostileInspectionView;
            @EnableHostileInspectionView.canceled -= instance.OnEnableHostileInspectionView;
        }

        public void RemoveCallbacks(IStateSwitcherActions instance)
        {
            if (m_Wrapper.m_StateSwitcherActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IStateSwitcherActions instance)
        {
            foreach (var item in m_Wrapper.m_StateSwitcherActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_StateSwitcherActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public StateSwitcherActions @StateSwitcher => new StateSwitcherActions(this);
    public interface ITankmovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnIncreaseGear(InputAction.CallbackContext context);
        void OnDecreaseGear(InputAction.CallbackContext context);
        void OnTurretRotate(InputAction.CallbackContext context);
        void OnShellSwitch(InputAction.CallbackContext context);
        void OnZoomADS(InputAction.CallbackContext context);
    }
    public interface ITankinspectionActions
    {
        void OnZoom(InputAction.CallbackContext context);
        void OnInspectTank(InputAction.CallbackContext context);
        void OnAllowInspection(InputAction.CallbackContext context);
    }
    public interface IStateSwitcherActions
    {
        void OnEnableADSView(InputAction.CallbackContext context);
        void OnEnableThirdPersonView(InputAction.CallbackContext context);
        void OnEnableInspectionView(InputAction.CallbackContext context);
        void OnEnableHostileInspectionView(InputAction.CallbackContext context);
    }
}
