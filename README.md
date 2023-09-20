# IMTC 505 LAB 1 Assignment Criteria - README

These are the following criteria or points which are full-field for the LAB 1 assignment.

## Criteria 1: Imported Assets from the mentioned .unitypackage

![Alt Text](https://res.cloudinary.com/dolt8nnzc/image/upload/v1695172810/image1_obbxxi.png)

## Criteria 2: Scene Setup
Scene contains a GameObject with GameManager (eg. `GameManager prefab`) and atleast 10 GameObjects with GamePoint (eg. `PointsObject`) - 5 points
![Alt Text](https://res.cloudinary.com/dolt8nnzc/image/upload/v1695173152/image2_jdx6it.png)

## Criteria 3: Additional Assets

In compliance with the assignment, I've thoughtfully integrated two valuable assets from the open-source Unity Asset Store into my scene. These assets are collectively known as "Old Coin," and they bring depth and visual appeal to our game. 

The "Old Coin" asset package includes two distinct types of Prefabs: 
1. **Single Coin**: These single coins serve as individual collectibles, contributing to the player's score and overall gaming experience.
2. **Pile of Coin**: The "Pile of Coin" Prefab represents a collection of coins, offering a more significant reward when collected.

This thoughtful inclusion of additional assets enhances the immersive quality of our game while adhering to the assignment's requirements.

![Alt Text](https://res.cloudinary.com/dolt8nnzc/image/upload/v1695173814/image3_csi0nl.png)

## Criteria 4: Implementation of different Behaviors

In pursuit of enhancing gameplay and adding uniqueness to my Unity game, I've made two significant behavior modifications:

1. **Rotation and Aesthetic Improvements**:
   - For the Single Coin, I've introduced dynamic rotation, making it visually captivating as it spins elegantly.
   - Moreover, I've revamped the coin's appearance by altering its color and introducing a new 3D model. This refresh adds visual diversity and depth to my in-game currency.

2. **Coin Pile Scoring Adjustment**:
   - To offer players a more rewarding experience, I've adjusted the scoring criteria for collecting a Coin Pile.
   - Previously, a player earned 10 points for collecting a pile of coins. Now, users will receive a substantial 50 points for successfully collecting a Coin Pile. This modification not only makes the game more engaging but also encourages players to seek out these valuable coin piles.

```csharp
   // Single Coin Rotation and Aesthetic Improvements
   public float rotationSpeed = 60.0f; // Adjust the rotation speed as needed.
   
   // Check if it's a Single Coin or Coin Pile
   if (pile_or_Single == true)
   {
       points = 10;
       
       // Rotate the GameObject around its Y-axis.
       // You can adjust the rotationSpeed as needed for a captivating effect.
       transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
       
       pile_or_Single = false;
   }

   void Update()
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * 2);

        }
```


## Criteria 5: Point Object Behaviors


In line with the changes made to the behaviors of the game objects, here are the specific behaviors applied to individual objects:

1. **Single Coin**:
   - The Single Coin objects now exhibit dynamic rotation, adding a visually engaging element to the gameplay(new marterial added)
   - Each collected Single Coin is worth 10 points, contributing to the player's score.

2. **Coin Pile**:
   - Coin Pile objects, in contrast, do not rotate, providing a distinct visual contrast with the Single Coins.
   - Collecting a Coin Pile is significantly rewarding, as each Coin Pile now awards players with 50 points.

These object-specific behaviors enhance gameplay dynamics, creating both visual and scoring distinctions between Single Coins and Coin Piles.



## Criteria 6: Environment Behaviors

In addition to enhancing the behaviors of individual objects, I've also added dynamic behaviors to objects within the game environment. One significant addition is the introduction of environmental objects that exhibit continuous rotation and color transitions, adding a dynamic and visually appealing aspect to the game world.

The following code snippet demonstrates the behaviors applied to these environmental objects:

```csharp
// Environment Behaviors
public float rotationSpeed = 30f;           // Adjust the rotation speed as needed.
public float colorChangeInterval = 2f;      // Adjust the interval for color changes.
public float colorChangeSpeed = 0.2f;       // Adjust the color change speed as needed.

private Renderer prefabRenderer;
private Color targetColor;
private float timer = 0f;

private void Start()
{
    prefabRenderer = GetComponentInChildren<Renderer>();
    targetColor = prefabRenderer.material.color;
}

private void Update()
{
    // Rotate the object around its local Y-axis
    transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

    timer += Time.deltaTime;

    if (timer >= colorChangeInterval)
    {
        // Change color every 'colorChangeInterval' seconds
        timer = 0f;
        targetColor = new Color(Random.value, Random.value, Random.value);
    }

    // Interpolate the color towards the target color
    prefabRenderer.material.color = Color.Lerp(prefabRenderer.material.color, targetColor, colorChangeSpeed * Time.deltaTime);
}
```

## Criteria 7: Documentation

I've provided comprehensive documentation for my Unity LAB task. You can find all "Lab Task"-related documentation here [project's GitHub repository](https://github.com/tarik19x/IMTC-505-LAB).

This repository serves as a centralized hub for all project-related documentation, ensuring that developers and contributors have access to the necessary resources for efficient project understanding and development.


## Criteria 8: Upload Instructions

![Upload Instructions](images/upload-instructions.png)

Thank you for reviewing our Unity game project. Each criterion is documented with visual evidence to showcase our achievements and adherence to the assignment requirements.
