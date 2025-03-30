# User Guide of TactAR
## TODO
- [x] Add text tutorial on how to use TactAR.
- [ ] Add video tutorial on how to use TactAR.

## Steps
### 1. Connect to the Wireless Network
Open the Quest's Wi-Fi settings and connect to the same network as the workstation which runs the teleopretaion server.


### 2. Launch Software
Find and launch the `TactAR` APP from the application list.

### 3. Create and Confirm Ground Boundary
Look at the ground to set the boundary beneath feet and confirm the ground boundary.

### 4. Set IP Address
Enter the correct IP address of the workstation (the host IP in the UI). You can click the virtual keyboard button with your finger.

### 5. Coordinate Calibration

1. Press the `X` button on the left controller and the `A` button on the right controller simultaneously and a coordinate axis will appear on the screen.
2. Hold the trigger on the right controller, pull back the controller or rotate the wrist to calibrate the rotation of the coordniate system.
3. Hold the trigger on the left controller and move the VR controller to adjust the origin position of the coordinate system.
4. Ensure the side of the blue axis (z-axis in Unity) with the sphere is facing backward.
5. Once calibration is complete, press the `X` button on the left controller and the `A` button on the right controller simultaneously to exit the calibration process.

### 6. Control the Robotic Arm

- **Left Arm Control:**
  - Hold the side trigger on the left controller.
    - Move hand to control the position of the robot end-effector
    - Rotate wrist to control the rotation of the robot end-effector
  - Hold the trigger on the left controller to open and close the left arm's gripper.
  
- **Right Arm Control:**
  - Hold the side trigger on the right controller.
    - Move hand to control the position of the end effector
    - Rotate wrist to control the rotation of the end effector
  - Hold the trigger on the right controller to open and close the right arm's gripper.

### 7. [Optional] Change Control of Left and Right Arms
Find and select the `SwitchL-R` option in the IP settings interface to change the control assignment for the left and right arms.

### 8. Exit the Software
Hold the `Meta` button on the right controller to exit the software.