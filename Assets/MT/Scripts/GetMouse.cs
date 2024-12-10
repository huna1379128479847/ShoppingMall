using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMouse : MonoBehaviour
{
    [SerializeField ] private ENDJudgment PopUp;
    [SerializeField] private GameObject Button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PopUp.PopUp_Active();
        }
    }
}
