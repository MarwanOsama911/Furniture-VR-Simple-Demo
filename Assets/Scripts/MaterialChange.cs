using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class MaterialChange : MonoBehaviour
{

    public GameObject furnitureModel;
    public Material material;
    
    public void changeMaterial()
    {
        furnitureModel.GetComponent<Renderer>().material = material;
    }
}
