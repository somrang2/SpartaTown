using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트 

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        //주로 내 컴퍼넌트안에서 끝나는 거
        // controlller랑 TopDownMovement랑 같은 게임오브젝트 안에 있다라고 가정(이 게임오프젝트 안에서만 찾음)
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        //FixedUpdate는 물리업데이트랑 관련
        //rigibody의 값을 바꾸니깐 FixedUpdate
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 10;
        movementRigidbody.velocity = direction;         // rigidbody의 속도를 나타낸다. velocity는 일정하게 움직이는 속도
    }

}
