using UnityEngine;

public class InputComponent : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SendMessage("Jump");
        }
    }
}
