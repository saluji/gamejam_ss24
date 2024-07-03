using UnityEngine;

public class BuildingDestruction : MonoBehaviour
{
    private bool isBroken = false; // Um sicherzustellen, dass das Objekt nur einmal zerf�llt

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fireball") && !isBroken)
        {
            isBroken = true;

            // F�ge einen Rigidbody hinzu und aktiviere ihn
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (rb == null)
            {
                rb = gameObject.AddComponent<Rigidbody>();
            }
            rb.isKinematic = false;

            // Zerst�re das Objekt nach 5 Sekunden
            Destroy(gameObject, 2f);

            // Zerst�re den Fireball nach 2 Sekunden
            Destroy(other.gameObject, 1f);
        }
    }
}
