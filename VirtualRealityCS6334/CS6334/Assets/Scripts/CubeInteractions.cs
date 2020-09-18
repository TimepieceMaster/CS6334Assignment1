using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractions : MonoBehaviour
{
	private void Update()
	{
		TryToMove();
		TryToRotate();
	}

	bool moving = false;
	bool rotating = false;

	public void StartMoving()
	{
		moving = true;
	}

	public void StopMoving()
	{
		moving = false;
	}

	public void StartRotating()
	{
		rotating = true;
	}

	public void StopRotating()
	{
		rotating = false;
	}

    public void TryToMove()
	{
		if (moving)
		{
			transform.position = transform.position + Vector3.left * 0.5f * Time.deltaTime;
		}
	}

	public void TryToRotate()
	{
		if (rotating)
		{
			transform.Rotate(Vector3.up, 180.0f * Time.deltaTime);
		}
	}

	public void TurnRed()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
}
