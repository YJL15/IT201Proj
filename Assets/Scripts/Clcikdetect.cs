
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetector : MonoBehaviour
{
private void Update()
    {
        if (Mouse.current == null || Camera.main == null)
            return;
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay( Mouse.current.position.ReadValue());
            //make a ray from cam to mouse to see what mouse is on
            if (Physics.Raycast(ray, out RaycastHit hit))
            //thing it hits needs a collider
            {
                SpawnButton button = hit.collider.GetComponent<SpawnButton>();
                if (button != null)
                {
                    button.SpawnObject();
                }
            }
    }}
}
