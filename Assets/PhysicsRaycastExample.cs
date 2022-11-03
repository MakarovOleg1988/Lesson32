using UnityEngine;

namespace Lesson32
{
    public class PhysicsRaycastExample : MonoBehaviour
    {
        public static float dragSpeed;

        private Physics[] _items;
        [SerializeField] private Material _selectColor;
        [SerializeField] private Material _UnSelectColor;
        [SerializeField, Range(0.01f, 0.1f)] private float _dragSpeed;

        void Start()
        {
            dragSpeed = _dragSpeed;
            _items = FindObjectsOfType<Physics>();

            foreach (var item in _items)
            { 
                item.OnPointerDownEventHandler += (q, qq) => qq.material = _selectColor;
                item.OnPointerUpEventHandler += (q, qq) => qq.material = _UnSelectColor;
            }
        }

    }
}
