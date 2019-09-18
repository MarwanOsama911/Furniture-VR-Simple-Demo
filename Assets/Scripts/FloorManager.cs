using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class FloorManager : MonoBehaviour
{
    private static FloorManager _Instance;

    public VRTK_StraightPointerRenderer pointerRenderer;

    [HideInInspector]
    public GameObject furnitureModelGame;
    [HideInInspector]
    public bool flag = false;

    public static FloorManager Instance
    {
        get { return _Instance; }
    }

    private void Awake()
    {
        /** Order of methods calling is critical**/
        if (_Instance == null)
        {
            _Instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void GenerateFurnitureModel()
    {
        print("maro");
        if (flag)
        {
            print("position to place :" + pointerRenderer.GetActualCursor().transform.position);
            GameObject mObject = Instantiate(furnitureModelGame, new Vector3( pointerRenderer.GetActualCursor().transform.position.x,0.5f, pointerRenderer.GetActualCursor().transform.position.z),Quaternion.identity);
            flag = false;
        }
    }
    
}
