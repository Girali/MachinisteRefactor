using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class UserInputBox : MonoBehaviour
    {

        public GameObject item;
        public GameObject openRender;
        public GameObject closeRender;

        private bool open = false;

        public void OpenClose(bool b)
        {
            open = b;

            openRender.SetActive(b);
            closeRender.SetActive(!b);
        }

        public void OnMouseDown()
        {
            if (open)
            {
                UserInputController.Instance.OnBoxClick(this);
            }
        }
    }
}
