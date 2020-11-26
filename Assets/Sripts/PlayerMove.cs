using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float yaw = 0;
    float pitch = 0;

    public float BaseSpeed = 5;
    public float RunSpeed = 10;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        yaw += Input.GetAxis("Mouse X");
        pitch -= Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -90, 90);

        float speed = BaseSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = RunSpeed;
        }
        Vector3 translation = new Vector3();
        translation += Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * speed;
        translation += Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speed;

        Vector3 rotatedTranslation = Quaternion.Euler(0, yaw, 0) * translation;
        transform.position += rotatedTranslation;
        transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }
}
