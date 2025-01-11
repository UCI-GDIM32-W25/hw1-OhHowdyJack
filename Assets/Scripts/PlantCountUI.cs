using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private Player player;
    int seedsPlanted = 0;

    private void Start()
    {
        _plantedText.text = seedsPlanted.ToString();
        _remainingText.text = player._numSeeds.ToString();
    }
    void Update()
    {
        // Check if the space bar is pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if there are still seeds
            if (player._numSeeds > 0)
            {
                player._numSeeds--;
                seedsPlanted++;
                UpdateSeeds(player._numSeeds, seedsPlanted); // Update the UI
            }
        }
    }
    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        player.PlantSeed();
        _plantedText.text = seedsPlanted.ToString();
        _remainingText.text = player._numSeeds.ToString();
    }
}