using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.SceneManagement;


public class PlayerInputController : TopDownController
{
    private Camera camera;
    private GameObject player1Instance;
    private GameObject player2instance;
    public GameObject player1;
    public GameObject player2;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Start()
    {


        if(player1Instance == true)
        {
            player1.SetActive(true);
            player2.SetActive(false);
        }
        else if(player2instance == true)
        {
            player1.SetActive(false);
            player2.SetActive(true);

        }
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        //실제 움직이는 처리는 여기서 하는게 아니라 PlayerMNovement에서 함
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);           //카메라의 범위에서 마우스좌표가 있는 스크인 좌표를 월드좌표로 바꿔라
        newAim = (worldPos - (Vector2)transform.position).normalized;    //이 게임오프젝트의 transform.position, 즉 Player의 transform.position
                                                                         //마우스좌표-캐릭터의 좌표, 즉 캐릭터에서 마우스까지의 좌표

        CallLookEvent(newAim);
    }

}
