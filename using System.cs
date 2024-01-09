using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;


public class CheckCorrectRate : MonoBehaviour
{
    public Transform[] Ding = new Transform[4];

    public Transform[] Ge = new Transform[4];

    public Transform[] Jue = new Transform[4];

    public Transform[] Ping = new Transform[4];

    public GameObject ShowPassCanvas;

    public GameObject ShowNotPassCanvas;
    public GameObject NextLevelTeleportPoint;

    public GameObject CheckCanvas;

    private bool isShowCheckCanvas=false;

    //public LayerMask layermask;
    //public Transform RayOriginTrans;

   // public GameObject LaserBeam;
    // public Transform[] dis = new Transform[2];
    private int WrongNum;
    // Start is called before the first frame update
    void Start()
    {
        ShowPassCanvas.SetActive(false);
        ShowNotPassCanvas.SetActive(false);
        NextLevelTeleportPoint.SetActive(false);
        CheckCanvas.SetActive(isShowCheckCanvas);

        //Distance = ;
        //Debug.Log("摆放正确的总距离为:"+Distance);

        SteamVR_Actions.default_CheckCorrectRate.onStateUp += Default_CheckCorrectRate_onStateUp;

    }

    private void Default_CheckCorrectRate_onStateUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        isShowCheckCanvas = !isShowCheckCanvas;
        CheckCanvas.SetActive(!isShowCheckCanvas);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public int CalculateDistance(Transform[] t)
    {
        int count = 0;
        for (int i = 1; i < t.Length;i++)
        {
            if(Vector3.Distance(t[0].position, t[i].position)>5)
                count++;
            if (count == 2)
                break;

        }


        return count;
    }
    public void CheckDistance()
    {
        WrongNum = CalculateDistance(Ding) + CalculateDistance(Ge) + CalculateDistance(Jue) + CalculateDistance(Ping);
        if (WrongNum < 3)
        {
            ShowPassCanvas.SetActive(true);
            NextLevelTeleportPoint.SetActive(true);
        }
        else
            ShowNotPassCanvas.SetActive(true);

    }
    public void CloseMenu()
    {
        isShowCheckCanvas = false;
        CheckCanvas.SetActive(false);
        
    }
}