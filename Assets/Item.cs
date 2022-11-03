using UnityEngine;
using UnityEngine.EventSystems;

namespace Lesson32
{
    public class Item : MonoBehaviour, IDragHandler
    {
        public void TestClick_EditorEvent()
        {
            Debug.Log("Test");
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.pointerCurrentRaycast.screenPosition;
        }
    }
}
