using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class ObjectMovement : MonoBehaviour
{
    private void Update()
    {
        if (GetComponent<VRTK_InteractableObject>().IsUsing())
        {
            //gameObject.transform.parent = null;
            gameObject.transform.position = new Vector3(FloorManager.Instance.pointerRenderer.GetActualCursor().transform.position.x,
                0f,
                FloorManager.Instance.pointerRenderer.GetActualCursor().transform.position.z);
        }
    }
}
