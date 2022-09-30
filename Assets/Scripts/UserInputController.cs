using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Refactor
{
    public class UserInputController : MonoBehaviour
    {
        private static UserInputController _instance = null;
        public static UserInputController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<UserInputController>();
                return _instance;
            }
        }

        private Camera cam;
        private SceneObject currentGrabbedObject;

        private void Awake()
        {
            cam = Camera.main;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (GameController.Instance.TimeScale == 0)
                    GameController.Instance.StartStopTime(1f);
                else
                    GameController.Instance.StartStopTime(0f);
            }

            if (currentGrabbedObject != null)
            {
                Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
                pos.z = 0;
                currentGrabbedObject.transform.position = pos;

                if (currentGrabbedObject.insideDropZone && currentGrabbedObject.snapToGrid)
                {
                    Transform t = GameController.Instance.GetNearestGridPoint(pos);
                    currentGrabbedObject.transform.position = t.position;
                }

                if (Input.GetMouseButtonUp(0))
                {
                    if (currentGrabbedObject.insideDropZone)
                    {
                        currentGrabbedObject.GetInScene();
                        GameController.Instance.AddObject(currentGrabbedObject);
                        EventGameController.Instance.NotifyUserPlaceElement(currentGrabbedObject);
                    }
                    else
                    {
                        Destroy(currentGrabbedObject.gameObject);
                    }

                    currentGrabbedObject = null;
                }
            }
        }

        public void OnBoxClick(UserInputBox userInputBox)
        {
            currentGrabbedObject = Instantiate(userInputBox.item).GetComponent<SceneObject>();
            currentGrabbedObject.Grab();
        }
    }
}