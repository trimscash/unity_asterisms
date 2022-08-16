using UnityEngine;
using System.Collections;

public class HeadTrack : MonoBehaviour
{
    private bool gyroBool;
    private Gyroscope gyro;
//    private Quaternion rotFix;
    private Vector3 initial = new Vector3(90, 0, 0);

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        gyroBool = SystemInfo.supportsGyroscope;

        Debug.Log("gyro bool = " + gyroBool.ToString());

        if (gyroBool)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

        }
        else
        {
            Debug.Log("No Gyro Support");
        }
    }
    void Update()
    {
        if (gyroBool)
        {
            var camRot = R2L(gyro.attitude);      //クォータニオンを右手系から左手系へ変換
            transform.eulerAngles = initial;      //カメラの向きを端末の始状態に合わせる
            transform.localRotation = camRot * transform.localRotation;      //カメラを回転
        }else{
            var camRot= Quaternion.Euler(0f,0f,0f);
            if(Input.GetKey(KeyCode.A)){
                camRot= Quaternion.Euler(0f,0f,-0.5f); 
            }else if(Input.GetKey(KeyCode.D)){
                camRot= Quaternion.Euler(0f,0f,0.5f); 
            }else if(Input.GetKey(KeyCode.UpArrow)){
                camRot= Quaternion.Euler(0f,-0.5f,0f); 
            }else if(Input.GetKey(KeyCode.DownArrow)){
                camRot= Quaternion.Euler(0f,0.5f,0f); 
            }else if(Input.GetKey(KeyCode.RightArrow)){
                camRot= Quaternion.Euler(-0.5f,0f,0f); 
            }else if(Input.GetKey(KeyCode.LeftArrow)){
                camRot= Quaternion.Euler(0.5f,0f,0f); 
            }
            transform.localRotation = camRot * transform.localRotation;      //カメラを回転

        }
    }

    private static Quaternion R2L(Quaternion q)
    {      //クォータニオンを右手系から左手系へ変換する関数
        return new Quaternion(-q.x, -q.z, -q.y, q.w);
    }
}