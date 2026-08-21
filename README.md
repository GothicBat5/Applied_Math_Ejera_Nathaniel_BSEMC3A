# Game Development Scoring System
> Scoring System - BSEMC 3A


## Task

- You will receive a starting Unity project.
- The provided project will already contain the basic gameplay, but some functionality related to the scoring system will be missing.
- You are required to modify and complete the project.
  
# Your implementation must include:

### 1. Score System

Implement the functionality that allows the player's score to increase when the appropriate gameplay event occurs.

The scoring system must:
- Store the player's current score.
- Add the appropriate number of points.
- Use the correct variables and data types.
- Update the score whenever points are earned.

### 2. Score UI

- Connect the scoring system to the provided UI.
- The current score must be displayed to the player.

For example:

- Score: 500
- When the score changes, the displayed value must also change.
- You must use the appropriate Unity UI component provided in the project.

### 3. High Score System

- Implement a high score system that keeps track of the player's best score.
- The system must compare the current score with the existing high score.
- The high score should only change when:
Current Score > High Score

### 4. Saving the High Score

- Implement high score persistence using Unity's PlayerPrefs.
- Only the high score is required to be saved.
- The current gameplay score does not need to be saved.
- When the player achieves a new high score:
  
### 5. Loading the High Score
- When the game starts, load the previously saved high score using PlayerPrefs.
  
If no high score exists yet, the high score should start at: 0

The high score should remain available even after the game is stopped and played again.
