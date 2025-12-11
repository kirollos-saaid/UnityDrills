using System;
using UnityEngine;

namespace GC
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10;
        void Start()
        {
            Destroy(gameObject, 10f);
        }

        private void Update()
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        }
    }
}