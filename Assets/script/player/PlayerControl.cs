using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MyFpsGame.Player
{
    public class PlayerControl : MonoBehaviour
    {
        /// <summary>
        /// ��ײ��
        /// </summary>
        [Header("�����ײ��")]
        private CharacterController controller;
        /// <summary>
        /// �����ƶ�����
        /// </summary>
        [Header("���﷽��")]
        public Vector3 moveDirotion;
        /// <summary>
        /// �����ƶ��ٶ�
        /// </summary>
        [Header("�����ֵ")]
       [Tooltip("�����ٶ�")] public float walkSpeed = 5f;
        [Tooltip("�ܲ��ٶ�")] public float runSpeed = 5f;
        [Tooltip("�¶������ٶ�")] public float crouchSpeed = 5f;
        void Start()
        {
            controller = this.GetComponent<CharacterController>();
        }
        private void FixedUpdate()
        {
            MoveMent();
        }
        /// <summary>
        /// �����ƶ�
        /// </summary>
        public void MoveMent()
        {
            //������������ƶ���ͣ����RAW
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            //�����ƶ�����
            moveDirotion= (transform.right *h+ transform.forward*v).normalized;
            controller.Move(moveDirotion * walkSpeed * Time.deltaTime);
        }
    }
}

