using UnityEngine.SceneManagement;
using UnityEngine;

public class levelCompleted : MonoBehaviour
{
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
