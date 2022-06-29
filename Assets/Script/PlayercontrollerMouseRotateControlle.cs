using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マウスの動きで視点を切り替える
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayercontrollerMouseRotateControlle : MonoBehaviour
{
    public float speed = 6.0F;          //歩行速度
    public float jumpSpeed = 8.0F;      //ジャンプ力
    public float gravity = 20.0F;       //重力の大きさ
    public float rotateSpeed = 3.0F;    //回転速度

    private Animator anim;
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float _moveHorizon;
    private float _moveVertical;
    private float _mouseX;
    
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        
    }

    void Update () {

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("blanim", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("blanim", false);
        }

        _moveHorizon = Input.GetAxis ("Horizontal");    //左右矢印キーの値(-1.0~1.0)
        _moveVertical = Input.GetAxis ("Vertical");      //上下矢印キーの値(-1.0~1.0)
        _mouseX = Input.GetAxis ("Mouse X");      //マウスの左右移動量(-1.0~1.0)

        //キャラクターの移動を回転
        if (controller.isGrounded) {
            moveDirection = speed * new Vector3 (_moveHorizon, 0, _moveVertical);//移動方向を決定
            moveDirection = transform.TransformDirection(moveDirection);         //ベクトルをローカル座標からグローバル座標へ変換
            gameObject.transform.Rotate (new Vector3 (0, rotateSpeed * _mouseX, 0));
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);



    }
}
