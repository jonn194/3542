﻿using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected WeaponData weaponData;
    
    private float currentTime;

    protected abstract void CreateBullet();

    public virtual void Update()
    {
        currentTime += Time.deltaTime;
    }
    
    public virtual void Fire()
    {
        if (!CanShoot())
            return;
        
        CreateBullet();
        currentTime = 0;
    }
    
    protected bool CanShoot()
    {
        return currentTime > weaponData.rateOfFire;
    }
}

public enum WeaponType
{
    Basic,
    TriShot,
    Sinusoidal
}