using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FurniturePlaceManger : MonoBehaviour
{
    public VRTK_StraightPointerRenderer pointerRenderer;
    public GameObject furnitureModel;

    public void GenerateFurnitureModel()
    {
        print("position to place :" + pointerRenderer.GetActualCursor().transform.position);
        GameObject @object =  Instantiate(furnitureModel, pointerRenderer.GetActualCursor().transform.position, pointerRenderer.GetActualCursor().transform.rotation);
        @object.transform.parent = pointerRenderer.transform;
    }

}
