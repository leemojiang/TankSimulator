using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class ShootComponent : TankComponent
{
    [SerializeField] private ParticleSystem fireExplosion;
    [SerializeField] private List<Shell> _shellPrefabs;
    private int _maxShellTypes;
    private int _currentShellIndex;

    public int CurrentAmmoCount { get; private set; }
    public bool CanFire { get; private set; } = true;
    public string CurrentShellType { get; private set; }

    private void Start()
    {
        CurrentAmmoCount = componentManager.Properties.AmmoCount;
        _maxShellTypes = _shellPrefabs.Count;
        CurrentShellType = _shellPrefabs[_currentShellIndex].GetShellType();
    }

    public void FireShell()
    {
        GameObject shellInstance = Instantiate(_shellPrefabs[_currentShellIndex].gameObject,
            componentManager.ShellSpawnpoint.position, componentManager.ShellSpawnpoint.rotation);
        Rigidbody rb = shellInstance.GetComponent<Rigidbody>();
        rb.AddForce(rb.transform.forward * componentManager.Properties.FireForce);
        fireExplosion.transform.position = componentManager.VFXPivot.position;
        fireExplosion.transform.rotation = componentManager.VFXPivot.rotation;
        fireExplosion.Play();
        CanFire = false;
        CurrentAmmoCount--;
        if (CurrentAmmoCount > 0)
            StartCoroutine(ReloadCannon());
        else CanFire = false;
    }

    private IEnumerator ReloadCannon()
    {
        yield return new WaitForSeconds(componentManager.Properties.ReloadTime);

        CanFire = true;
    }

    public bool HasAmmo() => CurrentAmmoCount > 0;

    public float TrackDistance()
    {
        RaycastHit hit;
        Debug.DrawRay(componentManager.ShellSpawnpoint.position, componentManager.ShellSpawnpoint.forward * 1000,
            Color.red);
        if (Physics.Raycast(componentManager.ShellSpawnpoint.position, componentManager.ShellSpawnpoint.forward,
                out hit, Mathf.Infinity))
        {
            return (float)Math.Round(hit.distance, 2);
        }

        return 0;
    }

    public void SwitchShell()
    {
        _currentShellIndex++;
        if (_currentShellIndex > _maxShellTypes - 1)
            _currentShellIndex = 0;
        CurrentShellType = _shellPrefabs[_currentShellIndex].GetShellType();
    }
}