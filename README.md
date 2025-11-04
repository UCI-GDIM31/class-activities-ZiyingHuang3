# in-class-activities
## Devlogs
### W1
Hello World!

### W2
1.Because the color are float and not whole number. There is a smooth transition between 2 colors.
2.The bounce counts how many times has bounced and it is a whole number so it is an int.
3.That means the variable is working as a float. The error was with variable wasn't used correct. There was a reference issue in the code.

### W3
1. input: float playerhittime, float beattime output: bool true=hit false=miss

### W4
table#4  
line 5: SerializeField make this variable visible and it is private. Float is a number like 1.0. _moveSpeed is how fast the cat moves and it is 1.0f
line 22: This float variable called translation and it is a player's input on Vertical axis. This multiplies cat's speed multiplies Time_deltatime makes this frame by frame at the same speed
line 25: The transform of the game object and translate(x, y, z) make it moves forward and backward.

1.We put Rigidbodies to cat and ball. Trigger the goal collider on
2.We just tried to tigger it on and off to see what happens. We found out that the goal need to trigger the collider on.

### W5
1.How Vector3 makes gameobject to move? A:Vector3 is (x,y,z) of a point. We can assign a new position by using transform.position to change its position

### W6
For BatW6, I plan to write the speed first which is private float. I need the cat's position so I need to put down Transform. It calls every frame so I need to use Update() and Vector3.MoveTowards to make bats to chase the cat. Make bats to stop chasing, I need to use eable=false
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
