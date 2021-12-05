using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    //움직일 배경의 Material을 가져와서 offset을 조정해서 움직이는것을 만든다.
    public MeshRenderer[]  bGMaterial;

    [SerializeField][Tooltip("배경을 움직이게 할 속도")]
    private float[] offsetSpeedMenu; //0=땅, 1=강, 2=하늘
    private float ground = 0, sky = 0, river =0;
    void Update()
    {
        BGMove();
    }

    void BGMove()
    {
        ground += offsetSpeedMenu[0] * Time.deltaTime;
        river += offsetSpeedMenu[1] * Time.deltaTime;
        sky += offsetSpeedMenu[2] * Time.deltaTime;

        bGMaterial[0].material.mainTextureOffset = new Vector2(ground, 0);
        bGMaterial[1].material.mainTextureOffset = new Vector2(river, 0);
        bGMaterial[2].material.mainTextureOffset = new Vector2(sky, 0);
    }
}
