# Coroutines
This repository serves as an educational tool for learning about and working with Coroutines in Unity.

## What are Coroutines?
Coroutines are methods or routines that run on the main thread of Unity and execute every cycle (either Update or FixedUpdate cycles depending on when and how the coroutine is managed).

## What are Coroutines NOT?
Coroutines are NOT parallel processing. They allow you to spread logic across multiple frames, not multiple threads!

## Why not just perform all logic in the Update or FixedUpdate methods?
In the Update methods, you would need to manage a boolean that dictates whether or not logic is performed. This can quickly spiral into large if structures and monoliths, or multiple Update methods running every frame to manage the logic.

Additionally, coroutines have significant less overhead than the Update/FixedUpdate methods in Unity, as the Update methods are called every frame regardless of whether or not the bool is true or not if the method exists. Coroutines are only called on frames that they are active.
