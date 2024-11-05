using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Bullet : MonoBehaviour
{
    [Inject]
        private void Construct(Vector3 position, Vector3 direction, float power)
        {
            transform.position = position;
            GetComponent<Rigidbody>().AddForce(direction * power);
        }

        public class Factory : PlaceholderFactory<Vector3, Vector3, float, Bullet>
        {
            
        }
}
