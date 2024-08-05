using UnityEngine;

public class CameraMove : MonoBehaviour
{

    private float velocidade = 200f;
    private void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetMouseButtonDown(1)){
            pos.z += velocidade * Time.deltaTime;
        }

        transform.position = pos;
    }
}
