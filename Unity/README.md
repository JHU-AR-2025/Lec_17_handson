# Enable Unity GLTF Support

To enable GLTF/GLB support, add GLTFast package to Unity:
Go to Window > Package Manager
Then on the left pane, click the "+" button, and select "add package by name": Then add the following name:

```
com.unity.cloud.gltfast
```

# Workflow for loading and controlling this animation
1. Adding the GLTF/GLB to your Assets window: Drag the [CuteDemoRigged.glb](CuteDemoRigged.glb) to the Assets window
2. Create an Animation Controller in the Assets window: Right click in the Assets window > Create > Animation > Animation Controller
3. Click on the Animator Tab (next to Scene and Game tabs). Then drag the actions from your GLTF/GLB into the Animator window. You may need to expand your GLTF/GLB in the Assets window after clicking the expand (play looking) icon to see the actions
4. Create an Empty state in the Animator window and make it default: Right Click > Create State > Empty. Right click the Empty state and make it "Set as default layer state"
5. Now drag your GLTF/GLB model to the Hierarchy tab (or the Scene)
6. If not present, add an Animator component to the GLB model. To this Animator component, add the Animation Controller you created in 2
7. Now add a new script to the model such as [DemonAnimatorScript.cs](DemonAnimatorScript.cs). This script binds keyboard input to control the actions
