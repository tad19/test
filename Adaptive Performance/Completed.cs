using UnityEngine;
using UnityEngine.SceneManagement;

public class SpotlightTrigger : MonoBehaviour
{
    // Define the scene name to load when the spotlight is hi

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the car
        if (other.gameObject.tag == "Car")
        {
            // Load the specified scene
            SceneManager.LoadScene(4);
        }
    }
}

