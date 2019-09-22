using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Examples;

public class FloorManager : MonoBehaviour
{
    private static FloorManager _Instance;

    public VRTK_StraightPointerRenderer pointerRenderer;

    [HideInInspector]
    public List<GameObject> stages = new List<GameObject>();
    [HideInInspector]
    public List<GameObject> chairs = new List<GameObject>();
    [HideInInspector]
    public List<GameObject> tables = new List<GameObject>();

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
        GameObject mObject = null;
        if (flag)
        {
            print("position to place :" + pointerRenderer.GetActualCursor().transform.position);
            mObject = Instantiate(furnitureModelGame, new Vector3(pointerRenderer.GetActualCursor().transform.position.x, 0.0f,
                pointerRenderer.GetActualCursor().transform.position.z), furnitureModelGame.transform.rotation);
            flag = false;
        }
        switch (mObject.gameObject.tag)
        {
            case "Chairs":
                chairs.Add(mObject);
                break;
            case "Tables":
                tables.Add(mObject);
                break;
            case "Stages":
                stages.Add(mObject);
                break;
            default:
                break;
        }
    }

    public void ChangeChairsMaterials(Material material)
    {
        foreach (var item in chairs)
        {
            item.GetComponent<Renderer>().material = material;
        }
    }
    public void ChangeTablesMaterials(Material material)
    {
        foreach (var item in tables)
        {
            item.GetComponent<Renderer>().material = material;
        }

    }
    public void ChangeStagesMaterials(Material material)
    {
        foreach (var item in stages)
        {
            item.GetComponent<Renderer>().material = material;
        }
    }

}
