[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.
https://docs.google.com/document/d/1fGfiAsCCjFu1pjs5OtMj13L0ge45Ec4dYU46yPN-lpc/edit?usp=sharing
## Devlog
Prompt: Include the HW1 breakdown exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the breakdown connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


## Write your Devlog here:
  My plan was not very different from Prof. Reid's answer key. A bulk of my plan's actions and logic were similar, with a few details missing. I had all of the player input on my plan but what I initially failed to include was the look of the sprites, I later added in that the player sprite is represented by a bunny, and the prefab is represented by a pixelated plant seed. I also had forgotten to mention how UI text is its own object in question 3, but I did mention its functionality.

  In my breakdown, I note that the player has to have 2 different actions: Movement Action and Planting Action. Before anything, I wanted to get my player moving and the prefab action completed (as it was fresh in my mind). Within the game's code, I decided to use a [SerializeField] private 2D rigid body called _rigidBody2D. I also wanted to declare a [SerializeField] private gameobject called _plantPrefab, which is where I will input my Plant prefab. Once I had movement set up, I began to create what on my plan was called 'Planting Action.' I used the instantiate function to spawn the _plantPrefab gameobject at the same position as the Player gameobject once the player has pushed Space (or in other words, KeyCode.Space). 

  Once the player Object was completely set up, I began work on the UI. I created a Canvas with 4 UI Text objects: Seeds Planted (Text), Seeds Planted [Number], Seeds Remaining (Text), and Seeds Remaining [Number]. UI with the [Number] at the end is the text that updates when the planting action takes place. UI with (Text) are the objects that will not update at all and are referenced on the breakdown as "Seeds Planted UI" and "Seeds Remaining UI." 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
