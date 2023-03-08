using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TankComponentManager : MonoBehaviour
{
    public TankProperties Properties;
    public Rigidbody TankRB;
    public BaseHUDManager entityHUD;
    public EventManager eventManager;

    public bool HasDied;

    [Header("Transformation")]
    public List<WheelCollider> LeftTrackWheelColliders = new List<WheelCollider>(); 
    public List<WheelCollider> RightTrackWheelColliders = new List<WheelCollider>();
    public MeshRenderer LeftTrackRenderer;
    public MeshRenderer RightTrackRenderer;
    public Transform CenterOfMass;
    public Transform TurretTransform;
    public Transform BarrelTransform;

    [Header("Shooting")] 
    public Transform ShellSpawnpoint;
    public Transform VFXPivot;

    [HideInInspector] public Vector3 BarrelEulerAngles;
    [HideInInspector] public Vector3 TurretEulerAngles;

    private void Awake()
    {
        eventManager = GetComponent<EventManager>();
        if(entityHUD == null)
            entityHUD = GetComponent<BaseHUDManager>();
    }

    private void Start()
    {
        entityHUD.UpdateName(Properties.TankName);
    }

    private void OnValidate()
    {
        TankRB.mass = Properties.TankMass;
        TankRB.centerOfMass = CenterOfMass.localPosition;
    }

    private void LateUpdate()
    {
        BarrelTransform.localEulerAngles = BarrelEulerAngles;
        TurretTransform.localEulerAngles = TurretEulerAngles;
    }

    public Vector3 GetCurrentBarrelDirection()
    {
        return BarrelTransform.forward;
    }
}