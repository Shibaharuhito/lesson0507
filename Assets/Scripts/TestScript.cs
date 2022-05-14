using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMSYS
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField]
        private int index;

        private int k4sen;
  
        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void Init()
        {
            Debug.Log($"{index}");
        }
    }
}