using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using Zenject;

public class Artillery : MonoBehaviour
{
    private Bullet.Factory _bulletFactory;
    [SerializeField] private Transform bulletPoint;

    [Inject]
    private void Construct(Bullet.Factory bulletFactory)
    {
        _bulletFactory = bulletFactory;
    }

    private void Fire()
    {
        _bulletFactory.Create(bulletPoint.position, Vector3.forward, 500f);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Fire();
    }
}
