using UnityEngine;
using System.Collections;

namespace Chishaan.Common.Representation
{
    [RequireComponent(typeof(Rigidbody))]
    [AddComponentMenu("Chishaan/Common/Apply Accelerometer")]
    [DisallowMultipleComponent]
    public sealed class ApplyAccelerometer : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private void OnEnable()
        {
            if(!SystemInfo.supportsAccelerometer)
            {
                enabled = false;
            }
        }

        private void Awake()
        {
            _rigidbody = GetComponent(typeof(Rigidbody)) as Rigidbody;
        }

        private void Update()
        {
            _rigidbody.AddForce(Vector3.Scale(Input.acceleration, new Vector3(1, 1, -1)));
        }

       
    }
}