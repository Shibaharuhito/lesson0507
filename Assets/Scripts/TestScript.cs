using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMSYS
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField]
        private int index;

        [SerializeField]
        private Rigidbody rigidBody;

        [SerializeField]
        private float BallSpeed=30;
  
        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        private void Awake()
        {
            //rigidBody=
        }

        // Update is called once per frame
        void Update()
        {
            // �X�y�[�X����������o�E���h�~�܂�
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rigidBody.velocity = Vector3.up * BallSpeed;
            }
        }

        public void Init()
        {
            Debug.Log($"{index}");
        }
    }
}