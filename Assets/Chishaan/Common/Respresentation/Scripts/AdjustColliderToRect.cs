using UnityEngine;

namespace Nyg2016.Common.Representation
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(BoxCollider))]
    [AddComponentMenu("Chishaan/Common/Adjust Collider To Rect")]
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public sealed class AdjustColliderToRect : MonoBehaviour
    {
        private RectTransform _rectTransform;
        private BoxCollider _collider;

        private void Awake()
        {
            _rectTransform = GetComponent(typeof(RectTransform)) as RectTransform;
            _collider = GetComponent(typeof(BoxCollider)) as BoxCollider;
        }

        private void Update()
        {
            var rectSize = _rectTransform.rect.size;
            //_collider.center = Vector3.zero;
            _collider.size = new Vector3(rectSize.x, rectSize.y, _collider.size.z);
        }
    }
}