using UnityEngine;
public class FieldTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger area.");
            audioSource.Play();
        }
    }
}
