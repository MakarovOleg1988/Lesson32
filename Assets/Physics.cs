using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lesson32
{
    [RequireComponent(typeof(MeshRenderer))]
    public class Physics : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler
    {
        private MeshRenderer _meshRenderer;

        public event EventHandler<MeshRenderer> OnPointerDownEventHandler;
        public event EventHandler<MeshRenderer> OnPointerUpEventHandler;

        private void OnValidate()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position += (Vector3)eventData.delta * PhysicsRaycastExample.dragSpeed;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            OnPointerDownEventHandler?.Invoke(this, _meshRenderer);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log(gameObject.name);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            OnPointerUpEventHandler?.Invoke(this, _meshRenderer);
        }
    }
}
