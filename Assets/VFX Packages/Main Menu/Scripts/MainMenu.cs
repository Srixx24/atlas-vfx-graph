using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button fireworksButton;
    public Button imageFireworksButton;
    public Button fireballButton;
    public Button campfireButton;
    public Button slimeBombButton;
    public Button quitButton;


   void Start ()
    {
        fireworksButton.onClick.AddListener(Fireworks);
        imageFireworksButton.onClick.AddListener(ImageFireworks);
        fireballButton.onClick.AddListener(Fireball);
        campfireButton.onClick.AddListener(Campfire);
        slimeBombButton.onClick.AddListener(SlimeBomb);
        quitButton.onClick.AddListener(QuitSamples);
    }

    private void Fireworks()
    {
        SceneManager.LoadScene("0. Fireworks");
    }

    private void ImageFireworks()
    {
        SceneManager.LoadScene("1. Graphics Fireworks");
    }

    private void Fireball()
    {
        SceneManager.LoadScene("2. Fireball");
    }

    private void Campfire()
    {
        SceneManager.LoadScene("3. Smoke and Wind");
    }

    private void SlimeBomb()
    {
        SceneManager.LoadScene("4. Slime Bomb");
    }

    private void QuitSamples()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
