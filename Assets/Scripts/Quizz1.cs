using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizz1 : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
 
        /* y�������ɂ��Ė��b90�x�A��]������Quaternion���쐬�i�ϐ���rot�Ƃ���j
        Quaternion rot = Quaternion.AngleAxis(90.0f*Time.deltaTime, Vector3.up);
        // ���݂̎��M�̉�]�̏����擾����B
        Quaternion q = this.transform.rotation;
        // �������āA���g�ɐݒ�
        this.transform.rotation = q * rot;
        */

        transform.Rotate(0, 90 * Time.deltaTime, 0);

    }
}
