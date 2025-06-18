using UnityEngine;

public class PlaneSoundPlayer : MonoBehaviour
{
    public AudioClip redSound;
    public AudioClip greenSound;
    public AudioClip blueSound;
    public AudioClip yellowSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;

        switch (tag)
        {
            case "RedPlane":
                audioSource.PlayOneShot(redSound);
                break;
            case "GreenPlane":
                Debug.Log("Green plane collided");
                audioSource.PlayOneShot(greenSound);
                break;
            case "BluePlane":
                audioSource.PlayOneShot(blueSound);
                break;
            case "YellowPlane":
                audioSource.PlayOneShot(yellowSound);
                break;
        }
    }
}
