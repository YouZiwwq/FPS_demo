using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MyFpsGame.Player
{
    public class PlayerControl : MonoBehaviour
    {
        /// <summary>
        /// 碰撞体
        /// </summary>
        [Header("玩家碰撞器")]
        private CharacterController controller;
        /// <summary>
        /// 人物移动方向
        /// </summary>
        [Header("人物方向")]
        public Vector3 moveDirotion;
        /// <summary>
        /// 人物移动速度
        /// </summary>
        [Header("玩家数值")]
       [Tooltip("行走速度")] public float walkSpeed = 5f;
        [Tooltip("跑步速度")] public float runSpeed = 5f;
        [Tooltip("下蹲行走速度")] public float crouchSpeed = 5f;
        void Start()
        {
            controller = this.GetComponent<CharacterController>();
        }
        private void FixedUpdate()
        {
            MoveMent();
        }
        /// <summary>
        /// 人物移动
        /// </summary>
        public void MoveMent()
        {
            //这里如果想让移动急停，用RAW
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            //人物移动方向
            moveDirotion= (transform.right *h+ transform.forward*v).normalized;
            controller.Move(moveDirotion * walkSpeed * Time.deltaTime);
        }
    }
}

