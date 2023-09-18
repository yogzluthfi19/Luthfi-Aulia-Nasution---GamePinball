using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpercotrol : MonoBehaviour
{
	public Collider bola;

    public float multiplier;
    public Color color;
	
    private void Start(){
        GetComponent<Renderer>().material.color = color;
    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
        }
	}
}
