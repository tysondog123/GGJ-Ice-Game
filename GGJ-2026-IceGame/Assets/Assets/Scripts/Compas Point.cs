using Unity.Mathematics;
using UnityEngine;

public class CompasPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject Base;
    private void Start()
    {
        PointToBase();
    }
    public void PointToBase()
    {
        gameObject.transform.LookAt(Base.transform.position);
        transform.rotation =quaternion.Euler(0f,0f,transform.rotation.z);
    }
}
