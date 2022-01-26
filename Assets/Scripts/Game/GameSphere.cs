using UnityEngine;

[RequireComponent(typeof(Destroyable))]
public class GameSphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Hero>())
        {
            gameObject.GetComponent<Destroyable>().Destroy();
        }
    }
}
