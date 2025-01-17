[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

How would you describe this game world in objects?
- Objects 
  - UI
    - Seeds planted UI
    - Seeds remaining UI
  - Player
    - Movement 
  - Plant 

What attributes and actions do these objects have?
- UI
  - Seed counter 
    - Counts the seeds remaining 
    - Attributes: test
    - actions : count goes up when player plants a seed
  - Plant counter
    - Counts the plants on screen planted 
    - Attributes: text
    - Actions: count goes down when player plants a seed
- Player
  - Attributes 
    - Bunny sprite
  - Movement
    - Input - WASD keys
    - Output - player changes location
  - Planting seeds
    - Input - press spacebar
    - Output - Plants a plant 

How do these objects act on or affect each other?
  - UI
    - Seed counter goes down as Plant counter goes up 
  - Player
    - Action of spacebar to plant affects both counters
    - Seed counter only allows player to plant as many plants as there are seeds to do so


## Devlog
  My plan was not very different from Prof. Reid's answer key. A bulk of my plan's actions and logic were similar, with a few details missing. I had all of the player input on my plan but what I initially failed to include was the look of the sprites, I later added in that the player sprite is represented by a bunny, and the prefab is represented by a pixelated plant seed. I also had forgotten to mention how UI text is its own object in question 3, but I did mention its functionality.

  In my breakdown, I note that the player has to have 2 different actions: Movement Action and Planting Action. Before anything, I wanted to get my player moving and the prefab action completed (as it was fresh in my mind). Within the game's code, I decided to use a [SerializeField] private 2D rigid body called _rigidBody2D. I also wanted to declare a [SerializeField] private gameobject called _plantPrefab, which is where I will input my Plant prefab. Once I had movement set up, I began to create what on my plan was called 'Planting Action.' I used the instantiate function to spawn the _plantPrefab gameobject at the same position as the Player gameobject once the player has pushed Space (or in other words, KeyCode.Space). 

  Once the player Object was completely set up, I began work on the UI. I created a Canvas with 4 UI Text objects: Seeds Planted (Text), Seeds Planted [Number], Seeds Remaining (Text), and Seeds Remaining [Number]. UI with the [Number] at the end is the text that updates when the planting action takes place. UI with (Text) are the objects that will not update at all and are referenced on the breakdown as "Seeds Planted UI" and "Seeds Remaining UI." 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting your break-down to your code. :)

Next time, please actually put the text from your break-down into the Devlog instead of just the link. You can format your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
