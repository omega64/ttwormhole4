using System;

public class Class1
{
	public Class1()
	{
	}
}
spare

     private void OnControllerColliderHit(ControllerColliderHit hit)

{
    if (hit.gameObject.tag == "Player")
    {
        if (hit.point.z > transform.position.z)
        {
            Death();
        }
    }

    if (hit.gameObject.tag == "Wall")
    {
        isDead = false;
        return;

    }




}
private void OnCollisionEnter2D(Collision2D collision)
{
    Death();
}