using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FurniturePlaceManger : MonoBehaviour
{
    public GameObject furnitureModel;
    public Material material;

    public void FurnitureUseClick()
    {
        furnitureModel.GetComponent<Renderer>().material = material;
        FloorManager.Instance.flag = true;
        FloorManager.Instance.furnitureModelGame = furnitureModel;
    }

    public void ResetFlag()
    {
        FloorManager.Instance.flag = false;
    }
}